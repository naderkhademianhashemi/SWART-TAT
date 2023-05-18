using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Presentation.Tabs.BasicInfo
{
    public class Common
    {
        public static  DataTable Grid2TableSearch(System.Windows.Forms.DataGridView dgv)
        {
            DataTable dt = new DataTable();

            DataColumn dcolFarsiField = new DataColumn("FarsiField", typeof(System.String));
            dt.Columns.Add(dcolFarsiField);

            DataColumn dcolField = new DataColumn("Field", typeof(System.String));
            dt.Columns.Add(dcolField);

            DataColumn dcolType = new DataColumn("Type", typeof(System.String));
            dt.Columns.Add(dcolType);

            foreach (System.Windows.Forms.DataGridViewColumn dcv in dgv.Columns)
            {
                if (dcv.Visible)
                {
                    if (dcv.Name.ToString() != "dummy" && dcv.Name.ToString() != "Row")
                    {
                        DataRow dr = dt.NewRow();
                        dr["FarsiField"] = dcv.HeaderText;
                        dr["Field"] = dcv.Name.ToString();
                        dr["Type"] = dcv.ValueType.ToString();
                        dt.Rows.Add(dr);
                    }
                }

            }
            return dt;
        }
    }
}
