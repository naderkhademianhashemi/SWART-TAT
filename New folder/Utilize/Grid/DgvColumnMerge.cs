using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Utilize.Grid
{
    public partial class DgvColumnMerge : DataGridView
    {

        public int startCol = 0, endCol = 0;
        public string[] upHeader;
        //= { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر","آبان", "آذر", "دی", "بهمن", "اسفند"};


        public DgvColumnMerge()
        {
            InitializeComponent();


        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);

            
            for (int j = 1; j < this.ColumnCount; j++)
            {
                this.Columns[j].HeaderText = ((DataTable)this.DataSource).Columns[j].Caption;



            }

            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.ColumnHeadersHeight = this.ColumnHeadersHeight * 3;

            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            

        }
        protected override void OnColumnWidthChanged(DataGridViewColumnEventArgs e)
        {
            base.OnColumnWidthChanged(e);

            Rectangle rtHeader = this.DisplayRectangle;

            rtHeader.Height = this.ColumnHeadersHeight / 2;

            this.Invalidate(rtHeader);
        }



        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);
            Rectangle rtHeader = this.DisplayRectangle;

            rtHeader.Height = this.ColumnHeadersHeight / 2;

            //this.Invalidate(rtHeader);

            //this.Refresh();
        }


        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            base.OnCellPainting(e);
           /* if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {

                Rectangle r2 = e.CellBounds;

                r2.Y += e.CellBounds.Height / 2;

                r2.Height = e.CellBounds.Height / 2;



                e.PaintBackground(r2, true);



                e.PaintContent(r2);

                e.Handled = true;

            }*/


            for (int j = startCol; j < this.endCol; )
            {

                Rectangle r1 = this.GetCellDisplayRectangle(j, -1, true);

                int w2 = this.GetCellDisplayRectangle(j + 1, -1, true).Width;

                r1.X += 1;

                r1.Y += 1;

                r1.Width = r1.Width + w2 - 2;

                r1.Height = r1.Height / 2 - 2;

                e.Graphics.FillRectangle(new SolidBrush(this.ColumnHeadersDefaultCellStyle.BackColor), r1);

                StringFormat format = new StringFormat();

                format.Alignment = StringAlignment.Center;

                format.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(upHeader[(j - startCol) / 2],

                    this.ColumnHeadersDefaultCellStyle.Font,

                    new SolidBrush(this.ColumnHeadersDefaultCellStyle.ForeColor),

                    r1,

                    format);
                j += 2;

            }
        }

        private readonly Image mainImag;
        /*protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            for (int j = startCol; j < this.endCol; )
            {

                Rectangle r1 = this.GetCellDisplayRectangle(j, -1, true);

                int w2 = this.GetCellDisplayRectangle(j + 1, -1, true).Width;

                r1.X += 1;

                r1.Y += 1;

                r1.Width = r1.Width + w2 - 2;

                r1.Height = r1.Height / 2 - 2;

                e.Graphics.FillRectangle(new SolidBrush(this.ColumnHeadersDefaultCellStyle.BackColor), r1);

                StringFormat format = new StringFormat();

                format.Alignment = StringAlignment.Center;

                format.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(upHeader[(j - startCol) / 2],

                    this.ColumnHeadersDefaultCellStyle.Font,

                    new SolidBrush(this.ColumnHeadersDefaultCellStyle.ForeColor),

                    r1,

                    format);
                j += 2;

            }

        }*/
    }
}
