using System;
using System.Drawing;
using System.Windows.Forms;

namespace Utilize.Company
{
    public partial class SWART_TAT : Form
    {
        public SWART_TAT(string title = "", string version = "")
        {

            InitializeComponent();
            lblTitle.Text = title;
            lblVersion.Text = version;

        }


        private void SWART_TAT_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            this.Update();

        }

        private int tick = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            tick++;
            //By Hosein(90.12.07) _ change from "if (tick == 10)" to 
            if (tick == 2)
                Close();
        }
    }
}
