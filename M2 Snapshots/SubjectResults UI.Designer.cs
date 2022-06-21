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
            this.subjectResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupPmb2DataSet = new M2_Snapshots.GroupPmb2DataSet();
            this.subjectResultsTableAdapter = new M2_Snapshots.GroupPmb2DataSetTableAdapters.subjectResultsTableAdapter();
            this.SubjectResultsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.termNO = new System.Windows.Forms.TextBox();
            this.termResult = new System.Windows.Forms.TextBox();
            this.subjTeachID = new System.Windows.Forms.TextBox();
            this.subjID = new System.Windows.Forms.TextBox();
            this.subjResID = new System.Windows.Forms.Label();
            this.SubjectResID = new System.Windows.Forms.TextBox();
            this.studID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.ClearSubjectBtn = new System.Windows.Forms.Button();
            this.RemoveSubjectBtn = new System.Windows.Forms.Button();
            this.SearchSubjectBtn = new System.Windows.Forms.Button();
            this.AddResultBtn = new System.Windows.Forms.Button();
            this.UpdateSubjectBtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.searchRes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectResultsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectResultsBindingSource
            // 
            this.subjectResultsBindingSource.DataMember = "subjectResults";
            this.subjectResultsBindingSource.DataSource = this.groupPmb2DataSet;
            // 
            // groupPmb2DataSet
            // 
            this.groupPmb2DataSet.DataSetName = "GroupPmb2DataSet";
            this.groupPmb2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectResultsTableAdapter
            // 
            this.subjectResultsTableAdapter.ClearBeforeFill = true;
            // 
            // SubjectResultsGridView
            // 
            this.SubjectResultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectResultsGridView.Location = new System.Drawing.Point(10, 64);
            this.SubjectResultsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectResultsGridView.Name = "SubjectResultsGridView";
            this.SubjectResultsGridView.RowHeadersWidth = 51;
            this.SubjectResultsGridView.Size = new System.Drawing.Size(976, 268);
            this.SubjectResultsGridView.TabIndex = 31;
            this.SubjectResultsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectResultsGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.termNO);
            this.groupBox1.Controls.Add(this.termResult);
            this.groupBox1.Controls.Add(this.subjTeachID);
            this.groupBox1.Controls.Add(this.subjID);
            this.groupBox1.Controls.Add(this.subjResID);
            this.groupBox1.Controls.Add(this.SubjectResID);
            this.groupBox1.Controls.Add(this.studID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.StudentIDTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(18, 368);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(968, 307);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Subject Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Term Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Term Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Subject Teacher ID:";
            // 
            // termNO
            // 
            this.termNO.Location = new System.Drawing.Point(692, 186);
            this.termNO.Name = "termNO";
            this.termNO.Size = new System.Drawing.Size(257, 23);
            this.termNO.TabIndex = 21;
            this.termNO.TextChanged += new System.EventHandler(this.termNO_TextChanged);
            // 
            // termResult
            // 
            this.termResult.Location = new System.Drawing.Point(692, 114);
            this.termResult.Name = "termResult";
            this.termResult.Size = new System.Drawing.Size(257, 23);
            this.termResult.TabIndex = 20;
            this.termResult.TextChanged += new System.EventHandler(this.termResult_TextChanged);
            // 
            // subjTeachID
            // 
            this.subjTeachID.Location = new System.Drawing.Point(692, 46);
            this.subjTeachID.Name = "subjTeachID";
            this.subjTeachID.Size = new System.Drawing.Size(257, 23);
            this.subjTeachID.TabIndex = 19;
            this.subjTeachID.TextChanged += new System.EventHandler(this.subjTeachID_TextChanged);
            // 
            // subjID
            // 
            this.subjID.Location = new System.Drawing.Point(167, 186);
            this.subjID.Name = "subjID";
            this.subjID.Size = new System.Drawing.Size(257, 23);
            this.subjID.TabIndex = 18;
            this.subjID.TextChanged += new System.EventHandler(this.subjID_TextChanged);
            // 
            // subjResID
            // 
            this.subjResID.AutoSize = true;
            this.subjResID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjResID.ForeColor = System.Drawing.Color.DimGray;
            this.subjResID.Location = new System.Drawing.Point(25, 53);
            this.subjResID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjResID.Name = "subjResID";
            this.subjResID.Size = new System.Drawing.Size(131, 16);
            this.subjResID.TabIndex = 17;
            this.subjResID.Text = "Subject Result ID:";
            // 
            // SubjectResID
            // 
            this.SubjectResID.Location = new System.Drawing.Point(167, 46);
            this.SubjectResID.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectResID.Name = "SubjectResID";
            this.SubjectResID.Size = new System.Drawing.Size(257, 23);
            this.SubjectResID.TabIndex = 7;
            this.SubjectResID.TextChanged += new System.EventHandler(this.SubjectIDTextBox_TextChanged);
            // 
            // studID
            // 
            this.studID.AutoSize = true;
            this.studID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studID.ForeColor = System.Drawing.Color.DimGray;
            this.studID.Location = new System.Drawing.Point(25, 121);
            this.studID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studID.Name = "studID";
            this.studID.Size = new System.Drawing.Size(84, 16);
            this.studID.TabIndex = 5;
            this.studID.Text = "Student ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Subject ID:";
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(167, 114);
            this.StudentIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(257, 23);
            this.StudentIDTextBox.TabIndex = 8;
            this.StudentIDTextBox.TextChanged += new System.EventHandler(this.StudentIDTextBox_TextChanged);
            // 
            // ClearSubjectBtn
            // 
            this.ClearSubjectBtn.Location = new System.Drawing.Point(155, 684);
            this.ClearSubjectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearSubjectBtn.Name = "ClearSubjectBtn";
            this.ClearSubjectBtn.Size = new System.Drawing.Size(119, 48);
            this.ClearSubjectBtn.TabIndex = 43;
            this.ClearSubjectBtn.Text = "Clear";
            this.ClearSubjectBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveSubjectBtn
            // 
            this.RemoveSubjectBtn.BackColor = System.Drawing.Color.Red;
            this.RemoveSubjectBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSubjectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveSubjectBtn.Location = new System.Drawing.Point(488, 683);
            this.RemoveSubjectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveSubjectBtn.Name = "RemoveSubjectBtn";
            this.RemoveSubjectBtn.Size = new System.Drawing.Size(131, 49);
            this.RemoveSubjectBtn.TabIndex = 40;
            this.RemoveSubjectBtn.Text = "Remove";
            this.RemoveSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // SearchSubjectBtn
            // 
            this.SearchSubjectBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchSubjectBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSubjectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchSubjectBtn.Location = new System.Drawing.Point(16, 683);
            this.SearchSubjectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchSubjectBtn.Name = "SearchSubjectBtn";
            this.SearchSubjectBtn.Size = new System.Drawing.Size(131, 49);
            this.SearchSubjectBtn.TabIndex = 39;
            this.SearchSubjectBtn.Text = "Search";
            this.SearchSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // AddResultBtn
            // 
            this.AddResultBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddResultBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResultBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddResultBtn.Location = new System.Drawing.Point(658, 683);
            this.AddResultBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddResultBtn.Name = "AddResultBtn";
            this.AddResultBtn.Size = new System.Drawing.Size(131, 49);
            this.AddResultBtn.TabIndex = 41;
            this.AddResultBtn.Text = "Add Results";
            this.AddResultBtn.UseVisualStyleBackColor = false;
            this.AddResultBtn.Click += new System.EventHandler(this.AddResultBtn_Click);
            // 
            // UpdateSubjectBtn
            // 
            this.UpdateSubjectBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateSubjectBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSubjectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateSubjectBtn.Location = new System.Drawing.Point(834, 683);
            this.UpdateSubjectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateSubjectBtn.Name = "UpdateSubjectBtn";
            this.UpdateSubjectBtn.Size = new System.Drawing.Size(131, 49);
            this.UpdateSubjectBtn.TabIndex = 42;
            this.UpdateSubjectBtn.Text = "Update";
            this.UpdateSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(43, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(50, 16);
            this.Search.TabIndex = 44;
            this.Search.Text = "Search";
            // 
            // searchRes
            // 
            this.searchRes.Location = new System.Drawing.Point(100, 28);
            this.searchRes.Name = "searchRes";
            this.searchRes.Size = new System.Drawing.Size(216, 22);
            this.searchRes.TabIndex = 45;
            // 
            // SubjectResults_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 751);
            this.Controls.Add(this.searchRes);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ClearSubjectBtn);
            this.Controls.Add(this.RemoveSubjectBtn);
            this.Controls.Add(this.SearchSubjectBtn);
            this.Controls.Add(this.AddResultBtn);
            this.Controls.Add(this.UpdateSubjectBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubjectResultsGridView);
            this.Name = "SubjectResults_UI";
            this.Text = "SubjectResults_UI";
            this.Load += new System.EventHandler(this.SubjectResults_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectResultsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupPmb2DataSet groupPmb2DataSet;
        private System.Windows.Forms.BindingSource subjectResultsBindingSource;
        private GroupPmb2DataSetTableAdapters.subjectResultsTableAdapter subjectResultsTableAdapter;
        private System.Windows.Forms.DataGridView SubjectResultsGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox subjID;
        private System.Windows.Forms.Label subjResID;
        private System.Windows.Forms.TextBox SubjectResID;
        private System.Windows.Forms.Label studID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox termResult;
        private System.Windows.Forms.TextBox subjTeachID;
        private System.Windows.Forms.TextBox termNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearSubjectBtn;
        private System.Windows.Forms.Button RemoveSubjectBtn;
        private System.Windows.Forms.Button SearchSubjectBtn;
        private System.Windows.Forms.Button AddResultBtn;
        private System.Windows.Forms.Button UpdateSubjectBtn;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox searchRes;
    }
}