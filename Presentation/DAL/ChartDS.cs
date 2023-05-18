using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.DAL
{
    public class ChartDS
    {
        public System.Data.DataTable GetDT5Row()
        {
            var DT = new System.Data.DataTable();

            var COL = new DataColumn();
            COL.DataType = System.Type.GetType("System.Int32");
            COL.ColumnName = "Row2";
            DT.Columns.Add(COL);

            for (int i = 5; i > 0; i--)
            {
                var row = DT.NewRow();
                row["Row2"] = 1234567;
                DT.Rows.Add(row);
            }
            return DT;
        }
        public System.Data.DataTable GetDT()
        {
            var DT = new System.Data.DataTable();

            var COL = new DataColumn();
            COL.DataType = System.Type.GetType("System.Int32");
            COL.ColumnName = "Row";
            DT.Columns.Add(COL);

            for (int i = 10; i > 0; i--)
            {
                var row = DT.NewRow();
                row["Row"] = i;
                DT.Rows.Add(row);
            }
            return DT;
        }

        public System.Data.DataTable GetDTByCol(string ColName)
        {
            var DT = new System.Data.DataTable();

            var COL = new DataColumn()
            {
                DataType = System.Type.GetType("System.Int32"),
                ColumnName = ColName,
            };
            DT.Columns.Add(COL);

            for (int i = 5; i > 0; i--)
            {
                var row = DT.NewRow();
                row[ColName] = i;
                DT.Rows.Add(row);
            }
            return DT;
        }
    }
}
