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
            this.SeartchText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // SeartchText
            // 
            this.SeartchText.Location = new System.Drawing.Point(66, 10);
            this.SeartchText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SeartchText.Name = "SeartchText";
            this.SeartchText.Size = new System.Drawing.Size(144, 20);
            this.SeartchText.TabIndex = 1;
            this.SeartchText.TextChanged += new System.EventHandler(this.SeartchText_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(22, 12);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(66, 545);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(104, 41);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "M2_Snapshots.subjResults.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 46);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(735, 383);
            this.reportViewer1.TabIndex = 30;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // AcademicReport_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 596);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SeartchText);
            this.Name = "AcademicReport_UI";
            this.Text = "AcademicReport_UI";
            this.Load += new System.EventHandler(this.AcademicReport_UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeartchText;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button searchbutton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}