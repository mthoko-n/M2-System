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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teachID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DivisionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
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
            this.classClearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchClassDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 28;
            this.label1.Text = "Class Details";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(808, 33);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(216, 22);
            this.SearchTextBox.TabIndex = 27;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teachID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DivisionTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GradeTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BuildingNoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ClassRollTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClassIDTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(51, 326);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1093, 242);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Class";
            // 
            // teachID
            // 
            this.teachID.FormattingEnabled = true;
            this.teachID.Items.AddRange(new object[] {
            "",
            "Female"});
            this.teachID.Location = new System.Drawing.Point(191, 130);
            this.teachID.Name = "teachID";
            this.teachID.Size = new System.Drawing.Size(227, 24);
            this.teachID.TabIndex = 26;
            this.teachID.SelectedIndexChanged += new System.EventHandler(this.teacherID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Teacher ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(16, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Division";
            // 
            // DivisionTextBox
            // 
            this.DivisionTextBox.Location = new System.Drawing.Point(157, 338);
            this.DivisionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DivisionTextBox.Name = "DivisionTextBox";
            this.DivisionTextBox.Size = new System.Drawing.Size(227, 23);
            this.DivisionTextBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(691, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Grade:";
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.Location = new System.Drawing.Point(797, 127);
            this.GradeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(227, 23);
            this.GradeTextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(691, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Building No:";
            // 
            // BuildingNoTextBox
            // 
            this.BuildingNoTextBox.Location = new System.Drawing.Point(797, 80);
            this.BuildingNoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuildingNoTextBox.Name = "BuildingNoTextBox";
            this.BuildingNoTextBox.Size = new System.Drawing.Size(227, 23);
            this.BuildingNoTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(49, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "No. of Students:";
            // 
            // ClassRollTextBox
            // 
            this.ClassRollTextBox.Location = new System.Drawing.Point(191, 185);
            this.ClassRollTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClassRollTextBox.Name = "ClassRollTextBox";
            this.ClassRollTextBox.Size = new System.Drawing.Size(227, 23);
            this.ClassRollTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(48, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class ID:";
            // 
            // ClassIDTextBox
            // 
            this.ClassIDTextBox.Location = new System.Drawing.Point(191, 84);
            this.ClassIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClassIDTextBox.Name = "ClassIDTextBox";
            this.ClassIDTextBox.Size = new System.Drawing.Size(227, 23);
            this.ClassIDTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(692, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Search Class ID";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Red;
            this.RemoveButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveButton.Location = new System.Drawing.Point(628, 603);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(131, 49);
            this.RemoveButton.TabIndex = 33;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ViewDetalisButton
            // 
            this.ViewDetalisButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ViewDetalisButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetalisButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewDetalisButton.Location = new System.Drawing.Point(51, 604);
            this.ViewDetalisButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewDetalisButton.Name = "ViewDetalisButton";
            this.ViewDetalisButton.Size = new System.Drawing.Size(131, 49);
            this.ViewDetalisButton.TabIndex = 32;
            this.ViewDetalisButton.Text = "Search";
            this.ViewDetalisButton.UseVisualStyleBackColor = false;
            this.ViewDetalisButton.Click += new System.EventHandler(this.ViewDetalisButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButton.Location = new System.Drawing.Point(817, 604);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(131, 49);
            this.AddButton.TabIndex = 34;
            this.AddButton.Text = "Add Class";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateButton.Location = new System.Drawing.Point(1013, 604);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(131, 49);
            this.UpdateButton.TabIndex = 35;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchClassDataGridView
            // 
            this.SearchClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchClassDataGridView.Location = new System.Drawing.Point(147, 91);
            this.SearchClassDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchClassDataGridView.Name = "SearchClassDataGridView";
            this.SearchClassDataGridView.RowHeadersWidth = 51;
            this.SearchClassDataGridView.Size = new System.Drawing.Size(879, 215);
            this.SearchClassDataGridView.TabIndex = 36;
            this.SearchClassDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchClassDataGridView_CellContentClick);
            // 
            // classClearBtn
            // 
            this.classClearBtn.Location = new System.Drawing.Point(260, 603);
            this.classClearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classClearBtn.Name = "classClearBtn";
            this.classClearBtn.Size = new System.Drawing.Size(133, 49);
            this.classClearBtn.TabIndex = 37;
            this.classClearBtn.Text = "Clear";
            this.classClearBtn.UseVisualStyleBackColor = true;
            this.classClearBtn.Click += new System.EventHandler(this.classClearBtn_Click);
            // 
            // ClassUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 687);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClassUI";
            this.Text = "ClassUI";
            this.Load += new System.EventHandler(this.ClassUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchClassDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox GradeTextBox;
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
    }
}