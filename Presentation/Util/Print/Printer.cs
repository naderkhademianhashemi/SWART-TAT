using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Util
{
    public class Printer
    {
        PrintDocument prtDocument;
        PrintPreviewDialog prtPreviewDialog;
        DataGridViewPrinter dgvPrinter;

        public Printer()
        {
            prtDocument = new PrintDocument();
            prtDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prtDocument_PrintPage);

            prtPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            prtPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            prtPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            prtPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            prtPreviewDialog.Document = this.prtDocument;
            prtPreviewDialog.Enabled = true;
            prtPreviewDialog.Name = "prtPreviewDialog";
            prtPreviewDialog.Visible = false;

        }

        public Printer(System.Windows.Forms.DataGridView dgv)
        {
            prtDocument = new PrintDocument();
            prtDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prtDocument_PrintPage);
            prtPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            prtPreviewDialog.Document = this.prtDocument;

            dgvPrinter = new DataGridViewPrinter(dgv, prtDocument, true, true, "", null, System.Drawing.Color.Black, true);
        }
       
        public bool SetupThePrinting()
        {
            PrintDialog prtDialog = new PrintDialog();
            
            if (prtDialog.ShowDialog() != DialogResult.OK)
                return false;

            prtDocument.DocumentName = "grd";
            
            return true;
        }
        public void PrintDocument()
        {
            prtPreviewDialog.ShowDialog();
        }
        public void prtDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = dgvPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        public void Draw(DataGridView DGV, PrintPageEventArgs e)
        {
            var curdhead = "Print Grid";
            e.Graphics.DrawString(curdhead, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, x: 350, y: 50);

            var height = 100;
            for (int l = 0; l < DGV.Rows.Count; l++)
            {
                height += DGV.Rows[0].Height;
                e.Graphics.DrawString(DGV.Rows[l].Cells[0].FormattedValue.ToString(), DGV.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(80, height, DGV.Columns[0].Width, DGV.Rows[0].Height));
            }
        }

    }
}
