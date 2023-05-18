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
    public partial class frmUserMng : Form
    {
        public frmUserMng()
        {
            InitializeComponent();

            Init();


        }

        private void Init()
        {
            try
            {
                #region State And Organization

                var state_DataTable = new DAL.GeneralDataSetTableAdapters.StateTableAdapter().GetData();
                ucfState.DisplayMember = "State_Name";
                ucfState.ValueMember = "State_Id";
                ucfState.DataSource = state_DataTable;
                ucfState.CheckedChanged += ucfState_CheckedChanged;

                var organization_DataTable = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();

                ucfOrganization.DisplayMember = "Branch_Description";
                ucfOrganization.ValueMember = "Branch";
                ucfOrganization.DataSource = organization_DataTable;
                ucfOrganization.DropDownOpening += ucfOrganization_DropDownOpening;

                var state1_DataTable = new DAL.GeneralDataSetTableAdapters.StateTableAdapter().GetData();
                ucfStateEdit.DisplayMember = "State_Name";
                ucfStateEdit.ValueMember = "State_Id";
                ucfStateEdit.DataSource = state1_DataTable;
                ucfStateEdit.CheckedChanged += ucfStateEdit_CheckedChanged;

                var organization1_DataTable = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();

                ucfBranchEdit.DisplayMember = "Branch_Description";
                ucfBranchEdit.ValueMember = "Branch";
                ucfBranchEdit.DataSource = organization1_DataTable;
                ucfBranchEdit.DropDownOpening += ucfBranchEdit_DropDownOpening;


                cmbgroupuser.DisplayMember = "GroupName";
                cmbgroupuser.ValueMember = "ID";
                cmbgroupuser.DataSource = new GroupsTableAdapter().GetDataAll();



                #endregion
            }
            catch (Exception exception)
            {


                exception.ConfigLog(false, "خطا در بارگزاری داده رخ");
                Close();
            }


        }
        readonly ProfileTableAdapter Profile_TableAdapter = new ProfileTableAdapter();
        readonly UsersTableAdapter Users_TableAdapter = new UsersTableAdapter();
        readonly User_LocationTableAdapter UserLocation_TableAdapter = new User_LocationTableAdapter();

        private int userId;
        private void lnlEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userId = GlobalInfo.UserID;
            RefTab(utpEditPass);
            var user = Users_TableAdapter.GetData().Where(item => item.User_Id.Equals(userId)).FirstOrDefault();
            if (user != null)
                txtUserName.Text = user.User_Name;
        }

        private void RefTab(UITabPage tabPage)
        {
            ClearItem();
            tabPage.Selected = true;
            tabMain.Refresh();
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
            txtUserName_AddUser.Text = txtPassRep_AddUser.Text = txtPassRep_AddUser.Text = "";
            txtPass_EditUser.Text = "";
            cmbUsers.DisplayMember = "User_Name";
            cmbUsers.ValueMember = "User_Id";
            cmbUsers.DataSource = Users_TableAdapter.GetDataWA();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearItem();
            //tabMain.Visible = false;
        }

        private void btnSave_AddUser_Click(object sender, EventArgs e)
        {
            if (txtUserName_AddUser.Text.IsNullOrEmptyByTrim())
            {
                Utilize.Routines.ShowErrorMessageFa("خطا در ورودی اطلاعات", "نام کاربر وارد نشده است", Utilize.MyDialogButton.OK);
                return;
            }
            if (txtPass_AddUser.Text.IsNullOrEmptyByTrim() || txtPassRep_AddUser.Text.IsNullOrEmptyByTrim())
            {
                Utilize.Routines.ShowErrorMessageFa("خطا در ورودی اطلاعات", "رمز عبور/تکرار رمز عبور وارد نشده است",
                                            Utilize.MyDialogButton.OK);
                return;
            }
            if (txtPass_AddUser.Text.Trim().Equals(txtPassRep_AddUser.Text.Trim()) == false)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا در ورودی اطلاعات", "رمز عبور با تکرار رمز عبور یکسان نیست",
                                            Utilize.MyDialogButton.OK);
                return;
            }
            if (Users_TableAdapter.GetData().Any(item => item.User_Name.ToUpper().Trim().Equals(txtUserName_AddUser.Text.ToUpper().Trim())))
            {
                Utilize.Routines.ShowErrorMessageFa("خطا",
                                            "این نام کاربری قبلاً انتخاب شده است\r\n لطفاً نام کاربری دیگری را وارد نمایید.",
                                            Utilize.MyDialogButton.OK);
                return;
            }
            if (cmbgroupuser.SelectedIndex == -1)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا",
                                            "لطفا محل خدمت کاربر را مشخص کنید.",
                                            Utilize.MyDialogButton.OK);
                return;
            }
            if (cmbgroupuser.SelectedIndex == 3)
            {
                if (ucfState.ValueMember == null || ucfOrganization.ValueMember == null)
                    Utilize.Routines.ShowErrorMessageFa("خطا",
                                                               "لطفا استان و شعبه مورد نظر را انتخاب کنید.",
                                                               Utilize.MyDialogButton.OK);
                return;
            }
            try
            {
                Users_TableAdapter.Insert(txtUserName_AddUser.Text.Trim(), null, txtPass_AddUser.Text.Trim(), 1);
                var user = Users_TableAdapter.GetDataByUserName(txtUserName_AddUser.Text.Trim()).FirstOrDefault();

                var inputProfName = new frmInputText();
                inputProfName.ShowDialog();
                Profile_TableAdapter.InsertProfile(inputProfName.ReturnValue, user.User_Id);
                Users_TableAdapter.UpdateProfileActive(inputProfName.ReturnValue, user.User_Id);
                Users_TableAdapter.UpdateUserGroupId(cmbgroupuser.SelectedValue.ToString().ToInt(), user.User_Id);
                GetFilterLocation();
                ClearItem();
                Utilize.Routines.ShowQuestionMessageFa("ثبت کاربر جدید",
                                               "کاربر جدید با موفقیت ثبت شد.\r\n آیا می خواهید کاربر جدید دیگری وارد نمایید؟",
                                               Utilize.MyDialogButton.YesNO);
            }
            catch (Exception)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا در ورودی اطلاعات", "برنامه با خطا روبرو شده است.",
                                          Utilize.MyDialogButton.OK);
                return;
            }
        }

        private void btnSave_EditUser_Click(object sender, EventArgs e)
        {
            if (txtPass_EditUser.Text.IsNullOrEmptyByTrim())
            {
                Utilize.Routines.ShowErrorMessageFa("خطا در ورودی اطلاعات", "رمز عبور رمز عبور وارد نشده است",
                                            Utilize.MyDialogButton.OK);
                return;
            }
            Users_TableAdapter.UpdatePassByUserId(txtPass_EditUser.Text.Trim(), cmbUsers.SelectedValue.ToString().ToInt());
            Utilize.Routines.ShowInfoMessageFa("ثبت تغییرات", "رمز عبور جدید ثبت شد", Utilize.MyDialogButton.OK);
            ClearItem();
        }

        private void cbReset_CButtonClicked(object sender, EventArgs e)
        {
            // set user login Status
            //UsersTableAdapter Users_TableAdapter = new UsersTableAdapter();
            Users_TableAdapter.UpdateUserLoginStatus(cmbUsers.SelectedValue.ToString().ToInt(), 0);            
            Utilize.Routines.ShowInfoMessageFa("ثبت تغییرات", "تغییرات اعمال شد", Utilize.MyDialogButton.OK);
        }

        private void btnRemove_User_Click(object sender, EventArgs e)
        {
            if (Utilize.Routines.ShowQuestionMessageFa("حدف کاربر", "آیا از حذف کاربر\r\n " + cmbUsers.SelectedText + "\r\n مطمئن هستید؟", Utilize.MyDialogButton.YesNO) == Utilize.MyDialogResoult.Yes)
            {
                try
                {
                    Users_TableAdapter.DeleteByUserId(cmbUsers.SelectedValue.ToString().ToInt());
                    Utilize.Routines.ShowErrorMessageFa("حذف کاربر", "کاربر انتخاب شده،با موفقیت حذف شد", Utilize.MyDialogButton.OK);
                }
                catch(Exception ex)
                {
                    if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                        Utilize.Routines.ShowQuestionMessageFa("حدف کاربر", "توسط این کاربر، مدل هایی در نرم افزار ایجاد شده است" + "\n" +
                                "امکان حذف کاربر وجود ندارد", Utilize.MyDialogButton.OK);
                        //if (Utilize.Routines.ShowQuestionMessageFa("حدف کاربر", "با حذف نام کاربری " + cmbUsers.SelectedText + "تمامی مدل های ایجاد شده توسط وی نیز حذف خواهد شد" + "\n" +
                        //        "آیا از حذف کاربر\r\n " + cmbUsers.SelectedText + "\r\n مطمئن هستید؟", Utilize.MyDialogButton.YesNO) == MyDialogResoult.Yes)
                        //            {

                        //            }
                }
            }
            ClearItem();
        }

        private void lnlNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefTab(utpNewUser);
        }

        private void lnlEditUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefTab(utpEditUser);
        }

        private void cmbusers_Prof_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefCmbProf();
        }

        private void RefCmbProf()
        {
            try
            {
                tabMain.Visible = true;
                if (cmbusers_Prof.SelectedIndex == -1)
                    return;
                var uId = cmbusers_Prof.SelectedValue.ToString().ToInt();
                cmbProf.DisplayMember = "Profile_Id";
                cmbProf.ValueMember = "Id";
                cmbProf.DataSource =
                    Profile_TableAdapter.GetDataByUserId(uId);
                var Actprof = Users_TableAdapter.GetDataByUserId(uId).FirstOrDefault().Act_Profile_Id;
                var prof =
                    Profile_TableAdapter.GetDataByUserId(uId).Where(item => item.Profile_Id.Equals(Actprof)).
                        FirstOrDefault();
                cmbProf.SelectedByDataValue(prof.ID);
            }
            catch (Exception)
            {

            }

        }

        private void lnlMngProf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefTab(utpMngProf);
            cmbusers_Prof.DisplayMember = "User_Name";
            cmbusers_Prof.ValueMember = "User_Id";
            cmbusers_Prof.DataSource = Users_TableAdapter.GetDataWA();
        }

        private void btnNewProf_Click(object sender, EventArgs e)
        {
            var frmInputText = new frmInputText { Text = string.Format("نام پروفایل جدید برای کاربر {0}", cmbusers_Prof.SelectedText), Topic = "نام پروفایل" };
            frmInputText.ShowDialog();
            if (frmInputText.ReturnValue.IsNullOrEmptyByTrim())
                return;
            var user_Id = cmbusers_Prof.SelectedValue.ToString().ToInt();
            if (Profile_TableAdapter.GetDataByUserId(user_Id).Any(item => item.Profile_Id.ToUpper().Equals(frmInputText.ReturnValue.ToUpper())))
            {
                Utilize.Routines.ShowErrorMessageFa("خطا", "پروفایلی با این نام وجود دارد", Utilize.MyDialogButton.OK);
                return;
            }
            Profile_TableAdapter.InsertProfile(frmInputText.ReturnValue, user_Id);
            Utilize.Routines.ShowInfoMessageFa("ثبت اطلاعات", " پروفایل جدید با موفقیت وارد شد", Utilize.MyDialogButton.OK);
            RefCmbProf();

        }

        private void btnSave_Prof_Click(object sender, EventArgs e)
        {
            Users_TableAdapter.UpdateActProf(cmbProf.Text, cmbusers_Prof.SelectedValue.ToString().ToInt());
            Utilize.Routines.ShowInfoMessageFa("ثبت اطلاعات", "تغییر پروفایل با موفقیت انجام شد", Utilize.MyDialogButton.OK);
        }

        private void frmUserMng_Load(object sender, EventArgs e)
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgvUserInfo);
            dgvUserInfo.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            h.FormatDataGridView(dgvUserLoginLogs);
            dgvUserLoginLogs.CellBorderStyle = DataGridViewCellBorderStyle.Single;


            tabMain.ShowTabs = false;
            this.Dock = DockStyle.Fill;
        }

        private void lnlGroupMng_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefTab(utpGroupMng);
            cmbUser_MngGroup.DisplayMember = "User_Name";
            cmbUser_MngGroup.ValueMember = "User_Id";
            cmbUser_MngGroup.DataSource = new DAL.Table_DataSetTableAdapters.UsersTableAdapter().GetDataWA();
        }

        private void cmbUser_MngGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGroup.DisplayMember = "GroupName";
            cmbGroup.ValueMember = "ID";
            cmbGroup.DataSource = new GroupsTableAdapter().GetDataAll();

            var groupId = Users_TableAdapter.GetDataByUserId(cmbUser_MngGroup.SelectedValue.ToString().ToInt()).FirstOrDefault().User_Group_Id;
            cmbGroup.SelectedByDataValue(groupId);
        }

        private void btnMngGroupSave_Click(object sender, EventArgs e)
        {
            Users_TableAdapter.UpdateUserGroupId(cmbGroup.SelectedValue.ToString().ToInt(),
                                              cmbUser_MngGroup.SelectedValue.ToString().ToInt());
            if (cmbGroup.Text.Equals("کاربر شعبه"))
            {
                new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().DeleteUserLocation(cmbUser_MngGroup.SelectedValue.ToString().ToInt());

                DataTable fil_Organization = ucfBranchEdit.GetFilterforImport();
                foreach (System.Data.DataRow row in fil_Organization.Rows)
                {
                    UserLocation_TableAdapter.Insert_UserLocation(cmbUser_MngGroup.SelectedValue.ToString().ToInt(), row.ItemArray[0].ToString());
                }

            }
            Utilize.Routines.ShowInfoMessageFa("ثبت اطلاعات", "گروه کاربر با موفیت ثبت شد", Utilize.MyDialogButton.OK);
        }

        private void btn_SaveGroup_Click(object sender, EventArgs e)
        {
            new DAL.Table_DataSetTableAdapters.GroupsTableAdapter().InsertNewGroup(txtNewGroupName.Text, Convert.ToInt32(cmb_AccessLevel.SelectedValue));
            txtNewGroupName.Text = "";
            Utilize.Routines.ShowInfoMessageFa("ثبت اطلاعات", "گروه با موفیت ثبت شد", Utilize.MyDialogButton.OK);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefTab(uiTabNewGroup);
            cmb_AccessLevel.DisplayMember = "Access Level";
            cmb_AccessLevel.ValueMember = "ID";
            cmb_AccessLevel.DataSource = new DAL.Table_DataSetTableAdapters.AccessLevelTableAdapter().GetAccessLevel();
        }

        private void tabMain_SelectedTabChanged(object sender, TabEventArgs e)
        {

        }

        private void cmb_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Acc.DisplayMember = "Access Level";
            cmb_Acc.ValueMember = "ID";
            cmb_Acc.DataSource = new DAL.Table_DataSetTableAdapters.AccessLevelTableAdapter().GetAccessLevel();

            var accessLevel = new DAL.Table_DataSetTableAdapters.GroupsTableAdapter().GetDataBygroupID(cmb_groups.SelectedValue.ToString().ToInt()).FirstOrDefault().AccessLevel;
            cmb_Acc.SelectedByDataValue(accessLevel);
        }

        private void EditGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefTab(utEditGroupAccess);

            cmb_Acc.DisplayMember = "Access Level";
            cmb_Acc.ValueMember = "ID";
            cmb_Acc.DataSource = new DAL.Table_DataSetTableAdapters.AccessLevelTableAdapter().GetAccessLevel();

            cmb_groups.DisplayMember = "GroupName";
            cmb_groups.ValueMember = "ID";
            cmb_groups.DataSource = new DAL.Table_DataSetTableAdapters.GroupsTableAdapter().GetDataAll();

        }

        private void btn_deleteGroup_Click(object sender, EventArgs e)
        {
            if (Utilize.Routines.ShowQuestionMessageFa("حدف گروه", "آیا از حذف گروه\r\n " + cmb_groups.SelectedText + " مطمئن هستید؟" + "\r\n", Utilize.MyDialogButton.YesNO) == Utilize.MyDialogResoult.Yes)
            {
                new DAL.Table_DataSetTableAdapters.GroupsTableAdapter().DeleteGroup(cmb_groups.SelectedValue.ToString().ToInt());
                Utilize.Routines.ShowErrorMessageFa("حذف گروه", "گروه انتخاب شده،با موفقیت حذف شد", Utilize.MyDialogButton.OK);
            }

            cmb_groups.DisplayMember = "GroupName";
            cmb_groups.ValueMember = "ID";
            cmb_groups.DataSource = new DAL.Table_DataSetTableAdapters.GroupsTableAdapter().GetDataAll();
        }

        private void btn_SaveGRP_Click(object sender, EventArgs e)
        {
            try
            {
                var gda = new DAL.Table_DataSetTableAdapters.GroupsTableAdapter();
                var group = gda.GetDataBygroupID(Convert.ToInt32(cmb_Acc.SelectedValue));
                if (group != null)
                {
                    new DAL.Table_DataSetTableAdapters.GroupsTableAdapter().UpdateGroupAcc(cmb_Acc.SelectedValue.ToString().ToInt(), cmb_groups.SelectedValue.ToString().ToInt());
                    txtNewGroupName.Text = "";
                }
                else
                {
                    new DAL.Table_DataSetTableAdapters.GroupsTableAdapter().InsertNewGroup(txtNewGroupName.Text, Convert.ToInt32(cmb_AccessLevel.SelectedValue));
                    txtNewGroupName.Text = "";
                }

                //new DAL.Table_DataSetTableAdapters.GroupsTableAdapter().UpdateGroupAcc(cmb_Acc.SelectedValue.ToString().ToInt(), cmb_groups.SelectedValue.ToString().ToInt());
                Utilize.Routines.ShowInfoMessageFa("ثبت تغییرات", "تغییرات سطح دسترسی اعمال شد", Utilize.MyDialogButton.OK);
                ClearItem();
            }
            catch (Exception ex)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا", ex.Message, Utilize.MyDialogButton.OK);
            }
        }

        void ucfState_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucfState.IsChecked() && ucfState.GetSelectedItem().Count() > 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                        org =>
                            ucfState.GetSelectedItem().Any(
                            sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();
                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizations;
                }
                else
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizations;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        void ucfOrganization_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                if (ucfState.IsChecked() && ucfState.GetSelectedItem().Count() > 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                        org =>
                            ucfState.GetSelectedItem().Any(
                            sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();
                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizations;
                }
                else
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfOrganization.DisplayMember = "Branch_Description";
                    ucfOrganization.ValueMember = "Branch";
                    ucfOrganization.DataSource = organizations;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }


        void ucfStateEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucfStateEdit.IsChecked() && ucfStateEdit.GetSelectedItem().Count() > 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                        org =>
                            ucfStateEdit.GetSelectedItem().Any(
                            sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();
                    ucfBranchEdit.DisplayMember = "Branch_Description";
                    ucfBranchEdit.ValueMember = "Branch";
                    ucfBranchEdit.DataSource = organizations;
                }
                else
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfBranchEdit.DisplayMember = "Branch_Description";
                    ucfBranchEdit.ValueMember = "Branch";
                    ucfBranchEdit.DataSource = organizations;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }

        void ucfBranchEdit_DropDownOpening(object sender, EventArgs e)
        {
            try
            {
                if (ucfStateEdit.IsChecked() && ucfStateEdit.GetSelectedItem().Count() > 0)
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData().Where(
                        org =>
                            ucfStateEdit.GetSelectedItem().Any(
                            sta => sta.DataValue.ToString().Equals(org.State_Of_Branch.ToString()))).ToArray();
                    ucfBranchEdit.DisplayMember = "Branch_Description";
                    ucfBranchEdit.ValueMember = "Branch";
                    ucfBranchEdit.DataSource = organizations;
                }
                else
                {
                    var organizations = new DAL.GeneralDataSetTableAdapters.OrganizationTableAdapter().GetData();
                    ucfBranchEdit.DisplayMember = "Branch_Description";
                    ucfBranchEdit.ValueMember = "Branch";
                    ucfBranchEdit.DataSource = organizations;
                }
            }
            catch (Exception exception)
            {
                exception.ConfigLog(true);
            }
        }


        private void cmbgroupuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbgroupuser.Text.Equals("کاربر شعبه"))
            {
                pnl_Branch.Visible = true;
                cgBranch.Visible = true;

            }
            else
            {
                pnl_Branch.Visible = false;
                cgBranch.Visible = false;
                return;
            }
        


    }

        private DataTable GetFilterLocation()
        {

            var user = Users_TableAdapter.GetDataByUserName(txtUserName_AddUser.Text.Trim()).FirstOrDefault();
            var fil_Organization = ucfOrganization.GetFilterforImport();
            var items = fil_Organization;
            DataTable dt = new DataTable();
            dt = fil_Organization;
            foreach (System.Data.DataRow row in dt.Rows)
            {

                UserLocation_TableAdapter.Insert_UserLocation(user.User_Id, row.ItemArray[0].ToString());

            }

            return dt;


        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbGroup.Text.Equals("کاربر شعبه"))
            {
                cgBranchGr.Visible = true;
                pnlBranchState.Visible = true;
                var Locations = new DAL.Table_DataSetTableAdapters.User_LocationTableAdapter().GetDataByUserID(Convert.ToInt32(cmbUser_MngGroup.SelectedValue));
                var db = Locations.Rows;
                ucfStateEdit.SetSelectedItem(Locations.Rows.Cast<DataRow>().Select(row => row["State_Id"].ToString()).AsEnumerable());
                ucfBranchEdit.SetSelectedItem(Locations.Rows.Cast<DataRow>().Select(row => row["Branch"].ToString()).AsEnumerable());

            }
            else
            {
                cgBranchGr.Visible = false;
                pnlBranchState.Visible = false;
                return;
            }
        }

        private void frmUserMng_Paint(object sender, PaintEventArgs e)
        {
            pnl07.Left = (this.utpNewUser.Width - pnl07.Width) / 2;
            pnl07.Top = (this.utpNewUser.Height - pnl07.Height) / 2;

            pnl06.Left = (this.utpNewUser.Width - pnl07.Width) / 2;
            pnl06.Top = (this.utpNewUser.Height - pnl07.Height) / 2;

            pnl05.Left = (this.utpNewUser.Width - pnl07.Width) / 2;
            pnl05.Top = (this.utpNewUser.Height - pnl07.Height) / 2;

            pnl04.Left = (this.utpNewUser.Width - pnl07.Width) / 2;
            pnl04.Top = (this.utpNewUser.Height - pnl07.Height) / 2;

            pnl03.Left = (this.utpNewUser.Width - pnl07.Width) / 2;
            pnl03.Top = (this.utpNewUser.Height - pnl07.Height) / 2;

            pnl02.Left = (this.utpNewUser.Width - pnl07.Width) / 2;
            pnl02.Top = (this.utpNewUser.Height - pnl07.Height) / 2;

            pnl01.Left = (this.utpNewUser.Width - pnl07.Width) / 2;
            pnl01.Top = (this.utpNewUser.Height - pnl07.Height) / 2;
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefTab(utUserInfo);

            DataTable dt = new DAL.UserInfo().GetDt_UserInfo();
            dgvUserInfo.DataSource = dt;
            dgvUserInfo.Columns["User_Id"].Visible = false;
            dgvUserInfo.FormatDataGridView();
        }

        private void dgvUserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId = int.Parse(dgvUserInfo["User_Id", e.RowIndex].Value.ToString());
            DataTable dt = new DAL.UserInfo().GetDt_UserLoginDetails(userId);
            dgvUserLoginLogs.DataSource = dt;
            dgvUserLoginLogs.FormatDataGridView();
        }

        private void pnl07_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteProf_CButtonClicked(object sender, EventArgs e)
        {
            try
            {
                if (cmbProf.SelectedIndex == -1 || cmbProf.SelectedValue == null)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "پروفایلی انتخاب نشده است", Utilize.MyDialogButton.OK);
                    return;
                }
                int ProfileID = (int)cmbProf.SelectedValue;

                if (ProfileID == GlobalInfo.ProfileID)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "پروفایل انتخابی، در حال حاضر در سیستم وارد شده است " + "\n" +
                                                                " امکان حذف وجود ندارد ", Utilize.MyDialogButton.OK);
                    return;
                }
                var UserDataSet = new DAL.User_DataSet();
                int IsActive = 0;
                UserDataSet.IsActiveProfile(ProfileID, out IsActive);
                if (IsActive == 1)
                {
                    Utilize.Routines.ShowInfoMessageFa("خطا", "پروفایل انتخابی، پروفایل فعال کاربر متناظر است " + "\n" +
                                                                " امکان حذف پروفایل فعال وجود ندارد ", Utilize.MyDialogButton.OK);
                    return;
                }

                if (Utilize.Routines.ShowInfoMessageFa("خطا", " با حذف پروفایل، تمامی مدل های ایجاد شده توسط آن پروفایل نیز حذف می گردند " + "\n" +
                                                                " آیا ادامه می دهید؟ ", Utilize.MyDialogButton.YesNO) == Utilize.MyDialogResoult.No)
                {
                    return;
                }

                Profile_TableAdapter.DeleteProfile(ProfileID);
                Utilize.Routines.ShowInfoMessageFa("حذف", " پروفایل جدید با موفقیت حذف شد", Utilize.MyDialogButton.OK);
                RefCmbProf();
            }
            catch (Exception ex)
            {
                Utilize.Routines.ShowErrorMessageFa("خطا", "خطای نامشخص" + "\n" + ex.Message, Utilize.MyDialogButton.OK);
            }

        }

        


    }
}
