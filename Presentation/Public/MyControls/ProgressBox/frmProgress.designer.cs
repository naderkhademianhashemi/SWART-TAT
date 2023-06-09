namespace Presentation.Public
{
    partial class frmProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgress));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spProgress = new Presentation.Public.SpinningProgress();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label4.Location = new System.Drawing.Point(133, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "زمان سپری شده :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(110, 58);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "لطفا منتظر بمانيد ...";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.lblTime.Location = new System.Drawing.Point(93, 87);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نرم افزار هم اكنون در حال انجام عمليات است .\r\n";
            // 
            // spProgress
            // 
            this.spProgress.ActiveSegmentColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spProgress.AutoIncrement = false;
            this.spProgress.AutoIncrementFrequency = 100D;
            this.spProgress.BehindTransistionSegmentIsActive = false;
            this.spProgress.Location = new System.Drawing.Point(25, 54);
            this.spProgress.Name = "spProgress";
            this.spProgress.Size = new System.Drawing.Size(30, 30);
            this.spProgress.TabIndex = 1;
            this.spProgress.TransistionSegment = 10;
            this.spProgress.TransistionSegmentColour = System.Drawing.Color.Maroon;
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(310, 123);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.spProgress);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProgress";
            this.ShowIcon = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmProgress_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProgress_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmProgress_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Presentation.Public.SpinningProgress spProgress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer;
    }
}