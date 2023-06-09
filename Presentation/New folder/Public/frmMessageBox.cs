using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentation.Public
{
    public class frmMessageBox : Form
	{
		#region VARS
		private string caption;
		private string text;
		private System.Windows.Forms.MessageBoxButtons buttons;
		private System.Windows.Forms.MessageBoxIcon icon;
		#endregion

		#region CONTRLOS
		private System.Windows.Forms.ImageList imlIcons;
		private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Label lblIcon;
        private Label label1;
        private Utilize.Company.CButton cbClose;		
		private System.ComponentModel.IContainer components;
		#endregion

		public frmMessageBox()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBox));
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClose = new Utilize.Company.CButton();
            this.SuspendLayout();
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "");
            this.imlIcons.Images.SetKeyName(1, "");
            this.imlIcons.Images.SetKeyName(2, "");
            this.imlIcons.Images.SetKeyName(3, "");
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btn1.Location = new System.Drawing.Point(125, 114);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 37);
            this.btn1.TabIndex = 3;
            this.btn1.Tag = "Ignore";
            this.btn1.Text = "ادامه";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            this.btn1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btn2.Location = new System.Drawing.Point(205, 114);
            this.btn2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 37);
            this.btn2.TabIndex = 4;
            this.btn2.Tag = "No";
            this.btn2.Text = "خیر";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            this.btn2.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn2.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImage = global::Presentation.Properties.Resources.S_But75px;
            this.btn3.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.btn3.Location = new System.Drawing.Point(285, 114);
            this.btn3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 37);
            this.btn3.TabIndex = 5;
            this.btn3.Tag = "Yes";
            this.btn3.Text = "بله";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            this.btn3.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn3.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(27, 48);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(404, 60);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "متن پیغام";
            // 
            // lblIcon
            // 
            this.lblIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblIcon.Image")));
            this.lblIcon.Location = new System.Drawing.Point(437, 48);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(32, 32);
            this.lblIcon.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(423, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 27);
            this.label1.TabIndex = 146;
            this.label1.Text = "پیغام";
            // 
            // cbClose
            // 
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.DefaultImage = ((System.Drawing.Image)(resources.GetObject("cbClose.DefaultImage")));
            this.cbClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cbClose.HoverImage = ((System.Drawing.Image)(resources.GetObject("cbClose.HoverImage")));
            this.cbClose.Location = new System.Drawing.Point(14, 6);
            this.cbClose.Name = "cbClose";
            this.cbClose.PicAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClose.Size = new System.Drawing.Size(29, 27);
            this.cbClose.TabIndex = 145;
            this.cbClose.Title = "";
            this.cbClose.CButtonClicked += new System.EventHandler<System.EventArgs>(this.cbClose_CButtonClicked);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblMessage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پیغام ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion		

		public string MsgCaption
		{
			get
			{
				return caption;
			}
			set
			{
				caption = value;
				this.Text = caption;
			}
		}

		public string MsgText
		{
			get
			{
				return text;
			}
			set
			{
				text = value;
				lblMessage.Text = text;
			}
		}

		public MessageBoxIcon MsgIcon
		{
			get
			{
				return icon;
			}
			set
			{
				icon = value;
			}
		}

		public MessageBoxButtons MsgButtons
		{
			get
			{
				return buttons;
			}
			set
			{
				buttons = value;
			}
		}

		private void frmMessageBox_Load(object sender, System.EventArgs e)
		{		
			Graphics g = this.CreateGraphics();
            //Size size = g.MeasureString(text, this.Font).ToSize();
            //this.Width = size.Width + lblIcon.Width + 3*16;		
            //this.Width = (this.Width > 256) ? (this.Width) : (256);
            //this.Height = size.Height + 96;
            //lblMessage.Width = size.Width + 16;
            //lblMessage.Height = size.Height + 16;
            //lblMessage.Top = 12;
            //lblMessage.Left = lblIcon.Left - lblMessage.Width - 12;
			
			if (this.Owner != null)
				this.CenterToParent();
			else
				this.CenterToScreen();

			int numButtons = 0;
			#region BUTTONS
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					numButtons = 1;
					btn2.Text = "تایید";
					btn2.Tag = "OK";
			        btn1.Visible = false;
			        btn3.Visible = false;
					break;

				case MessageBoxButtons.OKCancel:
					numButtons = 2;
					btn3.Text = "تایید";
					btn3.Tag = "OK";
					btn2.Text = "انصراف";
					btn2.Tag = "Cancel";
			        btn1.Visible = false;
					break;

				case MessageBoxButtons.RetryCancel:
					numButtons = 2;
					btn3.Text = "تکرار";
					btn3.Tag = "Retry";
					btn2.Text = "انصراف";
					btn2.Tag = "Cancel";
                    btn1.Visible = false;
					break;

				case MessageBoxButtons.YesNo:
					numButtons = 2;
					btn3.Text = "بله";
					btn3.Tag = "Yes";
					btn2.Text = "خیر";
					btn2.Tag = "No";
                    btn1.Visible = false;
					break;

				case MessageBoxButtons.YesNoCancel:
					numButtons = 3;
					btn3.Text = "بله";
					btn3.Tag = "Yes";
					btn2.Text = "خیر";
					btn2.Tag = "No";					
					btn1.Text = "انصراف";
					btn1.Tag = "Cancel";					
					break;

				case MessageBoxButtons.AbortRetryIgnore:
					numButtons = 3;
					btn3.Text = "خروج";
					btn3.Tag = "Abort";
					btn2.Text = "تکرار";
					btn2.Tag = "Retry";					
					btn1.Text = "ادامه";
					btn1.Tag = "Ignore";					
					break;
			}
			#endregion

			#region PLACEMENT
            //int L = this.Width;
            //int s=4, w=75; //and x=0
            //int h = lblMessage.Height + 20;
            //switch (numButtons)
            //{
            //    case 1:
            //        btn3.Left = (L-w)/2;
            //        btn3.Top = h;
            //        btn2.Visible = false;
            //        btn1.Visible = false;
            //        break;

            //    case 2:
            //        btn2.Left = (L-s)/2 - w;
            //        btn2.Top = h;
            //        btn3.Left = (L-s)/2 - w + w + s;
            //        btn3.Top = h;
            //        btn1.Visible = false;
            //        break;

            //    case 3:
            //        btn1.Left = (L-w)/2 - (s+w);
            //        btn1.Top = h;
            //        btn2.Left = (L-w)/2 - (s+w) + w + s;
            //        btn2.Top = h;
            //        btn3.Left = (L-w)/2 - (s+w) + w + s + w + s;
            //        btn3.Top = h;
            //        break;
            //}
			#endregion

			#region ICONS
			switch (icon)
			{
				case MessageBoxIcon.Stop:
				//case MessageBoxIcon.Error:
				//case MessageBoxIcon.Hand:
					lblIcon.Image = imlIcons.Images[3];
					break;

				case MessageBoxIcon.Exclamation:
				//case MessageBoxIcon.Warning:
					lblIcon.Image = imlIcons.Images[2];
					break;

				case MessageBoxIcon.Information:
				//case MessageBoxIcon.Asterisk:
					lblIcon.Image = imlIcons.Images[0];
					break;

				case MessageBoxIcon.Question:
					lblIcon.Image = imlIcons.Images[1];
					break;				

				case MessageBoxIcon.None:
					lblIcon.Image = null;
					break;
			}
			#endregion
		}

		private void btn_Click(object sender, System.EventArgs e)
		{
            Button btn = (Button)sender;
            DialogResult dr = DialogResult.None;
            
            try
            {
                
                if (btn.Tag.ToString() == "OK")
                    dr = DialogResult.OK;

                if (btn.Tag.ToString() == "Cancel")
                    dr = DialogResult.Cancel;

                if (btn.Tag.ToString() == "Yes")
                    dr = DialogResult.Yes;

                if (btn.Tag.ToString() == "No")
                    dr = DialogResult.No;

                if (btn.Tag.ToString() == "Abort")
                    dr = DialogResult.Abort;

                if (btn.Tag.ToString() == "Retry")
                    dr = DialogResult.Retry;

                if (btn.Tag.ToString() == "Ignore")
                    dr = DialogResult.Ignore;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

		    this.DialogResult = dr;
			this.Close();
		}

        private void cbClose_CButtonClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void btn_MouseHover(object sender, EventArgs e)
        {
          
            Button btn = (Button)sender;
            btn.BackgroundImage = Properties.Resources.S_But75px_Hover;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
          
            Button btn = (Button)sender;
            btn.BackgroundImage = Properties.Resources.S_But75px;
        }
	}
}
