using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilize;

namespace Presentation.Util
{
    public class Routines
    {
        public static MyDialogResoult ShowErrorMessageFa(string title, string message, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.Error, true);
        }

        public static MyDialogResoult ShowErrorMessageFa(string title, string message, string information, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, information, buttons, MyDialogIcon.Error, true);
        }

        public static MyDialogResoult ShowInfoMessageFa(string title, string message, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.Information, true);
        }

        public static MyDialogResoult ShowInfoMessageFa(string title, string message, string information, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, information, buttons, MyDialogIcon.Information, true);
        }

        public static MyDialogResoult ShowQuestionMessageFa(string title, string message, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.Question, true);
        }

        public static MyDialogResoult ShowQuestionMessageFa(string title, string message, string information, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, information, buttons, MyDialogIcon.Question, true);
        }

        public static void ShowErrorBox(string caption="", string errorLog = "")
        {
            Presentation.Public.frmErrorBox fx = new Presentation.Public.frmErrorBox();
            fx.txtLog.Text = errorLog;

            fx.ShowDialog();
        }

        public static string ShowInputBox()
        {
            Presentation.Public.frmInputBox fx = new Presentation.Public.frmInputBox();
            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return fx.Description;
            else
                return string.Empty;
        }
        public static DialogResult ShowMessageBoxFa(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            Presentation.Public.frmMessageBox fx = new Presentation.Public.frmMessageBox();

            fx.MsgCaption = title;
            fx.MsgText = text;
            fx.MsgIcon = icon;
            fx.MsgButtons = buttons;

            System.Windows.Forms.DialogResult dr = fx.ShowDialog();
            return dr;


        }


        public static DialogResult ShowMessageBoxFa(string text, string title, MessageBoxButtons buttons, MessageBoxIcon icon, Form owner)
        {
            Presentation.Public.frmMessageBox fx = new Presentation.Public.frmMessageBox();

            fx.MsgCaption = title;
            fx.MsgText = text;
            fx.MsgIcon = icon;
            fx.MsgButtons = buttons;
            if (owner != null)
                fx.Owner = owner;

            System.Windows.Forms.DialogResult dr = fx.ShowDialog();
            return dr;
        }
        public static string ShowInputBox(string descr)
        {
            Presentation.Public.frmInputBox fx = new Presentation.Public.frmInputBox();
            fx.Description = descr;
            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return fx.Description;
            else
                return string.Empty;
        }

        public static string ShowInputBox2(String title)
        {
            Presentation.Public.frmInputBox fx = new Presentation.Public.frmInputBox();
            fx.Title = title;

            if (fx.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return fx.Description;
            else
                return string.Empty;
        }

        public static string GetExceptionString(Exception ex)
        {
            string exStr = String.Empty;

            //Exception Module
            exStr += "Exception Module			: " + ex.Source + Environment.NewLine;
            //Exception Target
            exStr += "Exception Target			: " + ((ex.TargetSite != null) ? ex.TargetSite.Name : "") + Environment.NewLine;
            //Exception Type
            exStr += "Exception Type			: " + ex.GetType().FullName + Environment.NewLine;
            //Exception Help Link
            exStr += "Help Link				: " + ex.HelpLink + Environment.NewLine;
            //Exception Message
            exStr += "Exception Message			: " + ex.Message + "	" + Environment.NewLine;

            exStr += Environment.NewLine;

            //Stack Trace				
            exStr += "Exception Stack Trace		: " + Environment.NewLine + ex.StackTrace;

            return exStr;
        }
        public static void Verbose(Exception ex)
        {
            try
            {
                //Date and Time	
                string err = "Date and Time			: " + DateTime.Now.ToString() + Environment.NewLine;

                //Machine Name
                err += "Machine Name			: " + Environment.MachineName + Environment.NewLine;

                //IP Address
                string ip = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0].ToString();
                err += "IP Address			: " + ip + Environment.NewLine;

                //User Identity
                string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                err += "User Identity			: " + user + Environment.NewLine;

                err += Environment.NewLine;
                err += GetExceptionString(ex);

                Routines.ShowErrorBox(ex.Message, err);
            }
            catch
            {
                Routines.ShowErrorBox(ex.Message, ex.Message);
            }
        }

        public static int GetNumericValue(string s, out int value)
        {
            try
            {
                value = Convert.ToInt32(s);
            }
            catch
            {
                value = 0;
            }

            return value;
        }
        public static double GetNumericValue(string s, out double value)
        {
            try
            {
                value = Convert.ToDouble(s);
            }
            catch
            {
                value = 0;
            }

            return value;
        }
        public static decimal GetNumericValue(string s, out decimal value)
        {
            try
            {
                value = Convert.ToDecimal(s);
            }
            catch
            {
                value = 0;
            }

            return value;
        }
    }
}
