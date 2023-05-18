using System;
using System.Data;
using System.Windows.Forms;
using DAL.Table_DataSetTableAdapters;

namespace Presentation.Tabs.GuidanceTableu
{
    public partial class frmModelManagementUser : BaseForm
    {
        #region VAR/CONTROLS

        DAL.Table_DataSetTableAdapters.UsersTableAdapter user;
        DataTable dt;
        string strUser = string.Empty;
        public string User
        {
            get
            { return cmbUsers.Text; }

            set
            { strUser = value; }

        }
        string strActProfile = string.Empty;
        public string ActProfile
        {
            get
            { return cmbProfile.Text; }

            set
            { strActProfile = value; }

        }
        int profileId;
        public int ActProfileId
        {
            get
            { return int.Parse(cmbProfile.SelectedValue.ToString()); }

            set
            { profileId = value; }

        }
        private string strSourceUser = string.Empty;
        public string SourceUser
        {
            get { return strSourceUser; }
            set { strSourceUser = value; }
        }
        
        #endregion
        public frmModelManagementUser()
        {
            InitializeComponent();
        }

        private void cmbUsers_Click(object sender, EventArgs e)
        {

        }

        private void frmModelManagementUser_Load(object sender, EventArgs e)
        {
            lblSourceUser.Text = strSourceUser;
            user =new UsersTableAdapter();
            dt = user.GetData();
            cmbUsers.DataSource = dt;
            cmbUsers.DisplayMember = "User_Name";
            cmbUsers.ValueMember = "User_Id";
         
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();   
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //strActProfile = dt.Rows[cmbUsers.SelectedIndex]["Act_Profile_Id"].ToString();
            fillProfile(int.Parse(dt.Rows[cmbUsers.SelectedIndex]["User_Id"].ToString()));
        }
        private void fillProfile(int userID)
        {
            var dtProfile = new ProfileTableAdapter().GetDataByUserId(userID);
            cmbProfile.DisplayMember = "Profile_Id";
            cmbProfile.ValueMember = "ID";
            cmbProfile.DataSource = dtProfile;
       
         
        }

        private void btnCancel_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}