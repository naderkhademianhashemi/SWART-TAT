using System;
using System.IO;
using System.Text;

namespace Utilize.Helper
{
    public static class ExceptionHelper
    {
        private static readonly string filePathNameLog = Environment.CurrentDirectory + @"\Log\Log.dat";
        private static void ConfigLogFile()
        {
            if (Directory.Exists(Environment.CurrentDirectory + @"\Log") == false)
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Log");
            if (File.Exists(Environment.CurrentDirectory + @"\Log\Log.dat") == false)
                File.Create(Environment.CurrentDirectory + @"\Log\Log.dat").Dispose();
        }

        public static void ConfigLog(this Exception exception)
        {
            ConfigLogFile();
            var reader = new StreamReader(filePathNameLog, Encoding.UTF8);
            var log = reader.ReadToEnd();
            reader.Close();
            var writer = new StreamWriter(filePathNameLog);
            writer.WriteLine(log);
            writer.WriteLine("*********");
            writer.WriteLine("Date : " + DateTime.Now);
            writer.WriteLine("Message : " + exception.Message);
            writer.WriteLine("StackTrace : " + exception.StackTrace);
            writer.Flush();
            writer.Dispose();
            writer.Close();
        }
        public static void ConfigLog(this Exception exception, bool ShowMessageBox)
        {
            ConfigLogFile();
            if (ShowMessageBox)
            {
                Routines.ShowErrorMessageFa("خطا", "برنامه با خطا روبرو شده است", exception.Message,
                                               MyDialogButton.OK);
            }
            var reader = new StreamReader(filePathNameLog, Encoding.UTF8);
            var log = reader.ReadToEnd();
            reader.Close();
            var writer = new StreamWriter(filePathNameLog);
            writer.WriteLine(log);
            writer.WriteLine("*********");
            writer.WriteLine("Date : " + DateTime.Now);
            writer.WriteLine("Message : " + exception.Message);
            writer.WriteLine("StackTrace : " + exception.StackTrace);
            writer.Flush();
            writer.Dispose();
            writer.Close();
        }

        public static void ConfigLog(this Exception exception,bool isTitle, string text)
        {
            ConfigLogFile();
            if (isTitle)
                Routines.ShowErrorMessageFa("خطا", string.Format("{0} با خطا روبرو شده است", text), exception.Message,
                                               MyDialogButton.OK);
            else
                Routines.ShowErrorMessageFa("خطا", text, exception.Message,
                                            MyDialogButton.OK);
            var reader = new StreamReader(filePathNameLog, Encoding.UTF8);
            var log = reader.ReadToEnd();
            reader.Close();
            var writer = new StreamWriter(filePathNameLog);
            writer.WriteLine(log);
            writer.WriteLine("*********");
            writer.WriteLine("Date : " + DateTime.Now);
            writer.WriteLine("Message : " + exception.Message);
            writer.WriteLine("StackTrace : " + exception.StackTrace);
            writer.Flush();
            writer.Dispose();
            writer.Close();
        }

        public static void ConfigLog(this Exception exception, string title)
        {
            ConfigLogFile();
            Routines.ShowErrorMessageFa("خطا", string.Format("{0} با خطا روبرو شده است", title), exception.Message,
                                           MyDialogButton.OK);
            var reader = new StreamReader(filePathNameLog, Encoding.UTF8);
            var log = reader.ReadToEnd();
            reader.Close();
            var writer = new StreamWriter(filePathNameLog);
            writer.WriteLine(log);
            writer.WriteLine("*********");
            writer.WriteLine("Date : " + DateTime.Now);
            writer.WriteLine("Message : " + exception.Message);
            writer.WriteLine("StackTrace : " + exception.StackTrace);
            writer.Flush();
            writer.Dispose();
            writer.Close();
        }
    }
}
