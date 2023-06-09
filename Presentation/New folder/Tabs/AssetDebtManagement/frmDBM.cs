using Janus.Windows.UI.Tab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Utilize;
using ERMSLib;
using Dundas.Charting.WinControl;
using System.Linq;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmDBM : BaseForm
    {

        public frmDBM()
        {
            InitializeComponent();
        }

        private void frmDBM_Load(object sender, EventArgs e)
        {
            Form form = new Tabs.AssetDebtManagement.frmDBMD
            {
                TopLevel = false,
                Text = "سپرده",
                Name = "سپرده"
            };

            var tabPage = new UITabPage(form.Text) { Key = form.Name, Name = form.Name, AllowClose = true };
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            tabPage.Controls.Add(form);
            form.Show();




            Form form2 = new Tabs.AssetDebtManagement.frmDBMG
            {
                TopLevel = false,
                Text = "ضمانت نامه",
                Name = "ضمانت نامه"
            };
            var tabPage2 = new UITabPage(form2.Text) { Key = form2.Name, Name = form2.Name, AllowClose = true };
            form2.Dock = DockStyle.Fill;
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            tabPage2.Controls.Add(form2);
            form2.Show();

            tblList1.TabPages[0].Controls.Add(form);
            tblList1.TabPages[1].Controls.Add(form2);
        }

    }
}