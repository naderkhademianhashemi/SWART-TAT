using System;
using System.Windows.Forms;

namespace Utilize.Company
{
    public partial class CButton : System.Windows.Forms.UserControl
    {
        private string _tooltipText = string.Empty;
        public String TooltipText
        {
            set
            {
                _tooltipText = value;
                System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
                toolTip1.SetToolTip(btnCompuco, value);
            }
        }

    

        [System.ComponentModel.DefaultValue(false)]

        private void ConfImage(System.Drawing.Image image)
        {
            btnCompuco.Image = image;
        }

        [System.ComponentModel.DefaultValue(System.Drawing.ContentAlignment.TopCenter)]
        private System.Drawing.ContentAlignment _PicAlignment;
        [System.ComponentModel.Category("Images")]
        public System.Drawing.ContentAlignment PicAlignment
        {
            get { return _PicAlignment; }
            set
            {
                _PicAlignment = value;
                btnCompuco.ImageAlign = value;
            }
        }

        //[System.ComponentModel.DefaultValue(System.Drawing.ContentAlignment.TopCenter)]
        //private System.Drawing.ContentAlignment _TextAlignment;
        //[System.ComponentModel.Category("Images")]
        //public System.Drawing.ContentAlignment TextAlignment
        //{
        //    get { return _TextAlignment; }
        //    set
        //    {
        //        _TextAlignment = value;
        //        btnCompuco.TextAlign = value;
        //    }
        //}

        [System.ComponentModel.DefaultValue(System.Windows.Forms.DialogResult.None)]
        private DialogResult _DialogResult;
        public DialogResult DialogResult
        {
            get
            {
                return _DialogResult;
            }

            set
            {
                if(Enum.IsDefined(typeof(DialogResult), value))                
                {
                    _DialogResult = value;
                }
            }    
        }



        [System.ComponentModel.DefaultValue("")]
        private string _Title;
        [System.ComponentModel.Category("Images")]
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                btnCompuco.Text = _Title;
            }
        }

        [System.ComponentModel.DefaultValue(null)]
        private System.Drawing.Image _HoverImage;
        [System.ComponentModel.Category("Images")]
        public System.Drawing.Image HoverImage
        {
            get { return _HoverImage; }
            set { _HoverImage = value; }
        }


        [System.ComponentModel.DefaultValue(null)]
        private System.Drawing.Image _DefaultImage;
        [System.ComponentModel.Category("Images")]
        public System.Drawing.Image DefaultImage
        {
            get { return _DefaultImage; }
            set
            {
                _DefaultImage = value;
                ConfImage(_DefaultImage);
            }
        }

        public CButton()
        {
            InitializeComponent();
        }

        [System.ComponentModel.Category("CompuCo Event")]
        public event System.EventHandler<System.EventArgs> CButtonClicked;
        private void btnCompuco_Click(object sender, System.EventArgs e)
        {
            if (CButtonClicked != null)
            {
                CButtonClicked.Invoke(this, e);
            }
        }

        private void btnCompuco_MouseEnter(object sender, System.EventArgs e)
        {
            ConfImage(_HoverImage);
        }

        private void btnCompuco_MouseLeave(object sender, System.EventArgs e)
        {
            ConfImage(_DefaultImage);        
        }
    }
}
