using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmPDF : Form
    {
        String filename;
        public frmPDF(String filename)
        {
            InitializeComponent();
            this.filename = filename;
        }

        private void cbProcess_Load(object sender, EventArgs e)
        {
         
        }

        private void frmPDF_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(Application.StartupPath+filename+"#toolbar=0&navpanes=0");
            
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        
        }

       

        
        
    }
}
