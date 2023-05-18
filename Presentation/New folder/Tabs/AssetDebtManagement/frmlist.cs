using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;

//
using ERMSLib;


namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmlist : BaseForm
    {
        private int _LimitID;
        private int _Type;
        private string _StateID;
        private FncRatio_BL Fnc_BL;

        DataTable dtState;
        DataTable dtBranch;

        public int LimitID
        {
            get { return _LimitID; }
            set { _LimitID = value; }
        }

        DataTable _dtSelected;
        public DataTable dtSelected
        {
            get { return _dtSelected; }
            set { _dtSelected = value; }
        }

        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string StateID
        {
            get { return _StateID; }
            set { _StateID = value; }
        }


        private string _strLimitDetail = string.Empty;
        public string strLimitDetail
        {
            get { return _strLimitDetail; }
            set { _strLimitDetail = value; }
        }

        public frmlist()
        {
            InitializeComponent();
        }

        private void frmlist_Load(object sender, EventArgs e)
        {
            chklstLimit.DataSource = null;
            if (Type == 1) //State
            {
                FillCheckBoxState();
            }
            if (Type == 2) //Branch
                FillCheckBoxBranch();


        }

        private void FillCheckBoxBranch()
        {
            Fnc_BL = new FncRatio_BL();
            DataSet ds;

            ds = Fnc_BL.GetDTBranch(StateID);
            dtBranch = ds.Tables[0];
            chklstLimit.DataSource = dtBranch;
            chklstLimit.DisplayMember = "Branch_Description";
            chklstLimit.ValueMember = "Branch";

        }

        private void FillCheckBoxState()
        {
            Fnc_BL = new FncRatio_BL();
            dtState = Fnc_BL.GetDTState();

            chklstLimit.DataSource = dtState;
            chklstLimit.DisplayMember = "State_Name";
            chklstLimit.ValueMember = "State_Id";


        }


        private void btnClose_Click(object sender, EventArgs e)
        {
           DataRow RowState;
           DataColumn dcol = new DataColumn("Selected", typeof(System.String));
            //int j = 0;
            _dtSelected = new DataTable();
        
            _dtSelected.Columns.Add(dcol);
            if (Type == 1) //State
            {
                for (int i = 0; i < dtState.Rows.Count; i++)
                {
                    if (chklstLimit.GetItemCheckState(i) == CheckState.Checked)
                    {
                        _strLimitDetail = _strLimitDetail + " State = " + dtState.Rows[i]["State_Id"].ToString().Trim() + " OR";
                         RowState = _dtSelected.NewRow();

                          RowState[0] = dtState.Rows[i]["State_Name"].ToString();
                        _dtSelected.Rows.InsertAt(RowState, 0);
                        
                    }
                }
            }
            if (Type == 2) //Branch
            {
                for (int i = 0; i < dtBranch.Rows.Count; i++)
                {

                    if (chklstLimit.GetItemCheckState(i) == CheckState.Checked)
                    {
                        _strLimitDetail = _strLimitDetail + "  Branch = " + dtBranch.Rows[i]["Branch"].ToString().Trim() + " OR";
                        RowState = _dtSelected.NewRow();

                        RowState[0] = dtBranch.Rows[i]["Branch_Description"].ToString();
                        _dtSelected.Rows.InsertAt(RowState, 0);
                    }

                }
            }

            _strLimitDetail = _strLimitDetail.Substring(1, _strLimitDetail.Length - 3);

            this.Close();
        }

        private void chklstLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chklstLimit.SetItemCheckState();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCancel_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}