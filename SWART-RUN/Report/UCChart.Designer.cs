namespace Utilize.Report
{
    partial class UCChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Dundas.Charting.WinControl.ChartArea chartArea2 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series2 = new Dundas.Charting.WinControl.Series();
            this.splc1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbColumnsOfShow = new System.Windows.Forms.CheckedListBox();
            this.ddChart = new Dundas.Charting.WinControl.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splc1)).BeginInit();
            this.splc1.Panel1.SuspendLayout();
            this.splc1.Panel2.SuspendLayout();
            this.splc1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splc1
            // 
            this.splc1.BackColor = System.Drawing.Color.Transparent;
            this.splc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splc1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splc1.Location = new System.Drawing.Point(0, 0);
            this.splc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splc1.Name = "splc1";
            // 
            // splc1.Panel1
            // 
            this.splc1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splc1.Panel1.Controls.Add(this.panel1);
            this.splc1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splc1.Panel2
            // 
            this.splc1.Panel2.Controls.Add(this.ddChart);
            this.splc1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splc1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splc1.Size = new System.Drawing.Size(572, 370);
            this.splc1.SplitterDistance = 91;
            this.splc1.SplitterWidth = 3;
            this.splc1.TabIndex = 138;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.chbColumnsOfShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 370);
            this.panel1.TabIndex = 48;
            // 
            // chbColumnsOfShow
            // 
            this.chbColumnsOfShow.BackColor = System.Drawing.Color.White;
            this.chbColumnsOfShow.CheckOnClick = true;
            this.chbColumnsOfShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbColumnsOfShow.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.chbColumnsOfShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(33)))), ((int)(((byte)(11)))));
            this.chbColumnsOfShow.FormattingEnabled = true;
            this.chbColumnsOfShow.Location = new System.Drawing.Point(0, 0);
            this.chbColumnsOfShow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbColumnsOfShow.Name = "chbColumnsOfShow";
            this.chbColumnsOfShow.Size = new System.Drawing.Size(91, 370);
            this.chbColumnsOfShow.TabIndex = 135;
            this.chbColumnsOfShow.SelectedIndexChanged += new System.EventHandler(this.chbColumnsOfShow_SelectedIndexChanged);
            // 
            // ddChart
            // 
            this.ddChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            this.ddChart.BorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            chartArea2.Name = "Default";
            this.ddChart.ChartAreas.Add(chartArea2);
            this.ddChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ddChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(228)))));
            legend2.Name = "Default";
            this.ddChart.Legends.Add(legend2);
            this.ddChart.Location = new System.Drawing.Point(0, 0);
            this.ddChart.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.ddChart.Name = "ddChart";
            series2.Name = "Series1";
            this.ddChart.Series.Add(series2);
            this.ddChart.Size = new System.Drawing.Size(478, 370);
            this.ddChart.TabIndex = 4;
            this.ddChart.UI.ContextMenu.Enabled = true;
            this.ddChart.UI.Toolbar.Enabled = true;
            // 
            // UCChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.Controls.Add(this.splc1);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCChart";
            this.Size = new System.Drawing.Size(572, 370);
            this.splc1.Panel1.ResumeLayout(false);
            this.splc1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splc1)).EndInit();
            this.splc1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splc1;
        private System.Windows.Forms.Panel panel1;
        private Dundas.Charting.WinControl.Chart ddChart;
        private System.Windows.Forms.CheckedListBox chbColumnsOfShow;

    }
}
