using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.DAL
{
    public class GapDS
    {
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
    }
}
