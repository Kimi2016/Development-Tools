using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageOverlay
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;


		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button_addList = new System.Windows.Forms.Button();
			this.listBox_allFileName = new System.Windows.Forms.ListBox();
			this.button_clearList = new System.Windows.Forms.Button();
			this.pictureBox_imageOverlay = new System.Windows.Forms.PictureBox();
			this.button_saveImageOverlay = new System.Windows.Forms.Button();
			this.button_addImage = new System.Windows.Forms.Button();
			this.button_removeImage = new System.Windows.Forms.Button();
			this.pictureBox_preview = new System.Windows.Forms.PictureBox();
			this.label_offsetX = new System.Windows.Forms.Label();
			this.textBox_inputOffsetX = new System.Windows.Forms.TextBox();
			this.label_OffsetY = new System.Windows.Forms.Label();
			this.textBox_inputOffsetY = new System.Windows.Forms.TextBox();
			this.button_clearImageOverlay = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_imageOverlay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
			this.SuspendLayout();
			// 
			// button_addList
			// 
			this.button_addList.Location = new System.Drawing.Point(202, 12);
			this.button_addList.Name = "button_addList";
			this.button_addList.Size = new System.Drawing.Size(90, 28);
			this.button_addList.TabIndex = 0;
			this.button_addList.Text = "添加文件列表";
			this.button_addList.UseVisualStyleBackColor = true;
			this.button_addList.Click += new System.EventHandler(this.addList_Click);
			// 
			// listBox_allFileName
			// 
			this.listBox_allFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox_allFileName.FormattingEnabled = true;
			this.listBox_allFileName.ItemHeight = 12;
			this.listBox_allFileName.Location = new System.Drawing.Point(12, 12);
			this.listBox_allFileName.Name = "listBox_allFileName";
			this.listBox_allFileName.Size = new System.Drawing.Size(184, 424);
			this.listBox_allFileName.TabIndex = 26;
			this.listBox_allFileName.SelectedIndexChanged += new System.EventHandler(this.listBox_allFileName_SelectedIndexChanged);
			// 
			// button_clearList
			// 
			this.button_clearList.Location = new System.Drawing.Point(202, 46);
			this.button_clearList.Name = "button_clearList";
			this.button_clearList.Size = new System.Drawing.Size(90, 28);
			this.button_clearList.TabIndex = 27;
			this.button_clearList.Text = "清空文件列表";
			this.button_clearList.UseVisualStyleBackColor = true;
			this.button_clearList.Click += new System.EventHandler(this.clearList_Click);
			// 
			// pictureBox_imageOverlay
			// 
			this.pictureBox_imageOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox_imageOverlay.Enabled = false;
			this.pictureBox_imageOverlay.Location = new System.Drawing.Point(298, 12);
			this.pictureBox_imageOverlay.Name = "pictureBox_imageOverlay";
			this.pictureBox_imageOverlay.Size = new System.Drawing.Size(391, 424);
			this.pictureBox_imageOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_imageOverlay.TabIndex = 1;
			this.pictureBox_imageOverlay.TabStop = false;
			// 
			// button_saveImageOverlay
			// 
			this.button_saveImageOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_saveImageOverlay.Location = new System.Drawing.Point(202, 406);
			this.button_saveImageOverlay.Name = "button_saveImageOverlay";
			this.button_saveImageOverlay.Size = new System.Drawing.Size(90, 28);
			this.button_saveImageOverlay.TabIndex = 28;
			this.button_saveImageOverlay.Text = "保存叠加图片";
			this.button_saveImageOverlay.UseVisualStyleBackColor = true;
			this.button_saveImageOverlay.Click += new System.EventHandler(this.saveImageOverlay_Click);
			// 
			// button_addImage
			// 
			this.button_addImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_addImage.Location = new System.Drawing.Point(202, 289);
			this.button_addImage.Name = "button_addImage";
			this.button_addImage.Size = new System.Drawing.Size(90, 28);
			this.button_addImage.TabIndex = 29;
			this.button_addImage.Text = "添加 图片";
			this.button_addImage.UseVisualStyleBackColor = true;
			this.button_addImage.Click += new System.EventHandler(this.addImage_Click);
			// 
			// button_removeImage
			// 
			this.button_removeImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_removeImage.Location = new System.Drawing.Point(202, 323);
			this.button_removeImage.Name = "button_removeImage";
			this.button_removeImage.Size = new System.Drawing.Size(90, 28);
			this.button_removeImage.TabIndex = 30;
			this.button_removeImage.Text = "删除 图片";
			this.button_removeImage.UseVisualStyleBackColor = true;
			this.button_removeImage.Click += new System.EventHandler(this.removeImage_Click);
			// 
			// pictureBox_preview
			// 
			this.pictureBox_preview.Enabled = false;
			this.pictureBox_preview.Location = new System.Drawing.Point(202, 113);
			this.pictureBox_preview.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox_preview.Name = "pictureBox_preview";
			this.pictureBox_preview.Size = new System.Drawing.Size(90, 90);
			this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_preview.TabIndex = 31;
			this.pictureBox_preview.TabStop = false;
			// 
			// label_offsetX
			// 
			this.label_offsetX.AutoSize = true;
			this.label_offsetX.Location = new System.Drawing.Point(202, 209);
			this.label_offsetX.Name = "label_offsetX";
			this.label_offsetX.Size = new System.Drawing.Size(47, 12);
			this.label_offsetX.TabIndex = 32;
			this.label_offsetX.Text = "OffsetX";
			this.label_offsetX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// textBox_inputOffsetX
			// 
			this.textBox_inputOffsetX.Location = new System.Drawing.Point(246, 206);
			this.textBox_inputOffsetX.MaxLength = 6;
			this.textBox_inputOffsetX.Name = "textBox_inputOffsetX";
			this.textBox_inputOffsetX.Size = new System.Drawing.Size(46, 21);
			this.textBox_inputOffsetX.TabIndex = 33;
			this.textBox_inputOffsetX.Text = "0";
			this.textBox_inputOffsetX.TextChanged += new System.EventHandler(this.textBox_inputOffsetX_TextChanged);
			this.textBox_inputOffsetX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_inputOffset_XY_KeyPress);
			// 
			// label_OffsetY
			// 
			this.label_OffsetY.AutoSize = true;
			this.label_OffsetY.Location = new System.Drawing.Point(202, 236);
			this.label_OffsetY.Name = "label_OffsetY";
			this.label_OffsetY.Size = new System.Drawing.Size(47, 12);
			this.label_OffsetY.TabIndex = 34;
			this.label_OffsetY.Text = "OffsetY";
			// 
			// textBox_inputOffsetY
			// 
			this.textBox_inputOffsetY.Location = new System.Drawing.Point(246, 233);
			this.textBox_inputOffsetY.MaxLength = 5;
			this.textBox_inputOffsetY.Name = "textBox_inputOffsetY";
			this.textBox_inputOffsetY.Size = new System.Drawing.Size(46, 21);
			this.textBox_inputOffsetY.TabIndex = 35;
			this.textBox_inputOffsetY.Text = "0";
			this.textBox_inputOffsetY.TextChanged += new System.EventHandler(this.textBox_inputOffsetY_TextChanged);
			this.textBox_inputOffsetY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_inputOffset_XY_KeyPress);
			// 
			// button_clearImageOverlay
			// 
			this.button_clearImageOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_clearImageOverlay.Location = new System.Drawing.Point(202, 372);
			this.button_clearImageOverlay.Name = "button_clearImageOverlay";
			this.button_clearImageOverlay.Size = new System.Drawing.Size(90, 28);
			this.button_clearImageOverlay.TabIndex = 36;
			this.button_clearImageOverlay.Text = "清除叠加图片";
			this.button_clearImageOverlay.UseVisualStyleBackColor = true;
			this.button_clearImageOverlay.Click += new System.EventHandler(this.button_clearImageOverlay_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 446);
			this.Controls.Add(this.button_clearImageOverlay);
			this.Controls.Add(this.textBox_inputOffsetY);
			this.Controls.Add(this.label_OffsetY);
			this.Controls.Add(this.textBox_inputOffsetX);
			this.Controls.Add(this.label_offsetX);
			this.Controls.Add(this.pictureBox_preview);
			this.Controls.Add(this.button_removeImage);
			this.Controls.Add(this.button_addImage);
			this.Controls.Add(this.button_saveImageOverlay);
			this.Controls.Add(this.button_clearList);
			this.Controls.Add(this.listBox_allFileName);
			this.Controls.Add(this.button_addList);
			this.Controls.Add(this.pictureBox_imageOverlay);
			this.Name = "Form1";
			this.Text = "图片叠加";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_imageOverlay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button_addList;
		private Button button_clearList;
		private PictureBox pictureBox_imageOverlay;
		private ListBox listBox_allFileName;
		private Button button_saveImageOverlay;
		private Button button_addImage;
		private Button button_removeImage;
		private PictureBox pictureBox_preview;
		private Label label_offsetX;
		private Label label_OffsetY;
		private TextBox textBox_inputOffsetX;
		private TextBox textBox_inputOffsetY;
		private Button button_clearImageOverlay;
	}
}

