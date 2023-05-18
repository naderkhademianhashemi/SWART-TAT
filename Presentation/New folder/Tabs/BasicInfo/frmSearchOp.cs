using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Tabs.BasicInfo
{
	public partial class frmSearch : BaseForm
	{
		#region Variable
		string _TableName = string.Empty;
		string strType = "";
		DataTable dtFields;
		#endregion

		#region constructor
		public frmSearch(DataTable dt)
		{
			InitializeComponent();
			dtFields = dt;
		}
		public frmSearch()
		{
			InitializeComponent();
		}
		#endregion

		#region Properties
		public string Field
		{
			get
			{
				//return cmbField.Text;
				return cmbField.SelectedValue.ToString();
			}
			set
			{
				//cmbField.Text = value;
				//cmbField.SelectedValue = value;
			}
		}

		public string TableName
		{
			get
			{
				return _TableName;
			}
			set
			{
				_TableName = value;
			}
		}

		public string Search
		{
			get
			{
				return txtSearch.Text;
			}
			set
			{
				txtSearch.Text = value;
				txtSearch.SelectionStart = 0;
				txtSearch.SelectionLength = txtSearch.Text.Length;
			}
		}

		public string Operator
		{
			get
			{
				switch (cmbOperator.Text)
				{
					case "<":
						return ">";

					case ">":
						return "<";

					case ">=":
						return "<=";

					case "<=":
						return ">=";

					default:
						return cmbOperator.Text;
				}

			}
			set
			{
				cmbOperator.Text = value;

			}
		}
		#endregion

		#region Form events
		private void frmSearch_Load(object sender, EventArgs e)
		{
			cmbField.DataSource = dtFields;
			cmbField.DisplayMember = dtFields.Columns["FarsiField"].ToString();
			cmbField.ValueMember = dtFields.Columns["Field"].ToString();
			cmbField.SelectedIndex = -1;
			txtSearch.Visible = false;


		}

		private void frmSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (txtSearch.Text == string.Empty)
				{
					this.DialogResult = DialogResult.None;
				}
				this.DialogResult = DialogResult.OK;
			}
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
		#endregion

		#region cmbField events
		private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
		{
			// start Modify 87/03/19 by A_Abbsi 
			// string strType = "";
			// End Modify
			txtSearch.Visible = true;
			if (cmbField.SelectedValue != null)
			{
				foreach (DataRow dr in dtFields.Rows)
					if (dr["Field"].ToString() == cmbField.SelectedValue.ToString())
					{ strType = dr["Type"].ToString(); break; }

				switch (strType)
				{
					case "numeric": cmbOperator.Visible = true;
						break;
                    case "System.Decimal": cmbOperator.Visible = true;
						break;

                    case "System.Int32": cmbOperator.Visible = true;
						break;

                    default: cmbOperator.Visible = false;
						break;
				}
			}


		}
		#endregion

		#region txtSearch events
		// start Modify 87/03/19 by A_Abbsi 
		//add this method to this class by me
		//for prevent to add character for numeric feilds in txtSearch
		private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (strType == "numeric" || strType == "System.Decimal" || strType == "System.Int32")
			{
				if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)32 && e.KeyChar != (char)59 && e.KeyChar != (char)45 && e.KeyChar != (char)46)
				{
					e.Handled = true;
				}
			}
		}

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
		//end Modify 87/03/19 by A_Abbsi 
		#endregion
	}
}