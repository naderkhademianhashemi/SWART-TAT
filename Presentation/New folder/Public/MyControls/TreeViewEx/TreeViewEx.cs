using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Public.MyControls.TreeViewEx
{
    public partial class TreeViewEx : System.Windows.Forms.TreeView
    {
        #region VARS
        private TreeInfoEx tix;
        #endregion

        public TreeViewEx()
        {
            InitializeComponent();

            this.tix = new TreeInfoEx();
            // Warning Error midad cmt kardam : Hosein
            //this.DrawMode = TreeViewDrawMode.OwnerDrawAll;
        }


        public TreeInfoEx TreeInfoEx
        {
            get { return tix; }
            set { tix = value; }
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {           
            Rectangle nodeBound = e.Node.Bounds;
            Rectangle padbound = nodeBound;
            padbound.Inflate(-1, -tix.Width4Padding);
            padbound.Width = tix.Width4MinBox;

            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                using (Brush b = new SolidBrush(Color.FromKnownColor(KnownColor.Highlight)))
                {
                    e.Graphics.FillRectangle(b, padbound);
                    using (Pen p = new Pen(Color.Gray, tix.Width4Border))
                    {
                        p.DashStyle = DashStyle.Dot;
                        e.Graphics.DrawRectangle(p, padbound);
                        e.Graphics.DrawLine(new Pen(Brushes.LightGray, tix.Width4Shadow), padbound.Right + 2, padbound.Top + 2, padbound.Right + 2, padbound.Bottom + 2 + 2);
                        e.Graphics.DrawLine(new Pen(Brushes.LightGray, tix.Width4Shadow), padbound.Left + 2, padbound.Bottom + 2, padbound.Right + 2 + 2, padbound.Bottom + 2);
                    }
                }
            }
            else
            {
                if (e.Node.BackColor.IsEmpty)
                    e.Node.BackColor = Color.LightBlue;

                using (Brush b = new LinearGradientBrush(padbound, Color.White, e.Node.BackColor, LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(b, padbound);
                    using (Pen p = new Pen(e.Node.BackColor, tix.Width4Border))
                    {
                        e.Graphics.DrawRectangle(p, padbound);
                        e.Graphics.DrawLine(new Pen(Brushes.LightGray, tix.Width4Shadow), padbound.Right + 2, padbound.Top + 2, padbound.Right + 2, padbound.Bottom + 2 + 2);
                        e.Graphics.DrawLine(new Pen(Brushes.LightGray, tix.Width4Shadow), padbound.Left + 2, padbound.Bottom + 2, padbound.Right + 2 + 2, padbound.Bottom + 2);
                    }
                }
            }

            using (Font font = ((e.State & TreeNodeStates.Selected) == 0) ? new Font(e.Node.TreeView.Font, FontStyle.Regular) : new Font(e.Node.TreeView.Font, FontStyle.Bold))
            {
                Rectangle textBound = padbound;
                textBound.Inflate(-20, 0);
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = sf.LineAlignment = StringAlignment.Center;
                    sf.FormatFlags = StringFormatFlags.NoWrap;
                    sf.Trimming = StringTrimming.EllipsisPath;                    
                    
                    if (e.Node.ForeColor.IsEmpty)
                        e.Node.ForeColor = Color.Black;

                    using (Brush fontbrush = new SolidBrush(e.Node.ForeColor))
                    {
                        e.Graphics.DrawString(e.Node.Text, font, fontbrush, textBound, sf);
                    }
                }
            }

            //Node Lines and PlusMinus Indicators
            int iconDim = 16;
            using (Pen pen = new Pen(Color.Black, 1F))
            {
                pen.DashStyle = DashStyle.Dot;

                TreeNode tn = e.Node;
                TreeNode tnParent = e.Node.Parent;
                while (tnParent != null)
                {
                    int left = tnParent.Bounds.Left + Indent / 2;
                    if (tn.NextNode != null)
                        e.Graphics.DrawLine(pen, left, nodeBound.Top, left, nodeBound.Bottom);

                    if (tnParent == e.Node.Parent)
                        e.Graphics.DrawLine(pen, left, nodeBound.Top, left, nodeBound.Bottom - ItemHeight / 2);

                    tn = tnParent;
                    tnParent = tnParent.Parent;
                }
                

                //Horizontal Line
                if ((e.Node.Parent != null) || e.Node.Nodes.Count > 0)
                    e.Graphics.DrawLine(pen, nodeBound.Left - Indent / 2, nodeBound.Top + nodeBound.Height / 2, nodeBound.Left, nodeBound.Top + nodeBound.Height / 2);

                if (e.Node.Nodes.Count > 0)
                {
                    Bitmap icon = e.Node.IsExpanded ? global::Presentation.Properties.Resources.Minus : global::Presentation.Properties.Resources.Plus;                    
                    e.Graphics.DrawImage(icon, nodeBound.Left - Indent / 2 - iconDim / 2 + 2, nodeBound.Top + (ItemHeight / 2 - iconDim / 2));
                }
            }            
        }
        protected override void OnBeforeSelect(TreeViewCancelEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
                e.Cancel = true;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            TreeNode tn = this.GetNodeAt(10, e.Y);
            if (tn != null)
                if (e.X >= tn.Bounds.Left && e.X <= tn.Bounds.Left + tix.Width4MinBox)
                    this.SelectedNode = tn;
        }
    }

    public class TreeInfoEx
    {
        public int Width4MinBox = 160;
        public float Width4Shadow = 3F;
        public float Width4Border = 1F;
        public int Width4Padding = 5;
    }
}
