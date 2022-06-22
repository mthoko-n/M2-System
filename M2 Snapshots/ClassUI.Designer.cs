namespace M2_Snapshots
{
    partial class ClassUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DivisionCB = new System.Windows.Forms.ComboBox();
            this.GradeCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.teachID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DivisionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuildingNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClassRollTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ViewDetalisButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchClassDataGridView = new System.Windows.Forms.DataGridView();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaryMakersDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binaryMakersDS = new M2_Snapshots.BinaryMakersDS();
            this.classClearBtn = new System.Windows.Forms.Button();
            this.paymentServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentServiceTableAdapter = new M2_Snapshots.BinaryMakersDSTableAdapters.PaymentServiceTableAdapter();
            this.classesTableAdapter = new M2_Snapshots.BinaryMakersDSTableAdapters.classesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchClassDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Class Details";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(606, 27);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(163, 20);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DivisionCB);
            this.groupBox1.Controls.Add(this.GradeCB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.teachID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DivisionTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BuildingNoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ClassRollTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClassIDTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(38, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(820, 197);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Class";
            // 
            // DivisionCB
            // 
            this.DivisionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionCB.FormattingEnabled = true;
            this.DivisionCB.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.DivisionCB.Location = new System.Drawing.Point(598, 150);
            this.DivisionCB.Name = "DivisionCB";
            this.DivisionCB.Size = new System.Drawing.Size(171, 22);
            this.DivisionCB.TabIndex = 29;
            // 
            // GradeCB
            // 
            this.GradeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeCB.FormattingEnabled = true;
            this.GradeCB.Items.AddRange(new object[] {
            "",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.GradeCB.Location = new System.Drawing.Point(598, 106);
            this.GradeCB.Name = "GradeCB";
            this.GradeCB.Size = new System.Drawing.Size(171, 22);
            this.GradeCB.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 27;
            this.label9.Text = "Division";
            // 
            // teachID
            // 
            this.teachID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teachID.FormattingEnabled = true;
            this.teachID.Items.AddRange(new object[] {
            ""});
            this.teachID.Location = new System.Drawing.Point(143, 106);
            this.teachID.Margin = new System.Windows.Forms.Padding(2);
            this.teachID.Name = "teachID";
            this.teachID.Size = new System.Drawing.Size(171, 22);
            this.teachID.TabIndex = 6;
            this.teachID.SelectedIndexChanged += new System.EventHandler(this.teacherID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Teacher ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 23;
            this.label7.Text = "Division";
            // 
            // DivisionTextBox
            // 
            this.DivisionTextBox.Location = new System.Drawing.Point(118, 275);
            this.DivisionTextBox.Name = "DivisionTextBox";
            this.DivisionTextBox.Size = new System.Drawing.Size(171, 20);
            this.DivisionTextBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(518, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "Grade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(518, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Building No:";
            // 
            // BuildingNoTextBox
            // 
            this.BuildingNoTextBox.Location = new System.Drawing.Point(598, 65);
            this.BuildingNoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BuildingNoTextBox.Name = "BuildingNoTextBox";
            this.BuildingNoTextBox.Size = new System.Drawing.Size(171, 20);
            this.BuildingNoTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "No. of Students:";
            // 
            // ClassRollTextBox
            // 
            this.ClassRollTextBox.Location = new System.Drawing.Point(143, 150);
            this.ClassRollTextBox.Name = "ClassRollTextBox";
            this.ClassRollTextBox.Size = new System.Drawing.Size(171, 20);
            this.ClassRollTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(36, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class ID:";
            // 
            // ClassIDTextBox
            // 
            this.ClassIDTextBox.Location = new System.Drawing.Point(143, 68);
            this.ClassIDTextBox.Name = "ClassIDTextBox";
            this.ClassIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.ClassIDTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(487, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "Search/Remove Class";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Red;
            this.RemoveButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveButton.Location = new System.Drawing.Point(471, 490);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(98, 40);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ViewDetalisButton
            // 
            this.ViewDetalisButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ViewDetalisButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetalisButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewDetalisButton.Location = new System.Drawing.Point(38, 491);
            this.ViewDetalisButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewDetalisButton.Name = "ViewDetalisButton";
            this.ViewDetalisButton.Size = new System.Drawing.Size(98, 40);
            this.ViewDetalisButton.TabIndex = 2;
            this.ViewDetalisButton.Text = "Search";
            this.ViewDetalisButton.UseVisualStyleBackColor = false;
            this.ViewDetalisButton.Click += new System.EventHandler(this.ViewDetalisButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButton.Location = new System.Drawing.Point(613, 491);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 40);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add Class";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateButton.Location = new System.Drawing.Point(760, 491);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(98, 40);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchClassDataGridView
            // 
            this.SearchClassDataGridView.AutoGenerateColumns = false;
            this.SearchClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchClassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classidDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn,
            this.numStudentsDataGridViewTextBoxColumn,
            this.buildingNoDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn});
            this.SearchClassDataGridView.DataSource = this.classesBindingSource;
            this.SearchClassDataGridView.Location = new System.Drawing.Point(110, 74);
            this.SearchClassDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SearchClassDataGridView.Name = "SearchClassDataGridView";
            this.SearchClassDataGridView.RowHeadersWidth = 51;
            this.SearchClassDataGridView.Size = new System.Drawing.Size(659, 175);
            this.SearchClassDataGridView.TabIndex = 40;
            this.SearchClassDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchClassDataGridView_CellClick);
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "class_id";
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            // 
            // numStudentsDataGridViewTextBoxColumn
            // 
            this.numStudentsDataGridViewTextBoxColumn.DataPropertyName = "numStudents";
            this.numStudentsDataGridViewTextBoxColumn.HeaderText = "numStudents";
            this.numStudentsDataGridViewTextBoxColumn.Name = "numStudentsDataGridViewTextBoxColumn";
            // 
            // buildingNoDataGridViewTextBoxColumn
            // 
            this.buildingNoDataGridViewTextBoxColumn.DataPropertyName = "buildingNo";
            this.buildingNoDataGridViewTextBoxColumn.HeaderText = "buildingNo";
            this.buildingNoDataGridViewTextBoxColumn.Name = "buildingNoDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "classes";
            this.classesBindingSource.DataSource = this.binaryMakersDSBindingSource;
            // 
            // binaryMakersDSBindingSource
            // 
            this.binaryMakersDSBindingSource.DataSource = this.binaryMakersDS;
            this.binaryMakersDSBindingSource.Position = 0;
            // 
            // binaryMakersDS
            // 
            this.binaryMakersDS.DataSetName = "BinaryMakersDS";
            this.binaryMakersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classClearBtn
            // 
            this.classClearBtn.Location = new System.Drawing.Point(195, 490);
            this.classClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.classClearBtn.Name = "classClearBtn";
            this.classClearBtn.Size = new System.Drawing.Size(100, 40);
            this.classClearBtn.TabIndex = 13;
            this.classClearBtn.Text = "Clear";
            this.classClearBtn.UseVisualStyleBackColor = true;
            this.classClearBtn.Click += new System.EventHandler(this.classClearBtn_Click);
            // 
            // paymentServiceBindingSource
            // 
            this.paymentServiceBindingSource.DataMember = "PaymentService";
            this.paymentServiceBindingSource.DataSource = this.binaryMakersDSBindingSource;
            // 
            // paymentServiceTableAdapter
            // 
            this.paymentServiceTableAdapter.ClearBeforeFill = true;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // ClassUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 558);
            this.Controls.Add(this.classClearBtn);
            this.Controls.Add(this.SearchClassDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ViewDetalisButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UpdateButton);
            this.Name = "ClassUI";
            this.Text = "ClassUI";
            this.Load += new System.EventHandler(this.ClassUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchClassDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DivisionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BuildingNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClassRollTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClassIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ViewDetalisButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView SearchClassDataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button classClearBtn;
        private System.Windows.Forms.ComboBox teachID;
        private System.Windows.Forms.Label label9;
        private BinaryMakersDS binaryMakersDS;
        private System.Windows.Forms.BindingSource binaryMakersDSBindingSource;
        private System.Windows.Forms.BindingSource paymentServiceBindingSource;
        private BinaryMakersDSTableAdapters.PaymentServiceTableAdapter paymentServiceTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private BinaryMakersDSTableAdapters.classesTableAdapter classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox DivisionCB;
        private System.Windows.Forms.ComboBox GradeCB;
    }
}