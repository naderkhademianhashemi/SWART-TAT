using System;
using DevComponents.DotNetBar;

namespace Presentation
{
    public class MyForm : System.Windows.Forms.Form
    {
        protected int ThemeIndex;

        protected System.Drawing.Color ColorHint;
        protected bool IsExpand;
        protected StyleManager manager;
        protected RibbonControl RibbonControl;

        protected override void OnLoad(EventArgs e)
        {
            manager.Initialize(out ThemeIndex, out ColorHint,out IsExpand,RibbonControl);
            base.OnLoad(e);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            MngTheme.SaveCustomize(ThemeIndex,ColorHint,IsExpand);
        }
    }
}
