using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilize.Company
{
    public partial class BaseForm : Form
    {
        private bool _IsTransparentEnable;
        public bool IsTransparentEnable
        {
            get { return _IsTransparentEnable; }
            set
            {
                _IsTransparentEnable = value;
                if (_IsTransparentEnable)
                {
                    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                    this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
                    this.Update();
                }
            }
        }

        private InputLanguageEnum _InputLanguage;
        public bool IsDockFill { get; set; }

        public InputLanguageEnum InputLanguageForm
        {
            get { return _InputLanguage; }
            set
            {
                _InputLanguage = value;
                ChangeLanguage();
            }
        }

        public BaseForm()
        {
            InitializeComponent();
            if (IsTransparentEnable)
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                TransparencyKey = Color.FromKnownColor(KnownColor.Control);
                Update();
            }
            Load+=BaseForm_Load;
        }

        void BaseForm_Load(object sender, EventArgs e)
        {
            if (IsDockFill)
            {
                Dock = DockStyle.Fill;
            }
        }

        void BaseForm_Shown(object sender, EventArgs e)
        {
            if (IsDockFill)
            {
                Dock = DockStyle.Fill;
            }
        }

        private void SetFarsiLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "farsi" || lang.LayoutName.ToLower() == "persian")
                {
                    InputLanguage.CurrentInputLanguage = lang;
                    break;
                }
            }
        }

        private void SetEnglishLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "English")
                {
                    InputLanguage.CurrentInputLanguage = lang;
                    break;
                }
            }
        }

        private void ChangeLanguage()
        {
            switch (_InputLanguage)
            {
                case InputLanguageEnum.Persian:
                    SetFarsiLanguage();
                    break;
                case InputLanguageEnum.English:
                    SetEnglishLanguage();
                    break;
                default:
                    SetEnglishLanguage();
                    break;
            }
        }
    }
}
