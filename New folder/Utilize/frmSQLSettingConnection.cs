using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilize
{
    public partial class frmSQLSettingConnection : Form
    {
        private const string DataSource = "Data Source=";
        private const string InitialCatalog = "Initial Catalog=";
        private const string PersistSecurityInfo = "Persist Security Info=True;";
        private const string IntegratedSecurity = "Integrated Security=True";
        private const string UserID = "User ID=";
        private const string Password = "Password=";
        private const string ConnectTimeout = "Connect Timeout=";
        private string _ConnectionString = "";
        public string ConnectionString
        {
            get { return _ConnectionString; }
        }
        public frmSQLSettingConnection()
        {
            InitializeComponent();
        }

        private void rdbWindowsUser_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = btnTestConnection.Enabled = false;
            if (rdbWindowsUser.Checked)
            {
                pnlUserSql.Enabled = false;
            }
            else
            {
                pnlUserSql.Enabled = true;
            }
        }

        private void GetServersName()
        {
            btnSave.Enabled = btnTestConnection.Enabled = false;
            cmbServerName.Items.Clear();
            Cursor = Cursors.WaitCursor;
            var ServerNames = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (var server in ServerNames.Rows.Cast<DataRow>())
            {
                cmbServerName.Items.Add(server.ItemArray[0].ToString());
            }
            Cursor = Cursors.Default;
        }

        private void cmbServerName_DropDown(object sender, EventArgs e)
        {
            if (cmbServerName.Items.Count == 0)
                GetServersName();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetServersName();
        }

        private void cmbDataBaseName_DropDown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbServerName.Text.Trim()))
            {
                Routines.ShowErrorMessageFa("خطا", "نام سرور وارد نشده است", MyDialogButton.OK);
                return;
            }
            if (rdbSQLUser.Checked)
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    Routines.ShowErrorMessageFa("خطا", "نام کاربری یا رمز عبور  وارد نشده است", MyDialogButton.OK);
                    return;
                }
                else
                {
                    //Data Source=192.168.20.100;Initial Catalog=Risk_Mng_Mehr;Persist Security Info=True;User ID=sa;Password=***********
                    var conString = string.Format("{0}{1};{2}{3};{4}{5}{6};{7}{8};{9}{10};", DataSource, cmbServerName.Text, InitialCatalog, cmbDataBaseName.Text, PersistSecurityInfo,
                        UserID, txtUserName.Text, Password, txtPassword.Text, ConnectTimeout, txtTimeout.Value.ToString().Replace("-", "").Trim().Length == 0 ? "15" : txtTimeout.Value.ToString().Replace("-", "").Trim());
                    cmbDataBaseName.Items.Clear();
                    var sqlCon = new SqlConnection(conString);
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        sqlCon.Open();
                        var tblDatabases = sqlCon.GetSchema("Databases");
                        sqlCon.Close();
                        foreach (var row in tblDatabases.Rows.Cast<DataRow>())
                        {
                            cmbDataBaseName.Items.Add(row["database_name"].ToString());
                        }
                        Cursor = Cursors.Default;
                        _ConnectionString = conString;
                    }
                    catch (Exception)
                    {
                        Cursor = Cursors.Default;
                        Routines.ShowErrorMessageFa("خطا", "اتصال به پایگاه داده با خطا روبرو شده است", "نام کاربری یا رمز عبور را بررسی کنید\r\nنام سرور ا بررسی کنید\r\n سرور را بررسی کیند", MyDialogButton.OK);
                        return;
                    }
                }
            }
            else
            {
                var conString = string.Format("{0}{1};{2}{3};{4};{5}{6};", DataSource, cmbServerName.Text, InitialCatalog, cmbDataBaseName.Text, IntegratedSecurity, ConnectTimeout, txtTimeout.Value.ToString().Replace("-", "").Trim().Length == 0 ? "15" : txtTimeout.Value.ToString().Replace("-", "").Trim());
                cmbDataBaseName.Items.Clear();
                var sqlCon = new SqlConnection(conString);
                try
                {
                    Cursor = Cursors.WaitCursor;
                    sqlCon.Open();
                    var tblDatabases = sqlCon.GetSchema("Databases");
                    sqlCon.Close();
                    foreach (var row in tblDatabases.Rows.Cast<DataRow>())
                    {
                        cmbDataBaseName.Items.Add(row["database_name"].ToString());
                    }
                    Cursor = Cursors.Default;
                    _ConnectionString = conString;
                }
                catch (Exception)
                {
                    Cursor = Cursors.Default;
                    Routines.ShowErrorMessageFa("خطا", "اتصال به پایگاه داده با خطا روبرو شده است", "نام کاربری یا رمز عبور را بررسی کنید\r\nنام سرور ا بررسی کنید\r\n سرور را بررسی کیند", MyDialogButton.OK);
                    return;
                }
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (cmbDataBaseName.SelectedIndex == -1)
            {
                Routines.ShowErrorMessageFa("خطا", "نام پایگاه داده انتخاب نشده است", MyDialogButton.OK);
                return;
            }
            try
            {
                var sqlCon = new SqlConnection(_ConnectionString);
                Cursor = Cursors.WaitCursor;
                sqlCon.Open();
                sqlCon.Close();
                Cursor = Cursors.Default;
                Routines.ShowInfoMessageFa("اتصال به پایگاه داده", "اتصال به پایگاه داده با موفقیت انجام شده است",
                                            MyDialogButton.OK);
                btnSave.Enabled = true;
            }
            catch (Exception exception)
            {
                Cursor = Cursors.Default;
                Routines.ShowErrorMessageFa("خطا", "اتصال به پایگاه داده با خطا روبرو شده است", exception.Message,
                                            MyDialogButton.OK);
                btnSave.Enabled = false;
                return;
            }
        }

        private void cmbDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTestConnection.Enabled = true;
            if (rdbSQLUser.Checked)
            {
                _ConnectionString = string.Format("{0}{1};{2}{3};{4}{5}{6};{7}{8};{9}{10};", DataSource, cmbServerName.Text, InitialCatalog, cmbDataBaseName.Text, PersistSecurityInfo,
                        UserID, txtUserName.Text, Password, txtPassword.Text, ConnectTimeout, txtTimeout.Value.ToString().Replace("-", "").Trim().Length == 0 ? "15" : txtTimeout.Value.ToString().Replace("-", "").Trim());
            }
            else
            {
                _ConnectionString = string.Format("{0}{1};{2}{3};{4};{5}{6};", DataSource, cmbServerName.Text, InitialCatalog, cmbDataBaseName.Text, IntegratedSecurity, ConnectTimeout, txtTimeout.Value.ToString().Replace("-", "").Trim().Length == 0 ? "15" : txtTimeout.Value.ToString().Replace("-", "").Trim());
            }
        }

        private void cmbServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = btnTestConnection.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Routines.ShowInfoMessageFa("اتصال به پایگاه داده", "تنظیمات اتصال با موفقیت ثبت شد",
                                           MyDialogButton.OK);
            this.Close();
        }

        private void cmbServerName_DropDown(object sender, MouseEventArgs e)
        {

        }

        private void cmbDataBaseName_DropDown(object sender, MouseEventArgs e)
        {

        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
