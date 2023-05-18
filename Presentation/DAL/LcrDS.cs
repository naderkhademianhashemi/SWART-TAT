using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Presentation.DAL
{
    public class LcrDS
    {
        public System.Data.DataTable GetDT(string[] cols)
        {
            var DT = new System.Data.DataTable();
            foreach (var col in cols)
            {
                var COL = new DataColumn();
                COL.DataType = System.Type.GetType("System.Int32");
                COL.ColumnName = col;
                DT.Columns.Add(COL);
            }
            for (int i = 0; i < 2; i++)
            {
                var row = DT.NewRow();
                var j = 0;
                foreach (var item in cols)
                {
                    row[j++] = "1";
                }
                DT.Rows.Add(row);
            }
            return DT;
        }
    }
}
