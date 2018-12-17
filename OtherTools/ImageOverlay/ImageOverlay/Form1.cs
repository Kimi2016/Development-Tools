using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;
using static System.Windows.Forms.ListBox;

/// <summary>
/// @Kimi 2018/12/17 15:24
/// </summary>
namespace ImageOverlay
{
	public partial class Form1 : Form
	{
		private string lastpath = @"E:\WorkSpace\client_Manghuangji_Trunk_Android\Images2\MainUI";
		
		//选择文件名称
		List<string> selectedFileNames = new List<string>();

		//记录XY的偏移值
		Dictionary<string, KeyValuePair<int, int>> preview_offsetXY = new Dictionary<string, KeyValuePair<int, int>>();

		//需要保存的图片内容
		Bitmap saveBitmap = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//System.Console.WriteLine("Form1_Load");
		}

		private void addList_Click(object sender, EventArgs e)  //add listBox_allFileName
		{
			string filePath = null;
			IEnumerable<string> files = null;
			using (var fbd = new FolderBrowserDialog())
			{
				if (lastpath != "")
				{
					fbd.SelectedPath = lastpath;
				}
				DialogResult result = fbd.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					files = Directory.EnumerateFiles(fbd.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
						.Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"));
					files = files.Select(s => Path.GetFileName(s));
					filePath = fbd.SelectedPath;

					if (files.Count<string>() == 0)
					{
						System.Windows.Forms.MessageBox.Show("No images found in folder!");
						return;
					}
				}
				else
				{
					return;
				}
				lastpath = fbd.SelectedPath;
			}

			listBox_allFileName.Items.Clear();
			listBox_allFileName.Items.AddRange(files.ToArray());
			listBox_allFileName.Tag = filePath;

			pictureBox_preview.Image = null;
			selectedFileNames.Clear();
			preview_offsetXY.Clear();
		}

		private void clearList_Click(object sender, EventArgs e)
		{
			listBox_allFileName.Items.Clear();
			pictureBox_preview.Image = null;
			selectedFileNames.Clear();
			preview_offsetXY.Clear();
		}

		private void listBox_allFileName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender is ListBox)
			{
				ListBox listBox = sender as ListBox;
				Bitmap result = new Bitmap(90, 90);
				Graphics g = Graphics.FromImage(result);
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
				g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

				var path = Path.Combine(listBox.Tag.ToString(), listBox.SelectedItem.ToString());
				using (Image temp_img = Bitmap.FromFile(path))
				{
					g.DrawImage(temp_img, new Rectangle(0, 0, 90, 90));
				}

				// preview
				pictureBox_preview.Tag = listBox.SelectedItem.ToString();
				pictureBox_preview.Image = result;
			}
		}


		private void button_clearImageOverlay_Click(object sender, EventArgs e)
		{
			pictureBox_imageOverlay.Image = null;
			selectedFileNames.Clear();
			preview_offsetXY.Clear();
		}

		private void saveImageOverlay_Click(object sender, EventArgs e)
		{
			if (saveBitmap == null)
			{
				System.Windows.Forms.MessageBox.Show("No image to save!");
				return;
			}
			using (var sfd = new SaveFileDialog())
			{
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					//if (checkBox3.Checked == true)
					//	using (var crp = CropBitmap(tosave))
					//	{
					//		crp.Save(sfd.FileName, ImageFormat.Png);
					//	}
					//else
					{
						saveBitmap.Save(sfd.FileName, ImageFormat.Png);
					}
				}
			}
		}

		private void removeImage_Click(object sender, EventArgs e)
		{
			var fileName = "";
			foreach (var item in listBox_allFileName.SelectedItems)
			{
				fileName = item.ToString();
				if (string.IsNullOrEmpty(fileName) || !selectedFileNames.Contains(fileName))
				{
					continue;
				}
				selectedFileNames.Remove(fileName);
			}

			update_image();
		}

		private void addImage_Click(object sender, EventArgs e)
		{
			var fileName = "";
			foreach (var item in listBox_allFileName.SelectedItems)
			{
				fileName = item.ToString();
				if (string.IsNullOrEmpty(fileName) || selectedFileNames.Contains(fileName))
				{
					continue;
				}
				selectedFileNames.Add(fileName);
			}

			update_image();
		}

		private void update_image()
		{
			// reset
			pictureBox_imageOverlay.Image = null;

			// calc max value
			int imgMax_W = 0;
			int imgMax_H = 0;
			foreach (var item in selectedFileNames)
			{
				var path = Path.Combine(listBox_allFileName.Tag.ToString(), item.ToString());
				System.Console.WriteLine("path:" + path);
				using (Image temp_img = Bitmap.FromFile(path))
				{
					if (imgMax_W < temp_img.Width)
						imgMax_W = temp_img.Width;
					if (imgMax_H < temp_img.Height)
						imgMax_H = temp_img.Height;
				}
			}

			if (imgMax_W == 0 || imgMax_H == 0)
			{
				return;
			}

			// DrawImage
			Bitmap result = new Bitmap(imgMax_W, imgMax_H);
			Graphics g = Graphics.FromImage(result);

			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
			g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

			foreach (string fileName in selectedFileNames)
			{
				if (string.IsNullOrEmpty(fileName))
				{
					continue;
				}
				var path = Path.Combine(listBox_allFileName.Tag.ToString(), fileName.ToString());
				using (Image temp_img = Bitmap.FromFile(path))
				{
					int sPos = (int)((imgMax_W - temp_img.Width) * 0.5f);
					int ePos = (int)((imgMax_H - temp_img.Height) * 0.5f);

					if (preview_offsetXY.ContainsKey(fileName))
					{
						sPos += preview_offsetXY[fileName].Key;
						ePos += preview_offsetXY[fileName].Value;
					}

					g.DrawImage(temp_img, new Rectangle(sPos, ePos, temp_img.Width, temp_img.Height));
				}
			}

			pictureBox_imageOverlay.Image = result;
			saveBitmap = result;
		}

		private void textBox_inputOffsetX_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			string key = pictureBox_preview.Tag.ToString();
			int offsetX = 0;

			if (int.TryParse(textBox.Text, out offsetX))
			{
				if (preview_offsetXY.ContainsKey(key))
				{
					preview_offsetXY[key] = new KeyValuePair<int, int>(offsetX, preview_offsetXY[key].Value);
				}
				else
				{
					preview_offsetXY[key] = new KeyValuePair<int, int>(offsetX, 0);
				}
			}
			
			update_image();
		}

		private void textBox_inputOffsetY_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			string key = pictureBox_preview.Tag.ToString();
			int offsetY = 0;

			if (int.TryParse(textBox.Text, out offsetY))
			{
				if (preview_offsetXY.ContainsKey(key))
				{
					preview_offsetXY[key] = new KeyValuePair<int, int>(preview_offsetXY[key].Value, offsetY);
				}
				else
				{
					preview_offsetXY[key] = new KeyValuePair<int, int>(0, offsetY);
				}
			}

			update_image();
		}

		private void textBox_inputOffset_XY_KeyPress(object sender, KeyPressEventArgs e)//控制键盘输入内容
		{
			//System.Console.WriteLine(e.KeyChar);

			if (e.KeyChar == (char)45)
			{
				return;//负号处理，可以输入
			}

			if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
			{
				e.Handled = true;
				//System.Console.WriteLine("请输入数字：" + e.KeyChar.ToString());
			}
		}
	}
}
