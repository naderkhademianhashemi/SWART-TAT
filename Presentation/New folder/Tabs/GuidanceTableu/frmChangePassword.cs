using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAL.Table_DataSetTableAdapters;
using ERMS.Model;
using Janus.Windows.UI.Tab;
using Utilize;
using Utilize.Helper;
using Presentation.Public;

namespace Presentation.Tabs.GuidanceTableu
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();

            Init();


        }

        private void Init()
        {


        }
        readonly ProfileTableAdapter Profile_TableAdapter = new ProfileTableAdapter();
        readonly UsersTableAdapter Users_TableAdapter = new UsersTableAdapter();
        readonly User_LocationTableAdapter UserLocation_TableAdapter = new User_LocationTableAdapter();

        private int userId;
        private void lnlEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void RefTab(UITabPage tabPage)
        {
            ClearItem();
            tabPage.Selected = true;
        }

        private int CheckPass;
        private void btnSave_ChangePass_Click(object sender, EventArgs e)
        {
            var user = new DAL.SwartDataSetTableAdapters.UsersTableAdapter().GetDataByCheckUser(txtUserName.Text.Trim(),
                                                                                               txtPassCurent.Text.Trim()).FirstOrDefault();
            if (user == null)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا در اطلاعات کاربر", "نام کاربری / رمز عبور فعلی وارد شده صحیح نیست.",
                                            Utilize.MyDialogButton.OK);
                return;
            }
            else if (!txtPassNew.Text.Equals(txtPassNewConfirm.Text))
            {
                Utilize.Routines.ShowErrorMessageFa("خطا در رمز عبور جدید", "رمز عبور جدید وارد شده و تکرار آن صحیح نیست.",
                                            Utilize.MyDialogButton.OK);
                return;
            }
            else if (txtPassNew.Text.Length < 4)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا در رمز عبور جدید", "طول رمز عبور می بایست بیشتر از 3 کاراکتر باشد.",
                                            Utilize.MyDialogButton.OK);
                return;
            }
            else
            {
                //UsersTableAdapter Users_TableAdapter = new UsersTableAdapter();
                Users_TableAdapter.UpdatePassByUserId(txtPassNew.Text, user.User_Id);
                Utilize.Routines.ShowInfoMessageFa("پیام", "رمز عبور جدید ثبت شد.", Utilize.MyDialogButton.OK);
            }

        }

        private void ClearItem()
        {
            CheckPass = 0;
            txtPassNew.Text = txtPassCurent.Text = txtUserName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearItem();
            //tabMain.Visible = false;
        }

        private void frmUserMng_Load(object sender, EventArgs e)
        {
            Helper h = new Helper();

            this.Dock = DockStyle.Fill;

            userId = GlobalInfo.UserID;
            var user = Users_TableAdapter.GetData().Where(item => item.User_Id.Equals(userId)).FirstOrDefault();
            if (user != null)
                txtUserName.Text = user.User_Name;
        }


        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt = new DAL.UserInfo().GetDt_UserInfo();
        }

        private void dgvUserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DAL.UserInfo().GetDt_UserLoginDetails(userId);
        }

        private void frmChangePassword_Paint(object sender, PaintEventArgs e)
        {
            pnl06.Left = (this.Width - pnl06.Width) / 2;
            pnl06.Top = (this.Height - pnl06.Height) / 2;
        }

        


    }
}
