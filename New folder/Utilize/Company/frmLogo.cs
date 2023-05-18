using System;
using System.Windows.Forms;

namespace Utilize.Company
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        public bool WhitTimerForClosing
        {
            get {return timerWaiting.Enabled; }
            set { timerWaiting.Enabled = value; }
        }

        public frmLogo(System.Drawing.Image logoOfCompany,System.Drawing.Image LogoOfCustomer,string txtProductName,string txtCustomerName,string txtReleaseDate)
        {
            InitializeComponent();
            pcbLogoCompuCo.Image = logoOfCompany;
            pcbLogoCustomer.Image = LogoOfCustomer;
            lblDate.Text = txtReleaseDate;
            lblNameOfCustomer.Text = txtCustomerName;
            lblNameOfProduct.Text = txtProductName;
        }

        public frmLogo(string txtProductName,string txtCustomerName,string txtReleaseDate)
        {
            InitializeComponent();
            lblDate.Text = txtReleaseDate;
            lblNameOfCustomer.Text = txtCustomerName;
            lblNameOfProduct.Text = txtProductName;
        }

        private void timerWaiting_Tick(object sender, EventArgs e)
        {
            indexTime++;
            if (indexTime > 5)
            {
                Colsed = true;
                this.Close();
            }
        }

        private int indexTime;
        public bool Colsed;

        private void lnkCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(lnkCompany.Tag.ToString());
            }
            catch (Exception)
            {

            }
        }
    }
}
