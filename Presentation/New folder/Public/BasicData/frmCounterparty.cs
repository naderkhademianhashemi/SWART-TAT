using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Model;
//
using ERMSLib;
using Presentation.Public;
using Presentation.Tabs.BasicInfo;
using Utilize.Helper;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.BasicData
{
    public partial class frmCounterparty : Form
    {
        DataTable ds;
        int startIndex, endIndex;

        public frmCounterparty()
        {
            InitializeComponent();
            InitializeForm();
            clsERMSGeneral.InitializeTheme(this);
            GeneralDataGridView = dgvCounterparty;
        }

        private void InitializeForm()
        {
            this.bindingNavigatorSearchItem.ToolTipText = "جستجو";
            this.bindingNavigatorReturnItem.ToolTipText = "بازگشت به حالت اول";
        }

        private void frmCounterparty_Load(object sender, EventArgs e)
        {
            Helper h = new Helper();
                h.FormatDataGridView(dgvCounterparty);
                dgvCounterparty.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();
                GeneralDataGridView = dgvCounterparty;
        }
        private void fill_cmbPages()
        {
            //ProgressBox.Show();
            var count = new DAL.Table_DataSetTableAdapters.CounterpartyTableAdapter().GetCount().Value;
            cmbPages.BeginUpdate();
            for (var i = 1; i < count; i = i + 100)
            {
                cmbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cmbPages.EndUpdate();
            //ProgressBox.Hide();
            cmbPages.SelectedIndex = cmbPages.Items.Count == 0 ? -1 : 0;
            startIndex = cmbPages.SelectedIndex * 100 + 1;
            endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
            //fill_Counterparty(startIndex, endIndex);
        }
        private void fill_Counterparty(int startIndex, int endIndex)
        {
            //ProgressBox.Show();
            ds = new DAL.Counterparty_DataSet().GetCounterparty(startIndex, endIndex);
            //ProgressBox.Hide();
            bindingSource1.DataSource = ds;
            bindingNavigator1.BindingSource = bindingSource1;

            dgvCounterparty.DataSource = bindingSource1;
            dgvCounterparty.RightToLeft = RightToLeft.Yes;
            dgvCounterparty.Columns["ID"].HeaderText = "ردیف";
            dgvCounterparty.Columns["Counterparty"].HeaderText = "شماره مشتری";
            dgvCounterparty.Columns["Counterparty_Type_Desc"].HeaderText = "نوع مشتری";
            dgvCounterparty.Columns["Name"].HeaderText = "نام مشتری";
            dgvCounterparty.Columns["Customer_Group_Description"].HeaderText = "گروه مشتری";
        }


        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvCounterparty;
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Counterparty";
        }
        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = cmbPages.SelectedIndex * 100 + 1;
            endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;
            fill_Counterparty(startIndex, endIndex);
        }

        

        private void CounterpartySearch()
        {
            var dt = dgvCounterparty.Grid2TableSearch();

            Presentation.Tabs.BasicInfo.frmSearch frm = new Presentation.Tabs.BasicInfo.frmSearch(dt) {TableName = "Counterparty"};

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //ProgressBox.Show();
                    if (frm.Field != string.Empty)
                    {
                        if (frm.Search != string.Empty)
                        {
                            ds = new DAL.Counterparty_DataSet().CounterpartySearhc(frm.Search, frm.Field, frm.Operator);
                            bindingSource1.DataSource = ds;
                            //bindingSource1.DataMember = ds.Tables[0].TableName.ToString();
                            bindingNavigator1.BindingSource = bindingSource1;
                            dgvCounterparty.DataSource = bindingSource1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //ProgressBox.Hide();
                }
            }
        }

        

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            CounterpartySearch();
        }

        private void bindingNavigatorReturnItem_Click(object sender, EventArgs e)
        {
            try
            {
                //ProgressBox.Show();

                Helper h = new Helper();
                h.FormatDataGridView(dgvCounterparty);
                dgvCounterparty.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                fill_cmbPages();

            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //ProgressBox.Hide();
            }
        }
       
    }
}