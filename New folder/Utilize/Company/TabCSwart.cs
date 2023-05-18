namespace Utilize.Company
{
    public partial class TabCSwart : System.Windows.Forms.UserControl
    {
        [System.ComponentModel.DefaultValue(false)]
        private bool _selected;
        [System.ComponentModel.Category("CheckControl")]
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                if (_selected && _SelectedImage != null)
                    ConfImage(_SelectedImage);
                else
                    ConfImage(_DefaultImage);
            }
        }

        private void ConfImage(System.Drawing.Image image)
        {
            picTab.Image = image;
            this.Size = picTab.Size;
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
        private System.Drawing.Image _SelectedImage;
        [System.ComponentModel.Category("Images")]
        public System.Drawing.Image SelectedImage
        {
            get { return _SelectedImage; }
            set { _SelectedImage = value; }
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

        public TabCSwart()
        {
            InitializeComponent();
        }

        [System.ComponentModel.Category("CompuCo Event")]
        public event System.EventHandler<System.EventArgs> TabSwartClicked;
        private void picTab_Click(object sender, System.EventArgs e)
        {
            if (TabSwartClicked != null)
                TabSwartClicked.Invoke(this, e);
            _selected = true;
            ConfImage(_SelectedImage);

        }

        private void picTab_MouseEnter(object sender, System.EventArgs e)
        {
            if (_selected == false)
                ConfImage(_HoverImage);
        }

        private void picTab_MouseLeave(object sender, System.EventArgs e)
        {
            if (_selected == false)
                ConfImage(_DefaultImage);
        }
    }
}
