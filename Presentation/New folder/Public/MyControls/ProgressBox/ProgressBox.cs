using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Presentation.Public
{
    internal class ProgreessForm
    {
        #region VARS

        private frmProgress fx;

        #endregion

        public frmProgress PForm
        {
            get { return fx; }
        }

        public void Start()
        {
            fx = new frmProgress();
            fx.Start();
            fx.ShowDialog();
        }

        public void Stop()
        {
            fx.Stop();
        }
    }

    public class ProgressBox
    {
        #region VARS         

        private static ThreadStart threadStart;
        private static Thread thread;

        #endregion

        public static void Show()
        {
            frmProgress progress = new frmProgress();
            threadStart = new ThreadStart(progress.Start);
            thread = new Thread(threadStart);
            thread.Start();
        }

        public static void Hide()
        {
            Thread.Sleep(3000);
            if (thread.ThreadState != ThreadState.Aborted)
                thread.Abort();
        }
    }
}
