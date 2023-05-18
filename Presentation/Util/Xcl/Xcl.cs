using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Presentation.Util
{
    public class Xcl
    {
        public void EditXcell(XLWorkbook workbook,SheetModel sheet)
        {
            workbook.Worksheets.Worksheet(sheet.sheetId).
                Cell(sheet.cellRow, sheet.cellCol).
                SetValue(sheet.cellValue.ToString());
        }
        public System.Data.DataTable ToDT(string sheetName, string path)
        {
            var X = RSRC.Setting.Prvdr + path;
            var Y = RSRC.Setting.CNS;
            var CNS = X + Y;
            var CN = new OleDbConnection(CNS);
            var CMD = new OleDbCommand("Select * From [" + sheetName + "$]", CN);
            var ADP = new OleDbDataAdapter(CMD);
            var DT = new System.Data.DataTable();
            ADP.Fill(DT);
            return DT;
        }

        public System.Data.DataSet ToDS(XLWorkbook workbook, string path)
        {
            var DS = new System.Data.DataSet();
            var X = RSRC.Setting.Prvdr + path;
            var Y = RSRC.Setting.CNS;
            var CNS = X + Y;
            foreach (var sheet in GetLstSheets(workbook))
            {
                var DT = new System.Data.DataTable();
                var CN = new OleDbConnection(CNS);
                var CMD = new OleDbCommand("Select * From [" + sheet + "$]", CN);
                var ADP = new OleDbDataAdapter(CMD);
                ADP.Fill(DT);
                DS.Tables.Add(DT);
            }
            return DS;
        }

        private List<string> GetLstSheets(XLWorkbook workbook)
        {
            var lstSheets = new List<string>();
            foreach (var sheet in workbook.Worksheets)
            {
                lstSheets.Add(sheet.Name);
            }
            return lstSheets;
        }
    }

    public class SheetModel
    {
        internal string sheetId;
        internal int cellCol;
        internal int cellRow;
        internal object cellValue;
    }
}
