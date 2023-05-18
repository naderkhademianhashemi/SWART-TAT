using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Presentation.Public;

namespace Presentation.Miscs
{
    public partial class frmCheckDependents : Form
    {

        public frmCheckDependents()
        {
            InitializeComponent();
        }

        public DataTable Items
        {
            get { return (DataTable)dgv.DataSource; }
            set 
            {
                dgv.Columns.Clear();

                dgv.DataSource = value;
                dgv.ColumnHeadersVisible = false;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //Dummy Column
                DataGridViewImageColumn tCol = new DataGridViewImageColumn();
                tCol.Image = global::Presentation.Properties.Resources.Exclamation;
                tCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                tCol.Width = 20;
                tCol.Name = "Dummy";                
                dgv.Columns.Insert(0, tCol);
            }
        }

        private void frmCheckDependents_Load(object sender, EventArgs e)
        {
            Helper h = new Helper();
            h.FormatDataGridView(dgv);

            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void frmCheckDependents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
            if (e.KeyCode == Keys.Escape)
            {
                
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
    }
}