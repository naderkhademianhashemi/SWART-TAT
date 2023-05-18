using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.Table_DataSetTableAdapters;
using System.Collections;
using ERMSLib;
using Presentation.Public;


namespace Presentation.Tabs.GuidanceTableu
{
    public partial class frmCreatAccessLevel : BaseForm
    {

        bool bolLoad;
        DataSet ds = new DataSet();
        readonly UsersTableAdapter clsUser = new UsersTableAdapter();
        
        readonly Form_InformationTableAdapter FormInformation_TableAdapter = new Form_InformationTableAdapter();
        ArrayList arrLst = new ArrayList();
        DataTable dtblGroup = new DataTable();
        private Point Position = new Point(0, 0);
        string strAccessLvlName = string.Empty;
        int selectedaccessItem=-1;

        DataTable formsBySection;
        DataTable CheckedFormes;

        public frmCreatAccessLevel()
        {
            InitializeComponent();
            clsERMSGeneral.InitializeTheme(this);
        }


        

        private void frmCreatAccessLevel_Load(object sender, EventArgs e)
        {
            loadAccessLevels();
            lbxSection.Items.AddRange(new[] { 
            "ریسک نقدینگی" ,//"مدیریت دارایی- بدهی" ,
            "مدل های رفتاری" ,//"گزارش دارایی- بدهی",
            "ریسک اعتباری",
            "ریسک بازار سهام",
            "ريسك بازار ارز",
            "سپرده ها",
            "مدیریت حدود و داشبورد",
            "نسبت های مالی",
            "داده های پایه",
            "اطلاعات پایه",
            "تابلوي هدايت",
            "شخصی سازی"
            });
            lbxSection.SelectedIndex = 0;
           

            bolLoad = true;
            this.Dock = DockStyle.Fill;
        }

        private void loadAccessLevels()
        {
            lsv_AccModel.View = View.Details;
            ColumnHeader ch = new ColumnHeader();
            ch.Width = lsv_AccModel.Width - 5;
            lsv_AccModel.Columns.Add(ch);
            lsv_AccModel.FullRowSelect = true;
            lsv_AccModel.HideSelection = false;
            lsv_AccModel.HeaderStyle = ColumnHeaderStyle.None;

            lsv_AccModel.Items.Clear();
            var AccesssLevels = new DAL.Table_DataSetTableAdapters.AccessLevelTableAdapter().GetAccessLevel();

            foreach (DataRow dr in AccesssLevels.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["Access Level"].ToString();
                lvi.Tag = dr["ID"].ToString();

                lsv_AccModel.Items.Add(lvi);
            }
           
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            setSection();
            Cursor = Cursors.Default;
        }

        private void setSection()
        {
            if (selectedaccessItem!=null)
            {
                if (lbxSection.SelectedItems != null)
                {
                    foreach (var item in formsBySection.Rows.Cast<DataRow>())
                    {
                        new DAL.Table_DataSetTableAdapters.AccessLevel_FormInformationTableAdapter().DeletebyAcessFormID(selectedaccessItem,Convert.ToInt32(item["ID"]));
                    }
                }
                
                foreach (var row in chbForms.CheckedItems.Cast<ColumnOfList<string, int>>())
                {
                    new DAL.Table_DataSetTableAdapters.AccessLevel_FormInformationTableAdapter().InsertNewRelation(selectedaccessItem, row.GetValue());
                }
               
                    Presentation.Public.Routines.ShowMessageBoxFa(" با موفقیت ذخیره شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbModelNew_Click(object sender, EventArgs e)
        {
            strAccessLvlName = Presentation.Public.Routines.ShowInputBox();
            String Discr =Presentation.Public.Routines.ShowInputBox("لطفا توصیفی از این سطح دسترسی ارائه دهید:");
           
            if (strAccessLvlName != string.Empty)
            {
                new DAL.Table_DataSetTableAdapters.AccessLevelTableAdapter().InsertNewAccessLevel(strAccessLvlName.Trim(), Discr.Trim());
                loadAccessLevels();
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            int id;
            if (lsv_AccModel.SelectedItems != null)
            {
                
                    strAccessLvlName = Presentation.Public.Routines.ShowInputBox(lsv_AccModel.SelectedItems[0].Text);
                    id = Convert.ToInt32(lsv_AccModel.SelectedItems[0].Tag);
                    if (strAccessLvlName != string.Empty)
                        new DAL.Table_DataSetTableAdapters.AccessLevelTableAdapter().UpdateAccessLevel(strAccessLvlName.Trim(),id);
                    
                    loadAccessLevels();
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsv_AccModel.SelectedItems != null)
                {
                    new DAL.Table_DataSetTableAdapters.AccessLevelTableAdapter().DeleteAccessLevel(Convert.ToInt32(lsv_AccModel.SelectedItems[0].Tag));
                    loadAccessLevels();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                    Routines.ShowQuestionMessageFa("حدف کاربر", "در اعطای سطح دسترسی به گروه های کاربری، از این سطح استفاده شده است " + "\n" +
                            "امکان حذف سطح دسترسی وجود ندارد", MyDialogButton.OK);
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            loadAccessLevels();
        }

        private void lbxSection_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (bolLoad == true)
            {

                this.Refresh();
                chbForms.Items.Clear();

                
                formsBySection = new DAL.Table_DataSetTableAdapters.Form_Information1TableAdapter().GetDataBySection(lbxSection.SelectedIndex);

                if (selectedaccessItem == -1)
                    Presentation.Public.Routines.ShowMessageBoxFa("ابتدا یکی از سطوح دسترسي را انتخاب کنید.",
                             "پيغام", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    CheckedFormes = new DAL.Table_DataSetTableAdapters.AccessLevel_FormInformationTableAdapter().GetDataByAccessID(selectedaccessItem);

                    bolLoad = false;

                    if (formsBySection != null)
                    {

                        foreach (var row in formsBySection.Rows.Cast<DataRow>())
                        {
                            chbForms.Items.Add(new ColumnOfList<string, int>(row["Frm_Description_Farsi"].ToString(),
                                                                                Convert.ToInt32(row["ID"])));

                        }
                        foreach (var item in CheckedFormes.Rows.Cast<DataRow>())
                        {
                            DataRow selected = formsBySection.Rows.Cast<DataRow>().Where(i => Convert.ToInt32(i["ID"]) == Convert.ToInt32(item["Form_ID"])).FirstOrDefault();
                            if (selected != null)
                            {
                                String indexTxt = selected["Frm_Description_Farsi"].ToString();
                                var indexChb = chbForms.FindString(indexTxt);
                                if (indexChb != -1)
                                    chbForms.SetItemCheckState(indexChb, CheckState.Checked);
                            }
                        }
                    }
                    else
                    {
                        chbForms.Items.Clear();
                    }

                    bolLoad = true;
                    this.Refresh();
                }
            }
        }

        private void lsv_AccModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_AccModel.SelectedItems.Count == 0)
                return;
            selectedaccessItem = Convert.ToInt32(lsv_AccModel.SelectedItems[0].Tag);
        }


        internal class ColumnOfList<DType, VType>
        {
            private readonly DType Display;
            private readonly VType Value;
            public ColumnOfList(DType display, VType value)
            {
                Display = display;

                Value = value;
            }
            public string GetDisplay()
            {
                return Display.ToString();
            }
            public int GetValue()
            {
                return Convert.ToInt32(Value);
            }
            public override string ToString()
            {
                return GetDisplay();
            }
        }
    }
}
