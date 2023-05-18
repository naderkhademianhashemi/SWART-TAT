using Presentation.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.FRM_Routine
{
    public partial class frmRoutine : Form
    {
        public frmRoutine()
        {
            InitializeComponent();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            Routines.ShowErrorBox(errorLog:"asd");
        }
    }
}
