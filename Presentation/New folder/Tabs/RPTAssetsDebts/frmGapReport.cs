using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using ERMSLib;

//        this.BackColor = System.Drawing.Color.Transparent;
using Dundas.Charting.WinControl;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;


namespace Presentation.Tabs.RPTAssetsDebts
{
    /// <summary>
    /// masi 
    /// 1388.03.19
    /// </summary>
    public partial class frmGapReport : BaseForm, IPrintable
    {
        #region VARS

        private GAP gap;
        private TBM tbm;

        decimal gapModelID;

        DataRow summaryDRow1, summaryDRow2, drGAPD;
        private decimal curModelID = -1;
        DataTable dtTBElements, dtGAP;
        private TBOption tbOption;
        DataColumn totalDColumn;
        private List<DataGridViewColumn> irrCols = new List<DataGridViewColumn>();

        #endregion

        #region CONST

        private const int CTE_NumSumNodes = 2;
        #endregion

        public frmGapReport()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            
        }

        //Show Reports
        private void frmGapReport_Load(object sender, EventArgs e)
        {
            Init();
            GeneralDataGridView = dgvGAP;
        }
        private void Init()
        {

            gap = new GAP();
            tbm = new TBM();

            tbOption = new TBOption();
            tbOption.MaxBoxWidth = 325;

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;

            //GAP Grid
            dgvGAP.ReadOnly = true;
            dgvGAP.AllowUserToAddRows = false;
            dgvGAP.AllowUserToDeleteRows = false;
            dgvGAP.AllowUserToResizeRows = false;
            dgvGAP.AllowUserToResizeColumns = true;
            dgvGAP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgvGAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvGAP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dgvGAP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgvGAP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvGAP.RowHeadersVisible = false;
            dgvGAP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            System.Windows.Forms.DataGridViewCellStyle style = new System.Windows.Forms.DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgvGAP.RowsDefaultCellStyle = style;
            dgvGAP.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvGAP.EnableHeadersVisualStyles = false;

            FillModel();
        }
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshlsvModel();
        }
        private void RefreshlsvModel()
        {
            //  FillGap();
        }
        private void FillModel()
        {
            lsvModel.Items.Clear();
            DataTable dt = gap.GetGAPReport();
            foreach (DataRow dr in dt.Rows)
            {
                GAPReportInfo gi = new GAPReportInfo();
                gap.CloneXGapReport(dr, gi, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = gi.ModelName;
                lvi.Tag = gi;

                lsvModel.Items.Add(lvi);
            }
        }
        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersianTools.Dates.PersianDate P;
            if (lsvModel.SelectedItems.Count > 0)
            {
                GAPReportInfo gi = (GAPReportInfo)lsvModel.SelectedItems[0].Tag;
                curModelID = gi.ID;

                P = new PersianTools.Dates.PersianDate((DateTime)gi.StartDate);
                lblgapDate.Text = P.FormatedDate("yyyy/MM/dd").ToString();

                ReLoad();
                return;
            }
        }

        // show detail grid gap        
        private void ReLoad()
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            FillGap();
            RefreshChart();
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        private void FillGap()
        {
            try
            {
                ProgressBox.Show();

                dgvGAP.Columns.Clear();


                gapModelID = ((GAPReportInfo)lsvModel.SelectedItems[0].Tag).ID;

                DataSet ds = new DataSet();
                int tbModelID = ((GAPReportInfo)lsvModel.SelectedItems[0].Tag).TBModelID;
                dtTBElements = tbm.GetTBMelements(tbModelID);
                //  dtGAP = gap.GetGAPElementReport(gapModelID);
                ds = gap.GetGAPElementReport(gapModelID);
                dtGAP = ds.Tables[0];
                dtGAP.DefaultView.RowFilter = "(Hidden = 0)";

                summaryDRow1 = dtGAP.NewRow();
                dtGAP.Rows.Add(summaryDRow1);

                summaryDRow2 = dtGAP.NewRow();
                dtGAP.Rows.Add(summaryDRow2);

                PrepareSummary();

                dgvGAP.DataSource = dtGAP;
                //dgvGAP.DataSource = ds;
                FormatGrid(dtTBElements, true); ;

                dtGAP.AcceptChanges();

                //if (cmbUnit.SelectedIndex != 0)
                //  NumberScale(cmbUnit.SelectedIndex);
                
            }
            catch (Exception ex)
            {
                Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }

        }
        private void RefreshChart()
        {
            int gapmodelID = (int)((GAPReportInfo)lsvModel.SelectedItems[0].Tag).ID;
            ddChart.Series.Clear();
            ddChart.Series.Add("Series1");
            ddChart.Series.Add("Series2");
            ddChart.Series.Add("Series3");

            ddChart.Series["Series1"].Type = SeriesChartType.StackedColumn;
            ddChart.Series["Series2"].Type = SeriesChartType.StackedColumn;
            ddChart.Series["Series3"].Type = SeriesChartType.StackedColumn;

            ddChart.Series["Series1"].ValueMemberX = "X";
            ddChart.Series["Series1"].ValueMembersY = "Y1";
            ddChart.Series["Series1"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series1"].YValuesPerPoint = 1;
            ddChart.Series["Series1"].ShowInLegend = false;
            ddChart.Series["Series1"].LegendText = "دارایی";

            ddChart.Series["Series2"].ValueMemberX = "X";
            ddChart.Series["Series2"].ValueMembersY = "Y2";
            ddChart.Series["Series2"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series2"].YValuesPerPoint = 1;
            ddChart.Series["Series2"].ShowInLegend = false;
            ddChart.Series["Series2"].LegendText = "شكاف";

            ddChart.Series["Series3"].ValueMemberX = "X";
            ddChart.Series["Series3"].ValueMembersY = "Y3";
            ddChart.Series["Series3"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series3"].YValuesPerPoint = 1;
            ddChart.Series["Series3"].ShowInLegend = false;
            ddChart.Series["Series3"].LegendText = "بدهی";

            ddChart.DataSource = gap.GetGAPSummary_Historic(gapmodelID, true);
            ddChart.DataBind();

            ddChart.Series["Series1"].XValueIndexed = true;
            ddChart.Series["Series2"].XValueIndexed = true;
            ddChart.Series["Series3"].XValueIndexed = true;

            ddChart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series2"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series3"]["DrawingStyle"] = "Cylinder";

            ddChart.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            ddChart.ChartAreas["Default"].Area3DStyle.Light = LightStyle.Realistic;
            ddChart.ChartAreas["Default"].Area3DStyle.Perspective = 30;
            ddChart.ChartAreas["Default"].Area3DStyle.XAngle = 10;
            ddChart.ChartAreas["Default"].Area3DStyle.YAngle = 5;
            ddChart.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            ddChart.ChartAreas["Default"].Area3DStyle.PointGapDepth = 0;
            ddChart.ChartAreas["Default"].Area3DStyle.RightAngleAxes = true;

            ddChart.ChartAreas["Default"].BackColor = Color.White;

            ddChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            ddChart.BackColor = Color.FromArgb(146, 180, 222);
            ddChart.BackGradientEndColor = Color.White;
            ddChart.BackGradientType = GradientType.TopBottom;
            ddChart.BorderStyle = ChartDashStyle.Solid;
            ddChart.BorderColor = Color.DarkBlue;
            ddChart.BorderWidth = 2;


            ddChart.ChartAreas["Default"].ShadowOffset = 5;
            ddChart.ChartAreas["Default"].ShadowColor = Color.Gray;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.ShowEndLabels = true;
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Font = this.Font;
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.ShowEndLabels = true;
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Font = this.Font;
            ddChart.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
            ddChart.ChartAreas["Default"].AxisY.MinorGrid.Enabled = true;
            ddChart.ChartAreas["Default"].AxisY.MinorGrid.LineColor = Color.LightGray;
            ddChart.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
            ddChart.ChartAreas["Default"].AxisY.MajorGrid.Enabled = true;
            ddChart.ChartAreas["Default"].AxisY.MajorGrid.LineColor = Color.Wheat;

            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Format = "###,###";
            ddChart.ChartAreas["Default"].AxisY.LabelStyle.Format = "###,###";

            ddChart.Series["Series1"].SmartLabels.Enabled = true;
            ddChart.Series["Series1"].Font = this.Font;
            ddChart.Series["Series1"].LabelFormat = "###,###";
            ddChart.Series["Series1"].ShowLabelAsValue = false;
            ddChart.Series["Series2"].SmartLabels.Enabled = true;
            ddChart.Series["Series2"].Font = this.Font;
            ddChart.Series["Series2"].LabelFormat = "###,###";
            ddChart.Series["Series2"].ShowLabelAsValue = false;
            ddChart.Series["Series3"].SmartLabels.Enabled = true;
            ddChart.Series["Series3"].Font = this.Font;
            ddChart.Series["Series3"].LabelFormat = "###,###";
            ddChart.Series["Series3"].ShowLabelAsValue = false;

            ddChart.Palette = ChartColorPalette.Dundas;

        }
        private void FormatGrid(DataTable dtTBElements, bool bAutoSize)
        {
            //    irrCols.Clear();

            int maxColumnWidth = GetColumnMaxWidthProportional(dtTBElements);
            foreach (DataRow dr in dtTBElements.Rows) //Time Bucket Columns
            {
                TBMElementInfo tei = new TBMElementInfo();
                tbm.CloneX(dr, tei, ECloneXdir.DR2Info);

                DataGridViewColumn col = dgvGAP.Columns["TB" + tei.ID];
                if (col != null)
                {
                    //if (tei.BucketType == "Irr")
                    //    irrCols.Add(col);

                    //if (tei.BucketType == "Irr" && !chkIrr.Checked)
                    //    col.Visible = false;

                    col.HeaderText = tei.BucketName;
                    col.Tag = tei;
                    if (!bAutoSize)
                        col.Width = GetColumnWidthProportional(tei, maxColumnWidth);
                    else
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.DefaultCellStyle.Format = "###,###.##";
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    if (true)
                        col.HeaderCell.Style.BackColor = Color.FromArgb(tei.BucketColor);
                }
            }

            foreach (DataGridViewColumn dgvc in dgvGAP.Columns)
            {
                if (dgvc.Tag is TBMElementInfo)
                {
                }
                else
                    if (dgvc.DataPropertyName == "FSME_GroupName")
                    {
                        dgvc.Frozen = true;
                        dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvc.MinimumWidth = 200;
                        dgvc.HeaderText = "";
                    }

                    else
                        if (dgvc.DataPropertyName == "Total")
                        {
                            dgvc.DefaultCellStyle.Format = "###,###.##";
                            dgvc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgvc.DefaultCellStyle.BackColor = Color.Ivory;
                            dgvc.DefaultCellStyle.ForeColor = Color.Green;
                            dgvc.MinimumWidth = 100;
                        }
                        else
                            dgvc.Visible = false;
            }

            dgvGAP.ColumnHeadersHeight = 40;
        }
        private int GetColumnMaxWidthProportional(DataTable dtTBM)
        {
            int maxWidth = 0;
            foreach (DataRow dr in dtTBM.Rows)
            {
                TBMElementInfo tei = new TBMElementInfo();
                tbm.CloneX(dr, tei, ECloneXdir.DR2Info);

                int len = tei.BucketLength;
                int w = tbOption.GetBucketWidth(tei.BucketType);

                maxWidth = (w * len > maxWidth) ? w * len : maxWidth;
            }

            return maxWidth;
        }
        private int GetColumnWidthProportional(TBMElementInfo tei, int maxWidthValue)
        {
            int len = tei.BucketLength;
            int w = tbOption.GetBucketWidth(tei.BucketType);
            return Convert.ToInt32(
                    (tbOption.MaxBoxWidth - tbOption.MinBoxWidth)
                                * (w * len * 1.0 - 1.0)
                                / (maxWidthValue - 1.01) + tbOption.MinBoxWidth);
        }
        private void @PrepareSummary()
        {
            totalDColumn = dtGAP.Columns["Total"];
            int numColumns = dtGAP.Columns.Count;

            for (int r = 0; r <= dtGAP.Rows.Count - 1; r++)
                dtGAP.Rows[r][totalDColumn] = 0;

            for (int iCol = 1; iCol < numColumns - 1; iCol++)
            {
                if (dtGAP.Columns[iCol].ColumnName.StartsWith("TB"))
                {
                    string columnName = dtGAP.Columns[iCol].ColumnName;
                    DataGridViewColumn dgvc = dgvGAP.Columns[columnName];
                    bool bIrr = false;
                    foreach (DataGridViewColumn col in irrCols)
                        if (col.DataPropertyName == columnName)
                            bIrr = true;

                    summaryDRow1[iCol] = 0;
                    summaryDRow2[iCol] = 0;
                    for (int iRow = 0; iRow <= dtGAP.Rows.Count - 1 - CTE_NumSumNodes; iRow++)
                    {
                        int AL = (int)dtGAP.Rows[iRow]["FSME_AL"];
                        if (AL != -1)
                        {
                            if (AL == (int)EAL.Asset)
                                summaryDRow1[iCol] = (decimal)summaryDRow1[iCol] + (+1) * (decimal)dtGAP.Rows[iRow][iCol];
                            if (AL == (int)EAL.Liability)
                                summaryDRow1[iCol] = (decimal)summaryDRow1[iCol] + (-1) * (decimal)dtGAP.Rows[iRow][iCol];
                        }

                        if (dtGAP.Rows[iRow].IsNull(totalDColumn))
                            dtGAP.Rows[iRow][totalDColumn] = 0;

                        if (bIrr || !bIrr)//&& chkIrr.Checked) || !bIrr)
                            dtGAP.Rows[iRow][totalDColumn] = (decimal)dtGAP.Rows[iRow][totalDColumn] + (decimal)dtGAP.Rows[iRow][iCol];
                    }

                    summaryDRow2[iCol] = (decimal)summaryDRow1[iCol] + ((iCol == 13) ? 0 : (decimal)summaryDRow2[iCol - 1]);
                }
            }

            summaryDRow1["Hidden"] = 0;
            summaryDRow2["Hidden"] = 0;

            summaryDRow1["FSME_GroupName"] = "GAP:";
            summaryDRow2["FSME_GroupName"] = "Sum GAP:";
        }

        //private void ToggleIrr()
        //{
        //    foreach (DataGridViewColumn col in irrCols)
        //    {
        //        if (chkIrr.Checked)
        //            col.Visible = true;
        //        else
        //            col.Visible = false;
        //    }
        //}

        private void Collapse(int dIndex, int balance)
        {
            for (int i = dIndex + 1; i <= dtGAP.Rows.Count - CTE_NumSumNodes - 1; i++)
            {
                DataRow dr = dtGAP.Rows[i];
                if ((int)dr["FSME_Balance"] <= balance)
                    break;

                dr["Hidden"] = true;
            }
        }
        private void Expand(int dIndex, int balance)
        {
            for (int i = dIndex + 1; i <= dtGAP.Rows.Count - CTE_NumSumNodes - 1; i++)
            {
                DataRow dr = dtGAP.Rows[i];
                if ((int)dr["FSME_Balance"] <= balance)
                    break;

                dr["Hidden"] = false;
            }
        }
        private void dgvGAP_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0 && e.RowIndex <= dgvGAP.Rows.Count - 1 - CTE_NumSumNodes)
            {
                DataGridViewRow dgvr = dgvGAP.Rows[e.RowIndex];

                int balance = (int)dgvr.Cells["FSME_Balance"].Value;
                int pointRight = 20 * balance;
                int pointLeft = 20 * (balance + 1);

                if (e.X > pointRight && e.X < pointLeft)
                {
                    int dIndex = dtGAP.Rows.IndexOf(((DataRowView)dgvGAP.Rows[e.RowIndex].DataBoundItem).Row);
                    if (dIndex < dtGAP.Rows.Count - 1 - CTE_NumSumNodes)
                    {
                        DataRow curDRow = dtGAP.Rows[dIndex];
                        DataRow nextDRow = dtGAP.Rows[dIndex + 1];

                        if ((bool)nextDRow["Hidden"] == false)
                        {
                            Collapse(dIndex, balance);
                        }
                        else
                        {
                            Expand(dIndex, balance);
                        }
                    }
                }
            }
        }
        private void dgvGAP_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Color color1 = Color.White;
			Color color2 = Color.White;

            if (e.RowIndex == -1 || e.ColumnIndex != 0 || e.RowIndex > dgvGAP.Rows.Count - 1 - CTE_NumSumNodes)
            {
                e.Handled = false;
                return;
            }

            DataGridViewRow row = dgvGAP.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells["FSME_Balance"];

            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
                e.PaintBackground(e.ClipBounds, true);
            else
            {

                if (Color.FromArgb((int)row.Cells["FSME_Color"].Value) != null)
                {
                    color2 = Color.FromArgb((int)row.Cells["FSME_Color"].Value);
                }
                using (Brush bg = new System.Drawing.Drawing2D.LinearGradientBrush(e.CellBounds, color1, color2, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(bg, e.CellBounds);
                }
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.Focus | DataGridViewPaintParts.Border);

            //////////////////////////////
            int balance = (int)cell.Value;
            int indent = balance * 20;

            string groupName = row.Cells["FSME_GroupName"].Value.ToString();
            string title = row.Cells["FSME_Title"].Value.ToString();
            string caption = groupName != string.Empty ? groupName : title;

            Image nodeImage;
            int dIndex = dtGAP.Rows.IndexOf(((DataRowView)row.DataBoundItem).Row);

            DataRow curDRow = dtGAP.Rows[dIndex];
            if (dIndex < dtGAP.Rows.Count - 1 - CTE_NumSumNodes)
            {
                DataRow nextDRow = dtGAP.Rows[dIndex + 1];

                string curULevel = curDRow["FSME_ULevel"].ToString();
                string nextULevel = nextDRow["FSME_ULevel"].ToString();
                bool nextIsHidden = (bool)nextDRow["Hidden"];

                if (nextULevel.StartsWith(curULevel))
                {
                    if (nextIsHidden)
                        nodeImage = global::Presentation.Properties.Resources.Plus;
                    else
                        nodeImage = global::Presentation.Properties.Resources.Minus;
                }
                else
                    nodeImage = global::Presentation.Properties.Resources.Lines;
            }
            else
                nodeImage = global::Presentation.Properties.Resources.Lines;


            e.Graphics.DrawString(caption.ToString(), e.CellStyle.Font, Brushes.DimGray, e.CellBounds.Location.X + indent + 20, e.CellBounds.Location.Y + 2);

            if (nodeImage != null)
            {
                System.Drawing.Drawing2D.GraphicsContainer container = e.Graphics.BeginContainer();
                e.Graphics.SetClip(e.ClipBounds);
                e.Graphics.DrawImageUnscaled(nodeImage, e.CellBounds.Location.X + indent, e.CellBounds.Location.Y);
                e.Graphics.EndContainer(container);
            }

            e.Handled = true;
        }
        private void dgvGAP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= dgvGAP.Rows.Count - CTE_NumSumNodes || e.ColumnIndex == dgvGAP.Columns.Count - 1)
            {
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.BackColor = Color.Ivory;

                using (Font boldFont = new Font(dgvGAP.Font, FontStyle.Bold))
                {
                    e.CellStyle.Font = boldFont;
                }
            }
            if (e.RowIndex >= dgvGAP.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (e.RowIndex > -1 && e.RowIndex < dgvGAP.Rows.Count - CTE_NumSumNodes && e.ColumnIndex == 0)
            {
                Font boldFont = new Font(dgvGAP.Font, FontStyle.Bold);
                e.CellStyle.Font = boldFont;
            }
        }

        public void DoPrint()
        {
            DataGridView dgv = new DataGridView();

            if (dgvGAP.DataSource != null)
            {
                foreach (DataGridViewColumn c1 in dgvGAP.Columns)
                {
                    DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                    dgv.Columns.Add(c2);
                }

                int i = 0;
                foreach (DataGridViewRow dgvr in dgvGAP.Rows)
                {
                    DataGridViewRow r = (DataGridViewRow)dgvr.Clone();
                    i = 0;
                    foreach (DataGridViewCell cell in dgvr.Cells)
                    {

                        r.Cells[i].Value = cell.Value;
                        i++;
                    }
                    dgv.Rows.Add(r);
                }



                string str;
                for (int k = 0; k < dgv.Rows.Count - 1; ++k)
                {
                    str = dgv.Rows[k].Cells["FSME_Title"].Value.ToString();
                    dgv.Rows[k].Cells["FSME_Title"].Value = dgv.Rows[k].Cells["FSME_GroupName"].Value;
                    dgv.Rows[k].Cells["FSME_GroupName"].Value = str;
                }
                dgv.Columns["FSME_Title"].Visible = true;
                dgv.Columns["FSME_GroupName"].HeaderText = "عنوان";
                dgv.Columns["FSME_Title"].HeaderText = "نام گروه";

                clsERMSGeneral.dgvActive = dgv;

            }
        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "Gap";
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (Presentation.Public.Routines.ShowMessageBoxFa("آیا از حذف مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem lvi = lsvModel.SelectedItems[0];
                GAPReportInfo GAP_Report_Info = (GAPReportInfo)lvi.Tag;
                GAP GAP_BL = new GAP();
                decimal GAP_Report_Model_Id = GAP_Report_Info.ID;
                GAP_BL.Delete_GAP_Report(GAP_Report_Model_Id);
                FillModel();
            }

        }

        private void tsmiDetail_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ProgressBox.Show();
               
                    GAP gap = new GAP();
                  
                    DataRow drDetail ;
                    drDetail = gap.GetGAPD((int)gapModelID);

                    Presentation.Tabs.AssetDebtManagement.frmDetail fx = new Presentation.Tabs.AssetDebtManagement.frmDetail();
                    DataGridViewCell cell = dgvGAP.CurrentCell;
                    if (cell != null && cell.RowIndex <= dgvGAP.Rows.Count - 1 - CTE_NumSumNodes && cell.ColumnIndex != 0 && cell.ColumnIndex != dgvGAP.Columns.Count - 1)
                    {
                        int fsModelElementID = (int)dgvGAP.CurrentRow.Cells["FSME_ID"].Value;
                        string title = dgvGAP.CurrentRow.Cells["FSME_Title"].Value.ToString();
                        if (title != string.Empty)
                        {
                            Presentation.Public.Routines.ShowMessageBoxFa("عملیات درخواست شده تحت یك عنوان گروه حساب قابل انجام نیست", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        int tbElementSeq = ((TBMElementInfo)cell.OwningColumn.Tag).Sequence;
                        int tbModelID = ((TBMElementInfo)cell.OwningColumn.Tag).ModelID;


                        fx.fsModelElementID = fsModelElementID;
                        fx.tbModelID = tbModelID;
                        fx.tbElementSeq = tbElementSeq;
                        fx.limitDetails = string.Empty;
                        fx.limitID = 0;
                        fx.dtpStartDateValue =
                            FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(lblgapDate.Text);
                        //fx.dtpStartDateValue = Convert.ToDateTime(drDetail["StartDate"]);
                        //fx.IsSeperate = IsSeperate;

                        //fx.dtpStartDateValue = (DateTime)drDetail["StartDate"];
                        //fx.chkIrrValue = Convert.ToBoolean(drDetail["IrrActive"]);


                        fx.Show();
                    }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Presentation.Public.Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    ProgressBox.Hide();
            //}
        }

        private void chkShowHideValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowHideValue.Checked)
            {
                ddChart.Series["Series1"].ShowLabelAsValue = true;
                ddChart.Series["Series2"].ShowLabelAsValue = true;
                ddChart.Series["Series3"].ShowLabelAsValue = true;
            }
            else
            {
                ddChart.Series["Series1"].ShowLabelAsValue = false;
                ddChart.Series["Series2"].ShowLabelAsValue = false;
                ddChart.Series["Series3"].ShowLabelAsValue = false;

            }

        }

        private void chkLegend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLegend.Checked)
            {
                ddChart.Series["Series1"].ShowInLegend = true;
                ddChart.Series["Series2"].ShowInLegend = true;
                ddChart.Series["Series3"].ShowInLegend = true;
            }
            else
            {
                ddChart.Series["Series1"].ShowInLegend = false;
                ddChart.Series["Series2"].ShowInLegend = false;
                ddChart.Series["Series3"].ShowInLegend = false;
            }
        }

        private void cbCollapseRight_CButtonClicked(object sender, EventArgs e)
        {
            if (spcAll.Panel1Collapsed == false)
            {
                spcAll.Panel1Collapsed = true;
                cbCollapseRight.DefaultImage = Properties.Resources.S_Panleft1;
                cbCollapseRight.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (spcAll.Panel1Collapsed == true)
            {
                spcAll.Panel1Collapsed = false;
                cbCollapseRight.DefaultImage = Properties.Resources.S_PanRight1;
                cbCollapseRight.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void frmGapReport_Shown(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}