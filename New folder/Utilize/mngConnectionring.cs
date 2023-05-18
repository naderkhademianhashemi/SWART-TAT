using System;
using System.IO;
using System.Text;

namespace Utilize
{
    public static class mngConnectionring
    {
        private static readonly string filePathNameConfig = Environment.CurrentDirectory + @"\Config\config.dat";
        private static void ConfigFile()
        {
            if (Directory.Exists(Environment.CurrentDirectory + @"\Config") == false)
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Config");
            if (File.Exists(Environment.CurrentDirectory + @"\Config\config.dat") == false)
                File.Create(Environment.CurrentDirectory + @"\Config\config.dat").Dispose();
        }

        public static string ConfigConnectionString()
        {
            ConfigFile();
            var reader = new StreamReader(filePathNameConfig, Encoding.UTF8);
            var conString = reader.ReadToEnd();
            reader.Close();
            if (string.IsNullOrEmpty(conString.Trim()))
            {
                //var frmSqlSettingConnection = new frmSQLSettingConnection();
                //frmSqlSettingConnection.ShowDialog();
                //conString = frmSqlSettingConnection.ConnectionString;

                conString = "Data Source=127.0.0.1;Initial Catalog=Risk_Mng_Tat_OLTP;Persist Security Info=True;User ID=sa;Password=1024compuco;";
                var writer = new StreamWriter(filePathNameConfig);
                writer.WriteLine(conString);
                writer.Flush();
                writer.Dispose();
                writer.Close();
            }
            return conString;
        }
    }
}
