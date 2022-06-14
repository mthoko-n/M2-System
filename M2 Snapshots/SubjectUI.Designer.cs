namespace M2_Snapshots
{
    partial class SubjectUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchSubjectTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectIDTextBox = new System.Windows.Forms.TextBox();
            this.SubjectDetailsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveSubjectBtn = new System.Windows.Forms.Button();
            this.SearchSubjectBtn = new System.Windows.Forms.Button();
            this.AddSubjectBtn = new System.Windows.Forms.Button();
            this.UpdateSubjectBtn = new System.Windows.Forms.Button();
            this.ClearSubjectBtn = new System.Windows.Forms.Button();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Subject Details";
            // 
            // SearchSubjectTextBox
            // 
            this.SearchSubjectTextBox.Location = new System.Drawing.Point(264, 78);
            this.SearchSubjectTextBox.Name = "SearchSubjectTextBox";
            this.SearchSubjectTextBox.Size = new System.Drawing.Size(163, 20);
            this.SearchSubjectTextBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SubjectIDTextBox);
            this.groupBox1.Controls.Add(this.SubjectDetailsTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SubjectNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(505, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 234);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Subject";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(19, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Subject ID:";
            // 
            // SubjectIDTextBox
            // 
            this.SubjectIDTextBox.Location = new System.Drawing.Point(125, 40);
            this.SubjectIDTextBox.Name = "SubjectIDTextBox";
            this.SubjectIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.SubjectIDTextBox.TabIndex = 18;
            // 
            // SubjectDetailsTextBox
            // 
            this.SubjectDetailsTextBox.Location = new System.Drawing.Point(125, 113);
            this.SubjectDetailsTextBox.Multiline = true;
            this.SubjectDetailsTextBox.Name = "SubjectDetailsTextBox";
            this.SubjectDetailsTextBox.Size = new System.Drawing.Size(171, 38);
            this.SubjectDetailsTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Subject Details:";
            // 
            // SubjectNameTextBox
            // 
            this.SubjectNameTextBox.Location = new System.Drawing.Point(125, 75);
            this.SubjectNameTextBox.Name = "SubjectNameTextBox";
            this.SubjectNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.SubjectNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(154, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search Subject";
            // 
            // RemoveSubjectBtn
            // 
            this.RemoveSubjectBtn.BackColor = System.Drawing.Color.Red;
            this.RemoveSubjectBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSubjectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveSubjectBtn.Location = new System.Drawing.Point(490, 469);
            this.RemoveSubjectBtn.Name = "RemoveSubjectBtn";
            this.RemoveSubjectBtn.Size = new System.Drawing.Size(98, 40);
            this.RemoveSubjectBtn.TabIndex = 24;
            this.RemoveSubjectBtn.Text = "Remove";
            this.RemoveSubjectBtn.UseVisualStyleBackColor = false;
            this.RemoveSubjectBtn.Click += new System.EventHandler(this.RemoveSubjectBtn_Click);
            // 
            // SearchSubjectBtn
            // 
            this.SearchSubjectBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchSubjectBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSubjectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchSubjectBtn.Location = new System.Drawing.Point(30, 470);
            this.SearchSubjectBtn.Name = "SearchSubjectBtn";
            this.SearchSubjectBtn.Size = new System.Drawing.Size(98, 40);
            this.SearchSubjectBtn.TabIndex = 23;
            this.SearchSubjectBtn.Text = "Search";
            this.SearchSubjectBtn.UseVisualStyleBackColor = false;
            this.SearchSubjectBtn.Click += new System.EventHandler(this.SearchSubjectBtn_Click);
            // 
            // AddSubjectBtn
            // 
            this.AddSubjectBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddSubjectBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubjectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddSubjectBtn.Location = new System.Drawing.Point(617, 469);
            this.AddSubjectBtn.Name = "AddSubjectBtn";
            this.AddSubjectBtn.Size = new System.Drawing.Size(98, 40);
            this.AddSubjectBtn.TabIndex = 25;
            this.AddSubjectBtn.Text = "Add Subject";
            this.AddSubjectBtn.UseVisualStyleBackColor = false;
            this.AddSubjectBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateSubjectBtn
            // 
            this.UpdateSubjectBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateSubjectBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSubjectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateSubjectBtn.Location = new System.Drawing.Point(749, 469);
            this.UpdateSubjectBtn.Name = "UpdateSubjectBtn";
            this.UpdateSubjectBtn.Size = new System.Drawing.Size(98, 40);
            this.UpdateSubjectBtn.TabIndex = 26;
            this.UpdateSubjectBtn.Text = "Update";
            this.UpdateSubjectBtn.UseVisualStyleBackColor = false;
            this.UpdateSubjectBtn.Click += new System.EventHandler(this.UpdateSubjectBtn_Click);
            // 
            // ClearSubjectBtn
            // 
            this.ClearSubjectBtn.Location = new System.Drawing.Point(183, 470);
            this.ClearSubjectBtn.Name = "ClearSubjectBtn";
            this.ClearSubjectBtn.Size = new System.Drawing.Size(89, 39);
            this.ClearSubjectBtn.TabIndex = 39;
            this.ClearSubjectBtn.Text = "Clear";
            this.ClearSubjectBtn.UseVisualStyleBackColor = true;
            this.ClearSubjectBtn.Click += new System.EventHandler(this.ClearSubjectBtn_Click);
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Location = new System.Drawing.Point(30, 116);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.Size = new System.Drawing.Size(397, 306);
            this.SubjectDataGridView.TabIndex = 40;
            // 
            // SubjectUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 548);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.ClearSubjectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchSubjectTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveSubjectBtn);
            this.Controls.Add(this.SearchSubjectBtn);
            this.Controls.Add(this.AddSubjectBtn);
            this.Controls.Add(this.UpdateSubjectBtn);
            this.Name = "SubjectUI";
            this.Text = "SubjectUI";
            this.Load += new System.EventHandler(this.SubjectUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchSubjectTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SubjectDetailsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubjectNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveSubjectBtn;
        private System.Windows.Forms.Button SearchSubjectBtn;
        private System.Windows.Forms.Button AddSubjectBtn;
        private System.Windows.Forms.Button UpdateSubjectBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SubjectIDTextBox;
        private System.Windows.Forms.Button ClearSubjectBtn;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
    }
}