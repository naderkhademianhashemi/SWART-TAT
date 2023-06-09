using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERMS.Logic;
using ERMS.Model;
using ERMSLib;
using Presentation.Public;

namespace Presentation.Tabs.GuidanceTableu
{
    public partial class frmEventLog : BaseForm, IPrintable
    {
        #region VARS
        private EventLog evlog;
        PersianTools.Dates.PersianDate p, p1;
        #endregion

        public frmEventLog()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
            splitContainer.Panel2Collapsed = true;
        }

        private void frmEventLog_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            Helper h = new Helper();
            h.FormatDataGridView(dgvEventList);
            h.FormatDataGridView(dgvEventData);
          //  dgvEventList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            // add for farsi
            p1 = new PersianTools.Dates.PersianDate(int.Parse("2007"), int.Parse("03"), int.Parse("21"), PersianTools.Dates.CalendarsMode.Gregorian);
            fdpStartDate.Text = p1.FormatedDate("yyyy/MM/dd");

            p = new PersianTools.Dates.PersianDate(DateTime.Now);
            fdpLastDate.Text = p.FormatedDate("yyyy/MM/dd");

            
            DataTable dt;
            DataRow dr;

            evlog = new EventLog();

            //
            dt = evlog.GetEventCategorys();
            dr = dt.NewRow();
            dr[EventLog.CTE_Alias_Descr] = "All";
            dr[EventLog.CTE_Alias_ID] = -1;
            dt.Rows.InsertAt(dr, 0);
            //
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = EventLog.CTE_Alias_Descr;
            cmbCategory.ValueMember = EventLog.CTE_Alias_ID;

            Misc misc = new Misc();
            //
            dt = misc.GetUserDT();
            dr = dt.NewRow();
            dr[Misc.CTE_Alias_UserDescr] = "All";
            dr[Misc.CTE_Alias_UserID] = -1;
            dt.Rows.InsertAt(dr, 0);
            //
            cmbUser.DataSource = dt;
            cmbUser.DisplayMember = Misc.CTE_Alias_UserDescr;
            cmbUser.ValueMember = Misc.CTE_Alias_UserID;

            cmbCategory.SelectedIndex = 0;
            cmbUser.SelectedIndex = 0;

            this.ResumeLayout();
            this.Dock = DockStyle.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CommandRefresh();
        }
        private void CommandRefresh()
        {
            int userID = (int)cmbUser.SelectedValue;
            int categoryID = (int)cmbCategory.SelectedValue;

            dgvEventList.Columns.Clear();
            dgvEventData.Columns.Clear();
            cmbPages.Items.Clear();
            int count = evlog.GetEventsCount(userID, categoryID);
            for (int i = 1; i < count; i = i + 100)
            {
                cmbPages.Items.Add(string.Format("{0} .. {1}", i, i + 100 - 1));
            }
            cmbPages.SelectedIndex = cmbPages.Items.Count == 0 ? -1 : 0;

        }

        private void cmbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userID = (int)cmbUser.SelectedValue;
            int categoryID = (int)cmbCategory.SelectedValue;
            int startIndex = cmbPages.SelectedIndex * 100 + 1;
            int endIndex = (cmbPages.SelectedIndex + 1) * 100 - 1;

           
            p1 = new PersianTools.Dates.PersianDate(int.Parse(fdpStartDate.Text.Substring(0, 4)), int.Parse(fdpStartDate.Text.Substring(5, 2)), int.Parse(fdpStartDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            DateTime startDate = DateTime.Parse(p1.ToGregorian.ToString("yyyy/MM/dd"));

            p = new PersianTools.Dates.PersianDate(int.Parse(fdpLastDate.Text.Substring(0, 4)), int.Parse(fdpLastDate.Text.Substring(5, 2)), int.Parse(fdpLastDate.Text.Substring(8, 2)), PersianTools.Dates.CalendarsMode.Persian);
            DateTime lastDate = DateTime.Parse(p.ToGregorian.ToString("yyyy/MM/dd"));

            
            dgvEventList.Columns.Clear();
            DataTable dt = new DataTable();

            dt = evlog.GetEvents(userID, categoryID, startIndex, endIndex, startDate, lastDate);

            PersianTools.Dates.PersianDate P;


            DataColumn dcolDateF = new DataColumn("DateF", typeof(System.String));
            dt.Columns.Add(dcolDateF);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Date"].ToString() != "")
                {
                    //Farsi
                    P = new PersianTools.Dates.PersianDate((DateTime)dt.Rows[i]["Date"]);
                    dt.Rows[i]["DateF"] = P.FormatedDate("yyyy/MM/dd");

                }
            }
            dgvEventList.DataSource = dt;

            dgvEventList.Columns[0].HeaderText="سطر";
            dgvEventList.Columns[1].HeaderText = "كاربر";
            dgvEventList.Columns[2].HeaderText = "طبقه";
            dgvEventList.Columns["Action"].HeaderText = "عمليات";
            dgvEventList.Columns["DateF"].HeaderText = "تاريخ";
            dgvEventList.Columns["Description"].HeaderText = "شرح";
            dgvEventList.Columns["Notes"].HeaderText = "يادداشت";
            dgvEventList.Columns["Date"].Visible = false;

            DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
            tCol.MinimumWidth = 1023;
            tCol.Name = "Dummy";
            tCol.HeaderText = string.Empty;
            dgvEventList.Columns.Add(tCol);

            //TEMPORARY!!!
            try
            {
                dgvEventList.Columns[1].Visible = false;
                dgvEventList.Columns[2].Visible = false;
                dgvEventList.Columns[3].Visible = false;
                dgvEventList.Columns[4].Visible = false;
            }
            catch { }
        }

        private void dgvEventList_SelectionChanged(object sender, EventArgs e)
        {
            if (!clsERMSGeneral.CloseForm)
            {
                if (dgvEventList.SelectedRows.Count > 0)
                {
                    int eventLogID = (int)dgvEventList.SelectedRows[0].Cells[1].Value;

                    dgvEventData.Columns.Clear();
                    cmbData.DataSource = evlog.GetEventDetails(eventLogID);
                    cmbData.DisplayMember = EventLog.CTE_Alias_Descr;
                    cmbData.ValueMember = EventLog.CTE_Alias_ID;
                }
            }
        }

        private void cmbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbData.SelectedIndex != -1)
            {
                Cursor.Current = Cursors.WaitCursor;
                int eventLogDataID = (int)cmbData.SelectedValue;

                dgvEventData.Columns.Clear();
                dgvEventData.DataSource = evlog.GetEventRawData(eventLogDataID);

                DataGridViewTextBoxColumn tCol = new DataGridViewTextBoxColumn();
                tCol.MinimumWidth = 1023;
                tCol.Name = "Dummy";
                tCol.HeaderText = string.Empty;
                dgvEventData.Columns.Add(tCol);
                Cursor.Current = Cursors.Default;
            }

        }
        public void DoPrint()
        {
            clsERMSGeneral.dgvActive = dgvEventList;
        }

        public void DoHelp()
        {
            clsERMSGeneral.strHelp = "EventLog";
        }
        private void frmEventLog_KeyDown(object sender, KeyEventArgs e)
        {
            //Load
            if (e.KeyCode == Keys.F5)
            {
                CommandRefresh();
            }
        }




    }
}