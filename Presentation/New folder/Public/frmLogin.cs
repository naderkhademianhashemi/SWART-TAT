using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Utilize;
using Utilize.Helper;
using DAL.Table_DataSetTableAdapters;

namespace Presentation.Public
{
    public partial class frmLogin : Form
    {
        private readonly SqlConnection _sqlConnection;
        private readonly string strTable;
        private readonly string strName;
        private readonly string strPass;

        public frmLogin(string conString, string NameOfTableUsers, string nameU, string nameP)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            _sqlConnection = new SqlConnection(conString);
            strTable = NameOfTableUsers;
            strName = nameU;
            strPass = nameP;
            LoginBG ch = new LoginBG();
            ch.Show();
            //this.TopMost = true;
            this.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(false);
        }


        public void Login(bool PassUser)
        {
            try
            {
                if (txtUserName.Text.Trim().IsNullOrEmptyByTrim() || txtPassword.Text.Trim().IsNullOrEmptyByTrim())
                {
                    this.TopMost = false;
                    Routines.ShowErrorMessageFa("خطا در ورود اطلاعات", "نام کاربری / رمز عبور وارد نشده است.",
                                                MyDialogButton.OK);
                    ChangeLanguage("English");
                    this.TopMost = true;
                    return;
                }
                var user = new DAL.SwartDataSetTableAdapters.UsersTableAdapter().GetDataByCheckUser(txtUserName.Text.Trim(),
                                                                                               txtPassword.Text.Trim()).FirstOrDefault();
                if (user == null)
                {
                    this.TopMost = false;
                    Routines.ShowErrorMessageFa("خطا در ورود کاربر", "نام کاربری / رمز عبور صحیح نیست.",
                                                MyDialogButton.OK);
                    ChangeLanguage("English");
                    this.TopMost = true;
                    return;
                }
                if (user.User_LoginStatus == true && !PassUser)
                {
                    Routines.ShowMessageBoxFa("این نام کاربری در سیستم دیگری در حال استفاده است" + "\n" +
                                                    "امکان استفاده همزمان از یک نام کاربری وجود ندارد", "هشدار",
                                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ChangeLanguage("English");
                    return;
                }
                ERMS.Model.GlobalInfo.UserID = user.User_Id;
                ERMS.Model.GlobalInfo.ProfileID =
                    new DAL.SwartDataSetTableAdapters.ProfileTableAdapter().GetDataByProfile_Id(user.Act_Profile_Id).
                        FirstOrDefault().ID;
                ERMS.Model.GlobalInfo.UserName = user.User_Name;
                ERMS.Model.GlobalInfo.User_Group_Id = user.User_Group_Id;
                
                // set user login Status
                UsersTableAdapter Users_TableAdapter = new UsersTableAdapter();
                Users_TableAdapter.UpdateUserLoginStatus(user.User_Id, 1);

                Close();
                return;
            }
            catch (Exception exception)
            {
                this.TopMost = false;
                exception.ConfigLog(true);
                this.TopMost = true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //#if DEBUG
            //            Application.ThreadException += Application_ThreadException;
            //            System.Threading.Thread.CurrentThread.Abort();
            //#else
            //            Application.Exit();
            //#endif


            //#if DEBUG
            //            Application.ThreadException += Application_ThreadException;
            //            System.Threading.Thread.CurrentThread.Abort();
            //#endif
            //Application.ThreadException += Application_ThreadException;
            //System.Threading.Thread.CurrentThread.Abort();

            //this.Close();
            // set user login Status
            //if (GlobalInfo.UserID != null && GlobalInfo.UserID != 0 && GlobalInfo.UserID != -1)
            //{
            //    UsersTableAdapter Users_TableAdapter = new UsersTableAdapter();
            //    Users_TableAdapter.UpdateUserLoginStatus(false, GlobalInfo.UserID);
            //}
            this.TopMost = false;
            Application.Exit();
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.TransparencyKey = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
            this.Update();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            btnLogin_Click(sender, null);
        }

        private void cbOK_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            lblVersion.Visible = true;
        }

        private InputLanguage GetFarsiLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName.ToLower() == "farsi" || lang.LayoutName.ToLower() == "persian")
                    return lang;
            }
            return null;
        }

        private InputLanguage GetEnglishLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.Name.Contains("en"))
                    return lang;
            }
            return null;
        }

        public void ChangeLanguage(string strlang)
        {
            if (strlang.Equals("farsi"))
            {
                InputLanguage lang = GetFarsiLanguage();
                if (lang == null)
                {
                    return;
                }
                InputLanguage.CurrentInputLanguage = lang;
            }
            else
            {
                InputLanguage lang = GetEnglishLanguage();
                if (lang == null)
                {
                    return;
                }
                InputLanguage.CurrentInputLanguage = lang;
            }
        }

        private void btnPassUser_Click(object sender, EventArgs e)
        {
            Login(true);
        }
    }
}
