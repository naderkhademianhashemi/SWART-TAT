using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;

//   this.BackColor = System.Drawing.Color.Transparent;
using Presentation.Public;

namespace Presentation.Tabs.LimitManagement
{
    public partial class frmLimitAmount : Form
    {
        #region VAR
        private AGM agm;
        private LM lm;
       
        #endregion

        public string strAmount;
        public string Amount
        {
            get { return strAmount; }
            set { strAmount = value; }
        }

        private string strAmount_Type;
        public string Amount_Type
        {
            get { return strAmount_Type; }
            set { strAmount_Type = value; }
        }

        private string strAmount_Operand;
        public string Amount_Operand
        {
            get { return strAmount_Operand; }
            set { strAmount_Operand  = value; }
        }
        private decimal VAmount_Percent;
        public decimal Amount_Percent
        {
            get { return VAmount_Percent; }
            set { VAmount_Percent = value; }
        }
        
        public bool ApplyAll
        {
            get { return ChkApplyAll.Checked; }
            set { ChkApplyAll.Checked = value; }
        }

        public int VElementId = 0;
        public int ElementId
        {
            get { return VElementId; }
            set { VElementId = value; }
        }

        public frmLimitAmount()
        {
            InitializeComponent();
            //cmbAmountOp.Items.AddRange(new string[] { "=", ">" });
            //cmbAGMOp.Items.AddRange(new string[] { "= ", ">" });
            //cmbQueryOp.Items.AddRange(new string[] { "=", ">" });
           
        }

        private void frmAmount_Load(object sender, EventArgs e)
        {
            Init();
            
            if (VElementId != 0)
                ShowElements();
            
          
        }
        private void Init()
        {
            
            agm = new AGM();
            lm = new LM();

            rdoAmount.Checked = false;
            rdoGroupName.Checked = false;
            rdoQuery.Checked = false;
            
            cmbAGM.DataSource = agm.GetAccountGroups();
            cmbAGM.DisplayMember = AGM.CTE_Alias_AccountGroup_GroupName;
            cmbAGM.SelectedIndex = -1;

            nQueryPer.Value = nAGMPer.Value = nAmountPer.Value = 100;
            txtAmount.Text = txtAmountQuery.Text = string.Empty;
            rdoAmount.Checked = rdoGroupName.Checked = rdoQuery.Checked = false;
        }

        private void ShowElements()
        {
            DataRow drElement = lm.GetLMElement(VElementId);

            switch (drElement["AmountType"].ToString().Trim())
            {
                case "A":
                    txtAmount.Text = drElement["Amount"].ToString();
                    nAmountPer.Value = decimal.Parse(drElement["AmountPercent"].ToString());
                    rdoAmount.Checked = true;

                    break;

                case "AG":
                    
                    string strAmountAG = drElement["Amount"].ToString();
                    strAmountAG = strAmountAG.Substring(0, strAmountAG.IndexOf("."));
                                       
                    for (int i = 0; i < cmbAGM.Items.Count ; i++)
                    {
                    //    System.Data.DataRowView drv = (System.Data.DataRowView)cmbAGM.Items[i];
                      
                        //if (drv.Row.ItemArray[1].ToString().Trim() == strAmountAG.Trim())
                        //{
                        //    cmbAGM.SelectedIndex = i;
                        //    break;
                      //  }
                    }
                    nAGMPer.Value = decimal.Parse(drElement["AmountPercent"].ToString());
                    rdoGroupName.Checked = true;
                 
                    break;

                case "Q":
                    txtAmountQuery.Text = drElement["Amount"].ToString();
                    nQueryPer.Value = decimal.Parse(drElement["AmountPercent"].ToString());
                    rdoQuery.Checked = true;
                    
                    break;

                default:
                    nQueryPer.Value = nAGMPer.Value = nAmountPer.Value = 100;
                    break;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!rdoAmount.Checked && !rdoGroupName.Checked && !rdoQuery.Checked)
            { Presentation.Public.Routines.ShowMessageBoxFa("لطفا يك روش برای مقدار دهی انتخاب كنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); this.DialogResult = DialogResult.None; return;
            
            }
            else
            {
                if (rdoAmount.Checked) CalculateAmount();
                if (rdoGroupName.Checked) CalculateGroupName();
                if (rdoQuery.Checked) CalculateQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void CalculateAmount()
        {
            strAmount_Type = "A";
            VAmount_Percent = nAmountPer.Value; 
            strAmount_Operand = cmbAmountOp.Text;
            strAmount = txtAmount.Text;
           

        }


        private void CalculateGroupName()
        {
            nAmountPer.Value = 0;
            txtAmount.Text = string.Empty;

            strAmount_Type = "AG";
            VAmount_Percent = nAGMPer.Value;
            strAmount_Operand = cmbAGMOp.Text;
            strAmount = cmbAGM.Text;
            

        }
        
      private void CalculateQuery()
        {
            strAmount_Type = "Q";
            VAmount_Percent = nQueryPer.Value; 
            strAmount = txtAmountQuery.Text;
        }
             
     private void btnQuery_Click(object sender, EventArgs e)
        {
           //frmQuery fx = new frmQuery();
           // fx.ShowDialog();
           // txtAmountQuery.Text = fx.Amount_Limit.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
     {

     }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rdoAmount_CheckedChanged(object sender, EventArgs e)
        {
            cmbAmountOp.Enabled = rdoAmount.Checked;
            nAmountPer.Enabled = rdoAmount.Checked;
            txtAmount.Enabled = rdoAmount.Checked;
        }

        private void rdoGroupName_CheckedChanged(object sender, EventArgs e)
        {
            cmbAGM.Enabled = rdoGroupName.Checked;
            nAGMPer.Enabled = rdoGroupName.Checked;
            cmbAGM.Enabled = rdoGroupName.Checked;
        }

        private void rdoQuery_CheckedChanged(object sender, EventArgs e)
        {
            cmbQueryOp.Enabled = rdoQuery.Checked;
            nQueryPer.Enabled =  rdoQuery.Checked;
            txtAmountQuery.Enabled = rdoQuery.Checked;
            btnQuery.Enabled = rdoQuery.Checked;
        }

    }
}