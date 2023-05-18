using System.Collections.Generic;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinTree;

namespace Utilize
{
    public partial class frmShowSelectionItem : Form
    {
        private IEnumerable<Infragistics.Win.ValueListItem> Items;
        public frmShowSelectionItem(string title, IEnumerable<Infragistics.Win.ValueListItem> Items)
        {
            InitializeComponent();
            Text = title;
            this.Items = Items;
        }

        private void frmShowSelectionItem_Load(object sender, System.EventArgs e)
        {
            foreach (var item in Items)
            {
                treeSelectedItem.Nodes.Add(new TreeNode(item.DisplayText));
            }
            treeSelectedItem.Refresh();
        }
    }
}
