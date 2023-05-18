using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilize.Helper;
//
using System.Collections;
using ERMS.Logic;
using ERMS.Model;
using ERMSLib;
using Presentation.Public;
using Presentation.Tabs.AssetDebtManagement;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.FinancialRatio
{
    public partial class frmAccountsReport : BaseForm, IPrintable
    {

        private Presentation.Tabs.AssetDebtManagement.frmGroup fxGroup;
        private TreeNode tnRoot;
        private Hashtable htNodes;

        private List<string> VirtualTree;
        private bool bDirty;

        #region VAR

        private const int CTE_Checked_ColIndex = 0;
        private const int CTE_AccountCode_ColIndex = 1;
        private const int CTE_AccountName_ColIndex = 2;

        private AGM agm;
  
        private bool bResumeCheckDep;
     
        private List<int> lsRemovedTitleIDs, lsRemovedGroupIDs, lsRemovedAGIDs;
   
        private DataTable dtDgvAccountGL;
        #endregion VAR

        public frmAccountsReport()
        {
            InitializeComponent();
            bDirty = false;

            lblProgress.Visible = false;

            trv.ItemHeight = 32;
            trv.Indent = 40;
            trv.TreeInfoEx.Width4MinBox = 350;


            VirtualTree = new List<string>();

            dgvAccountGL.Tag = EAccountCategory.AccountGL;


            htNodes = new Hashtable();
            fxGroup = new Presentation.Tabs.AssetDebtManagement.frmGroup();
            GeneralDataGridView = dgvAccountGL;
            Reload();
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "AGM";
        }


        private void Reload()
        {
            try
            {
                ProgressBox.Show();

                Cursor.Current = Cursors.WaitCursor;
                lblProgress.Visible = true;
                trv.Nodes.Clear();
                VirtualTree.Clear();


                FillAccounts();
                FillDiagram();




                bDirty = false;


                lblProgress.Visible = false;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
        }



        private void FillAccounts()
        {


            Helper h = new Helper();
            h.FormatDataGridView(dgvAccountGL);

            dgvAccountGL.ColumnHeadersVisible = true;
            dgvAccountGL.AllowUserToResizeColumns = true;
            dgvAccountGL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvAccountGL.MultiSelect = false;
            dgvAccountGL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            DataTable dt;
            dt = new DAL.SwartDataSetTableAdapters.Accounts_GLTableAdapter().GetDataBy();

            //dt.PrimaryKey = new DataColumn[] { dt.Columns["Accounting_Code"] };
            dt.DefaultView.Sort = "Accounting_Code";
            foreach (DataColumn column in dt.Columns)
            {
                column.ReadOnly = false;
            }
            dgvAccountGL.DataSource = dt;


            dgvAccountGL.Columns["Accounting_Code"].HeaderText = "كد";
            dgvAccountGL.Columns["Accounting_Name"].HeaderText = "نام";
            dgvAccountGL.Columns["Accounting_Name"].MinimumWidth = (dgvAccountGL.Width) * 5 / 6;
            dgvAccountGL.Columns["Debt_Amount"].HeaderText = "مقدار بدهکار";
            dgvAccountGL.Columns["Credit_Amount"].HeaderText = "مقدار بستانکار";
        }

        private void FillDiagram()
        {

            trv.BeginUpdate();
            tnRoot = trv.Nodes.Add("ترازنامه");
            DataTable dt1 = new DAL.Table_DataSetTableAdapters.AccountsTableAdapter().GetDataBy("0000");
            htNodes.Clear();

            foreach (DataRow dr1 in dt1.Rows)
            {

                TreeNode tn1 = new TreeNode();
                tn1.Tag = dr1;
                tn1.Name = dr1["sarfasl"].ToString();
                tn1.Text = dr1["des"].ToString();
                tn1.ToolTipText = dr1["des"].ToString();
                tnRoot.Nodes.Add(tn1);
                DataTable dt2 = new DAL.Table_DataSetTableAdapters.AccountsTableAdapter().GetDataBy(tn1.Name);


                foreach (DataRow dr2 in dt2.Rows)
                {
                    TreeNode tn2 = new TreeNode();
                    tn2.Tag = dr2;
                    tn2.Name = dr2["sarfasl"].ToString();
                    tn2.Text = dr2["des"].ToString();
                    tn2.ToolTipText = dr2["des"].ToString();
                    tn1.Nodes.Add(tn2);
                    DataTable dt3 = new DAL.Table_DataSetTableAdapters.AccountsTableAdapter().GetDataBy(tn2.Name);


                    foreach (DataRow dr3 in dt3.Rows)
                    {
                        TreeNode tn3 = new TreeNode();
                        tn3.Tag = dr3;
                        tn3.Name = dr3["sarfasl"].ToString();
                        tn3.Text = dr3["des"].ToString();
                        tn3.ToolTipText = dr3["des"].ToString();
                        tn2.Nodes.Add(tn3);
                        DataTable dt4 = new DAL.Table_DataSetTableAdapters.AccountsTableAdapter().GetDataBy(tn3.Name);

                        foreach (DataRow dr4 in dt4.Rows)
                        {
                            TreeNode tn4 = new TreeNode();
                            tn4.Tag = dr4;
                            tn4.Name = dr4["sarfasl"].ToString();
                            tn4.Text = dr4["des"].ToString();
                            tn4.ToolTipText = dr4["des"].ToString();
                            tn3.Nodes.Add(tn4);
                            DataTable dt5 = new DAL.Table_DataSetTableAdapters.AccountsTableAdapter().GetDataBy(tn4.Name);


                            foreach (DataRow dr5 in dt5.Rows)
                            {
                                TreeNode tn5 = new TreeNode();
                                tn5.Tag = dr5;
                                tn5.Name = dr5["sarfasl"].ToString();
                                tn5.Text = dr5["des"].ToString();
                                tn5.ToolTipText = dr5["des"].ToString();
                                tn4.Nodes.Add(tn5);
                              

                            }
                        }
                    }

                }
                VirtualTree.Add(dr1["des"].ToString());
            }
            trv.EndUpdate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter(txtSearch.Text);

        }

        private void Filter(string criteria)
        {
           
            string filter = (criteria != string.Empty) ? string.Format("[Accounting_Code] LIKE '%{0}%' OR [Accounting_Name] LIKE '%{0}%'", criteria) : string.Empty;
            ((DataTable)dgvAccountGL.DataSource).DefaultView.RowFilter = filter;

            TreeNode[] temp = trv.Nodes.Find(((criteria != string.Empty) ? criteria : ""), true);

            if (temp.Length > 0)
            {
                trv.SelectedNode = temp[0];
                trv.Select();
            }




        }
    
        private void trv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DataTable dt1 = new DAL.Table_DataSetTableAdapters.AccountsTableAdapter().GetData();
           

                int i = 0;
                foreach (DataGridViewRow row in dgvAccountGL.Rows)
                {
                    i = i + 1;
                                if (row.Cells[0].Value.ToString().Equals(e.Node.Name.ToString()))
                                {
                                    row.Selected = true;
                                    dgvAccountGL.FirstDisplayedScrollingRowIndex = i - 1;
                                    break;
                                }
                  

            }

            //if (e.Node.Tag is DataRow)
            //{
            //    e.Node.Nodes.Clear();
            //    //htNodes.Clear();
            //    string x = e.Node.Name;
            //    DataRow agi = (DataRow)e.Node.Tag;
            //    DataRow agiParent = (DataRow)e.Node.Parent.Tag;
            //    trv.BeginUpdate();
            //    DataTable dt1 = new DAL.Table_DataSetTableAdapters.AccountsTableAdapter().GetDataBy(x);

            //    foreach (DataRow dr1 in dt1.Rows)
            //    {
            //        TreeNode tn1 = new TreeNode();
            //        tn1.Tag = dr1;
            //        tn1.Name = dr1["sarfasl"].ToString();
            //        tn1.Text = dr1["des"].ToString();
            //        tn1.ToolTipText = dr1["des"].ToString();
            //        //htNodes.Add(dr1["sarfasl"], tn1);
            //        TreeNode parentNode = (TreeNode)e.Node;
            //        parentNode.Nodes.Add(tn1);
            //        VirtualTree.Add(dr1["des"].ToString());
            //    }

            //    trv.EndUpdate();

            //}

        }


        private void dgvSelected(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count != 0)
                dgv.SelectedRows[0].Selected = false;
        }



    }
}
