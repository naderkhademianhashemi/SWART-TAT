using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ERMS.Logic;
using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmMap : Form
    {
        #region CONST
        private const string CTE_Loan = "تسهیلات";
        private const string CTE_Deposit = "سپرده ها";
        private const string CTE_warranty = "ضمانتنامه ها";
        private const string CTE_warranty_cur = "ضمانتنامه ارزی";
        private const string CTE_lc_cur = "اعتبارات اسنادی ارزی";
        #endregion

        #region VARS
        private Contract_Type ct;
        private AGM agm;
        private GCX gcx;

        #endregion


        public frmMap()
        {
            InitializeComponent();
            cmbContract_Type_LD.AddItemsRange(new string[] { CTE_Loan, CTE_Deposit, CTE_warranty, CTE_warranty_cur, CTE_lc_cur });
            cmbContract_Type_LD.SelectedIndex = -1;

        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            ct = new Contract_Type();
            agm = new AGM();
            gcx = new GCX();

            dgvList.Columns.Clear();
            Helper h = new Helper();
            h.FormatDataGridView(dgvList);


        
            cmbAccountingGroup.DataSource = agm.GetAccountGroups();
            cmbContractType.DataSource = ct.GetInstancesDT();
            dgvList.DataSource = gcx.GetInstancesDT();
            dgvList.Columns[0].Visible = false;
            dgvList.Columns[1].HeaderText = "گروه حساب";
            dgvList.Columns[2].HeaderText = "نوع قرارداد";

            DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
            tCol.MinimumWidth = 512;
            dgvList.Columns.Add(tCol);


            tsbApply.Enabled = false;
            tsbCancel.Enabled = false;

         
            cmbAccountingGroup.DisplayMember = AGM.CTE_Alias_AccountGroup_GroupName;
            cmbAccountingGroup.ValueMember = AGM.CTE_Alias_AccountGroup_GroupID;
           // cmbAccountingGroup.SelectedIndex = 0;
            cmbContractType.DisplayMember = Contract_Type.CTE_Alias_Descr;
            cmbContractType.ValueMember = Contract_Type.CTE_Alias_ID;

        }


        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            CommandNew();
        }

        private void CommandNew()
        {
            if (cmbContractType.SelectedIndex != -1 && cmbAccountingGroup.SelectedIndex != -1)
            {
                string groupName = cmbAccountingGroup.SelectedItem.DisplayText;
                int ctID = (int)cmbContractType.SelectedValue;
                string ctDescr = cmbContractType.Text;

                if (CheckExist(groupName, ctDescr))
                {
                    DataRow dr = gcx.InsertInstance(groupName, ctID);
                    DataTable dt = (DataTable)dgvList.DataSource;

                    dt.LoadDataRow(dr.ItemArray, true);
                }
                else
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("گروه حسابها با نوع قرارداد قبلا تطبيق داده شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("هیچ گروه حساب یا نوع قراردادی انتخاب نشده است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private bool CheckExist(string groupName, string ctDescr)
        {
            bool flag = true;
            foreach (DataGridViewRow r in dgvList.Rows)
            {
                if ((ctDescr.Trim() == r.Cells[GCX.CTE_Alias_ContractDescr].Value.ToString().Trim()) && (groupName.Trim() == r.Cells[GCX.CTE_Alias_GroupDescr].Value.ToString().Trim()))
                {
                    flag = false;
                    break;
                }
            }
            return flag;

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            CommandEdit();
        }

        private void CommandEdit()
        {
          
            try
            {
                if (dgvList.SelectedRows.Count > 0)
                {
                   
                    tsbEdit.Enabled = false;
                    tsbNew.Enabled = false;
                    tsbRefresh.Enabled = false;
                    tsbDelete.Enabled = false;
                    dgvList.Enabled = false;
                    
                    DataGridViewRow r = dgvList.SelectedRows[0];
                    int gcID = Convert.ToInt32(r.Cells[GCX.CTE_Alias_ID].Value);
                    DataRow dr = gcx.GetInstanceByID(gcID);
                    string groupName =r.Cells[GCX.CTE_Alias_GroupDescr].ToString();
                    int ctID = Convert.ToInt32(dr[GCX.CTE_Alias_ContractID]);

                    //cmbAccountingGroup.SelectedText = groupName;
                    //cmbContractType.SelectedByDataValue(ctID);

                    tsbApply.Enabled = true;
                    tsbCancel.Enabled = true;
                   
                }
            }

            catch(Exception ex)
            {

                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            CommandDelete();
        }
        private void CommandDelete()
        {
            foreach (DataGridViewRow r in dgvList.SelectedRows)
            {
                int gcID = Convert.ToInt32(r.Cells[GCX.CTE_Alias_ID].Value);

                gcx.DeleteInstance(gcID);
                dgvList.Rows.Remove(r);
            }

        }

        private void tsbApply_Click(object sender, EventArgs e)
        {
            CommandApply();
        }

        private void CommandApply()
        {
            if (cmbContractType.SelectedIndex != -1 && cmbAccountingGroup.SelectedIndex != -1)
            {
                DataGridViewRow r = dgvList.SelectedRows[0];
                int gcID = Convert.ToInt32(r.Cells["ID"].Value);
                string groupName = cmbAccountingGroup.SelectedItem.DisplayText;
                int ctID = (int)cmbContractType.SelectedValue;

                gcx.UpdateInstance(gcID, groupName, ctID);
                r.Cells[GCX.CTE_Alias_GroupDescr].Value = cmbAccountingGroup.SelectedItem.DisplayText;
                r.Cells[GCX.CTE_Alias_ContractDescr].Value = cmbContractType.SelectedItem.DisplayText;

                tsbEdit.Enabled = true;
                tsbNew.Enabled = true;
                tsbRefresh.Enabled = true;
                tsbDelete.Enabled = true;
                dgvList.Enabled = true;
                tsbApply.Enabled = false;
                //tsbCancel.Enabled = false;
                
            }
            else
            {
                Presentation.Public.Routines.ShowMessageBoxFa("هیچ گروه حساب یا نوع قراردادی انتخاب نشده است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            tsbEdit.Enabled = true;
            tsbNew.Enabled = true;
            tsbRefresh.Enabled = true;
            tsbDelete.Enabled = true;
            dgvList.Enabled = true;
            tsbApply.Enabled = false;
            tsbCancel.Enabled = false;
            Init();

        }


        private void frmMap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "N")
            {
                CommandNew();
            }
            if (e.Control && e.KeyCode.ToString() == "E")
            {
                CommandEdit();
            }
            if (e.Control && e.KeyCode.ToString() == "S")
            {
                CommandApply();
            }
            //delete
            if (e.Control && e.KeyCode.ToString() == "D")
            {
                CommandDelete();
            }
            //Load,refresh
            if (e.KeyCode == Keys.F5)
            {
                Init();
            }
        }

        private void cmbContract_Type_LD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int LD = cmbContract_Type_LD.SelectedIndex + 1;
            if (LD > 0)
            {
                cmbContractType.DataSource = ct.GetInstancesDTLD(LD);
            }
            else
                return;
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow r = dgvList.SelectedRows[0];
            int gcID = Convert.ToInt32(r.Cells[GCX.CTE_Alias_ID].Value);
            DataRow dr = gcx.GetInstanceByID(gcID);
            string groupName = dr[GCX.CTE_Alias_GroupDescr].ToString();

            string contract = dr[GCX.CTE_Alias_ContractDescription].ToString();
            int ctID = Convert.ToInt32(dr[GCX.CTE_Alias_ContractID]);
            int gnID = Convert.ToInt32(dr[GCX.CTE_Alias_ID]);

            cmbAccountingGroup.SelectedByDataValue(groupName);
            cmbContractType.SelectedByDataValue(contract);
            cmbAccountingGroup.SelectedByDataValue(gnID);
            cmbContractType.SelectedByDataValue(ctID);
           
            
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridViewRow r = dgvList.SelectedRows[0];
            //int gcID = Convert.ToInt32(r.Cells[GCX.CTE_Alias_ID].Value);
            //DataRow dr = gcx.GetInstanceByID(gcID);
            //string groupName = dr[GCX.CTE_Alias_GroupDescr].ToString();
            //string contract = dr[GCX.CTE_Alias_ContractDescription].ToString();
            //int ctID = Convert.ToInt32(dr[GCX.CTE_Alias_ContractID]);
            //int gnID = Convert.ToInt32(dr[GCX.CTE_Alias_ID]);
            
            //cmbAccountingGroup.SelectedByDataValue(groupName);
            //cmbContractType.SelectedByDataValue(contract);
            //cmbAccountingGroup.SelectedByDataValue(gnID);
            //cmbContractType.SelectedByDataValue(ctID);
            ////cmbContractType.SelectedText = contract;
        }

        

      
    
    }
}