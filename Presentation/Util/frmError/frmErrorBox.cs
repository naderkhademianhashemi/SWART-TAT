using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Public
{
    public partial class frmErrorBox : Form
    {
        public frmErrorBox()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}