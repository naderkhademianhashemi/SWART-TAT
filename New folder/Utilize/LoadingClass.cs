using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Forms;
using Utilize.Helper;

namespace Utilize
{
    public static class LoadingClass
    {
        private static Thread lengthyProcessThread;
        private static readonly Collection<Control> Controls = new Collection<Control>();
        private static bool _canceled;
        public static bool ShowProcecing(this Action action, IEnumerable<Control> controls)
        {
            _canceled = false;
            controls.ForEach(item => Controls.Add(item));
            HideORShowControls(Controls, false);
            var Waiting = new frmWaiting {TopMost = true};
            lengthyProcessThread = new Thread(() =>
                                                  {
                                                      action.Invoke();
                                                      Waiting.Invoke(new Action(Waiting.Close));
                                                  }) {IsBackground = true};
            lengthyProcessThread.Start();
            Waiting.Stoped += Waiting_Stoped;
            Waiting.ShowDialog();
            HideORShowControls(Controls, true);
            return _canceled;
        }

        private static void HideORShowControls(IEnumerable<Control> controls, bool show)
        {
            controls.ForEach(item => item.Enabled = show);
        }

        static void Waiting_Stoped(object sender, EventArgs e)
        {
            _canceled = true;
            HideORShowControls(Controls, true);
        }
    }
}
