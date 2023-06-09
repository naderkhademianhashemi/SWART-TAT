using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Presentation.DAL;

namespace Presentation.Tabs.AssetDebtManagement
{
    public partial class frmTBM : Form
    {
        public frmTBM()
        {
            InitializeComponent();
        }
       
        private void FillModel(ListView LSV)
        {
            var DT = new GapDS().GetDT();
            foreach (DataRow dr in DT.Rows)
            {
                var lvi = new ListViewItem { Text = dr[0].ToString(), Tag = "ModelTag" };
                LSV.Items.Add(lvi);
            }
        }
        private void frmTimeBucket_Load(object sender, EventArgs e) 
        {
            FillModel(lsvModel);
        }
        public void SelectedModelID() { }
        private void frmTBM_FormClosing(object sender, FormClosingEventArgs e) { }

        private void lsvModel_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lsvModel_DoubleClick(object sender, EventArgs e) { }
        private void dgvList_DoubleClick(object sender, EventArgs e) { }
        private void dgvList_SelectionChanged(object sender, EventArgs e) { }

        private void tsbModelNew_Click(object sender, EventArgs e) { }
        private void tsbModelNewCopy_Click(object sender, EventArgs e) { }
        private void tsbModelEdit_Click(object sender, EventArgs e) { }
        private void tsbModelRemove_Click(object sender, EventArgs e) { }

        private void tsbModelSave_Click(object sender, EventArgs e) { }


        void rb_DoubleClick(object sender, EventArgs e) { }
        void rb_DragLeave(object sender, EventArgs e) { }
        void rb_DragEnter(object sender, DragEventArgs e) { }
        void rb_DragDrop(object sender, DragEventArgs e) { }
        void rb_MouseDown(object sender, MouseEventArgs e) { }
        void rb_MouseMove(object sender, MouseEventArgs e) { }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void tsmiZoom_Click(object sender, EventArgs e) { }
        private void tsmiLabel_Click(object sender, EventArgs e) { }

        private void btnModel_Click(object sender, EventArgs e) { }

        private void tsbNew_Click(object sender, EventArgs e) { }

        private void tsbEdit_Click(object sender, EventArgs e) { }

        private void tsbRemove_Click(object sender, EventArgs e) { }

        private void tsbMoveDown_Click(object sender, EventArgs e) { }

        private void tsbMoveUp_Click(object sender, EventArgs e) { }


        private void frmTBM_KeyDown(object sender, KeyEventArgs e) { }

        private void tsbModelRefres_Click(object sender, EventArgs e) { }

        private void tsbRefresh_Click(object sender, EventArgs e) { }

        private void cbMdl_CButtonClicked(object sender, EventArgs e) { }

        private void tsbShowBaloon_Click(object sender, EventArgs e) { }

        private void tsbAutomaticCreate_Click(object sender, EventArgs e) { }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}