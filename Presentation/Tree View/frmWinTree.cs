using Presentation.Public.MyControls.TreeViewEx;
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
    public partial class frmWinTree : Form
    {
        public frmWinTree()
        {
            InitializeComponent();
        }

        private void frmWinTree_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            TreeNode RND = new TreeNode();
            RND.Text = "root";
            treeView1.Nodes.Add(RND);

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
