using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Tree_View
{
    public partial class frmTree : Form
    {
        public frmTree()
        {
            InitializeComponent();
        }

        private void frmTree_Load(object sender, EventArgs e)
        {
            treeViewEx1.Nodes.Clear();
            TreeNode RND = new TreeNode();
            RND.Text = "root";
            treeViewEx1.Nodes.Add(RND);

            var lst = new List<string>() { "1", "2" };
            foreach (var item in lst)
            {
                TreeNode ND = new TreeNode();
                ND.Text = item;
                ND.Tag = item;
                RND.Nodes.Add(ND);
            }
        }
    }
}
