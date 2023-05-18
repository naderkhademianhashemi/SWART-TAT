using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utilize.ProgressBox
{
    public partial class UtfrmProgress : Form
    {
        #region VARS
        private DateTime startDate;
        #endregion

        public UtfrmProgress()
        {
            InitializeComponent();

            this.TopMost = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        internal void Start()
        {
            try
            {
                timer.Enabled = true;
                timer.Interval = 250;
                spProgress.AutoIncrement = true;
                spProgress.AutoIncrementFrequency = 1000;
                spProgress.TransistionSegment = 0;
                startDate = DateTime.Now.AddSeconds(-1);
                ShowDialog();
            }
            catch (Exception)
            {

                Stop();
            }
        }
        internal void Stop()
        {
            timer.Enabled = false;
            spProgress.AutoIncrement = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            TimeSpan ts = DateTime.Now.Subtract(startDate);
            lblTime.Text = string.Format("{0,2:00}:{1,2:00}", ts.Minutes, ts.Seconds);
            Application.DoEvents();
        }
    }
}