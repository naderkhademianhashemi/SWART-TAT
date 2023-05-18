using System.Linq;
using Infragistics.Win;
using System.Data;
using System;

namespace Utilize.Company
{
    public sealed class CComboCox : Infragistics.Win.UltraWinEditors.UltraComboEditor
    {
        readonly Infragistics.Win.Appearance appearanceBase = new Infragistics.Win.Appearance();
        readonly Infragistics.Win.Appearance appearanceButton = new Infragistics.Win.Appearance();
        readonly Infragistics.Win.Appearance appearanceItem = new Infragistics.Win.Appearance();

        public CComboCox()
        {

            appearanceBase.BackColor = System.Drawing.Color.FromArgb(244, 232, 192);
            appearanceBase.BackColor2 = System.Drawing.Color.FromArgb(244, 232, 192);
            appearanceBase.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearanceBase.BorderColor = System.Drawing.Color.FromArgb(244, 232, 192);
            appearanceBase.ImageBackground = Properties.Resources.S_Combo;
            appearanceBase.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.Appearance = appearanceBase;
            this.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.DiagonalResize;
            this.BackColor = System.Drawing.Color.FromArgb(244, 232, 192);
            this.AutoSize = false;
            //////////////////////
            //appearanceButton.BackColor = System.Drawing.Color.RosyBrown;
            //appearanceButton.BackColor2 = System.Drawing.Color.Red;
            //appearanceButton.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            //appearanceButton.BackColorDisabled = System.Drawing.Color.Red;
            //appearanceButton.BackColorDisabled2 = System.Drawing.Color.Red;
            //appearanceButton.BorderColor = System.Drawing.Color.Red;
            //appearanceButton.BorderColor2 = System.Drawing.Color.Red;
            //appearanceButton.BorderColor3DBase = System.Drawing.Color.Red;
            //appearanceButton.ImageBackground = global::Utilize.Properties.Resources.S_Arrow_Combo;
            //appearanceButton.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            ////////////////////
            appearanceButton.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearanceButton.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearanceButton.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearanceButton.ImageBackground = Properties.Resources.S_ArrowCombo_Hor;
            appearanceButton.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            //appearanceButton.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            //appearanceButton.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            //appearanceButton.BorderColor = System.Drawing.Color.FromArgb(244, 232, 192);
            //appearanceButton.BorderColor2 = System.Drawing.Color.FromArgb(244, 232, 192);
            //appearanceButton.BorderColor3DBase = System.Drawing.Color.FromArgb(244, 232, 192);
            //appearanceButton.ForeColor = System.Drawing.Color.FromArgb(244, 232, 192);
            //appearanceButton.ForeColorDisabled = System.Drawing.Color.FromArgb(244, 232, 192);
            //appearanceButton.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            //appearanceButton.ImageBackground = Properties.Resources.S_Arrow_Combo;
            //appearanceButton.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Centered;
            this.ButtonAppearance = appearanceButton;
            this.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.DropDownButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.HideSelection = false;
            appearanceItem.BackColor = System.Drawing.Color.FromArgb(245, 224, 197);
            appearanceItem.BackColor2 = System.Drawing.Color.FromArgb(254, 251, 245);
            appearanceItem.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20;
            appearanceItem.BorderColor = System.Drawing.Color.FromArgb(181, 152, 102);
            this.ItemAppearance = appearanceItem;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Size = new System.Drawing.Size(69, 22);

            this.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        }

        public object SelectedValue
        {
            get
            {
                if (this.SelectedItem == null)
                    return null;
                return this.SelectedItem.DataValue; 
            }
           //set { this.SelectedItem.DataValue = value; }
        }

        public bool SelectedByDataValue(object value)
        {
            try
            {
                var sitem =
                                this.Items.Cast<Infragistics.Win.ValueListItem>().Where(
                                    item => item.DataValue.ToString().Equals(value.ToString())).
                                    FirstOrDefault();
                this.SelectedItem = sitem;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SetDefaultCurrency(string Currency)
        {
            try
            {
                int RialId = -1;
                foreach (DataRow dr in ((DataTable)this.DataSource).Rows)
                {
                    if (dr["Currency_Description"].ToString() == Currency)
                        RialId = int.Parse(dr["Currency"].ToString());
                }
                if(RialId != -1)
                    this.SelectedByDataValue(RialId);
            }
            catch(Exception ex)
            {
            }
        }

        public bool AddItemsRange(string[] items)
        {
            try
            {
                foreach (var item in items)
                {
                    this.Items.Add(new ValueListItem(item));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CComboCox));
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CComboCox
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            appearance1.BorderAlpha = Infragistics.Win.Alpha.UseAlphaLevel;
            appearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            appearance1.ImageBackground = global::Utilize.Properties.Resources.S_Combo;
            this.Appearance = appearance1;
            this.BackColor = System.Drawing.Color.Transparent;
            appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ForegroundAlpha = Infragistics.Win.Alpha.Transparent;
            appearance2.ImageBackground = ((System.Drawing.Image)(resources.GetObject("appearance2.ImageBackground")));
            appearance2.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            this.ButtonAppearance = appearance2;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        public string Contains(string p)
        {
            throw new NotImplementedException();
        }
    }
}
