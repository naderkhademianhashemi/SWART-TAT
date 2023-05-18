using System;
using System.Windows.Forms;

namespace Utilize
{
    public partial class frmWaiting : Form
    {

        public frmWaiting()
        {
            InitializeComponent();
            timerOp.Enabled = true;
        }
        public void Res()
        {
            Span = new TimeSpan(0, 0, 0);
            timerOp.Enabled = true;
           // timerOp.Tick+=new EventHandler(timerOp_Tick);
        }

        private TimeSpan Span = new TimeSpan(0, 0, 0);
        public event EventHandler Stoped;
        private void timerOp_Tick(object sender, EventArgs e)
        {
            try
            {
                Span = Span.Add(new TimeSpan(0, 0, 1));
                lblTime.Invoke(new Action(() => lblTime.Text = string.Format("{0}{1}:{2}{3}", Span.Minutes.ToString().Length == 1 ? "0" : "", Span.Minutes, Span.Seconds.ToString().Length == 1 ? "0" : "", Span.Seconds)));
            }
            catch (Exception)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            if (Stoped != null)
                Stoped.Invoke(sender, e);
        }
    }
}
