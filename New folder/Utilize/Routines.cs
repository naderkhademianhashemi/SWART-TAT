using System;
using System.Threading;

namespace Utilize
{
    public class Routines
    {
        public static MyDialogResoult ShowErrorMessageFa(string title, string message, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.Error, true);
        }

        public static MyDialogResoult ShwAccDenMessageFa(string title, string message, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.AccessDenied, true);
        }

        public static MyDialogResoult ShwAccDenMessage(string title, string message, MyDialogButton buttons)
        {
            return MyMessageBox.ShowMessage(title, message, buttons, MyDialogIcon.AccessDenied, false);
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

        private static frmWaiting _frmWaiting;
        public static void ShowProcess()
        {
            new Thread(() =>
                           {
                               if (_frmWaiting == null)
                                   _frmWaiting = new frmWaiting();
                               _frmWaiting.Res();
                               _frmWaiting.ShowDialog();
                           }) { IsBackground = true }.Start();
        }

        public static void HideProcess()
        {
            if (_frmWaiting == null)
                return;
            _frmWaiting.Invoke(new Action(() => _frmWaiting.Close()));
            _frmWaiting = null;
        }
    }
}
