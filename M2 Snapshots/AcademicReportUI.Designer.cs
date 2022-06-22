namespace M2_Snapshots
{
    partial class AcademicReport_UI
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21 = new M2_Snapshots.DataSet2();
            this.subjectResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaryMakersDS = new M2_Snapshots.BinaryMakersDS();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SeartchText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.subjectResultsTableAdapter = new M2_Snapshots.BinaryMakersDSTableAdapters.subjectResultsTableAdapter();
            this.studentTableAdapter = new M2_Snapshots.BinaryMakersDSTableAdapters.studentTableAdapter();
            this.subjResults = new M2_Snapshots.subjResults();
            this.subjResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupPmb2DataSet = new M2_Snapshots.GroupPmb2DataSet();
            this.groupPmb2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new M2_Snapshots.DataSet2TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet21BindingSource;
            // 
            // dataSet21BindingSource
            // 
            this.dataSet21BindingSource.DataSource = this.dataSet21;
            this.dataSet21BindingSource.Position = 0;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectResultsBindingSource
            // 
            this.subjectResultsBindingSource.DataMember = "subjectResults";
            this.subjectResultsBindingSource.DataSource = this.binaryMakersDS;
            // 
            // binaryMakersDS
            // 
            this.binaryMakersDS.DataSetName = "BinaryMakersDS";
            this.binaryMakersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.binaryMakersDS;
            // 
            // SeartchText
            // 
            this.SeartchText.Location = new System.Drawing.Point(88, 12);
            this.SeartchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeartchText.Name = "SeartchText";
            this.SeartchText.Size = new System.Drawing.Size(191, 22);
            this.SeartchText.TabIndex = 1;
            this.SeartchText.TextChanged += new System.EventHandler(this.SeartchText_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(29, 15);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(50, 16);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(12, 724);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(139, 50);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "M2_Snapshots.academicResults.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(71, 51);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 655);
            this.reportViewer1.TabIndex = 30;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // subjectResultsTableAdapter
            // 
            this.subjectResultsTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // subjResults
            // 
            this.subjResults.DataSetName = "subjResults";
            this.subjResults.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjResultsBindingSource
            // 
            this.subjResultsBindingSource.DataSource = this.subjResults;
            this.subjResultsBindingSource.Position = 0;
            // 
            // groupPmb2DataSet
            // 
            this.groupPmb2DataSet.DataSetName = "GroupPmb2DataSet";
            this.groupPmb2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPmb2DataSetBindingSource
            // 
            this.groupPmb2DataSetBindingSource.DataSource = this.groupPmb2DataSet;
            this.groupPmb2DataSetBindingSource.Position = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // AcademicReport_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 787);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SeartchText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AcademicReport_UI";
            this.Text = "AcademicReport_UI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AcademicReport_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button searchbutton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BinaryMakersDS binaryMakersDS;
        private System.Windows.Forms.BindingSource subjectResultsBindingSource;
        private BinaryMakersDSTableAdapters.subjectResultsTableAdapter subjectResultsTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private BinaryMakersDSTableAdapters.studentTableAdapter studentTableAdapter;
        private DataSet2 dataSet21;
        private System.Windows.Forms.BindingSource dataSet21BindingSource;
        private System.Windows.Forms.BindingSource subjResultsBindingSource;
        private subjResults subjResults;
        private System.Windows.Forms.BindingSource groupPmb2DataSetBindingSource;
        private GroupPmb2DataSet groupPmb2DataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        public System.Windows.Forms.TextBox SeartchText;
    }
}