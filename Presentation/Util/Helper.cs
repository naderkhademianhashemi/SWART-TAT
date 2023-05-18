using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentation.Util
{
    public class Helper
    {
        public void FormatDataGridView(System.Windows.Forms.DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 18;
            dgv.RowTemplate.Height = 20;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            System.Windows.Forms.DataGridViewCellStyle style = new System.Windows.Forms.DataGridViewCellStyle();
            style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            dgv.RowsDefaultCellStyle = style;
            dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AllowUserToResizeColumns = true;
        }

        internal void FormatDataGridView(Infragistics.Win.UltraWinGrid.UltraGrid ugSWARTReport)
        {
            throw new NotImplementedException();
        }
    }
}
