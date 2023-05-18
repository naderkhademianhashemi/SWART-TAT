using System;
using System.Data;
using System.Windows.Forms;
using ERMS.Logic;
using ERMSLib;
using Presentation.Public;
using Utilize.Helper;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmDetail : BaseForm
    {
        public string Parent = "GAP";
        public bool Delayed { get; set; }

        private DataTable dtDetail;

        public DataTable DetailDT
        {
            get { return dtDetail; }
            set { dtDetail = value; }
        }
        //soli-87/06/14
        private int count;
        public int dtCount
        {
            get { return count; }
            set { count = value; }
        }


        private bool _Historic;
        public bool Historic
        {
            get { return _Historic; }
            set { _Historic = value; }
        }


        //soli-87/06/14
        private int _fsModelElementID;

        public int fsModelElementID
        {
            get { return _fsModelElementID; }
            set { _fsModelElementID = value; }
        }

        private int _tbModelID;
        public int tbModelID
        {
            get { return _tbModelID; }
            set { _tbModelID = value; }
        }

        private int _cbModelID;
        public int cbModelID
        {
            get { return _cbModelID; }
            set { _cbModelID = value; }
        }

        private int _CurrencyID;
        public int CurrencyID
        {
            get { return _CurrencyID; }
            set { _CurrencyID = value; }
        }

        private int _tbElementSeq;

        public int tbElementSeq
        {
            get { return _tbElementSeq; }
            set { _tbElementSeq = value; }
        }

        private bool _IsSeperate;

        public bool IsSeperate
        {
            get { return _IsSeperate; }
            set { _IsSeperate = value; }
        }

        private int _limitID;

        public int limitID
        {
            get { return _limitID; }
            set { _limitID = value; }
        }

        private string _limitDetails;

        public string limitDetails
        {
            get { return _limitDetails; }
            set { _limitDetails = value; }
        }

        private DateTime _dtpStartDateValue;

        public DateTime dtpStartDateValue
        {
            get { return _dtpStartDateValue; }
            set { _dtpStartDateValue = value; }
        }

        private bool _chkIrrValue;

        public bool chkIrrValue
        {
            get { return _chkIrrValue; }
            set { _chkIrrValue = value; }
        }



        //////End Soli/////////////
        private static bool bprint;
        public static bool Detailprint
        {
            get { return bprint; }
            set { bprint = value; }

        }

        public static DataGridView dgv;

        public frmDetail()
        {
            InitializeComponent();
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvList);
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void fill_Detail_GAP()
        {
            try
            {
                GAP gap = new GAP();
                
                SaveFileDialog DialogSave = new SaveFileDialog
                                                {
                                                    DefaultExt = "xlsx",
                                                    Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                                                    AddExtension = true,
                                                    RestoreDirectory = true,
                                                    Title = " لطفا مسیر ذخیره فایل را انتخاب کنید"
                                                };


                if (DialogSave.ShowDialog() == DialogResult.OK)
                {

                    Cursor = Cursors.WaitCursor;
                    if (Delayed == false)
                    {
                        if (limitID == 2 && limitDetails.ToUpper().Contains("STATE"))
                            limitDetails = limitDetails.ToUpper().Replace("STATE", "State.State_Id");
                        else if (limitID == 3 && limitDetails.ToUpper().Contains("CITY"))
                            limitDetails = limitDetails.ToUpper().Replace("CITY", "City.City_Id");
                        else if (limitID == 4 && limitDetails.ToUpper().Contains("BRANCH"))
                            limitDetails = limitDetails.ToUpper().Replace("BRANCH", "Organization.BRANCH");
                    }
                    DataTable dt = gap.GetDetail(fsModelElementID, tbModelID, tbElementSeq, cbModelID, dtpStartDateValue, 
                        chkIrrValue, limitDetails, limitID, IsSeperate, CurrencyID, 1, 1,Delayed, Historic);
                    Cursor = Cursors.Default;
                    new Utilize.Excel.frmGrid(dt.ConfigDateTimeToPersian(),
                                              DialogSave.FileName);
                    Presentation.Public.Routines.ShowInfoMessageFa("خروجی اکسل", "ذخیره فایل به پایان رسید", MyDialogButton.OK);

                    DialogSave.Dispose();
                    this.Close();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fill_Detail_GAPBM()
        {
            try
            {                
                GAPBM gapbm = new GAPBM();

                SaveFileDialog DialogSave = new SaveFileDialog
                {
                    DefaultExt = "xlsx",
                    Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    AddExtension = true,
                    RestoreDirectory = true,
                    Title = " لطفا مسیر ذخیره فایل را انتخاب کنید"
                };


                if (DialogSave.ShowDialog() == DialogResult.OK)
                {

                    Cursor = Cursors.WaitCursor;
                    if (limitID == 2 && limitDetails.ToUpper().Contains("STATE"))
                        limitDetails = limitDetails.ToUpper().Replace("STATE", "State.State_Id");
                    if (limitID == 0 && limitDetails.ToUpper().Contains("BRANCH"))
                        limitDetails = limitDetails.ToUpper().Replace("BRANCH", "Organization.BRANCH");
                    DataTable dt = gapbm.GetDetail(fsModelElementID, tbModelID, tbElementSeq, dtpStartDateValue, chkIrrValue, limitDetails, limitID, IsSeperate, 1, 1);
                    Cursor = Cursors.Default;
                    new Utilize.Excel.frmGrid(dt.ConfigDateTimeToPersian(),
                                              DialogSave.FileName);
                    Presentation.Public.Routines.ShowInfoMessageFa("خروجی اکسل", "ذخیره فایل به پایان رسید", MyDialogButton.OK);

                    DialogSave.Dispose();
                    this.Close();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgv;
        }
        private void chkPrint_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrint.Checked)
            {
                Detailprint = true;
                dgv = dgvList;
                //dgv = new DataGridView();
                //if (dgvList.DataSource != null)
                //{

                //    foreach (DataGridViewColumn c1 in dgvList.Columns)
                //    {
                //        DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                //        dgv.Columns.Add(c2);
                //    }
                //    int i;
                //    dgv.Rows.Add(1);


                //    foreach (DataGridViewRow dgvr in dgvList.Rows)
                //    {

                //        DataGridViewRow r = (DataGridViewRow)dgvr.Clone();

                //        i = 0;
                //        foreach (DataGridViewCell cell in dgvr.Cells)
                //        {
                //            r.Cells[i].Value = cell.Value;
                //            i++;
                //        }
                //        dgv.Rows.Add(r);
                //    }
                //    if (dgv.Columns[0].HeaderText != "Flag")
                //    {
                //    dgv.Rows[0].Cells[0].Value = dgv.Columns[0].HeaderText;
                //    dgv.Rows[0].Cells[1].Value = dgv.Columns[1].HeaderText;
                //    dgv.Rows[0].Cells[2].Value = dgv.Columns[2].HeaderText;
                //    dgv.Rows[0].Cells[3].Value = dgv.Columns[3].HeaderText;
                //    dgv.Rows[0].Cells[4].Value = dgv.Columns[4].HeaderText;
                //    dgv.Rows[0].Cells[5].Value = dgv.Columns[5].HeaderText;
                //    dgv.Rows[0].Cells[6].Value = dgv.Columns[6].HeaderText;
                //    dgv.Rows[0].Cells[7].Value = dgv.Columns[7].HeaderText;
                //    dgv.Rows[0].Cells[9].Value = dgv.Columns[9].HeaderText;
                //    }
                //    else if (dgv.Columns[0].HeaderText == "Flag")
                //    {
                //        dgv.Rows[0].Cells[0].Value = dgv.Columns[0].HeaderText;
                //        dgv.Rows[0].Cells[1].Value = dgv.Columns[1].HeaderText;
                //        dgv.Rows[0].Cells[2].Value = dgv.Columns[2].HeaderText;
                //        dgv.Rows[0].Cells[3].Value = dgv.Columns[3].HeaderText;
                //    }

                //dgv.Rows[0].Cells[0].Style.BackColor = Color.Yellow  ;   
                //; 
                clsERMSGeneral.dgvActive = dgv;

            }
        }

        private void frmDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Detailprint = false;
        }


        private void btnCSV_Click(object sender, EventArgs e)
        {
            if(Parent.Equals("GAP"))
                fill_Detail_GAP();
            else if (Parent.Equals("GAPBM"))
                fill_Detail_GAPBM();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}