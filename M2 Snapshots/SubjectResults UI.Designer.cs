namespace M2_Snapshots
{
    partial class SubjectResults_UI
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupPmb2DataSet = new M2_Snapshots.GroupPmb2DataSet();
            this.subjectResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectResultsTableAdapter = new M2_Snapshots.GroupPmb2DataSetTableAdapters.subjectResultsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.subjectResultsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "M2_Snapshots.subjResults.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(840, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupPmb2DataSet
            // 
            this.groupPmb2DataSet.DataSetName = "GroupPmb2DataSet";
            this.groupPmb2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectResultsBindingSource
            // 
            this.subjectResultsBindingSource.DataMember = "subjectResults";
            this.subjectResultsBindingSource.DataSource = this.groupPmb2DataSet;
            // 
            // subjectResultsTableAdapter
            // 
            this.subjectResultsTableAdapter.ClearBeforeFill = true;
            // 
            // SubjectResults_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 505);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SubjectResults_UI";
            this.Text = "SubjectResults_UI";
            this.Load += new System.EventHandler(this.SubjectResults_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectResultsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GroupPmb2DataSet groupPmb2DataSet;
        private System.Windows.Forms.BindingSource subjectResultsBindingSource;
        private GroupPmb2DataSetTableAdapters.subjectResultsTableAdapter subjectResultsTableAdapter;
    }
}