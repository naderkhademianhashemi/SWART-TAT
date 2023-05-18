using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;
//    
using Presentation.Miscs;
using Presentation.Public;

namespace Presentation.Deposit
{
    public partial class frmDepositModeling : BaseForm
    {

       
        private int curModelID = -1;

        public frmDepositModeling()
        {
            InitializeComponent();
        }

        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            CommandModelNew();
        }

        private void tsbModelEdit_Click(object sender, EventArgs e)
        {
            CommandModelEdit();
        }

        private void tsbModelRemove_Click(object sender, EventArgs e)
        {
            CommandModelRemove();
        }

        private void tsbModelSave_Click(object sender, EventArgs e)
        {
            CommandModelSave(curModelID, true);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {

            lsvModel.Clear();
            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            FillModel();
        }


        private void frmDepositModeling_Load(object sender, EventArgs e)
        {

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;


            
            
            chbColumnsOfShow.Items.Clear();
            
            var dataContracts = new DAL.DepositDataSetTableAdapters.Contract_Type1TableAdapter().GetDataByContractTypes();
            
            if (dataContracts != null)
            {

                foreach (var row in dataContracts.Rows.Cast<DataRow>())
                {
                    chbColumnsOfShow.Items.Add(new ColumnOfList<string, int>(row["Contract_Type_Description"].ToString(),
                                                                                Convert.ToInt32(row["Contract_Type"])));

                }
                
            }
            else
            {
                chbColumnsOfShow.Items.Clear();
            }

            FillModel();


        }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            chb_AllDeposit.Checked = false;
            if (lsvModel.SelectedItems.Count == 0)
                return;
            chbColumnsOfShow.Items.Clear();
            ListViewItem lvi = lsvModel.SelectedItems[0];
            var dataContracts = new DAL.DepositDataSetTableAdapters.Contract_Type1TableAdapter().GetDataByContractTypes();
            var checkedData = new DAL.DepositDataSetTableAdapters.DepositModel_contractTypeTableAdapter().GetDataBySelectedContracts(Convert.ToInt32(lvi.Tag));



            if (dataContracts != null)
            {

                foreach (var row in dataContracts.Rows.Cast<DataRow>())
                {
                    chbColumnsOfShow.Items.Add(new ColumnOfList<string, int>(row["Contract_Type_Description"].ToString(),
                                                                                Convert.ToInt32(row["Contract_Type"])));

                }
                foreach (var item in checkedData)
                {
                    var selected=dataContracts.Where(i => i.Contract_Type == item.Contract_ID).FirstOrDefault();
                    var indexTxt = selected.Contract_Type_Description;
                    var indexChb = chbColumnsOfShow.FindString(selected.Contract_Type.ToString().Substring(4) + "  |  "+indexTxt);
                    if (indexChb != -1)
                        chbColumnsOfShow.SetItemCheckState(indexChb, CheckState.Checked);
                }
            }
            else
            {
                chbColumnsOfShow.Items.Clear();
            }


        }

        private void CommandModelNew()
        {
            string descr = Routines.ShowInputBox();
            if (descr != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = descr;

                var newModel =
                    new DAL.DepositDataSetTableAdapters.DepositModelTableAdapter().InsertNewDepositModel(descr, GlobalInfo.ProfileID);

                lvi.Tag = new DAL.DepositDataSetTableAdapters.DepositModelTableAdapter().GetData(GlobalInfo.ProfileID).Max(item => item.Deposit_ID);
                lsvModel.Items.Add(lvi);
                curModelID = newModel;


                lvi.Selected = true;
            }
        }

        private void CommandModelEdit()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];

                string descr = Routines.ShowInputBox(lvi.Text);
                if (descr != string.Empty)
                {
                    lvi.Text = descr;

                    var newModel =
                   new DAL.DepositDataSetTableAdapters.DepositModelTableAdapter().UpdateDepositModel(descr, Convert.ToInt32(lvi.Tag));


                }
            }
        }

        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Routines.ShowMessageBoxFa("مدل انتخاب شده و تمامی مدلهای مرتبط به آن حذف خواهد شد. آيا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];

                    //TODO: if there was dependency!!!!!
                    if (Presentation.Miscs.CheckDependents.Show(CheckDep.CHECK_TBM, Convert.ToInt32(lvi.Tag).ToString()) == DialogResult.Cancel)
                        return;

                    lvi.Remove();

                    new DAL.DepositDataSetTableAdapters.DepositModelTableAdapter().DeleteDepositModel(Convert.ToInt32(lvi.Tag));
                }
            }
        }

        private void CommandModelSave(int modelID, bool bMsg)
        {
           

            if (lsvModel.SelectedItems.Count > 0)
            {
                var deletedContracts = new DAL.DepositDataSetTableAdapters.DepositModel_contractTypeTableAdapter().DeleteContracts(Convert.ToInt32(lsvModel.SelectedItems[0].Tag));

                foreach (var row in chbColumnsOfShow.CheckedItems.Cast< ColumnOfList<string, int>>())
                {
                    var insertedContracts = new DAL.DepositDataSetTableAdapters.DepositModel_contractTypeTableAdapter().InsertNewContract(Convert.ToInt32(lsvModel.SelectedItems[0].Tag),row.GetValue());
                }
                if (bMsg)
                    Routines.ShowMessageBoxFa("مدل با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillModel()
        {
            var dt = new DAL.DepositDataSetTableAdapters.DepositModelTableAdapter().GetDataByDepositModel(GlobalInfo.ProfileID);

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["Name"].ToString();
                lvi.Tag = dr["Deposit_ID"].ToString();

                lsvModel.Items.Add(lvi);
            }
        }



        internal class ColumnOfList<DType, VType>
        {
            private readonly DType Display;
            private readonly VType Value;
            public ColumnOfList(DType display, VType value)
            {
                Display = display;
                
                Value = value;
            }
            public string GetDisplay()
            {
                return Value.ToString().Substring(4) + "  |  " + Display.ToString();
            }
            public int GetValue()
            {
                return Convert.ToInt32(Value);
            }
            public override string ToString()
            {
                return GetDisplay();
            }
        }

        private void chb_AllDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_AllDeposit.Checked)
            {
                for (int i = 0; i < chbColumnsOfShow.Items.Count; i++)
                {
                    chbColumnsOfShow.SetItemCheckState(i, CheckState.Checked);
                }


            }
            else
            {
                for (int i = 0; i < chbColumnsOfShow.Items.Count; i++)
                {
                    chbColumnsOfShow.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chbColumnsOfShow.Items[0].
        }
    }
}
