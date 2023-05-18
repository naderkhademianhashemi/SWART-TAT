using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ERMS.Logic;


namespace Presentation.Miscs
{
    public class CheckDependents
    {
        public static DialogResult Show(string item, string value)
        {
            Application.DoEvents();
            DataTable dt = CheckDep.Check(item, value);
            if (dt == null || dt.Rows.Count == 0)
                return DialogResult.None;

            frmCheckDependents fx = new frmCheckDependents();            
            fx.Items = dt;
            return fx.ShowDialog();
        }
    }
}
