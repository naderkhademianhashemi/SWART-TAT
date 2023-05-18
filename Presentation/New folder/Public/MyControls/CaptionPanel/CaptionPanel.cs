using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Public
{
    public partial class CaptionPanel : ContainerControl
    {
        public CaptionPanel()
        {
            InitializeComponent();
        }

        private void CaptionPanel_Resize(object sender, EventArgs e)
        {
            grpLine.Left = -3;
            grpLine.Top = this.Height - 10;
            grpLine.Width = this.Width + 3 + 3;
            grpLine.Height = 8;
            
            pnlCaption.Left = 0;
            pnlCaption.Top = 0;
            pnlCaption.Height = this.Height - 5;
            pnlCaption.Width = this.Width;
            //pnlCaption.BorderStyle = BorderStyle.Fixed3D;

            pnlCaption.SendToBack();
            grpLine.SendToBack();
        }
    }
}
