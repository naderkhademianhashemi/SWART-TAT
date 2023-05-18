using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Util
{
    public class Import
    {
        OpenFileDialog ofd;

        public Import()
        {
            ofd = new OpenFileDialog();
        }

        public string GetPath(string FileName)
        {
            var path = "";
            ofd.Title = "Select file";
            ofd.InitialDirectory = @"d:\";
            ofd.FileName = FileName;
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
                path = ofd.FileName;
            return path;
        }
    }
}
