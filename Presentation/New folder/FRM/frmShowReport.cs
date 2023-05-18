using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DevComponents.AdvTree;
using Presentation.Properties;
using Utilize;
using Utilize.Helper;

namespace Presentation
{
    public partial class frmShowReport : Form
    {
        private int index;
        private readonly long ReportId;
        private DataTable dtView;

        public frmShowReport(long reportId)
        {
            InitializeComponent();
            ReportId = reportId;
            timerWaiting.Enabled = true;
            timerWaiting.Tick += timerWaiting_Tick;
        }


        private void timerWaiting_Tick(object sender, EventArgs e)
        {
            index++;
            if (index.Equals(5))
            {
                timerWaiting.Enabled = false;
                LoadingClass.ShowProcecing(ConfReport,null);
                //ConfReport();
            }
        }

        private void ConfReport()
        {
            var report =
                new DAL.DepositDataSetTableAdapters.ReportsTableAdapter().GetDataById(ReportId).FirstOrDefault();
            //txtTitle.Text = report.ReportName;
            txtTitle.Invoke(new Action(() => { txtTitle.Text = report.ReportName; }));
            if (report.IsGroupingShow == false)
            {
                //splitContainer1.Panel2Collapsed = true;
                splitContainer1.Invoke(new Action(() => { splitContainer1.Panel2Collapsed = true; }));
                //btnExpand.Visible = false;
                btnExpand.Invoke(new Action(() => { btnExpand.Visible = false;}));
                //trnIndexOfReport.Visible = false;
                trnIndexOfReport.Invoke(new Action(() => { trnIndexOfReport.Visible = false; }));
                //Presentation.Public.Routines.StartProgress();
                //ProgressBox.Show();
                GenerateXMLFileForReportViewerWhitoutGrouping();
                //Presentation.Public.Routines.StopProgress();
                //ProgressBox.Hide();
            }
            else
            {
                //ProgressBox.Show();
                //Presentation.Public.Routines.StartProgress();
                GenerateXMLFileForReportViewerWhitGrouping();
                //ConfigureTreeViewNodeIndexReport();
                trnIndexOfReport.Invoke(new Action(ConfigureTreeViewNodeIndexReport));
                //Presentation.Public.Routines.StopProgress();
                //ProgressBox.Hide();
            }
            //rpvReport.RefreshReport();
            rpvReport.Invoke(new Action(() => rpvReport.RefreshReport()));
        }

        private void frmShowReport_Load(object sender, EventArgs e)
        {
            timerWaiting.Enabled = true;
        }




        private DataTable CreateQuery()
        {
            var report = new DAL.DepositDataSetTableAdapters.ReportsTableAdapter().GetDataById(ReportId).FirstOrDefault();

            var rModel = new DepositDataSet().GetResoult(report.SelectColumn, report.OrderBy, report.GroupBy, report.Where, report.TableName);
            //var alfa = new DataTable();
            //rModel.Rows.Cast<DataRow>().Select(item=> { });
            //rModel.Rows.Cast<DataRow>().ForEach(row =>
            //                                        {
            //                                            var @select = row.ItemArray.Select(s => s.ToString());
            //                                            alfa.Rows.Add(@select);
            //                                        });
            return rModel;
        }

        private void GenerateXMLFileForReportViewerWhitoutGrouping()
        {

            dtView = CreateQuery();

            #region [TEMPLATE_FIELD]

            var strTemplateField = "";
            foreach (DataColumn columnsItem in dtView.Columns)
            {
                if (columnsItem.ColumnName.Trim().Contains(" "))
                {
                    columnsItem.Caption = columnsItem.ColumnName;
                    columnsItem.ColumnName = columnsItem.ColumnName.Trim().Replace(" ", string.Empty);
                }
                strTemplateField +=
                    string.Format(Resources.TEMPLATE_FIELD, columnsItem.ColumnName, columnsItem.ColumnName, columnsItem.DataType.FullName);
            }

            #endregion

            #region [TEMPLATE_COUNT_COLUMN]
            var strTemplateCountColumn = "";
            foreach (var columnItem in dtView.Columns.Cast<DataColumn>())
            {
                strTemplateCountColumn += string.Format(Resources.TEMPLATE_COUNT_COLUMN, 1);
            }

            #endregion

            #region [TABLIX_CELL_LABEL] && [TABLIX_CELL] && [TABLIX_MEMBER]
            var CountTextBox = 2;
            var strTABLIX_CELL_LABEL = "";
            var strTABLIX_CELL = "";
            var strTABLIX_MEMBER = "";
            foreach (DataColumn ColumnsItem in dtView.Columns)
            {
                strTABLIX_MEMBER += Resources.TABLIX_MEMBER;
                var nameTextBox = "TextBox" + CountTextBox;
                var nameLabel = ColumnsItem.Caption;
                strTABLIX_CELL_LABEL += string.Format(Resources.TABLIX_CELL_LABEL, nameTextBox, nameLabel, nameTextBox);

                strTABLIX_CELL += string.Format(Resources.TABLIX_CELL, ColumnsItem.ColumnName, ColumnsItem.ColumnName, ColumnsItem.ColumnName);
                CountTextBox++;
            }
            #endregion

            #region Grouping


            var strTABLIX_ROW_HIERARCHY = "";
            var strTABLIX_ROW_HIERARCHY_FILL = "";

            strTABLIX_ROW_HIERARCHY = string.IsNullOrEmpty(strTABLIX_ROW_HIERARCHY.Trim())
                                            ? Resources.TABLIX_ROW_HIERARCHY_DEFAULT
                                            : strTABLIX_ROW_HIERARCHY;
            strTABLIX_ROW_HIERARCHY_FILL = string.IsNullOrEmpty(strTABLIX_ROW_HIERARCHY_FILL.Trim())
                                            ? Resources.TABLIX_ROW_HIERARCHY_FILL_DEFAULT
                                            : strTABLIX_ROW_HIERARCHY_FILL;


            #endregion


            #region Create Report File

            var strReport = Resources.strReportTemplate;
            if (System.IO.File.Exists("Report.rdlc"))
            {
                System.IO.File.Delete("Report.rdlc");
                System.IO.File.Create("Report.rdlc").Dispose();
            }
            else
            {
                System.IO.File.Create("Report.rdlc").Dispose();
            }
            strReport = strReport.Replace("[TEMPLATE_FIELD]", strTemplateField);
            strReport = strReport.Replace("[TEMPLATE_COUNT_COLUMN]", strTemplateCountColumn);
            strReport = strReport.Replace("[TABLIX_CELL_LABEL]", strTABLIX_CELL_LABEL);
            strReport = strReport.Replace("[TABLIX_CELL]", strTABLIX_CELL);
            strReport = strReport.Replace("[TABLIX_MEMBER]", strTABLIX_MEMBER);
            strReport = strReport.Replace("[TABLIX_ROW_HIERARCHY]", strTABLIX_ROW_HIERARCHY);
            strReport = strReport.Replace("[TABLIX_ROW_HIERARCHY_FILL]", strTABLIX_ROW_HIERARCHY_FILL);
            var oStreamWriter = new System.IO.StreamWriter("Report.rdlc");
            oStreamWriter.Write(strReport);
            oStreamWriter.Dispose();

            #endregion

            var rdsReport = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dtView);
            rpvReport.LocalReport.DataSources.Clear();
            rpvReport.LocalReport.DataSources.Add(rdsReport);
            rpvReport.LocalReport.ReportPath = "Report.rdlc";
            //rpvReport.RefreshReport();
            rpvReport.Invoke(new Action(() => rpvReport.RefreshReport()));

        }


        private void GenerateXMLFileForReportViewerWhitGrouping()
        {
            dtView = CreateQuery();
            var strGroupByColumnsNameWithAs = GetGroupByColumnsWithAs();

            #region [TEMPLATE_FIELD]
            var strTemplateField = "";
            foreach (DataColumn columnsItem in dtView.Columns)
            {
                if (columnsItem.ColumnName.Trim().Contains(" "))
                {
                    columnsItem.Caption = columnsItem.ColumnName;
                    columnsItem.ColumnName = columnsItem.ColumnName.Trim().Replace(" ", string.Empty);
                }
                strTemplateField +=
                    string.Format(Resources.TEMPLATE_FIELD, columnsItem.ColumnName, columnsItem.ColumnName, columnsItem.DataType.FullName);
            }
            #endregion

            #region [TEMPLATE_COUNT_COLUMN]
            var strTemplateCountColumn = "";
            foreach (var columnItem in dtView.Columns.Cast<DataColumn>())
            {
                if (strGroupByColumnsNameWithAs.Where(item => item.Contains(columnItem.Caption)).Any())
                    continue;
                strTemplateCountColumn += string.Format(Resources.TEMPLATE_COUNT_COLUMN, 1);
            }
            #endregion

            #region [TABLIX_CELL_LABEL] && [TABLIX_CELL] && [TABLIX_MEMBER]
            var countTextBox = 2;
            var strTABLIX_CELL_LABEL = "";
            var strTABLIX_CELL = "";
            var strTABLIX_MEMBER = "";
            foreach (DataColumn ColumnsItem in dtView.Columns)
            {
                if (strGroupByColumnsNameWithAs.Where(item => item.Contains(ColumnsItem.Caption)).Any())
                    continue;
                strTABLIX_MEMBER += Resources.TABLIX_MEMBER;
                var nameTextBox = "TextBox" + countTextBox;
                var nameLabel = ColumnsItem.Caption;
                strTABLIX_CELL_LABEL += string.Format(Resources.TABLIX_CELL_LABEL, nameTextBox, nameLabel, nameTextBox);

                strTABLIX_CELL += string.Format(Resources.TABLIX_CELL, ColumnsItem.ColumnName, ColumnsItem.ColumnName, ColumnsItem.ColumnName);
                countTextBox++;
            }

            #endregion

            #region [TABLIX_ROW_HIERARCHY] and [TABLIX_ROW_HIERARCHY_FILL]

            var strTABLIX_ROW_HIERARCHY = "";
            var strTABLIX_ROW_HIERARCHY_FILL = "";
            foreach (var VARIABLE in strGroupByColumnsNameWithAs)
            {
                var dataColumn =
                    dtView.Columns.Cast<DataColumn>().Where(item => VARIABLE.Contains(item.Caption)).FirstOrDefault();
                if (dataColumn == null) continue;
                var templateOfGroupColumn = "<TablixMember><TablixHeader><Size>1in</Size><CellContents><Textbox Name=\"Textbox" + countTextBox +
            "\"><CanGrow>true</CanGrow><KeepTogether>true</KeepTogether><Paragraphs><Paragraph><TextRuns><TextRun><Value>" +
            dataColumn.Caption +
            "</Value><Style><FontFamily>Tahoma</FontFamily><FontSize>11pt</FontSize><FontWeight>Bold</FontWeight><Color>White</Color></Style></TextRun></TextRuns><Style /></Paragraph></Paragraphs>" +
            "<rd:DefaultName>Textbox" + countTextBox +
            "</rd:DefaultName><Style><Border><Color>#7292cc</Color><Style>Solid</Style></Border><BackgroundColor>#4c68a2</BackgroundColor><PaddingLeft>2pt</PaddingLeft><PaddingRight>2pt</PaddingRight><PaddingTop>2pt</PaddingTop><PaddingBottom>2pt</PaddingBottom></Style></Textbox></CellContents></TablixHeader>" +
            "<TablixMembers><TablixMember /></TablixMembers><KeepWithGroup>After</KeepWithGroup>" +
            "</TablixMember>";
                if (string.IsNullOrEmpty(strTABLIX_ROW_HIERARCHY.Trim()))
                {
                    strTABLIX_ROW_HIERARCHY += templateOfGroupColumn;
                }
                else
                {
                    strTABLIX_ROW_HIERARCHY = strTABLIX_ROW_HIERARCHY.Replace("<TablixMember />", templateOfGroupColumn);
                }

                var templateOfGroupColumnFill =
                    "<TablixMember><Group Name=\"" + dataColumn.ColumnName + "\">" +
                    "<GroupExpressions><GroupExpression>=Fields!" + dataColumn.ColumnName +
                    ".Value</GroupExpression></GroupExpressions></Group><SortExpressions><SortExpression>" +
                    "<Value>=Fields!" + dataColumn.ColumnName + ".Value</Value></SortExpression></SortExpressions><TablixHeader>" +
                    "<Size>1in</Size><CellContents><Textbox Name=\"" + dataColumn.ColumnName +
                    "\"><CanGrow>true</CanGrow><KeepTogether>true</KeepTogether><Paragraphs><Paragraph><TextRuns><TextRun>" +
                    "<Value>=Fields!" + dataColumn.ColumnName +
                    ".Value</Value><Style><FontFamily>Tahoma</FontFamily><FontWeight>Bold</FontWeight><Color>#465678</Color></Style></TextRun></TextRuns><Style /></Paragraph></Paragraphs><rd:DefaultName>" +
                    dataColumn.ColumnName + "</rd:DefaultName><Style><Border><Color>#c6daf8</Color><Style>Solid</Style>" +
                    "</Border><BackgroundColor>#9eb6e4</BackgroundColor><PaddingLeft>2pt</PaddingLeft><PaddingRight>2pt</PaddingRight><PaddingTop>2pt</PaddingTop><PaddingBottom>2pt</PaddingBottom></Style>" +
                    "</Textbox></CellContents></TablixHeader><TablixMembers><TablixMember /></TablixMembers></TablixMember>";
                //,dataColumn.ColumnName,dataColumn.ColumnName,dataColumn.ColumnName,dataColumn.ColumnName,dataColumn.ColumnName,dataColumn.ColumnName
                if (string.IsNullOrEmpty(strTABLIX_ROW_HIERARCHY_FILL.Trim()))
                {
                    strTABLIX_ROW_HIERARCHY_FILL += templateOfGroupColumnFill;
                }
                else
                {
                    strTABLIX_ROW_HIERARCHY_FILL = strTABLIX_ROW_HIERARCHY_FILL.Replace("<TablixMember />", templateOfGroupColumnFill);
                }
                countTextBox++;
            }
            strTABLIX_ROW_HIERARCHY = string.IsNullOrEmpty(strTABLIX_ROW_HIERARCHY.Trim())
                                            ? "<TablixMember><KeepWithGroup>After</KeepWithGroup></TablixMember>"
                                            : strTABLIX_ROW_HIERARCHY;
            strTABLIX_ROW_HIERARCHY_FILL = string.IsNullOrEmpty(strTABLIX_ROW_HIERARCHY_FILL.Trim())
                                            ? "<TablixMember><Group Name=\"Details\" /></TablixMember>"
                                            : strTABLIX_ROW_HIERARCHY_FILL;
            #endregion


            #region Create Report File

            var strReport = Resources.strReportTemplate;
            if (System.IO.File.Exists("Report.rdlc"))
            {
                System.IO.File.Delete("Report.rdlc");
                System.IO.File.Create("Report.rdlc").Dispose();
            }
            else
            {
                System.IO.File.Create("Report.rdlc").Dispose();
            }
            strReport = strReport.Replace("[TEMPLATE_FIELD]", strTemplateField);
            strReport = strReport.Replace("[TEMPLATE_COUNT_COLUMN]", strTemplateCountColumn);
            strReport = strReport.Replace("[TABLIX_CELL_LABEL]", strTABLIX_CELL_LABEL);
            strReport = strReport.Replace("[TABLIX_CELL]", strTABLIX_CELL);
            strReport = strReport.Replace("[TABLIX_MEMBER]", strTABLIX_MEMBER);
            strReport = strReport.Replace("[TABLIX_ROW_HIERARCHY]", strTABLIX_ROW_HIERARCHY);
            strReport = strReport.Replace("[TABLIX_ROW_HIERARCHY_FILL]", strTABLIX_ROW_HIERARCHY_FILL);
            var oStreamWriter = new System.IO.StreamWriter("Report.rdlc");
            oStreamWriter.Write(strReport);
            oStreamWriter.Dispose();

            #endregion

            var rdsReport = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dtView);
            rpvReport.Invoke(new Action(()=>
                                            {
                                                rpvReport.LocalReport.DataSources.Clear()
                                                ;
                                                rpvReport.LocalReport.DataSources.Add(rdsReport);
                                                rpvReport.LocalReport.ReportPath = "Report.rdlc";
                                            }));
        }

        private string[] GetGroupByColumnsWithAs()
        {
            var report = new DAL.DepositDataSetTableAdapters.ReportsTableAdapter().GetDataById(ReportId).FirstOrDefault();

            return report.GroupingOrder.Substring(1).Split(new[] { ';' });
        }

        private void ConfigureTreeViewNodeIndexReport()
        {
            var table = CreateQuery();
            var report = new DAL.DepositDataSetTableAdapters.ReportsTableAdapter().GetDataById(ReportId).FirstOrDefault();
            var column = report.GroupingOrder.Substring(1).Split(new[] { ';' });
            trnIndexOfReport.Nodes.Clear();
            if (column.Count() == 0) return;
            var col = table.Columns.Cast<DataColumn>().Where(item => column.First().Contains(item.Caption)).FirstOrDefault();
            if (col == null) return;
            table.Rows.Cast<DataRow>().Select(row => new { valueCell = row[col] }).Distinct().ForEach(
                e =>
                {
                    var tag = table.Rows.Cast<DataRow>().Where(iRow => iRow[col].ToString().Equals(e.valueCell));
                    trnIndexOfReport.Nodes.Add(new Node(e.valueCell.ToString()) { Tag = tag, Image = Resources.ticket });
                }
                );
        }

        private static int GetLevelOfNode(Node node)
        {
            var level = 1;
            while (node.Parent != null)
            {
                level++;
                node = node.Parent;
            }
            return level;
        }

        private void trnIndexOfReport_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            try
            {
                rpvReport.Find(e.Node.Text, 1);
                var strGroupByColumnsNameWithAs = GetGroupByColumnsWithAs();
                var level = GetLevelOfNode(e.Node);
                e.Node.Nodes.Clear();
                var rows = e.Node.Tag == null ? dtView.Rows.Cast<DataRow>() : (IEnumerable<DataRow>)e.Node.Tag;

                var _column_1 = dtView.Columns.Cast<DataColumn>().Where(
                        colItem => strGroupByColumnsNameWithAs[level - 1].Contains(colItem.Caption)).FirstOrDefault();
                var column = dtView.Columns.Cast<DataColumn>().Where(
                    colItem => strGroupByColumnsNameWithAs[GetLevelOfNode(e.Node)].Contains(colItem.Caption)).
                    FirstOrDefault();
                rows.Where(ir => ir[_column_1.Caption].ToString().Equals(e.Node.Text)).Select(row => row[column.Caption]).Distinct().ForEach(item =>
                {
                    var tag =
                        rows.Where(iRow => iRow[_column_1.Caption].ToString().Equals(e.Node.Text));
                    e.Node.Nodes.Add(new Node(item.ToString()) { Tag = tag });
                });
                e.Node.Expand();
            }
            catch
            {

            }
        }

        private bool collapsed;

        private void btnExpand_Click(object sender, EventArgs e)
        {

            if (collapsed)
            {
                btnExpand.BackgroundImage = Resources.PanRight;
                trnIndexOfReport.Visible = true;
                splitContainer1.Panel2Collapsed = false;
                collapsed = false;
            }
            else
            {

                btnExpand.BackgroundImage = Resources.panLeft;
                trnIndexOfReport.Visible = false;
                splitContainer1.Panel2Collapsed = true;
                collapsed = true;
            }
        }

        private void frmShowReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(true);
        }
    }
}
