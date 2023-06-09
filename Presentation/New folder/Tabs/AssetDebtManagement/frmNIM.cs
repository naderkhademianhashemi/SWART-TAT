using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Utilize.Helper;


using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinTree;
using ERMSLib;
using Dundas.Charting.WinControl;
using Dundas.Charting.WinControl.ChartTypes;
using Dundas.Charting.WinControl.Design;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;
using System.Reflection;
using System.IO;
using ERMS.Logic;
using ERMS.Model;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmNIM : BaseForm
    {
        #region VARS

        private int curModelID = -1;
        private NIM nim;

        private DataTable dtList1;
        private bool TagFullMode = false;

        private int spcl1Height = 0;
        private int spcl2Height = 0;
        private int spcl3Height = 0;

        private DataTable branch;
        private DataTable dtTableXml;
        private DataTable user;
        private string limitDetails = string.Empty;
        private int limitID = -1;
        #endregion

        public frmNIM()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);

            #region State And Organization

            #region Add By AliZ

            // تابع برای تنظیم لیست شهر ها زمانی که نمایش داده می شود
            ucfCity.DropDownOpening += (ucfCity_DropDownOpening);

            #endregion

            ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;

            user =
                new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(
                    ERMS.Model.GlobalInfo.UserID);

            if (user.Rows.Count == 0)
            {
                var organization_DataTable = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();

                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";
                ucfOrganization.DataSource = organization_DataTable;
                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;

                #region Add By Aliz

                //تنظیمات فیلتر بندی شهر
                var cityDataTable = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_ID";
                ucfCity.DataSource = cityDataTable;

                #endregion
            }
            else
            {

                var organizationNew_DataTable =
                    user.Rows.Cast<DataRow>().Select(
                        item =>
                        new
                        {
                            Brach_Id = item["Branch"].ToString(),
                            Branch_Description = item["Branch_Description"].ToString()
                        }).Distinct().ToArray();

                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";
                ucfOrganization.DataSource = organizationNew_DataTable;
                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;

                #region Add By Aliz

                //تنظیمات فیلتر بندی شهر
                var cityDataTable = user.Rows.Cast<DataRow>().Select(item => new { City_ID = item["City_ID"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray(); new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData();
                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_ID";
                ucfCity.DataSource = cityDataTable;

                #endregion

            }

            #endregion
        }

        /// <summary>
        /// تابع برای تنظیم لیست شهر ها زمانی که نمایش داده می شود
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ucfCity_DropDownOpening(object sender, EventArgs e)
        {
            #region Add By Aliz

            try
            {
                ucfCity.DisplayMember = "City_Name";
                ucfCity.ValueMember = "City_Id";

                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (cmbLimitValue.SelectedIndex != -1)
                {
                    if (user.Rows.Count == 0)
                    {
                        var cities = new DAL.GeneralDataSetTableAdapters.CityTableAdapter().GetData().Where(
                            city => int.Parse(cmbLimitValue.SelectedValue.ToString().Trim()) == (int)city.State_ID_Fk);
                        DataTable dt = new DataTable();
                        dt.Columns.Add("City_Name");
                        dt.Columns.Add("City_Id");
                        foreach (var row in cities)
                        {
                            DataRow dr = dt.NewRow();
                            dr["City_Name"] = row["City_Name"];
                            dr["City_Id"] = row["City_Id"];
                            dt.Rows.Add(dr);
                        }
                        ucfCity.DataSource = dt;
                        ucfCity.Update();
                        ucfCity.Refresh();
                    }
                    else
                    {
                        var cities = user.Rows.Cast<DataRow>().Where(city => Convert.ToInt32(cmbLimitValue.SelectedValue) == Convert.ToInt32(city["State_Id"].ToString()))
                        .Select(item => new { City_Id = item["City_Id"].ToString(), City_Name = item["City_Name"].ToString() }).Distinct().ToArray();

                        ucfCity.DataSource = cities;
                    }
                    ucfOrganization.Enabled = true;
                    return;
                }

                if (ucfCity.GetSelectedItem().Count() > 0)
                    ucfOrganization.Enabled = true;
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            #endregion
        }

        private void frmNIM_Load(object sender, EventArgs e)
        {
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = new CultureInfo("fa-IR");

            fdpStartDate.SelectedDateTime = new DAL.General_DataSet().GetLastUpdateDate();  //DateTime.Now;
            // fdpStartDate.ResetSelectedDateTime();

            user =
                new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(
                    ERMS.Model.GlobalInfo.UserID);

            Init();
            rdbHistoric.Checked = true;
        }

        private void Init()
        {
            nim = new NIM();

            RebindTBM();

            Misc misc = new Misc();
            cmbCurrency.DataSource = misc.GetCurrencyDT();
            cmbCurrency.DisplayMember = Misc.CTE_Alias_CurrencyDescr;
            cmbCurrency.ValueMember = Misc.CTE_Alias_CurrencyID;
            cmbCurrency.SelectedIndex = cmbCurrency.Items.Count > 0 ? 0 : -1;
            cmbCurrency.SetDefaultCurrency("ریال ایران");

            cmbDefCurrency.DataSource = misc.GetCurrencyDT();
            cmbDefCurrency.DisplayMember = Misc.CTE_Alias_CurrencyDescr;
            cmbDefCurrency.ValueMember = Misc.CTE_Alias_CurrencyID;
            cmbDefCurrency.SelectedIndex = cmbDefCurrency.Items.Count > 0 ? 0 : -1;
            cmbDefCurrency.SetDefaultCurrency("ریال ایران");

            RebindNII();

            //dtpStartDate.Format = DateTimePickerFormat.Custom;
            //dtpStartDate.CustomFormat = "dd/MM/yyyy";

            cmbUnit.AddItemsRange(new string[] {"واحد", "هزار", "ميليون"});
            cmbUnit.SelectedIndex = 0;

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            dgvList1.EnableHeadersVisualStyles = false;
            GeneralDataGridView = dgvList1;

            FillModel();
            ReadXml();
            FillDest("State");

            //cbCollapseUp_CButtonClicked(null, null);
        }

        public int CurrentTBModelID
        {
            get
            {
                int cbModelID = (int) cmbCBM.SelectedValue;
                CBM cbm = new CBM();
                CBMInfo ci = new CBMInfo();
                DataRow drCBM = cbm.GetCBM(cbModelID);
                cbm.CloneX(drCBM, ci, ECloneXdir.DR2Info);

                int tbModelID = ci.TBModelID;

                return tbModelID;
            }
        }

        public int CurrentCBModelID
        {
            get
            {
                int cbModelID = (int) cmbCBM.SelectedValue;
                return cbModelID;
            }
        }

        private void cmbTBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FillCategory();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {

            if (scAll.Panel1Collapsed == false)
            {
                scAll.Panel1Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (scAll.Panel1Collapsed == true)
            {
                scAll.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
            Chk_AutoSize.Checked = true;
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.SelectedValue is int)
                Reload();
        }

        private void lsvModel_DoubleClick(object sender, EventArgs e)
        {
            CommandModelEdit();
        }

        private void frmNIM_FormClosing(object sender, FormClosingEventArgs e)
        {
            TagFullMode = false;
        }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
            {
                if (lsvModel.SelectedItems.Count > 0)
                {
                    NIMMInfo ni = (NIMMInfo) lsvModel.SelectedItems[0].Tag;
                    cmbNII.SelectedByDataValue(ni.NIIModelID);
                    //hgr Aliz soal
                    //SelectedValue = ni.NIIModelID;
                    //cmbCBM.SelectedValue = ni.CBModelID;
                    cmbCBM.SelectedByDataValue(ni.CBModelID);

                    //Farsi
                    //PersianTools.Dates.PersianDate P;
                    //P = new PersianTools.Dates.PersianDate(ni.StartDate.Year, ni.StartDate.Month, ni.StartDate.Day, PersianTools.Dates.CalendarsMode.Gregorian);
                    //DateTime startDate = DateTime.Parse(P.ToGregorian.ToString("yyyy/MM/dd"));
                    //P = new PersianTools.Dates.PersianDate(ni.StartDate.Year, ni.StartDate.Month, ni.StartDate.Day, PersianTools.Dates.CalendarsMode.Gregorian);
                    //DateTime startDate = DateTime.Parse(P.FormatedDate("yyyy/MM/dd"));

                    //fdpStartDate.Text = startDate.ToString();
                    fdpStartDate.SelectedDateTime = ni.StartDate; // startDate;//.ToString();

                    curModelID = ni.ID;

                    //FillCategory();
                    return;
                }
            }

            dgvList1.Columns.Clear();
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtList1 != null)
                NumberScale();
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
            Save(curModelID, true);
        }

        //private void FillCategory()
        //{
        //    try
        //    {
        //        if (cmbCBM.SelectedIndex == -1 || !(cmbCBM.SelectedValue is int) || curModelID == -1)
        //            return;

        //        Helper h = new Helper();
        //        h.FormatDataGridView(dgvCategory);
        //        dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //        dgvCategory.SelectionMode = DataGridViewSelectionMode.CellSelect;
        //        dgvCategory.ReadOnly = false;

        //        int tbModelID = CurrentTBModelID;

        //        dgvCategory.Columns.Clear();
        //        dgvCategory.Rows.Clear();

        //        DataGridViewColumn col = new DataGridViewColumn();
        //        col.HeaderText = "";
        //        col.Name = "Column1";
        //        col.CellTemplate = new DataGridViewTextBoxCell();
        //        dgvCategory.Columns.Add(col);
        //        dgvCategory.Rows.Add(new string[] { "Category" });

        //        DataTable dtCategory = nim.GetCategory(curModelID);

        //        TBM tbm = new TBM();
        //        foreach (DataRow dr in tbm.GetTBMelements(tbModelID).Rows)
        //        {
        //            TBMElementInfo tei = new TBMElementInfo();
        //            tbm.CloneX(dr, tei, ECloneXdir.DR2Info);
        //            if (tei.BucketType != "Irr")
        //            {
        //                col = new DataGridViewColumn();
        //                col.Tag = tei;
        //                col.HeaderText = tei.BucketName;
        //                col.Name = tei.BucketName;
        //                col.ReadOnly = false;
        //                col.DefaultCellStyle.Format = "###,###.##";
        //                col.CellTemplate = new DataGridViewTextBoxCell();
        //                dgvCategory.Columns.Add(col);

        //                foreach (DataRow drCV in dtCategory.Rows)
        //                {
        //                    if ((int)drCV["TBMElementID"] == tei.ID)
        //                    {
        //                        dgvCategory.Rows[0].Cells[col.Index].Value = (decimal)drCV["CategoryValue"];
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}
        private void FillModel()
        {
            DataTable dt = nim.GetNIMMs();
            foreach (DataRow dr in dt.Rows)
            {
                NIMMInfo ni = new NIMMInfo();
                nim.CloneX(dr, ni, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ni.ModelName;
                lvi.Tag = ni;

                lsvModel.Items.Add(lvi);
            }
        }

        private void CommandModelNew()
        {
            string descr = Presentation.Public.Routines.ShowInputBox();
            if (descr != string.Empty)
            {
                ListViewItem lvi = new ListViewItem();
                NIMMInfo ni = new NIMMInfo();
                lvi.Text = descr;
                lvi.Tag = ni;
                lsvModel.Items.Add(lvi);
                lvi.Selected = true;

                //                
                ni.ModelName = descr;
                ni.ID = nim.InsertNIMM(ni);
                curModelID = ni.ID;
            }
        }

        private void CommandModelEdit()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];

                string descr = Presentation.Public.Routines.ShowInputBox(lvi.Text);
                if (descr != string.Empty)
                {
                    lvi.Text = descr;

                    //
                    NIMMInfo ni = (NIMMInfo) lvi.Tag;
                    ni.ModelName = descr;
                    nim.UpdateNIMM(ni);
                }
            }
        }

        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (
                    Presentation.Public.Routines.ShowMessageBoxFa("مدل انتخاب شده حذف خواهد شد. آيا مطمئن هستيد؟",
                                                                  "تاييد", MessageBoxButtons.OKCancel,
                                                                  MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    //NIIMInfo ni = (NIIMInfo)lvi.Tag;
                    NIMMInfo ni = (NIMMInfo) lvi.Tag;
                    lvi.Remove();
                    nim.DeleteNIMM(ni.ID);
                }
            }
        }

        private void CommandModelSave()
        {
        }

        private void Save(int modelID, bool bMessage)
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                int niiModelID = (cmbNII.SelectedIndex == -1) ? -1 : (int) cmbNII.SelectedValue;
                int tbModelID = (cmbCBM.SelectedIndex == -1) ? -1 : (int) cmbCBM.SelectedValue;
                int defCurrrency = (cmbDefCurrency.SelectedIndex == -1) ? -1 : (int) cmbDefCurrency.SelectedValue;

                // add for farsi
                //PersianTools.Dates.PersianDate P;
                //P = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime startDate = DateTime.Parse(P.ToGregorian.ToString("yyyy/MM/dd"));


                NIMMInfo ni = (NIMMInfo) lsvModel.SelectedItems[0].Tag;
                ni.ID = modelID;
                ni.NIIModelID = niiModelID;
                ni.CBModelID = tbModelID;
                ni.DefaultCurrency = defCurrrency;
                ni.StartDate = fdpStartDate.SelectedDateTime; //startDate;

                nim.UpdateNIMM(ni);
                //SaveCategory(modelID);

                if (bMessage)
                    Presentation.Public.Routines.ShowMessageBoxFa("مدل شما ذخيره شد", "ذخيره", MessageBoxButtons.OK,
                                                                  MessageBoxIcon.Information);
            }
        }

        //private void SaveCategory(int nimModelID)
        //{
        //    nim.DeleteCategory(nimModelID);

        //    foreach (DataGridViewColumn col in dgvCategory.Columns)
        //    {
        //        try
        //        {

        //            decimal val = Convert.ToDecimal(dgvCategory[col.Name, 0].Value);
        //            nim.InsertCategory(nimModelID, ((TBMElementInfo)col.Tag).ID, val);
        //        }
        //        catch
        //        {
        //          //Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        }
        //    }
        //}

        private void Reload()
        {
            try
            {
                ProgressBox.Show();

                if (cmbCBM.SelectedIndex == -1)
                    return;

                int nimModelID = (int) curModelID;
                int cbModelID = (int) cmbCBM.SelectedValue;
                int niiModelID = (int) cmbNII.SelectedValue;
                int currencyID = (int) cmbCurrency.SelectedValue;
                int defCurrencyID = (int) cmbDefCurrency.SelectedValue;

                //PersianTools.Dates.PersianDate p1;
                //p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
                //DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));


                int unitIndex = cmbUnit.SelectedIndex;
                Reload(nimModelID, niiModelID, cbModelID, currencyID, defCurrencyID, unitIndex, rdbHistoric.Checked,
                       fdpStartDate.SelectedDateTime /*startDate*/, -1);
            }
            catch (Exception ex)
            {
                ProgressBox.Hide();
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "خطا", MessageBoxButtons.OK,
                                                              MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }

        }

        public void Reload(int nimModelID, int niiModelID, int cbModelID, int currencyID, int defCurrencyID,
                           int unitIndex, bool Historic, DateTime startDate, int direct_tbModelID)
        {

            try
            {
                int tbModelID = -1;
                if (direct_tbModelID == -1)
                    tbModelID = CurrentTBModelID;
                else
                    tbModelID = direct_tbModelID;

                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                //SaveCategory(niiModelID);
                GetFilter();
                if (limitID != -1 && limitDetails.Length == 0)
                {
                    Presentation.Public.Routines.ShowMessageBoxFa("خطا در تعریف فیلتر درآمد بهره خالص ", "هشدار",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                nim.CreateNIMElements(nimModelID, niiModelID, cbModelID, Historic, startDate, limitID, limitDetails);
                nim.CreateNIMTotals(nimModelID, niiModelID, cbModelID, defCurrencyID, -1);

                dgvList1.Columns.Clear();
                dtList1 = nim.GetNIMTotals(nimModelID, tbModelID, currencyID, 1);
                DataTable dtTB = new DAL.SwartDataSetTableAdapters.GetDT_TBMElementsTableAdapter().GetData(tbModelID);
                cbTB.DataSource = dtTB;
                cbTB.DisplayMember = "Time Bucket";
                cbTB.ValueMember = "ID";


                var dtRes = dtList1.Rows.Cast<DataRow>().Where(
                    item =>
                    new[] {"14", "17", "24", "27", "31", "32", "33"}.Contains(item["Total_Param_Id"].ToString()) ==
                    false).CopyToDataTable();
                cbType.DataSource = dtRes;
                cbType.DisplayMember = "Current Status";
                cbType.ValueMember = "Total_Param_Id";
                //if (cbType.Items.Contains((14)))
                //    cbType.Items.Remove(14);
                //if (cbType.Items.Contains((17)))
                //    cbType.Items.Remove(17);
                //if (cbType.Items.Contains((24)))
                //    cbType.Items.Remove(24);
                //if (cbType.Items.Contains((27)))
                //    cbType.Items.Remove(27);
                //if (cbType.Items.Contains((31)))
                //    cbType.Items.Remove(31);
                //if (cbType.Items.Contains((32)))
                //    cbType.Items.Remove(32);
                //if (cbType.Items.Contains((33)))
                //    cbType.Items.Remove(33);
                dgvList1.DataSource = dtList1;
                //if(dtList1.ToString() == "")
                //{
                dgvList1.DataSource = dtList1;
                dgvList1.Columns["Total_Param_Id"].Visible = false;
                dgvList1.Columns["AL"].Visible = false;
                var dtchart = dtList1.Copy();
                dtchart.Columns.Remove("Total_Param_Id");
                dtchart.Columns.Remove("AL");
                dtchart.Columns.Remove("Total");
                RefreshChart(dtchart);
                //}
                //else
                //{
                //    dgvList1[dgvList1.Columns.Count - 1, 6].Value = (decimal.Parse(dgvList1[dgvList1.Columns.Count - 1, 2].Value.ToString()) - decimal.Parse(dgvList1[dgvList1.Columns.Count - 1, 5].Value.ToString())) / decimal.Parse(dgvList1[dgvList1.Columns.Count - 1, 1].Value.ToString());
                //    RefreshChart(nimModelID, tbModelID, currencyID, ddChart1, 1, dtList1);
                //}
                // FormatGrid(tbModelID);
                dtList1.AcceptChanges();

                if (unitIndex != 0)
                    NumberScale();
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
            catch(Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "هشدار",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void RefreshChart(DataTable dtChart)
        {
            try
            {

                DataTable dt2 = new DataTable();
                var ss = dtChart.AsEnumerable().Select(s => new DataColumn(s[0].ToString().Trim())).ToArray();
                dt2.Columns.AddRange(ss);
                dt2.Columns.Add("X");
                for (int i = 0; i < dtChart.Columns.Count - 1; i++)
                {
                    dt2.Rows.Add(dtChart.AsEnumerable().Select(s => s[i + 1].ToString()).ToArray());
                    dt2.Rows[i]["X"] = dtChart.Columns[i + 1].ColumnName;
                }
                ucChart1.X = "X";
                ucChart1.DataSource = dt2;
                //ucChart1.SetSelectedItem("1 as ");
                return;

                //DataTable dt = nim.GetNIMSummery(nimModelID, tbModelID, currencyID, mode);
                //ddChart.DataSource = dt;
                //ddChart.DataBind();
            }

            catch
            {
                Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "هشدار",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FormatGrid(int tbModelID)
        {
            try
            {
                List<DataGridView> lsGrids = new List<DataGridView>();
                lsGrids.Add(dgvList1);

                Helper h = new Helper();
                h.FormatDataGridView(dgvList1);
                dgvList1.AutoSizeColumnsMode = Chk_AutoSize.Checked
                                                   ? DataGridViewAutoSizeColumnsMode.Fill
                                                   : DataGridViewAutoSizeColumnsMode.AllCells;

                dgvList1.CellBorderStyle = DataGridViewCellBorderStyle.Single;



                dgvList1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvList1.Columns[0].Width = 220;
                dgvList1.Columns[0].Frozen = true;

                TBM tbm = new TBM();
                DataTable dtTBElements = tbm.GetTBMelements(tbModelID);
                foreach (DataRow dr in dtTBElements.Rows) //Time Bucket Columns
                {
                    TBMElementInfo tei = new TBMElementInfo();
                    tbm.CloneX(dr, tei, ECloneXdir.DR2Info);

                    DataGridViewColumn col;

                    foreach (DataGridView dgv in lsGrids)
                    {
                        col = dgv.Columns[tei.BucketName];
                        if (col != null)
                        {
                            col.HeaderText = tei.BucketName;
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            col.DefaultCellStyle.Format = "###,##0.####";
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                            col.HeaderCell.Style.BackColor = Color.FromArgb(tei.BucketColor);
                        }
                    }
                }

                dgvList1.Columns[dgvList1.Columns.Count - 1].DefaultCellStyle.Format = "###,##0.#####";

                dgvList1.Columns[dgvList1.Columns.Count - 1].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
            catch
            {
                Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "هشدار",
                                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NumberScale()
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            int scale = 1;
            switch (cmbUnit.SelectedIndex)
            {
                case 0:
                    scale = 1;
                    break;
                case 1:
                    scale = 1000;
                    break;
                case 2:
                    scale = 1000000;
                    break;
            }

            List<DataGridView> lsGrids = new List<DataGridView>();
            lsGrids.Add(dgvList1);

            foreach (DataGridView dgv in lsGrids)
            {
                DataTable dt = (DataTable) dgv.DataSource;
                dt.RejectChanges();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewColumn col in dgv.Columns)
                        if (col.Index != 0 && col.Visible)
                            try
                            {
                                row.Cells[col.Name].Value = (decimal) row.Cells[col.Name].Value/scale;
                            }
                            catch
                            {
                                Presentation.Public.Routines.ShowMessageBoxFa("برنامه با خطا روبرو شده است.", "هشدار",
                                                                              MessageBoxButtons.OK,
                                                                              MessageBoxIcon.Information);
                            }
                }
            }

            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }


        public void SetFullMode()
        {
            scAll.Panel1Collapsed = true;
            //sc4All.Panel1Collapsed = true;
            TagFullMode = true;
        }

        private void Chk_AutoSize_CheckedChanged(object sender, EventArgs e)
        {
            dgvList1.AutoSizeColumnsMode = !Chk_AutoSize.Checked
                                               ? DataGridViewAutoSizeColumnsMode.Fill
                                               : DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void chkDgvList1_CheckedChanged(object sender, EventArgs e)
        {
            GeneralDataGridView = dgvList1;
        }

        private void frmNIM_KeyDown(object sender, KeyEventArgs e)
        {
            //New
            if (e.Control && e.KeyCode.ToString() == "N")
            {
                CommandModelNew();
            }

            //Edit
            if (e.Control && e.KeyCode.ToString() == "E")
            {
                CommandModelEdit();
            }
            //save
            if (e.Control && e.KeyCode.ToString() == "S")
            {
                Save(curModelID, true);
            }
            //Remove
            if (e.Control && e.KeyCode.ToString() == "D")
            {
                CommandModelRemove();
            }
            //Refresh
            if (e.KeyCode == Keys.F5)
            {
                Reload();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RebindNII();
            RebindTBM();
        }

        private void RebindTBM()
        {
            CBM cbm = new CBM();
            cmbCBM.DataSource = cbm.GetCBMs();
            cmbCBM.DisplayMember = TBM.CTE_Alias_ModelName;
            cmbCBM.ValueMember = TBM.CTE_Alias_ID;
            cmbCBM.SelectedIndex = -1;
        }

        private void RebindNII()
        {
            NII nii = new NII();
            cmbNII.DataSource = nii.GetNIIMs();
            cmbNII.DisplayMember = NII.CTE_Alias_Model_ModelName;
            cmbNII.ValueMember = NII.CTE_Alias_Model_ID;
            cmbNII.SelectedIndex = -1;
        }

        //private void Print(DataGridView dgv)
        //{
        //    Printer P = new Printer();
        //    if (chkDgvList1.Checked == false )
        //    { Presentation.Public.Routines.ShowMessageBoxFa("لطفا يك ليست برای چاپ انتخاب كنيد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        //    else
        //    {
        //        if (P.SetupThePrinting(dgv))
        //            P.PrintDocument();
        //    }
        //}

        //private void tsmiPrint_Click(object sender, EventArgs e)
        //{

        //    if (TagFullMode)
        //    { Print(clsERMSGeneral.dgvActive); }
        //}
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "NIM";
        }



        private void cbCollapseUp_CButtonClicked(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
            {
                splitContainer1.Panel1Collapsed = true;
                cbCollapseUp.DefaultImage = Properties.Resources.S_PanDown1;
                cbCollapseUp.HoverImage = Properties.Resources.S_PanDown_Hover1;
            }
            else if (splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel1Collapsed = false;
                cbCollapseUp.DefaultImage = Properties.Resources.S_PanUp1;
                cbCollapseUp.HoverImage = Properties.Resources.S_PanUp_Hover1;
            }
        }




        public bool saveExcel(DataSet ds)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel XML Files | *.xml";
            if (!(sfd.ShowDialog() == DialogResult.OK))
                return false;

            ProgressBox.Show();

            //const string TABLE_TITLE_FORMAT_NAME = "Title";
            const string TABLE_HEADER_FORMAT_NAME = "greyBackground";
            const string CELL_FONT_FORMAT = "cellFont";
            try
            {
                string fontName = "B Nazanin";
                Utilize.ExcelGeneratingClass.XmlExcelHelper helper =
                    new Utilize.ExcelGeneratingClass.XmlExcelHelper(sfd.FileName, fontName, 12);

                helper.AddStringStyle(TABLE_HEADER_FORMAT_NAME, fontName, 12, "#FFFFFF", "#C0C0C0", true);
                helper.AddStringStyle(CELL_FONT_FORMAT, fontName, 11, "#000000", false);
                for (int ii = 0; ii < ds.Tables.Count; ii++)
                {
                    helper.CreateSheet("جرئیات قرارداد " + (ii + 1).ToString());
                    helper.AddRow();
                    foreach (DataColumn column in ds.Tables[ii].Columns)
                    {
                        helper.AddCell(Utilize.ExcelGeneratingClass.XmlExcelHelper.CellType.String,
                                       TABLE_HEADER_FORMAT_NAME, column.ColumnName);
                    }

                    foreach (DataRow row in ds.Tables[ii].Rows)
                    {

                        helper.AddRow();
                        for (int i = 0; i < ds.Tables[ii].Columns.Count; i++)
                        {
                            float ff;
                            if (float.TryParse(row[i].ToString(), out ff))
                                helper.AddCell(Utilize.ExcelGeneratingClass.XmlExcelHelper.CellType.Number,
                                               CELL_FONT_FORMAT, row[i].ToString());
                            else
                                helper.AddCell(Utilize.ExcelGeneratingClass.XmlExcelHelper.CellType.String,
                                               CELL_FONT_FORMAT, row[i].ToString());

                        }
                        //helper.AddCell(XmlExcelHelper.CellType.Number, XmlExcelHelper.DefaultStyles.StringLiteral, row[0].ToString());
                        //helper.AddCell(XmlExcelHelper.CellType.String, CELL_FONT_FORMAT, row[1].ToString());
                        //helper.AddCell(XmlExcelHelper.CellType.String, CELL_FONT_FORMAT, row[2].ToString());
                        //helper.AddCell(XmlExcelHelper.CellType.String, CELL_FONT_FORMAT, row[3].ToString());
                        //helper.AddCell(XmlExcelHelper.CellType.Number, XmlExcelHelper.DefaultStyles.StringLiteral, row[4].ToString());
                        //helper.AddCell(XmlExcelHelper.CellType.String, CELL_FONT_FORMAT, row[5].ToString());
                        //helper.AddCell(XmlExcelHelper.CellType.String, CELL_FONT_FORMAT, row[6].ToString());
                        //helper.AddCell(XmlExcelHelper.CellType.String, CELL_FONT_FORMAT, row[7].ToString());
                    }

                    //    return helper.ExcelFileXml;
                }
                helper.SaveDocument();
                ProgressBox.Hide();
                return true;
            }
            catch (Exception ee)
            {
                ProgressBox.Hide();
                return false;
            }

        }



        private void cbExcel_CButtonClicked(object sender, EventArgs e)
        {
            if (currentTBtag == -1)
                return;
            if (currentParamIDtag == -1)
                return;
            DataSet ds = new DAL.NIM_DataSet().GetNIMDetails((int) curModelID, currentParamIDtag, currentTBtag,
                                                             currentALtag, rdbHistoric.Checked);
            if (saveExcel(ds))
                Routines.ShowInfoMessageFa("خروجی اکسل", "پایان عملیات خروجی اکسل", MyDialogButton.OK);

        }

        public int currentTBtag
        {
            get
            {
                if (cbTB.SelectedValue != null)
                    return (int) cbTB.SelectedValue;
                else
                    return -1;
            }
        }

        public int currentParamIDtag
        {
            get
            {
                if (cbType.SelectedValue != null)
                    return (int) cbType.SelectedValue;
                else
                    return -1;
            }
        }

        public int currentALtag
        {
            get
            {
                if (cbType.SelectedValue != null)
                {
                    foreach (DataGridViewRow dr in dgvList1.Rows)
                        if ((int) dr.Cells["Total_Param_Id"].Value == (int) cbType.SelectedValue)
                            return (int) dr.Cells["AL"].Value;
                }
                return -1;
            }
        }

        private void cButton1_CButtonClicked(object sender, EventArgs e)
        {
            try
            {
                ProgressBox.Show();
                if (currentTBtag == -1)
                    return;
                if (currentParamIDtag == -1)
                    return;
                Helper h = new Helper();
                h.FormatDataGridView(dgvDetails);
                h.FormatDataGridView(dgvDetails2);
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DAL.NIM_DataSet().GetNIMDetails((int) curModelID, currentParamIDtag, currentTBtag,
                                                                 currentALtag, rdbHistoric.Checked);
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                if (ds.Tables.Count == 2)
                {
                    dgvDetails2.DataSource = ds.Tables[0];
                    dgvDetails.DataSource = ds.Tables[1];
                }
            }
            catch
            {
            }
            finally
            {
                ProgressBox.Hide();
            }

        }

        private void FillDest(string TableName)
        {
            string str = "TableNameEnglish like '" + TableName + "' ";
            DataRow[] dr = dtTableXml.Select(str);
            branch =
                new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(
                    ERMS.Model.GlobalInfo.UserID);

            string strField = dr[0]["Field"].ToString();
            string strId = dr[0]["Id"].ToString();
            string strTable_Name = TableName + "." + strId;

            var lm = new LM();
            string filterexpression = string.Empty;
            DataTable dtDest = lm.GetTable(strId, strField, TableName, filterexpression);

            if (branch.Rows.Count != 0)
            {
                if (strId.Equals("State_Id"))
                {
                    var dt = dtDest.Rows.Cast<DataRow>().Where(
                        org =>
                        branch.Rows.Cast<DataRow>().Any(
                            sta => sta["State_Id"].ToString().Equals(org["State_Id"].ToString())));

                    cmbLimitValue.DataSource =
                        dt.Select(
                            item =>
                            new { State_Id = item["State_Id"].ToString(), State_Name = item["State_Name"].ToString() }).
                            ToList();
                }
                if (strId.Equals("Branch"))
                {
                    var dt = dtDest.Rows.Cast<DataRow>().Where(
                        org =>
                        branch.Rows.Cast<DataRow>().Any(
                            sta => sta["Branch"].ToString().Equals(org["Branch"].ToString())));

                    cmbLimitValue.DataSource =
                        dt.Select(
                            item =>
                            new
                            {
                                Branch = item["Branch"].ToString(),
                                Branch_Description = item["Branch_Description"].ToString()
                            }).ToList();
                }

            }
            else
                cmbLimitValue.DataSource = dtDest;

            cmbLimitValue.DisplayMember = strField;
            cmbLimitValue.ValueMember = strId;
            cmbLimitValue.SelectedIndex = -1;
        }

        private void chbOutput_dgvVaR_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOutput_dgvVaR.Checked)
            {
                chbOutput_dgvDetails.Checked = false;
                chbOutput_dgvDetails2.Checked = false;
                GeneralDataGridView = dgvList1;                
            }
        }

        private void chkDescreteGapAnalisys_CheckedChanged(object sender, EventArgs e)
        {
            cmbLimitValue.Enabled = chkDescreteGapAnalisys.Checked;
            if (!chkDescreteGapAnalisys.Checked)
            {
                ucfOrganization.Enabled = chkDescreteGapAnalisys.Checked;
                ucfCity.Enabled = chkDescreteGapAnalisys.Checked;
            }
        }

        private void cmbLimitValue_SelectionChanged(object sender, EventArgs e)
        {
            ucfOrganization.DataSource = null;
            ucfOrganization.ResetText();
            ucfCity.DataSource = null;
            ucfCity.ResetText();
            if (cmbLimitValue.SelectedIndex != -1)
            {
                ucfCity.Enabled = true;
                ucfCity.Enabled = true;
                ucfOrganization.ResetText();
                ucfOrganization.DataSource = null;
                ucfOrganization.Enabled = false;
            }
            else if (cmbLimitValue.SelectedIndex == -1)
            {
                ucfCity.Enabled = false;
                ucfOrganization.ResetText();
                ucfOrganization.DataSource = null;
                ucfOrganization.Enabled = false;
            }
        }

        private void ucfOrganization_DropDownOpening(object sender, EventArgs e)
        {
            #region Add By Aliz
            try
            {
                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";

                //بررسی اینکه فیلتر شهر انتخاب شده باشد و
                // شهرهای انتخاب شده بیشتر از یک باشد
                if (ucfCity.IsChecked() && ucfCity.GetSelectedItem().Count() > 0)
                {
                    //بررسی اینکه فیلتر مکان برای این کاربر تنظیم شده است
                    if (user.Rows.Count == 0)
                    {
                        var branchs = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(item => ucfCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(item.City_Of_Branch.ToString()))).ToArray();
                        ucfOrganization.DataSource = branchs;
                    }
                    else
                    {
                        var branchs = user.Rows.Cast<DataRow>().Where(
                             org => ucfCity.GetSelectedItem().Any(city => city.DataValue.ToString().Equals(org["City_Id"].ToString())))
                        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                        ucfOrganization.DataSource = branchs;
                    }

                    return;
                }

                //بررسی اینکه فیلتر استان انتخاب شده باشد و
                // استان های انتخاب شده بیشتر از یک باشد
                if (cmbLimitValue.SelectedIndex != -1)
                {
                    if (user.Rows.Count == 0)
                    {
                        var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                           org => cmbLimitValue.CheckedItems.Any(sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();

                        ucfOrganization.DataSource = organizations;
                    }
                    else
                    {
                        var organizations = user.Rows.Cast<DataRow>().Where(
                             org =>
                               cmbLimitValue.CheckedItems.Any(sta => sta.DataValue.ToString().Equals(org["State_Id"].ToString())))
                        .Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();

                        ucfOrganization.DataSource = organizations;
                    }

                    return;
                }

                // در صورتی که نه فیلتر استان یا شهر انتخاب نشده باشد
                if (user.Rows.Count == 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfOrganization.DataSource = organizations;
                }
                else
                {
                    var organizationNew_DataTable = user.Rows.Cast<DataRow>().Select(item => new { Brach_Id = item["Branch"].ToString(), Branch_Description = item["Branch_Description"].ToString() }).Distinct().ToArray();
                    ucfOrganization.DataSource = organizationNew_DataTable;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
            #endregion
        }

        private void ReadXml()
        {
            string s = Assembly.GetExecutingAssembly().Location;
            s = s.Substring(0, s.LastIndexOf("\\")) + "\\" + "GapTableProperty.xml";
            DataSet dset = new DataSet();
            FileStream fstr = new FileStream(s, FileMode.Open, FileAccess.Read);
            dset.ReadXml(fstr);
            dtTableXml = dset.Tables[0];
        }

        private void GetFilter()
        {
            limitDetails = "";
            limitID = -1;
            //تفکیک استان
            if (cmbLimitValue.SelectedIndex != -1)
            {
                limitDetails = cmbLimitValue.SelectedValue.ToString().Trim();
                limitID = 1;
            }

            // تفکیک استان و شهر
            if (cmbLimitValue.SelectedIndex != -1 && ucfCity.IsChecked() == true && ucfCity.GetSelectedItem().Count() > 0)
            {
                limitDetails = GetFilterCity();
                limitID = 2;
            }

            // تفکیک استان و شعب
            if (cmbLimitValue.SelectedIndex != -1 && ucfOrganization.IsChecked() == true
                    && ucfOrganization.GetSelectedItem().Count() > 0)
            {
                limitDetails = GetFilterBranchG();
                limitID = 3;
            }
        }

        private string GetFilterBranchG()
        {
            var fil_Organization = ucfOrganization.GetFilterStructureForSqlBranchG();

            bool isColl_Filter = false;
            var filter = "";
            if (fil_Organization.Trim().Length != 0)
            {
                if (filter.Trim().Length != 0) filter += " and ";
                filter += fil_Organization;
            }
            else if (user.Rows.Count != 0)
            {
                string fil = "";
                var organizationNew_DataTable =
                    user.Rows.Cast<DataRow>().Select(
                        item =>
                        new
                        {
                            Brach_Id = item["Branch"].ToString(),
                            Branch_Description = item["Branch_Description"].ToString()
                        }).Distinct().ToArray();
                foreach (var item in organizationNew_DataTable)
                {


                    fil += fil.Trim().Length == 0
                               ? "Branch = " + "'" + item.Brach_Id.Trim() + "' "
                               : " OR Branch = '" + item.Brach_Id.Trim() + "' ";

                }
                if (fil.Trim().IsNullOrEmptyByTrim() == false)
                    fil += "";

                if (filter.Trim().Length != 0) filter += " and ";
                filter += fil;

            }



            return filter;

        }

        private void chbOutput_dgvDetails_CheckedChanged(object sender, EventArgs e)
        {

            if (chbOutput_dgvDetails.Checked)
            {
                chbOutput_dgvVaR.Checked = false;
                chbOutput_dgvDetails2.Checked = false;
                GeneralDataGridView = dgvDetails;
            }
            
        }

        private void chbOutput_dgvDetails2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOutput_dgvDetails2.Checked)
            {
                chbOutput_dgvDetails.Checked = false;
                chbOutput_dgvVaR.Checked = false;
                GeneralDataGridView = dgvDetails2;
            }
        }

        private string GetFilterCity()
        {
            var fil_City = ucfCity.GetFilterStructureForSqlBranchG();

            bool isColl_Filter = false;
            var filter = "";
            if (fil_City.Trim().Length != 0)
            {
                if (filter.Trim().Length != 0) filter += " and ";
                filter += fil_City;
            }
            else if (user.Rows.Count != 0)
            {
                string fil = "";
                var organizationNew_DataTable =
                    user.Rows.Cast<DataRow>().Select(
                        item =>
                        new
                        {
                            Brach_Id = item["City_ID"].ToString(),
                            Branch_Description = item["City_Name"].ToString()
                        }).Distinct().ToArray();
                foreach (var item in organizationNew_DataTable)
                {


                    fil += fil.Trim().Length == 0
                               ? "City_Id = " + "'" + item.Brach_Id.Trim() + "' "
                               : " OR City_Id = '" + item.Brach_Id.Trim() + "' ";

                }
                if (fil.Trim().IsNullOrEmptyByTrim() == false)
                    fil += "";

                if (filter.Trim().Length != 0) filter += " and ";
                filter += fil;
            }
            return filter;
        }
    }
}