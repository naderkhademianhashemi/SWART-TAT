using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Utilize.ProgressBox
{
    internal class UtProgreessForm
    {
        #region VARS
        private Utilize.ProgressBox.UtfrmProgress fx;
        #endregion

        public UtfrmProgress PForm
        {
            get { return fx; }
        }

        public void Start()
        {
            fx = new UtfrmProgress();
            fx.Start();
            fx.ShowDialog();
        }

        public void Stop()
        {
            fx.Stop();            
        }
    }

    public class UtProgressBox
    {
        #region VARS         
        private static ThreadStart threadStart;
        private static Thread thread;
        #endregion

        public static void Show()
        {
            UtfrmProgress progress = new UtfrmProgress();
            threadStart = new ThreadStart(progress.Start);
            thread = new Thread(threadStart);
            thread.Start();
        }

        public static void Hide()
        {
            Thread.Sleep(3000);
            if (thread.ThreadState!=ThreadState.Aborted)
            thread.Abort();
        }
    }
}
