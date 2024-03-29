﻿namespace M2_Snapshots
{
    partial class StudentUI
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
        }//c

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stuUpdateBtn = new System.Windows.Forms.Button();
            this.stuRemoveBtn = new System.Windows.Forms.Button();
            this.stuViewBtn = new System.Windows.Forms.Button();
            this.stuFeesTB = new System.Windows.Forms.TextBox();
            this.stuIdTB = new System.Windows.Forms.TextBox();
            this.stuAddressTB = new System.Windows.Forms.TextBox();
            this.stuLastNameTB = new System.Windows.Forms.TextBox();
            this.stuFeesLbl = new System.Windows.Forms.Label();
            this.stuAddBtn = new System.Windows.Forms.Button();
            this.stuNameLbl = new System.Windows.Forms.Label();
            this.stuLastNameLbl = new System.Windows.Forms.Label();
            this.stuAddrLbl = new System.Windows.Forms.Label();
            this.stuGenderLbl = new System.Windows.Forms.Label();
            this.stuNameTB = new System.Windows.Forms.TextBox();
            this.stuSearchLbl = new System.Windows.Forms.Label();
            this.stuHeadingLbl = new System.Windows.Forms.Label();
            this.stuSearchTB = new System.Windows.Forms.TextBox();
            this.stuIdLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stuAgeCB = new System.Windows.Forms.ComboBox();
            this.StuClassIDCB = new System.Windows.Forms.ComboBox();
            this.stuAgeLbl = new System.Windows.Forms.Label();
            this.stuClassIdLbl = new System.Windows.Forms.Label();
            this.stuGenderCB = new System.Windows.Forms.ComboBox();
            this.stuParentNoTB = new System.Windows.Forms.TextBox();
            this.stuParentNoLbl = new System.Windows.Forms.Label();
            this.studentDGV = new System.Windows.Forms.DataGridView();
            this.stuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stusurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stugenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupPmb2DataSet = new M2_Snapshots.GroupPmb2DataSet();
            this.stuClearBtn = new System.Windows.Forms.Button();
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupPmb2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new M2_Snapshots.GroupPmb2DataSetTableAdapters.studentTableAdapter();
            this.binaryMakersDS = new M2_Snapshots.BinaryMakersDS();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new M2_Snapshots.BinaryMakersDSTableAdapters.studentTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stuUpdateBtn
            // 
            this.stuUpdateBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.stuUpdateBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuUpdateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stuUpdateBtn.Location = new System.Drawing.Point(969, 536);
            this.stuUpdateBtn.Name = "stuUpdateBtn";
            this.stuUpdateBtn.Size = new System.Drawing.Size(98, 40);
            this.stuUpdateBtn.TabIndex = 5;
            this.stuUpdateBtn.Text = "Update";
            this.stuUpdateBtn.UseVisualStyleBackColor = false;
            this.stuUpdateBtn.Click += new System.EventHandler(this.stuUpdateBtn_Click);
            // 
            // stuRemoveBtn
            // 
            this.stuRemoveBtn.BackColor = System.Drawing.Color.Red;
            this.stuRemoveBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuRemoveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stuRemoveBtn.Location = new System.Drawing.Point(644, 536);
            this.stuRemoveBtn.Name = "stuRemoveBtn";
            this.stuRemoveBtn.Size = new System.Drawing.Size(98, 40);
            this.stuRemoveBtn.TabIndex = 3;
            this.stuRemoveBtn.Text = "Remove";
            this.stuRemoveBtn.UseVisualStyleBackColor = false;
            this.stuRemoveBtn.Click += new System.EventHandler(this.stuRemoveBtn_Click);
            // 
            // stuViewBtn
            // 
            this.stuViewBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.stuViewBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuViewBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stuViewBtn.Location = new System.Drawing.Point(41, 536);
            this.stuViewBtn.Name = "stuViewBtn";
            this.stuViewBtn.Size = new System.Drawing.Size(98, 40);
            this.stuViewBtn.TabIndex = 2;
            this.stuViewBtn.Text = "Search";
            this.stuViewBtn.UseVisualStyleBackColor = false;
            this.stuViewBtn.Click += new System.EventHandler(this.stuViewBtn_Click);
            // 
            // stuFeesTB
            // 
            this.stuFeesTB.Location = new System.Drawing.Point(825, 113);
            this.stuFeesTB.Name = "stuFeesTB";
            this.stuFeesTB.Size = new System.Drawing.Size(203, 20);
            this.stuFeesTB.TabIndex = 15;
            this.stuFeesTB.TextChanged += new System.EventHandler(this.stuFeesTB_TextChanged);
            // 
            // stuIdTB
            // 
            this.stuIdTB.Location = new System.Drawing.Point(112, 31);
            this.stuIdTB.Name = "stuIdTB";
            this.stuIdTB.Size = new System.Drawing.Size(203, 20);
            this.stuIdTB.TabIndex = 7;
            // 
            // stuAddressTB
            // 
            this.stuAddressTB.Location = new System.Drawing.Point(112, 204);
            this.stuAddressTB.Name = "stuAddressTB";
            this.stuAddressTB.Size = new System.Drawing.Size(203, 20);
            this.stuAddressTB.TabIndex = 11;
            // 
            // stuLastNameTB
            // 
            this.stuLastNameTB.Location = new System.Drawing.Point(112, 159);
            this.stuLastNameTB.Name = "stuLastNameTB";
            this.stuLastNameTB.Size = new System.Drawing.Size(203, 20);
            this.stuLastNameTB.TabIndex = 10;
            // 
            // stuFeesLbl
            // 
            this.stuFeesLbl.AutoSize = true;
            this.stuFeesLbl.Location = new System.Drawing.Point(730, 119);
            this.stuFeesLbl.Name = "stuFeesLbl";
            this.stuFeesLbl.Size = new System.Drawing.Size(82, 14);
            this.stuFeesLbl.TabIndex = 12;
            this.stuFeesLbl.Text = "Fees Balance:";
            // 
            // stuAddBtn
            // 
            this.stuAddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.stuAddBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuAddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stuAddBtn.Location = new System.Drawing.Point(800, 536);
            this.stuAddBtn.Name = "stuAddBtn";
            this.stuAddBtn.Size = new System.Drawing.Size(98, 40);
            this.stuAddBtn.TabIndex = 4;
            this.stuAddBtn.Text = "Add Student";
            this.stuAddBtn.UseVisualStyleBackColor = false;
            this.stuAddBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // stuNameLbl
            // 
            this.stuNameLbl.AutoSize = true;
            this.stuNameLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.stuNameLbl.Location = new System.Drawing.Point(19, 119);
            this.stuNameLbl.Name = "stuNameLbl";
            this.stuNameLbl.Size = new System.Drawing.Size(41, 14);
            this.stuNameLbl.TabIndex = 5;
            this.stuNameLbl.Text = "Name:";
            // 
            // stuLastNameLbl
            // 
            this.stuLastNameLbl.AutoSize = true;
            this.stuLastNameLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuLastNameLbl.Location = new System.Drawing.Point(19, 165);
            this.stuLastNameLbl.Name = "stuLastNameLbl";
            this.stuLastNameLbl.Size = new System.Drawing.Size(68, 14);
            this.stuLastNameLbl.TabIndex = 6;
            this.stuLastNameLbl.Text = "Last Name:";
            this.stuLastNameLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // stuAddrLbl
            // 
            this.stuAddrLbl.AutoSize = true;
            this.stuAddrLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuAddrLbl.Location = new System.Drawing.Point(19, 210);
            this.stuAddrLbl.Name = "stuAddrLbl";
            this.stuAddrLbl.Size = new System.Drawing.Size(58, 14);
            this.stuAddrLbl.TabIndex = 9;
            this.stuAddrLbl.Text = "Address:";
            // 
            // stuGenderLbl
            // 
            this.stuGenderLbl.AutoSize = true;
            this.stuGenderLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuGenderLbl.Location = new System.Drawing.Point(730, 41);
            this.stuGenderLbl.Name = "stuGenderLbl";
            this.stuGenderLbl.Size = new System.Drawing.Size(51, 14);
            this.stuGenderLbl.TabIndex = 8;
            this.stuGenderLbl.Text = "Gender:";
            // 
            // stuNameTB
            // 
            this.stuNameTB.Location = new System.Drawing.Point(112, 113);
            this.stuNameTB.Name = "stuNameTB";
            this.stuNameTB.Size = new System.Drawing.Size(203, 20);
            this.stuNameTB.TabIndex = 9;
            // 
            // stuSearchLbl
            // 
            this.stuSearchLbl.AutoSize = true;
            this.stuSearchLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuSearchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stuSearchLbl.Location = new System.Drawing.Point(735, 22);
            this.stuSearchLbl.Name = "stuSearchLbl";
            this.stuSearchLbl.Size = new System.Drawing.Size(124, 14);
            this.stuSearchLbl.TabIndex = 11;
            this.stuSearchLbl.Text = "Search/Remove Student";
            // 
            // stuHeadingLbl
            // 
            this.stuHeadingLbl.AutoSize = true;
            this.stuHeadingLbl.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuHeadingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stuHeadingLbl.Location = new System.Drawing.Point(36, 12);
            this.stuHeadingLbl.Name = "stuHeadingLbl";
            this.stuHeadingLbl.Size = new System.Drawing.Size(173, 27);
            this.stuHeadingLbl.TabIndex = 10;
            this.stuHeadingLbl.Text = "Student Details";
            // 
            // stuSearchTB
            // 
            this.stuSearchTB.Location = new System.Drawing.Point(865, 19);
            this.stuSearchTB.Name = "stuSearchTB";
            this.stuSearchTB.Size = new System.Drawing.Size(163, 20);
            this.stuSearchTB.TabIndex = 1;
            // 
            // stuIdLbl
            // 
            this.stuIdLbl.AutoSize = true;
            this.stuIdLbl.Location = new System.Drawing.Point(19, 37);
            this.stuIdLbl.Name = "stuIdLbl";
            this.stuIdLbl.Size = new System.Drawing.Size(66, 14);
            this.stuIdLbl.TabIndex = 10;
            this.stuIdLbl.Text = "Student ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stuAgeCB);
            this.groupBox1.Controls.Add(this.StuClassIDCB);
            this.groupBox1.Controls.Add(this.stuAgeLbl);
            this.groupBox1.Controls.Add(this.stuClassIdLbl);
            this.groupBox1.Controls.Add(this.stuGenderCB);
            this.groupBox1.Controls.Add(this.stuParentNoTB);
            this.groupBox1.Controls.Add(this.stuParentNoLbl);
            this.groupBox1.Controls.Add(this.stuFeesTB);
            this.groupBox1.Controls.Add(this.stuIdTB);
            this.groupBox1.Controls.Add(this.stuAddressTB);
            this.groupBox1.Controls.Add(this.stuLastNameTB);
            this.groupBox1.Controls.Add(this.stuGenderLbl);
            this.groupBox1.Controls.Add(this.stuFeesLbl);
            this.groupBox1.Controls.Add(this.stuNameTB);
            this.groupBox1.Controls.Add(this.stuNameLbl);
            this.groupBox1.Controls.Add(this.stuIdLbl);
            this.groupBox1.Controls.Add(this.stuLastNameLbl);
            this.groupBox1.Controls.Add(this.stuAddrLbl);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(41, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1073, 278);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Student";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // stuAgeCB
            // 
            this.stuAgeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuAgeCB.FormattingEnabled = true;
            this.stuAgeCB.Items.AddRange(new object[] {
            "",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.stuAgeCB.Location = new System.Drawing.Point(823, 72);
            this.stuAgeCB.Name = "stuAgeCB";
            this.stuAgeCB.Size = new System.Drawing.Size(205, 22);
            this.stuAgeCB.TabIndex = 27;
            // 
            // StuClassIDCB
            // 
            this.StuClassIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StuClassIDCB.FormattingEnabled = true;
            this.StuClassIDCB.ItemHeight = 14;
            this.StuClassIDCB.Location = new System.Drawing.Point(112, 69);
            this.StuClassIDCB.Name = "StuClassIDCB";
            this.StuClassIDCB.Size = new System.Drawing.Size(203, 22);
            this.StuClassIDCB.TabIndex = 8;
            // 
            // stuAgeLbl
            // 
            this.stuAgeLbl.AutoSize = true;
            this.stuAgeLbl.Location = new System.Drawing.Point(730, 80);
            this.stuAgeLbl.Name = "stuAgeLbl";
            this.stuAgeLbl.Size = new System.Drawing.Size(32, 14);
            this.stuAgeLbl.TabIndex = 26;
            this.stuAgeLbl.Text = "Age:";
            // 
            // stuClassIdLbl
            // 
            this.stuClassIdLbl.AutoSize = true;
            this.stuClassIdLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuClassIdLbl.Location = new System.Drawing.Point(19, 77);
            this.stuClassIdLbl.Name = "stuClassIdLbl";
            this.stuClassIdLbl.Size = new System.Drawing.Size(54, 14);
            this.stuClassIdLbl.TabIndex = 24;
            this.stuClassIdLbl.Text = "Class ID:";
            // 
            // stuGenderCB
            // 
            this.stuGenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuGenderCB.FormattingEnabled = true;
            this.stuGenderCB.ItemHeight = 14;
            this.stuGenderCB.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.stuGenderCB.Location = new System.Drawing.Point(823, 35);
            this.stuGenderCB.Name = "stuGenderCB";
            this.stuGenderCB.Size = new System.Drawing.Size(204, 22);
            this.stuGenderCB.TabIndex = 12;
            // 
            // stuParentNoTB
            // 
            this.stuParentNoTB.Location = new System.Drawing.Point(824, 159);
            this.stuParentNoTB.Name = "stuParentNoTB";
            this.stuParentNoTB.Size = new System.Drawing.Size(204, 20);
            this.stuParentNoTB.TabIndex = 16;
            // 
            // stuParentNoLbl
            // 
            this.stuParentNoLbl.AutoSize = true;
            this.stuParentNoLbl.Location = new System.Drawing.Point(730, 165);
            this.stuParentNoLbl.Name = "stuParentNoLbl";
            this.stuParentNoLbl.Size = new System.Drawing.Size(63, 14);
            this.stuParentNoLbl.TabIndex = 21;
            this.stuParentNoLbl.Text = "Parent No:";
            // 
            // studentDGV
            // 
            this.studentDGV.AutoGenerateColumns = false;
            this.studentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIDDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.stunameDataGridViewTextBoxColumn,
            this.stusurnameDataGridViewTextBoxColumn,
            this.stuaddressDataGridViewTextBoxColumn,
            this.stuemailDataGridViewTextBoxColumn,
            this.stuageDataGridViewTextBoxColumn,
            this.stugenderDataGridViewTextBoxColumn,
            this.stuFeesDataGridViewTextBoxColumn,
            this.parentContactDataGridViewTextBoxColumn});
            this.studentDGV.DataSource = this.studentBindingSource;
            this.studentDGV.Location = new System.Drawing.Point(41, 63);
            this.studentDGV.Name = "studentDGV";
            this.studentDGV.RowHeadersWidth = 51;
            this.studentDGV.Size = new System.Drawing.Size(1150, 150);
            this.studentDGV.TabIndex = 18;
            this.studentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDGV_CellClick);
            this.studentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDGV_CellContentClick);
            // 
            // stuIDDataGridViewTextBoxColumn
            // 
            this.stuIDDataGridViewTextBoxColumn.DataPropertyName = "stu_ID";
            this.stuIDDataGridViewTextBoxColumn.HeaderText = "stu_ID";
            this.stuIDDataGridViewTextBoxColumn.Name = "stuIDDataGridViewTextBoxColumn";
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "classID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "classID";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            // 
            // stunameDataGridViewTextBoxColumn
            // 
            this.stunameDataGridViewTextBoxColumn.DataPropertyName = "stu_name";
            this.stunameDataGridViewTextBoxColumn.HeaderText = "stu_name";
            this.stunameDataGridViewTextBoxColumn.Name = "stunameDataGridViewTextBoxColumn";
            // 
            // stusurnameDataGridViewTextBoxColumn
            // 
            this.stusurnameDataGridViewTextBoxColumn.DataPropertyName = "stu_surname";
            this.stusurnameDataGridViewTextBoxColumn.HeaderText = "stu_surname";
            this.stusurnameDataGridViewTextBoxColumn.Name = "stusurnameDataGridViewTextBoxColumn";
            // 
            // stuaddressDataGridViewTextBoxColumn
            // 
            this.stuaddressDataGridViewTextBoxColumn.DataPropertyName = "stu_address";
            this.stuaddressDataGridViewTextBoxColumn.HeaderText = "stu_address";
            this.stuaddressDataGridViewTextBoxColumn.Name = "stuaddressDataGridViewTextBoxColumn";
            // 
            // stuemailDataGridViewTextBoxColumn
            // 
            this.stuemailDataGridViewTextBoxColumn.DataPropertyName = "stu_email";
            this.stuemailDataGridViewTextBoxColumn.HeaderText = "stu_email";
            this.stuemailDataGridViewTextBoxColumn.Name = "stuemailDataGridViewTextBoxColumn";
            // 
            // stuageDataGridViewTextBoxColumn
            // 
            this.stuageDataGridViewTextBoxColumn.DataPropertyName = "stu_age";
            this.stuageDataGridViewTextBoxColumn.HeaderText = "stu_age";
            this.stuageDataGridViewTextBoxColumn.Name = "stuageDataGridViewTextBoxColumn";
            // 
            // stugenderDataGridViewTextBoxColumn
            // 
            this.stugenderDataGridViewTextBoxColumn.DataPropertyName = "stu_gender";
            this.stugenderDataGridViewTextBoxColumn.HeaderText = "stu_gender";
            this.stugenderDataGridViewTextBoxColumn.Name = "stugenderDataGridViewTextBoxColumn";
            // 
            // stuFeesDataGridViewTextBoxColumn
            // 
            this.stuFeesDataGridViewTextBoxColumn.DataPropertyName = "stu_Fees";
            this.stuFeesDataGridViewTextBoxColumn.HeaderText = "stu_Fees";
            this.stuFeesDataGridViewTextBoxColumn.Name = "stuFeesDataGridViewTextBoxColumn";
            // 
            // parentContactDataGridViewTextBoxColumn
            // 
            this.parentContactDataGridViewTextBoxColumn.DataPropertyName = "parentContact";
            this.parentContactDataGridViewTextBoxColumn.HeaderText = "parentContact";
            this.parentContactDataGridViewTextBoxColumn.Name = "parentContactDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.groupPmb2DataSet;
            // 
            // groupPmb2DataSet
            // 
            this.groupPmb2DataSet.DataSetName = "GroupPmb2DataSet";
            this.groupPmb2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuClearBtn
            // 
            this.stuClearBtn.Location = new System.Drawing.Point(267, 536);
            this.stuClearBtn.Name = "stuClearBtn";
            this.stuClearBtn.Size = new System.Drawing.Size(89, 39);
            this.stuClearBtn.TabIndex = 6;
            this.stuClearBtn.Text = "Clear";
            this.stuClearBtn.UseVisualStyleBackColor = true;
            this.stuClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // binaryMakersDS
            // 
            this.binaryMakersDS.DataSetName = "BinaryMakersDS";
            this.binaryMakersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.binaryMakersDS;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 588);
            this.Controls.Add(this.stuClearBtn);
            this.Controls.Add(this.studentDGV);
            this.Controls.Add(this.stuUpdateBtn);
            this.Controls.Add(this.stuRemoveBtn);
            this.Controls.Add(this.stuViewBtn);
            this.Controls.Add(this.stuAddBtn);
            this.Controls.Add(this.stuSearchLbl);
            this.Controls.Add(this.stuHeadingLbl);
            this.Controls.Add(this.stuSearchTB);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentUI";
            this.Text = "StudentUI";
            this.Load += new System.EventHandler(this.StudentUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stuUpdateBtn;
        private System.Windows.Forms.Button stuRemoveBtn;
        private System.Windows.Forms.Button stuViewBtn;
        private System.Windows.Forms.TextBox stuFeesTB;
        private System.Windows.Forms.TextBox stuIdTB;
        private System.Windows.Forms.TextBox stuAddressTB;
        private System.Windows.Forms.TextBox stuLastNameTB;
        private System.Windows.Forms.Label stuFeesLbl;
        private System.Windows.Forms.Button stuAddBtn;
        private System.Windows.Forms.Label stuNameLbl;
        private System.Windows.Forms.Label stuLastNameLbl;
        private System.Windows.Forms.Label stuAddrLbl;
        private System.Windows.Forms.Label stuGenderLbl;
        private System.Windows.Forms.TextBox stuNameTB;
        private System.Windows.Forms.Label stuSearchLbl;
        private System.Windows.Forms.Label stuHeadingLbl;
        private System.Windows.Forms.TextBox stuSearchTB;
        private System.Windows.Forms.Label stuIdLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stuParentNoTB;
        private System.Windows.Forms.Label stuParentNoLbl;
        private System.Windows.Forms.DataGridView studentDGV;
        private System.Windows.Forms.ComboBox stuGenderCB;
        private System.Windows.Forms.Label stuAgeLbl;
        private System.Windows.Forms.Label stuClassIdLbl;
        private System.Windows.Forms.Button stuClearBtn;
        private System.Windows.Forms.ComboBox StuClassIDCB;
        private System.Windows.Forms.ComboBox stuAgeCB;
        private System.Windows.Forms.BindingSource groupPmb2DataSet1BindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private GroupPmb2DataSet groupPmb2DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private GroupPmb2DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stusurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stugenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuFeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentContactDataGridViewTextBoxColumn;
        private BinaryMakersDS binaryMakersDS;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private BinaryMakersDSTableAdapters.studentTableAdapter studentTableAdapter1;
    }
}