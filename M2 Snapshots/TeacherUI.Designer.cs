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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teachGender = new System.Windows.Forms.ComboBox();
            this.teachTitle = new System.Windows.Forms.TextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addTeach = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TeacherDGV = new System.Windows.Forms.DataGridView();
            this.ClearBtn = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Teacher Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(717, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teachGender);
            this.groupBox1.Controls.Add(this.teachTitle);
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
            // teachGender
            // 
            this.teachGender.FormattingEnabled = true;
            this.teachGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.teachGender.Location = new System.Drawing.Point(158, 136);
            this.teachGender.Name = "teachGender";
            this.teachGender.Size = new System.Drawing.Size(185, 24);
            this.teachGender.TabIndex = 23;
            this.teachGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // teachTitle
            // 
            this.teachTitle.Location = new System.Drawing.Point(557, 37);
            this.teachTitle.Name = "teachTitle";
            this.teachTitle.Size = new System.Drawing.Size(185, 23);
            this.teachTitle.TabIndex = 18;
            this.teachTitle.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // teachEmail
            // 
            this.teachEmail.Location = new System.Drawing.Point(557, 132);
            this.teachEmail.Name = "teachEmail";
            this.teachEmail.Size = new System.Drawing.Size(185, 23);
            this.teachEmail.TabIndex = 17;
            this.teachEmail.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // teachcellNum
            // 
            this.teachcellNum.Location = new System.Drawing.Point(158, 177);
            this.teachcellNum.Name = "teachcellNum";
            this.teachcellNum.Size = new System.Drawing.Size(185, 23);
            this.teachcellNum.TabIndex = 16;
            this.teachcellNum.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // teachAddress
            // 
            this.teachAddress.Location = new System.Drawing.Point(557, 87);
            this.teachAddress.Name = "teachAddress";
            this.teachAddress.Size = new System.Drawing.Size(185, 23);
            this.teachAddress.TabIndex = 15;
            this.teachAddress.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // teachLName
            // 
            this.teachLName.Location = new System.Drawing.Point(158, 79);
            this.teachLName.Name = "teachLName";
            this.teachLName.Size = new System.Drawing.Size(185, 23);
            this.teachLName.TabIndex = 13;
            this.teachLName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Teachers Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(42, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cell Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender:";
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(158, 36);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(185, 23);
            this.teacherName.TabIndex = 5;
            this.teacherName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(608, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search Teacher";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(510, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(71, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addTeach
            // 
            this.addTeach.BackColor = System.Drawing.Color.RoyalBlue;
            this.addTeach.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTeach.Location = new System.Drawing.Point(643, 505);
            this.addTeach.Name = "addTeach";
            this.addTeach.Size = new System.Drawing.Size(98, 40);
            this.addTeach.TabIndex = 25;
            this.addTeach.Text = "Add Teacher";
            this.addTeach.UseVisualStyleBackColor = false;
            this.addTeach.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(782, 505);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 40);
            this.button4.TabIndex = 26;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.ClearBtn.TabIndex = 38;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.classClearBtn_Click);
            // 
            // TeacherUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(938, 566);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.TeacherDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addTeach);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TeacherUI";
            this.Text = "s";
            this.Load += new System.EventHandler(this.TeacherUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox teachTitle;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addTeach;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox teachGender;
        private System.Windows.Forms.Button ClearBtn;
    }
}