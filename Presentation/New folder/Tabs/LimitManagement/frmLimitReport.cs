using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMSLib;

//  
using Dundas.Charting.WinControl;
using Dundas.Charting.WinControl.ChartTypes;
using Dundas.Charting.WinControl.Design;
using ERMS.Logic;
using ERMS.Model;
using Presentation.Public;
using ProgressBox = Presentation.Public.ProgressBox;

namespace Presentation.Tabs.LimitManagement
{
    public partial class frmLimitReport : BaseForm, IPrintable
    {
        #region VARS

        DataTable dtChart = new DataTable();
        DataTable dtChartSorting = new DataTable();
        DataTable dtLimit,dt;
        private LM lm;
        private int curModelID;

        #endregion

        public frmLimitReport()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }

        private void frmLimitReport_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            lm = new LM();

            lsvModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsvModel.Width - 5;
            lsvModel.Columns.Add(ch);
            lsvModel.FullRowSelect = true;
            lsvModel.HideSelection = false;
            lsvModel.HeaderStyle = ColumnHeaderStyle.None;
            
            //Limit Grid
            dgvLimit.ReadOnly = true;
            dgvLimit.AllowUserToAddRows = false;
            dgvLimit.AllowUserToDeleteRows = false;
            dgvLimit.AllowUserToResizeRows = false;
            dgvLimit.AllowUserToResizeColumns = true;
            dgvLimit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgvLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvLimit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dgvLimit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgvLimit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvLimit.RowHeadersVisible = false;
            dgvLimit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            System.Windows.Forms.DataGridViewCellStyle style = new System.Windows.Forms.DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgvLimit.RowsDefaultCellStyle = style;
            dgvLimit.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvLimit.EnableHeadersVisualStyles = false;
            GeneralDataGridView = dgvLimit;
            FillModel();
        }
        private void FillModel()
        {
            DataTable dt = lm.GetLMModels();
            lsvModel.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                LMInfo li = new LMInfo();
                lm.CloneX(dr, li, ECloneXdir.DR2Info);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = li.LMModelName;
                lvi.Tag = li;

                lsvModel.Items.Add(lvi);
            }
        }

        private void tsbModelRemove_Click(object sender, EventArgs e)
        {
            CommandModelRemove();
        }
        private void CommandModelRemove()
        {
            if (lsvModel.SelectedItems.Count > 0)
            {
                if (Routines.ShowMessageBoxFa("مدل انتخاب شده شما حذف خواهد شد. آیا مطمئن هستید؟", "هشدار",
                                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem lvi = lsvModel.SelectedItems[0];
                    LMInfo li = (LMInfo)lvi.Tag;

                    lvi.Remove();
                    lm.DeleteLM(li.ID);
                }
            }
        }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProgressBox.Show();
                if (curModelID != -1 || lsvModel.SelectedItems.Count > 0)
                {
                    //if (bDirty)
                    //{
                    //    if (Routines.ShowMessageBoxFa("آیا می خواهید مدل را ذخیره كنید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //        SaveDiagram(curModelID, false);
                    //}
                    //bDirty = false;

                    if (lsvModel.SelectedItems.Count > 0)
                    {
                        LMInfo li = (LMInfo)lsvModel.SelectedItems[0].Tag;
                        curModelID = li.ID;
                        FillGrid(li.ID);
                        RefreshChart1();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Routines.ShowMessageBoxFa(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBox.Hide();
            }
            
        }
        private void FillGrid(int lsModelID)
        {
            int limitBase = ((LMInfo)lsvModel.SelectedItems[0].Tag).LMBase;
            dtLimit = lm.GetLMReport(curModelID, limitBase, 1);
            
            dtLimit.DefaultView.RowFilter = "(Hidden = 0)";
            dgvLimit.DataSource = dtLimit;


            dgvLimit.Columns["LMElementName"].Visible = false;
            dgvLimit.Columns["Seq"].Visible = false;
            dgvLimit.Columns["Balance"].Visible = false;
            dgvLimit.Columns["ULevel"].Visible = false;
            dgvLimit.Columns["Color"].Visible = false;
            dgvLimit.Columns["Hidden"].Visible = false;

            dgvLimit.Columns["Id"].HeaderText = "";
            dgvLimit.Columns["Id"].MinimumWidth = 300;
            dgvLimit.Columns["Amount_Approved"].HeaderText = "مقدار";
            
            dgvLimit.Columns["Amount_Limit"].HeaderText = "مقدار حد";
            dgvLimit.Columns["OverDraft"].HeaderText = "مازاد";
            dgvLimit.Columns["Amount_Approved"].DefaultCellStyle.Format = "###,###.##";
            dgvLimit.Columns["Amount_Limit"].DefaultCellStyle.Format = "###,###.##";
            dgvLimit.Columns["OverDraft"].DefaultCellStyle.Format = "###,###.##";
        }

        private void dgvLimit_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 0 || e.RowIndex > dgvLimit.Rows.Count + 1)
            {
                e.Handled = false;
                return;
            }

            DataGridViewRow row = dgvLimit.Rows[e.RowIndex];
            
            DataGridViewCell cell = row.Cells["Balance"];

            if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
                e.PaintBackground(e.ClipBounds, true);
            else
            {
                Color color1 = Color.White;
                Color color2 =  Color.FromArgb((int)row.Cells["Color"].Value);
                using (Brush bg = new System.Drawing.Drawing2D.LinearGradientBrush(e.CellBounds, color1, color2, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(bg, e.CellBounds);
                }
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.Focus | DataGridViewPaintParts.Border);

            //////////////////////////////
            int balance = (int)cell.Value;
            int indent = balance * 20;

            string groupName = row.Cells["LMElementName"].Value.ToString();
            //string title = row.Cells["FSME_Title"].Value.ToString();
            string caption = groupName ;

            Image nodeImage;
            int dIndex = dtLimit.Rows.IndexOf(((DataRowView)row.DataBoundItem).Row);

            DataRow curDRow = dtLimit.Rows[dIndex];
            if (dIndex < dtLimit.Rows.Count - 1)
            {
                DataRow nextDRow = dtLimit.Rows[dIndex + 1];

                string curULevel = curDRow["ULevel"].ToString();
                string nextULevel = nextDRow["ULevel"].ToString();
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

        private void dgvLimit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= dgvLimit.Rows.Count || e.ColumnIndex == dgvLimit.Columns.Count - 1)
            {
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.BackColor = Color.Ivory;

                using (Font boldFont = new Font(dgvLimit.Font, FontStyle.Bold))
                {
                    e.CellStyle.Font = boldFont;
                }
                if (e.Value.ToString() != string.Empty)
                {
                    if (decimal.Parse(e.Value.ToString()) > 0)  //red
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(236, 39, 17 ); 
                        e.CellStyle.ForeColor = Color.White;
                    }
                   if (decimal.Parse(e.Value.ToString()) < 0) //green
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(0, 164, 82);
                        e.CellStyle.ForeColor = Color.White;
                    }
                   if (e.Value.ToString() == "0")
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255,255, 62);                         //e.CellStyle.ForeColor = Color.White;
                    }
                    
                }
                else
                { e.Value = "-"; }
            }
            if (e.RowIndex >= dgvLimit.Rows.Count && e.ColumnIndex == 0)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (e.RowIndex > -1 && e.RowIndex < dgvLimit.Rows.Count && e.ColumnIndex == 0)
            {
                Font boldFont = new Font(dgvLimit.Font, FontStyle.Bold);
                e.CellStyle.Font = boldFont;
            }
            
        }

        private void dgvLimit_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0 && e.RowIndex <= dgvLimit.Rows.Count - 1 )
            {
                DataGridViewRow dgvr = dgvLimit.Rows[e.RowIndex];

                int balance = (int)dgvr.Cells["Balance"].Value;
                int pointRight = 20 * balance;
                int pointLeft = 20 * (balance + 1);

                if (e.X > pointRight && e.X < pointLeft)
                {
                    int dIndex = dtLimit.Rows.IndexOf(((DataRowView)dgvLimit.Rows[e.RowIndex].DataBoundItem).Row);
                    if (dIndex < dtLimit.Rows.Count )
                    {
                        DataRow curDRow = dtLimit.Rows[dIndex];
                        DataRow nextDRow = dtLimit.Rows[dIndex + 1];

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
        private void Collapse(int dIndex, int balance)
        {
            for (int i = dIndex + 1; i <= dtLimit.Rows.Count -1 ; i++)
            {
                DataRow dr = dtLimit.Rows[i];
                if ((int)dr["Balance"] <= balance)
                    break;

                dr["Hidden"] = true;
            }
        }
        private void Expand(int dIndex, int balance)
        {
            for (int i = dIndex + 1; i <= dtLimit.Rows.Count - 1; i++)
            {
                DataRow dr = dtLimit.Rows[i];
                if ((int)dr["Balance"] <= balance)
                    break;

                dr["Hidden"] = false;
            }
        }

        private void tsbModelRefresh_Click(object sender, EventArgs e)
        {
            FillModel(); 
        }
        //CHART
             

        private void RefreshChart1()
        {
            dtChart = new DataTable();
            int limitBase = ((LMInfo)lsvModel.SelectedItems[0].Tag).LMBase;
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
            ddChart.Series["Series1"].LegendText = "مقدار";

            ddChart.Series["Series2"].ValueMemberX = "X";
            ddChart.Series["Series2"].ValueMembersY = "Y2";
            ddChart.Series["Series2"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series2"].YValuesPerPoint = 1;
            ddChart.Series["Series2"].ShowInLegend = false;
            ddChart.Series["Series2"].LegendText = "مازاد";

            ddChart.Series["Series3"].ValueMemberX = "X";
            ddChart.Series["Series3"].ValueMembersY = "Y3";
            ddChart.Series["Series3"].XValueType = ChartValueTypes.Int;
            ddChart.Series["Series3"].YValuesPerPoint = 1;
            ddChart.Series["Series3"].ShowInLegend = false;
            ddChart.Series["Series3"].LegendText = "حد";
            int mode = 2;
            dtChart = lm.GetLMReport(curModelID, limitBase, mode);
            ddChart.DataSource = dtChart;
            ddChart.DataBind();

            // Fill Filtering Combos
            dtChartSorting = new DataTable();
            dtChartSorting = dtChart.Clone();
            foreach (DataRow dr in dtChart.Rows)
            {
                DataRow drNew;
                drNew = dtChartSorting.NewRow();
                if (dr["X"] != null && dr["X"].ToString().Length > 0)
                    drNew["X"] = dr["X"].ToString().Replace(dr["X"].ToString().Substring(0, 1), " ").Trim();
                else
                    drNew["X"] = dr["X"].ToString();
                drNew["Y1"] = dr["Y1"];
                drNew["Y2"] = dr["Y2"];
                drNew["Y3"] = dr["Y3"];
                dtChartSorting.Rows.Add(drNew);
            }
            dtChartSorting.DefaultView.Sort = "X";
            var distinctLimits = dtChartSorting.DefaultView.ToTable(true, "X");
            dtChartSorting.DefaultView.Sort = "Y1";
            var distinctValues = dtChartSorting.DefaultView.ToTable(true, "Y1");
           
            cmbFilterLimits.DisplayMember = "X";
            cmbFilterLimits.ValueMember = "X";
            cmbFilterValues.DisplayMember = "Y1";
            cmbFilterValues.ValueMember = "Y1";

            for (int i = 0; i < distinctLimits.Rows.Count; i++)
            {
                cmbFilterLimits.Items.Add(distinctLimits.Rows[i][0].ToString());
            }
            for (int i = 0; i < distinctValues.Rows.Count; i++)
            {
                cmbFilterValues.Items.Add(distinctValues.Rows[i][0].ToString());
            }
            //

            ddChart.Series["Series1"].XValueIndexed = true;
            ddChart.Series["Series2"].XValueIndexed = true;
            ddChart.Series["Series3"].XValueIndexed = true;

            ddChart.Series["Series1"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series2"]["DrawingStyle"] = "Cylinder";
            ddChart.Series["Series3"]["DrawingStyle"] = "Cylinder";


            //ddChart.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            //ddChart.ChartAreas["Default"].Area3DStyle.Light = LightStyle.Realistic;
            //ddChart.ChartAreas["Default"].Area3DStyle.Perspective = 30;
            //ddChart.ChartAreas["Default"].Area3DStyle.XAngle = 10;
            //ddChart.ChartAreas["Default"].Area3DStyle.YAngle = 5;
            //ddChart.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            //ddChart.ChartAreas["Default"].Area3DStyle.PointGapDepth = 0;
            //ddChart.ChartAreas["Default"].Area3DStyle.RightAngleAxes = true;

            //ddChart.ChartAreas["Default"].BackColor = Color.White;

            ddChart.ChartAreas["Default"].AxisX.View.Position = 1;
            ddChart.ChartAreas["Default"].AxisX.View.Size = 5;
            ddChart.ChartAreas["Default"].AxisX.View.Scroll(ScrollType.LargeIncrement);
                
            //for scroling
            ddChart.ChartAreas["Default"].AxisX.ScrollBar.Enabled = true;
            ddChart.ChartAreas["Default"].AxisX.ScrollBar.PositionInside = true;
            ddChart.ChartAreas["Default"].AxisX.ScrollBar.Buttons = ScrollBarButtonStyle.SmallScroll;
            ddChart.ChartAreas["Default"].AxisX.ScrollBar.Size = 15;
            ddChart.ChartAreas["Default"].AxisX.ScrollBar.BackColor = Color.LightGray;
            ddChart.ChartAreas["Default"].AxisX.ScrollBar.ButtonColor = Color.Gray;
            ddChart.ChartAreas["Default"].AxisX.ScrollBar.LineColor = Color.Black;


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

            //ddChart.ChartAreas["Default"].AxisX.LabelStyle.Format = "###,###";
            //ddChart.ChartAreas["Default"].AxisY.LabelStyle.Format = "###,###";
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.Font = new Font("Tahoma", 9);
            ddChart.ChartAreas["Default"].AxisX.LabelStyle.FontAngle = -45;

            
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

        public void FilterChart()
        {
            DataTable dtTemp = new DataTable();
            string whereClauseValue = "";
            string whereClauseLimits = "";
            string whereClause = "";

            dtTemp = dtChart.Clone();
            DataRow[] foundRows;
            string SelectedValue = "";

            if (cmbFilterValues.SelectedItem != null)
            {
                SelectedValue = cmbFilterValues.SelectedItem.ToString();

                if (rdbMore.Checked)
                    whereClauseValue = "Y1 >= " + SelectedValue.ToString();
                else if (rdbLess.Checked)
                    whereClauseValue = "Y1 <= " + SelectedValue.ToString();
            }

            foreach (var item in cmbFilterLimits.CheckedItems)
                whereClauseLimits += " X = '" + item.DataValue.ToString() + "'  OR ";
                        
            if (whereClauseLimits.Length > 0 && whereClauseValue.Length > 0)
            {
                whereClause = "(" + whereClauseLimits.Substring(0, whereClauseLimits.Length - 4) +
                        ") AND " + whereClauseValue;
            }
            else if (whereClauseLimits.Length > 0 && whereClauseValue.Length == 0)
            {
                whereClause = whereClauseLimits.Substring(0, whereClauseLimits.Length - 4);                
            }
            else if (whereClauseLimits.Length == 0 && whereClauseValue.Length > 0)
            {
                whereClause = whereClauseValue;
            }
            
            foundRows = dtChartSorting.Select(whereClause);
            foreach (DataRow dr in foundRows)
            {
                DataRow drNew;
                drNew = dtTemp.NewRow();
                drNew["X"] = dr["X"];
                drNew["Y1"] = dr["Y1"];
                drNew["Y2"] = dr["Y2"];
                drNew["Y3"] = dr["Y3"];
                dtTemp.Rows.Add(drNew);
            }

            //DataTable dtTemp2 = new DataTable();
            
            //dtTemp2 = dtChart.Clone();
            //DataRow[] foundRows2;            
            //foreach (var item in cmbFilterValues.CheckedItems)
            //{
            //    whereClauseLimits += " X = " + item.DataValue.ToString() + " AND";
            //}
            //if (whereClauseLimits.Length > 1)
            //{
            //    whereClauseLimits = whereClauseLimits.Substring(0, whereClauseLimits.Length - 4);
            //    foundRows2 = dtTemp.Select(whereClauseLimits);

            //    foreach (DataRow dr in foundRows)
            //    {
            //        DataRow drNew;
            //        drNew = dtTemp.NewRow();
            //        drNew["X"] = dr["X"];
            //        drNew["Y1"] = dr["Y1"];
            //        drNew["Y2"] = dr["Y2"];
            //        drNew["Y3"] = dr["Y3"];
            //        dtTemp.Rows.Add(drNew);
            //    }
            //}

            if (dtTemp.Rows.Count == 0)
            {
                DataRow drNew;
                drNew = dtTemp.NewRow();
                drNew["X"] = ".";
                drNew["Y1"] = 0;
                drNew["Y2"] = 0;
                drNew["Y3"] = 0;
                dtTemp.Rows.Add(drNew);
                ddChart.DataSource = dtTemp;
                ddChart.DataBind();
            }
            else
            {
                ddChart.DataSource = dtTemp;
                ddChart.DataBind();
            }
        }

        private void ddChart_AxisScrollBarClicked(object sender, ScrollBarEventArgs e)
        {
            //if (e.ButtonType == ScrollBarButtonType.ZoomReset)
            //{
            //    // Event is handled, no more processing required
            //    e.Handled = true;

            //    // Reset zoom on X and Y axis
            //    ddChart.ChartAreas["Default"].AxisX.View.ZoomReset();
            //    ddChart.ChartAreas["Default"].AxisY.View.ZoomReset();
            //}

        }

        private void chkShowHideValue_Click(object sender, EventArgs e)
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

        private void chkLegend_Click(object sender, EventArgs e)
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
        public void DoPrint()
        {
            //dgvLimit.Columns["LMElementName"].Visible = true;
            //dgvLimit.Columns["Id"].Visible = false;

            DataGridView dgv = new DataGridView();

            if (dgvLimit.DataSource != null)
            {
                foreach (DataGridViewColumn c1 in dgvLimit.Columns)
                {
                    DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                    dgv.Columns.Add(c2);
                }

                int i = 0;
                foreach (DataGridViewRow dgvr in dgvLimit.Rows)
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
            }



                             
                dgv.Columns["LMElementName"].Visible = true;
                dgv.Columns["Id"].Visible = false;
                dgv.Columns["LMElementName"].HeaderText = "";
              //  dgv.Columns["FSME_Title"].HeaderText = "نام گروه";

                clsERMSGeneral.dgvActive = dgv;

            //clsERMSGeneral.dgvActive = dgvLimit;

            //dgvLimit.Columns["LMElementName"].Visible = false;
            //dgvLimit.Columns["Id"].Visible = true;

        }
        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "LimitReport";
        }

        private void btnModel_CButtonClicked(object sender, EventArgs e)
        {
            if (spcAll.Panel1Collapsed == false)
            {
                spcAll.Panel1Collapsed = true;
                btnModel.DefaultImage = Properties.Resources.S_Panleft1;
                btnModel.HoverImage = Properties.Resources.S_Panleft_Hover1;
            }
            else if (spcAll.Panel1Collapsed == true)
            {
                spcAll.Panel1Collapsed = false;
                btnModel.DefaultImage = Properties.Resources.S_PanRight1;
                btnModel.HoverImage = Properties.Resources.S_PanRight_Hover1;
            }
        }

        private void cbFilter_CButtonClicked(object sender, EventArgs e)
        {
            FilterChart();
        }

        private void chbFilterChartValues_CheckedChanged(object sender, EventArgs e)
        {
            cgbFiltering.Enabled = chbFilterChartValues.Checked;
            if (!chbFilterChartValues.Checked)
            {
                cmbFilterLimits.Clear();
                cmbFilterLimits.SelectedItem = null;
                cmbFilterValues.Clear();
                ddChart.DataSource = dtChart;
                ddChart.DataBind();
            }
        }

    }
}