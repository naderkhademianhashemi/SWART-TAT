using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Infragistics.Win.UltraWinGrid;
using ERMSLib;
using System;
//using Utilize.ExcelGeneratingClass;

namespace Presentation
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            this.Update();
        }

        private DataGridView _dataGridView;
        public DataGridView GeneralDataGridView
        {
            get { return _dataGridView; }
            set
            {
                _dataGridView = value;
                ERMSLib.clsERMSGeneral.dgvActive = _dataGridView;
            }
        }

        private Infragistics.Win.UltraWinGrid.UltraGrid _dataGridViewUltra;
        public Infragistics.Win.UltraWinGrid.UltraGrid GeneralDataGridViewUltra
        {
            get { return _dataGridViewUltra; }
            set
            {
                _dataGridViewUltra = value;
                //ERMSLib.clsERMSGeneral.dgvActive = _dataGridViewUltra;
            }
        }

        public void ExportToExcel()
        {
            if (_dataGridView == null)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("هشدار", "ليستی برای خروجی وجود ندارد", Presentation.Public.MyDialogButton.OK);
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                var ex = new Presentation.Public.Export();                
                ex.ExportDocument(_dataGridView);
                Cursor = Cursors.Default;
            }
        }

        public void ExportToExcelGAP()
        {
            if (clsERMSGeneral.dgvActive == null)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("هشدار", "ليستی برای خروجی وجود ندارد", Presentation.Public.MyDialogButton.OK);
            }
            else
            {   DataGridView dgv = new DataGridView();

            if (_dataGridView.DataSource != null)
            {
                foreach (DataGridViewColumn c1 in _dataGridView.Columns)
                {
                    DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                    dgv.Columns.Add(c2);
                }

                int i = 0;
                foreach (DataGridViewRow dgvr in _dataGridView.Rows)
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
            Cursor = Cursors.WaitCursor;
            Presentation.Public.Export ex = new Public.Export();
            ex.ExportDocument(clsERMSGeneral.dgvActive);
           
            Cursor = Cursors.Default;
            //DataTable dt = (DataTable)_dataGridView.DataSource;
            //saveExcel("D:\\456.xml", dt);
            }
            
        }



        public void DoPrint()
        {
            var P = new Presentation.Public.Printer();
            if (_dataGridView == null && _dataGridViewUltra == null)
            {
                Presentation.Public.Routines.ShowErrorMessageFa("اخطار", "ليستی برای چاپ وجود ندارد", Presentation.Public.MyDialogButton.OK);
            }
            else
            {
                var frmInputText = new Utilize.frmInputText() { Text = "عنوان گزارش" };
                if (frmInputText.ShowDialog() == DialogResult.OK)
                {
                    //Infragistics.Win.UltraWinGrid.UltraGrid dgv = new UltraGrid();
                    DataTable dt2 = new DataTable();
                    DataTable dt = new DataTable();

                    if (_dataGridView != null)
                    {
                        if (_dataGridView.DataSource is System.Data.DataTable)
                        {
                            dt2 = (DataTable)_dataGridView.DataSource;
                            dt = dt2.Copy();
                        }
                        else if (_dataGridView.DataSource is BindingSource)
                        {
                            BindingSource theBindingSource = (BindingSource)_dataGridView.DataSource;
                            if (theBindingSource.DataSource is DataSet)
                            {
                                dt2 = ((DataSet)theBindingSource.DataSource).Tables[0];
                            }
                            else
                            {
                                dt2 = theBindingSource.DataSource as DataTable;
                            }
                            dt = dt2.Copy();
                        }
                        else
                        {
                            dt2 = (DataTable)_dataGridView.DataSource;
                            dt = dt2.Copy();
                        }


                        for (int i = _dataGridView.Columns.Count - 1; i >= 0; i--)
                        {
                            if (_dataGridView.Columns[i].HeaderText != null && _dataGridView.Columns[i].HeaderText.Length > 0)
                                dt.Columns[i].ColumnName = _dataGridView.Columns[i].HeaderText;
                            if (_dataGridView.Columns[i].Visible == false)
                                if (dt.Columns.CanRemove(dt.Columns[i]))
                                    dt.Columns.RemoveAt(i);
                        }
                    }
                    else if (_dataGridViewUltra != null)
                    {
                        dt2 = (DataTable)_dataGridViewUltra.DataSource;
                        dt = dt2.Copy();
                        //for (int i = _dataGridViewUltra. Columns.Count - 1; i >= 0; i--)
                        //{
                        //    if (_dataGridView.Columns[i].HeaderText != null && _dataGridView.Columns[i].HeaderText.Length > 0)
                        //        dt.Columns[i].ColumnName = _dataGridView.Columns[i].HeaderText;
                        //    if (_dataGridView.Columns[i].Visible == false)
                        //        dt.Columns.RemoveAt(i);
                        //}
                    }
                    Utilize.Company.BaseForm b = new Utilize.Company.BaseForm();

                    b.dgvForPrint.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(ultraGrid1_InitializeLayout);

                    b.dgvForPrint.DataSource = dt;
                    b.dgvForPrint.DataBind();
                    b.dgvForPrint.DisplayLayout.Override.HeaderAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
                    b.dgvForPrint.DisplayLayout.Override.HeaderAppearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(156)))), ((int)(((byte)(11)))));
                    b.dgvForPrint.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    //dgv.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
                    //this.Controls.Add(dgv);
                    ultraGridPrintDocument.Grid = b.dgvForPrint;
                    ultraGridPrintDocument.Header.TextCenter = frmInputText.ReturnValue;
                    //this.Controls.Remove(dgv);
                    ultraPrintPreviewDialog.ShowDialog();
                }
                


                //if (P.SetupThePrinting(_dataGridView))
                //    P.PrintDocument();
            }
        }
        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.EntireColumn;
            //dgvForPrint.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.EntireColumn;
            foreach (var s in e.Layout.Bands[0].Columns)
            {
                s.PerformAutoResize();
                s.Width += 8;
            }
        }


        public void DoPrintGAP()
        {
       
              DataGridView dgv = new DataGridView();
             
                if (_dataGridView.DataSource != null)
                {
                    foreach (DataGridViewColumn c1 in _dataGridView.Columns)
                    {
                        DataGridViewColumn c2 = (DataGridViewColumn)c1.Clone();
                        dgv.Columns.Add(c2);
                    }

                    int i = 0;
                    foreach (DataGridViewRow dgvr in _dataGridView.Rows)
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
                    Presentation.Public.Printer P = new Public.Printer();
                    if (clsERMSGeneral.dgvActive == null)
                    { Presentation.Public.Routines.ShowErrorMessageFa("اخطار", "ليستی برای چاپ وجود ندارد", Presentation.Public.MyDialogButton.OK); }
                    else 
                    {
                        if 
                            (P.SetupThePrinting(clsERMSGeneral.dgvActive))
                            P.PrintDocument();
                    }
                   
                }
          
            
        }


        private void BaseForm_Load(object sender, System.EventArgs e)
        {
            ChangeLanguage("farsi");
        }

        private void ultraGridPrintDocument_PagePrinting(object sender, Infragistics.Win.Printing.PagePrintingEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.LogoPrint,
                                e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Right -
                                Properties.Resources.LogoPrint.Size.Width, 10);
        }

        private InputLanguage GetFarsiLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "farsi" || lang.LayoutName.ToLower() == "persian")
                    return lang;
            }
            return null;
        }

        private InputLanguage GetEnglishLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "English")
                    return lang;
            }
            return null;
        }

        public void ChangeLanguage(string strlang)
        {
            if (strlang.Equals("farsi"))
            {
                InputLanguage lang = GetFarsiLanguage();
                if (lang == null)
                {
                    return;
                }
                InputLanguage.CurrentInputLanguage = lang;
            }
            else
            {
                InputLanguage lang = GetEnglishLanguage();
                if (lang == null)
                {
                    return;
                }
                InputLanguage.CurrentInputLanguage = lang;
            }
        }
    }
}
