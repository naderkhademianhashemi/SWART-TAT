namespace Presentation.Tabs.LimitManagement
{
    partial class QueryBuilder
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
            this.mssqlMetadataProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.MSSQLMetadataProvider();
            this.sqL92SyntaxProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.SQL92SyntaxProvider();
            this.eventMetadataProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.EventMetadataProvider();
            this.plainTextSQLBuilder1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.PlainTextSQLBuilder();
            this.qblAmount = new ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mssqlMetadataProvider1
            // 
            this.mssqlMetadataProvider1.Connection = null;
            // 
            // eventMetadataProvider1
            // 
            this.eventMetadataProvider1.GetTables += new ActiveDatabaseSoftware.ActiveQueryBuilder.GetObjectNamesEventHandler(this.eventMetadataProvider1_GetTables);
            this.eventMetadataProvider1.GetFields += new ActiveDatabaseSoftware.ActiveQueryBuilder.GetFieldNamesEventHandler(this.eventMetadataProvider1_GetFields);
            this.eventMetadataProvider1.GetRelations += new ActiveDatabaseSoftware.ActiveQueryBuilder.GetTableRelationsEventHandler(this.eventMetadataProvider1_GetRelations);
            // 
            // plainTextSQLBuilder1
            // 
            this.plainTextSQLBuilder1.KeywordFormat = ActiveDatabaseSoftware.ActiveQueryBuilder.KeywordFormat.UpperCase;
            this.plainTextSQLBuilder1.QueryBuilder = this.qblAmount;
            this.plainTextSQLBuilder1.SQLUpdated += new System.EventHandler(this.plainTextSQLBuilder1_SQLUpdated);
            // 
            // qblAmount
            // 
            this.qblAmount.AddObjectFormOptions.Height = 342;
            this.qblAmount.AddObjectFormOptions.MinimumSize = new System.Drawing.Size(430, 430);
            this.qblAmount.AddObjectFormOptions.Width = 294;
            this.qblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qblAmount.CriteriListOptions.CriteriaListFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.qblAmount.DiagramObjectColor = System.Drawing.SystemColors.Window;
            this.qblAmount.DiagramObjectFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qblAmount.Location = new System.Drawing.Point(0, 0);
            this.qblAmount.MetadataProvider = this.eventMetadataProvider1;
            this.qblAmount.MetadataTreeOptions.DatabaseImageIndex = 6;
            this.qblAmount.MetadataTreeOptions.ImageList = null;
            this.qblAmount.MetadataTreeOptions.ProceduresNodeImageIndex = 4;
            this.qblAmount.MetadataTreeOptions.ProceduresNodeText = null;
            this.qblAmount.MetadataTreeOptions.SchemaImageIndex = 5;
            this.qblAmount.MetadataTreeOptions.SystemProceduresImageIndex = 2;
            this.qblAmount.MetadataTreeOptions.SystemTablesImageIndex = 0;
            this.qblAmount.MetadataTreeOptions.SystemViewsImageIndex = 1;
            this.qblAmount.MetadataTreeOptions.TablesNodeImageIndex = 4;
            this.qblAmount.MetadataTreeOptions.TablesNodeText = null;
            this.qblAmount.MetadataTreeOptions.TreeWidth = 200;
            this.qblAmount.MetadataTreeOptions.UserProceduresImageIndex = 2;
            this.qblAmount.MetadataTreeOptions.UserTablesImageIndex = 0;
            this.qblAmount.MetadataTreeOptions.UserViewsImageIndex = 1;
            this.qblAmount.MetadataTreeOptions.ViewsNodeImageIndex = 4;
            this.qblAmount.MetadataTreeOptions.ViewsNodeText = null;
            this.qblAmount.Name = "qblAmount";
            this.qblAmount.QueryStructureTreeOptions.FieldImageIndex = 8;
            this.qblAmount.QueryStructureTreeOptions.FieldsImageIndex = 7;
            this.qblAmount.QueryStructureTreeOptions.FieldsNodeText = "Expressions";
            this.qblAmount.QueryStructureTreeOptions.FromImageIndex = 4;
            this.qblAmount.QueryStructureTreeOptions.FromNodeText = "Objects";
            this.qblAmount.QueryStructureTreeOptions.FromObjImageIndex = 0;
            this.qblAmount.QueryStructureTreeOptions.ImageList = null;
            this.qblAmount.QueryStructureTreeOptions.QueriesImageIndex = 3;
            this.qblAmount.QueryStructureTreeOptions.UnionsNodeText = "Unions";
            this.qblAmount.Size = new System.Drawing.Size(673, 313);
            this.qblAmount.SnapSize = new System.Drawing.Size(5, 5);
            this.qblAmount.SyntaxProvider = this.sqL92SyntaxProvider1;
            this.qblAmount.TabIndex = 2;
            this.qblAmount.TreeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qblAmount.Load += new System.EventHandler(this.qblAmount_Load);
            // 
            // txtSQL
            // 
            this.txtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQL.Location = new System.Drawing.Point(0, 316);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(673, 129);
            this.txtSQL.TabIndex = 3;
            // 
            // QueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.qblAmount);
            this.Name = "QueryBuilder";
            this.Size = new System.Drawing.Size(673, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ActiveDatabaseSoftware.ActiveQueryBuilder.MSSQLMetadataProvider mssqlMetadataProvider1;
        public ActiveDatabaseSoftware.ActiveQueryBuilder.SQL92SyntaxProvider sqL92SyntaxProvider1;
        public ActiveDatabaseSoftware.ActiveQueryBuilder.EventMetadataProvider eventMetadataProvider1;
        private ActiveDatabaseSoftware.ActiveQueryBuilder.PlainTextSQLBuilder plainTextSQLBuilder1;
        public ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder qblAmount;
        public System.Windows.Forms.TextBox txtSQL;
    }
}
