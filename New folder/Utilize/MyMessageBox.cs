using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Utilize.Helper;


namespace Utilize
{
	public enum MyDialogResoult
	{
		[Description("تأیید")]
		Ok = 0,
		[Description("لغو")]
		Cancel = 1,
		[Description("بله")]
		Yes = 2,
		[Description("خیر")]
		No = 3
	}
	public enum MyDialogButton
	{

		OK = 0,
		OKCancel = 1,
		Cancel = 2,
		YesNO = 3,
		YesNoCancel = 4
	}
	public enum MyDialogIcon
	{
		Warning = 0,
		Error = 1,
		Information = 2,
		OK = 3,
		Question =4,
        AccessDenied = 5

	}

	public partial class MyMessageBox : Form
	{
		public MyMessageBox()
		{
			InitializeComponent();
		}

		 
		private static readonly Point[] SizeLocation = {new Point(4, 104),new Point(85, 104),new Point(166, 104),new Point(245, 104) };
		private static Collection<Button> _collection;
		private static MyMessageBox myMessage;
		private bool isShowExpandMessage;
		internal MyDialogResoult Resoult;
		private void pcbExpand_Click(object sender, EventArgs e)
		{
			isShowExpandMessage = !isShowExpandMessage;
            pcbExpand.Image = isShowExpandMessage ? Properties.Resources.XParrow_Expand : Properties.Resources.XParrow_Collapse;
			//myMessage.lblInformation.Visible = isShowExpandMessage;
			if(isShowExpandMessage)
			{
				myMessage.lblInformation.Visible = true;
                myMessage.Size = new Size(489, 242);
			}
			else
			{
				myMessage.lblInformation.Visible = false;
                myMessage.Size = new Size(489, 170);
			}
		}

		public static MyDialogResoult ShowMessage(string title,string message,string information,MyDialogButton button,MyDialogIcon icon,bool isPersian)
		{

			myMessage = new MyMessageBox
			            	{
			            		Text = title,
			            		lblMessage = {Text = message},
			            		lblTitle = {Text = title},
			            		lblInformation = {Text = information}
			            	};
			_collection = new Collection<Button>();
			_collection.Clear();
			foreach (Control control in myMessage.Controls)
			{
				if (control is Button)
					_collection.Add((Button)control);
			}
			SetButtonMessage(button,isPersian);
			SetIconMessage(icon);
			myMessage.pcbExpand.Visible = true;
			myMessage.lblInformation.Visible = true;
            myMessage.Size = new Size(489, 242);
			myMessage.TopLevel = true;
			myMessage.ShowDialog();
			return myMessage.Resoult;
		}

		public static MyDialogResoult ShowMessage(string title, string message, MyDialogButton button, MyDialogIcon icon, bool isPersian)
		{
			myMessage = new MyMessageBox {Text = title, lblMessage = {Text = message}, lblTitle = {Text = title}};
			_collection = new Collection<Button>();
			_collection.Clear();
			foreach (Control control in myMessage.Controls)
			{
				if (control is Button)
					_collection.Add((Button)control);
			}
			SetButtonMessage(button, isPersian);
			SetIconMessage(icon);
			myMessage.pcbExpand.Visible = false;
			myMessage.lblInformation.Visible = false;
            myMessage.Size = new Size(489, 170);
			myMessage.TopLevel= true;
			myMessage.ShowDialog();
			return myMessage.Resoult;
		}

		public static void SetIconMessage(MyDialogIcon icon)
		{
			switch (icon)
			{
				case MyDialogIcon.Error:
					myMessage.pcbIcon.Image = Properties.Resources.Symbol_Error;
					break;
				case MyDialogIcon.Information:
                    myMessage.pcbIcon.Image = Properties.Resources.Symbol_Information_2;
					break;
				case MyDialogIcon.OK:
                    myMessage.pcbIcon.Image = Properties.Resources.Symbol_Check;
					break;
				case MyDialogIcon.Question:
                    myMessage.pcbIcon.Image = Properties.Resources.Symbol_Question;
					break;
				case MyDialogIcon.Warning:
                    myMessage.pcbIcon.Image = Properties.Resources.Symbol_Warning;
					break;
				default:
                    myMessage.pcbIcon.Image = Properties.Resources.Symbol_Check;
					break;
			}
		}

		public static void SetButtonMessage(MyDialogButton button, bool isPersian)
		{
			if(isPersian)
			{
                myMessage.btnYes.Text = MyDialogResoult.Yes.GetDescription();
				myMessage.btnNo.Text = MyDialogResoult.No.GetDescription();
				myMessage.btnOK.Text = MyDialogResoult.Ok.GetDescription();
				myMessage.btnCancel.Text = MyDialogResoult.Cancel.GetDescription();

			}
			switch (button)
			{
				case MyDialogButton.YesNO:
					myMessage.btnCancel.Visible = false;
					myMessage.btnOK.Visible = false;
                    //myMessage.btnNo.Location = SizeLocation[0];
                    //myMessage.btnYes.Location = SizeLocation[1];
					myMessage.btnNo.Visible = true;
					myMessage.btnYes.Visible = true;
					break;
				case MyDialogButton.Cancel :
					myMessage.btnCancel.Visible = true;
                    //myMessage.btnCancel.Location = SizeLocation[0];
					myMessage.btnOK.Visible = false;
					myMessage.btnNo.Visible = false;
					myMessage.btnYes.Visible = false;
					break;
				case MyDialogButton.OK:
					myMessage.btnCancel.Visible = false;
					myMessage.btnOK.Visible = true;
                    //myMessage.btnOK.Location = SizeLocation[0];
					myMessage.btnNo.Visible = false;
					myMessage.btnYes.Visible = false;
					break;
				case MyDialogButton.OKCancel:
					myMessage.btnOK.Visible = true;
                    //myMessage.btnOK.Location = SizeLocation[0];
					myMessage.btnCancel.Visible = true;
                    //myMessage.btnOK.Location = SizeLocation[1];
					myMessage.btnNo.Visible = false;
					myMessage.btnYes.Visible = false;
					break;
				default:
					myMessage.btnCancel.Visible = false;
					myMessage.btnOK.Visible = false;
					myMessage.btnNo.Visible = false;
					myMessage.btnYes.Visible = false;
					break;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Resoult = MyDialogResoult.Ok;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Resoult = MyDialogResoult.Cancel;
			Close();
		}

		private void MyMessageBox_Paint(object sender, PaintEventArgs e)
		{
            //var mGraphics = e.Graphics;
            //var pen1 = new Pen(Color.FromArgb(96, 155, 173), 1);

            //var Area1 = new Rectangle(0, 0, Width - 1, Height - 1);
            //var LGB = new LinearGradientBrush(Area1, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            //mGraphics.FillRectangle(LGB, Area1);
            //mGraphics.DrawRectangle(pen1, Area1);
			//myMessage.lblTitle.BackColor = Color.Transparent;
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			Resoult = MyDialogResoult.Yes;
			Close();
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			Resoult = MyDialogResoult.No;
			Close();
		}

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
	}
}
