using System;
using System.IO;
using System.Collections;
using System.Data;

namespace ExportSqliteToCVS
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbPath = string.Empty;
            string csvPath = string.Empty;

            if (args.Length > 0)
            {
                dbPath = args[0];
                csvPath = args[1];
            }
            else
            {
                dbPath = @"E:\WorkSpace\client_Manghuangji_Trunk_Android\Assets\R\Inside\database\game.bytes";//args[0];
                csvPath = "../../../ExportCSV";
            }

            Console.WriteLine("dbPath:" + dbPath);
            Console.WriteLine("csvPath:" + csvPath);

            if (!File.Exists(dbPath))
            {
                Console.WriteLine("not found " + dbPath);
                Console.ReadKey();
            }

            SQLiteDatabase db = new SQLiteDatabase(dbPath);
            DataTable dataTable;
            String query = "SELECT name FROM sqlite_master " + "WHERE type = 'table'" + "ORDER BY 1";

            dataTable = db.GetDataTable(query);

            ArrayList dataTableList = new ArrayList();
            foreach (DataRow row in dataTable.Rows)
            {
                dataTableList.Add(row.ItemArray[0].ToString());
            }

            string exportDirName = csvPath;
            if (Directory.Exists(exportDirName))
            {
                Directory.Delete(exportDirName, true);
            }
            Directory.CreateDirectory(exportDirName);

            for (int tableIndex = 0; tableIndex < dataTableList.Count; tableIndex++)
            {
                Console.WriteLine(string.Format("{0}/{1}：{2}", tableIndex , dataTableList.Count , dataTableList[tableIndex]));

                DataTable tmpDataTable = db.GetDataTable("select * from " + dataTableList[tableIndex]);

                ExportToCSV(exportDirName, tmpDataTable);
            }

            Console.WriteLine("ExportSqliteToCVS Finish");
            Console.ReadKey();
        }

        public static void ExportToCSV(string tmpExportDirName, DataTable dataTable)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(string.Format("{0}/{1}.csv", tmpExportDirName , dataTable.TableName));

                DataColumnCollection dataColumnCollection = dataTable.Columns;

                //CSV Title
                string titleStr = string.Empty;
                for (int i = 0, max = dataColumnCollection.Count; i < max; ++i)
                {
                    if (i != 0)
                        titleStr += ",";
                    titleStr += dataColumnCollection[i].ColumnName;
                }
                streamWriter.WriteLine(titleStr);

                //CSV Contents
                foreach (var tableRow in dataTable.Rows)
                {
                    string contentStr = string.Empty;
                    DataRow tmpRow = tableRow as DataRow;
                    
                    for (int i = 0; i < tmpRow.ItemArray.Length; i++)
                    {
                        if (i != 0)
                            contentStr += ",";
                        contentStr += tmpRow.ItemArray[i];
                    }
                    streamWriter.WriteLine(contentStr);
                }

                streamWriter.Flush();
                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception e:" + e);
            }
        }
    }
}
