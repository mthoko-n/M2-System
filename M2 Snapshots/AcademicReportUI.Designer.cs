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
            this.SeartchText.Location = new System.Drawing.Point(88, 12);
            this.SeartchText.Name = "SeartchText";
            this.SeartchText.Size = new System.Drawing.Size(190, 22);
            this.SeartchText.TabIndex = 0;
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
            this.searchbutton.Location = new System.Drawing.Point(88, 671);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(139, 50);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "M2_Snapshots.subjResults.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(979, 471);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // AcademicReport_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 733);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SeartchText);
            this.Margin = new System.Windows.Forms.Padding(4);
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