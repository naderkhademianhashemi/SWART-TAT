using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Public
{
    public partial class frmProgress : BaseForm
    {
        #region VARS
        private DateTime startDate;
        #endregion

        public frmProgress()
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

        private bool mouseDown = false;
        private int xPos = 0;
        private int yPos = 0;
        private void frmProgress_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xPos = e.X;
                yPos = e.Y;
                mouseDown = true;
            }
        }

        private void frmProgress_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Left = Cursor.Position.X - xPos;
                Top = Cursor.Position.Y - yPos;
            }
        }

        private void frmProgress_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void cButton1_Load(object sender, EventArgs e)
        {
            
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}