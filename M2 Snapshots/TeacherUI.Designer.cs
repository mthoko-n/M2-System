namespace M2_Snapshots
{
    partial class TeacherUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teachTitle = new System.Windows.Forms.TextBox();
            this.teachGender = new System.Windows.Forms.ComboBox();
            this.teachEmail = new System.Windows.Forms.TextBox();
            this.teachcellNum = new System.Windows.Forms.TextBox();
            this.teachAddress = new System.Windows.Forms.TextBox();
            this.teachLName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.teachID = new System.Windows.Forms.TextBox();
            this.teacherSearchLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.addTeach = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.TeacherDGV = new System.Windows.Forms.DataGridView();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTeacherTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Teacher Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teachTitle);
            this.groupBox1.Controls.Add(this.teachGender);
            this.groupBox1.Controls.Add(this.teachEmail);
            this.groupBox1.Controls.Add(this.teachcellNum);
            this.groupBox1.Controls.Add(this.teachAddress);
            this.groupBox1.Controls.Add(this.teachLName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.teacherName);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(26, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 234);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Teacher";
            // 
            // teachTitle
            // 
            this.teachTitle.Location = new System.Drawing.Point(557, 37);
            this.teachTitle.Name = "teachTitle";
            this.teachTitle.Size = new System.Drawing.Size(185, 20);
            this.teachTitle.TabIndex = 13;
            this.teachTitle.TextChanged += new System.EventHandler(this.teachTitle_TextChanged);
            // 
            // teachGender
            // 
            this.teachGender.FormattingEnabled = true;
            this.teachGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.teachGender.Location = new System.Drawing.Point(158, 136);
            this.teachGender.Name = "teachGender";
            this.teachGender.Size = new System.Drawing.Size(185, 22);
            this.teachGender.TabIndex = 6;
            this.teachGender.SelectedIndexChanged += new System.EventHandler(this.teachGender_SelectedIndexChanged);
            // 
            // teachEmail
            // 
            this.teachEmail.Location = new System.Drawing.Point(557, 132);
            this.teachEmail.Name = "teachEmail";
            this.teachEmail.Size = new System.Drawing.Size(185, 20);
            this.teachEmail.TabIndex = 10;
            this.teachEmail.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // teachcellNum
            // 
            this.teachcellNum.Location = new System.Drawing.Point(158, 177);
            this.teachcellNum.Name = "teachcellNum";
            this.teachcellNum.Size = new System.Drawing.Size(185, 20);
            this.teachcellNum.TabIndex = 7;
            this.teachcellNum.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // teachAddress
            // 
            this.teachAddress.Location = new System.Drawing.Point(557, 87);
            this.teachAddress.Name = "teachAddress";
            this.teachAddress.Size = new System.Drawing.Size(185, 20);
            this.teachAddress.TabIndex = 9;
            this.teachAddress.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // teachLName
            // 
            this.teachLName.Location = new System.Drawing.Point(158, 79);
            this.teachLName.Name = "teachLName";
            this.teachLName.Size = new System.Drawing.Size(185, 20);
            this.teachLName.TabIndex = 5;
            this.teachLName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Teacher\'s Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(42, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cell Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender:";
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(158, 36);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(185, 20);
            this.teacherName.TabIndex = 4;
            this.teacherName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // teachID
            // 
            this.teachID.Location = new System.Drawing.Point(557, 181);
            this.teachID.Name = "teachID";
            this.teachID.Size = new System.Drawing.Size(185, 20);
            this.teachID.TabIndex = 24;
            this.teachID.TextChanged += new System.EventHandler(this.teachID_TextChanged_1);
            // 
            // teacherSearchLbl
            // 
            this.teacherSearchLbl.AutoSize = true;
            this.teacherSearchLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSearchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teacherSearchLbl.Location = new System.Drawing.Point(594, 15);
            this.teacherSearchLbl.Name = "teacherSearchLbl";
            this.teacherSearchLbl.Size = new System.Drawing.Size(84, 14);
            this.teacherSearchLbl.TabIndex = 20;
            this.teacherSearchLbl.Text = "Search Teacher";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 59);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(701, 171);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Red;
            this.remove.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remove.Location = new System.Drawing.Point(510, 505);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(98, 40);
            this.remove.TabIndex = 3;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.RoyalBlue;
            this.search.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Location = new System.Drawing.Point(71, 505);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(98, 40);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // addTeach
            // 
            this.addTeach.BackColor = System.Drawing.Color.RoyalBlue;
            this.addTeach.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTeach.Location = new System.Drawing.Point(643, 505);
            this.addTeach.Name = "addTeach";
            this.addTeach.Size = new System.Drawing.Size(98, 40);
            this.addTeach.TabIndex = 12;
            this.addTeach.Text = "Add Teacher";
            this.addTeach.UseVisualStyleBackColor = false;
            this.addTeach.Click += new System.EventHandler(this.addteach_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.RoyalBlue;
            this.update.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update.Location = new System.Drawing.Point(782, 505);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(98, 40);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // TeacherDGV
            // 
            this.TeacherDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDGV.Location = new System.Drawing.Point(27, 59);
            this.TeacherDGV.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherDGV.Name = "TeacherDGV";
            this.TeacherDGV.RowHeadersWidth = 51;
            this.TeacherDGV.Size = new System.Drawing.Size(853, 171);
            this.TeacherDGV.TabIndex = 18;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(215, 505);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(89, 39);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.classClearBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "ID";
            // 
            // SearchTeacherTextBox
            // 
            this.SearchTeacherTextBox.Location = new System.Drawing.Point(695, 12);
            this.SearchTeacherTextBox.Name = "SearchTeacherTextBox";
            this.SearchTeacherTextBox.Size = new System.Drawing.Size(185, 20);
            this.SearchTeacherTextBox.TabIndex = 14;
            this.SearchTeacherTextBox.TextChanged += new System.EventHandler(this.SearchTeacherTextBox_TextChanged);
            // 
            // TeacherUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(938, 566);
            this.Controls.Add(this.SearchTeacherTextBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.TeacherDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.teacherSearchLbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.search);
            this.Controls.Add(this.addTeach);
            this.Controls.Add(this.update);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TeacherUI";
            this.Text = "Teacher UI";
            this.Load += new System.EventHandler(this.TeacherUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox teachEmail;
        private System.Windows.Forms.TextBox teachcellNum;
        private System.Windows.Forms.TextBox teachAddress;
        private System.Windows.Forms.TextBox teachLName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.DataGridView TeacherDGV;
        private System.Windows.Forms.Label teacherSearchLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button addTeach;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox teachGender;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox teachID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teachTitle;
        private System.Windows.Forms.TextBox SearchTeacherTextBox;
    }
}