using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmInput :BaseForm
    {
        public frmInput()
        {
            InitializeComponent();
        }

        public bool Weighted
        {
            get
            {
                return chkWeighted.Checked;
            }
        }

        public int CurrencyID
        {
            get
            {
                return (int)cmbCurrency.SelectedValue;
            }
        }
        public int ModeID
        {
            get
            {
                return (int)cmbMode.SelectedValue;
            }
        }
        public int TBModelID
        {
            get
            {
                return (int)cmbTBM.SelectedValue;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((cmbCurrency.SelectedIndex == -1 || cmbTBM.SelectedIndex == -1) && (this.DialogResult != DialogResult.Cancel))
            {
                Presentation.Public.Routines.ShowMessageBoxFa("بعضی از مقادیر ورودی وجود ندارند", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            TBM tbm = new TBM();
            cmbTBM.DataSource = tbm.GetTBMs();
            cmbTBM.DisplayMember = TBM.CTE_Alias_ModelName;
            cmbTBM.ValueMember = TBM.CTE_Alias_ID;

            Misc misc = new Misc();
            cmbCurrency.DataSource = misc.GetCurrencyDT();
            cmbCurrency.DisplayMember = Misc.CTE_Alias_CurrencyDescr;
            cmbCurrency.ValueMember = Misc.CTE_Alias_CurrencyID;

            cmbMode.AddItemsRange(new string[] { "غیرخودكار" });

            cmbCurrency.SelectedIndex = cmbMode.Items.Count > 0 ? 0 : - 1;
            cmbCurrency.SetDefaultCurrency("ریال ایران");
            cmbTBM.SelectedIndex = cmbMode.Items.Count > 0 ? 0 : - 1;
            cmbMode.SelectedIndex = cmbMode.Items.Count > 0 ? 0 : -1;
        }

        private void chkWeighted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWeighted.Checked)
                cmbTBM.Enabled = false;
            else
                cmbTBM.Enabled = true;
        }

        private void frmInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((cmbCurrency.SelectedIndex == -1 || cmbTBM.SelectedIndex == -1) && (this.DialogResult != DialogResult.Cancel))
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("بعضی از مقادیر ورودی وجود ندارند", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DialogResult = DialogResult.None;
                    return;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        
        }

        private void btnCancel_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}