namespace M2_Snapshots
{
    partial class LoginUI
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
            this.LoginPagePnl = new System.Windows.Forms.Panel();
            this.enterAsLbl = new System.Windows.Forms.Label();
            this.teacherRB = new System.Windows.Forms.RadioButton();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.loginBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userTB = new System.Windows.Forms.TextBox();
            this.signInLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.binaryMakersDS1 = new M2_Snapshots.BinaryMakersDS();
            this.userLoginTableAdapter1 = new M2_Snapshots.BinaryMakersDSTableAdapters.UserLoginTableAdapter();
            this.tableAdapterManager1 = new M2_Snapshots.BinaryMakersDSTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LoginPagePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPagePnl
            // 
            this.LoginPagePnl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginPagePnl.Controls.Add(this.enterAsLbl);
            this.LoginPagePnl.Controls.Add(this.teacherRB);
            this.LoginPagePnl.Controls.Add(this.adminRB);
            this.LoginPagePnl.Controls.Add(this.loginBtn);
            this.LoginPagePnl.Controls.Add(this.clearBtn);
            this.LoginPagePnl.Controls.Add(this.passwordTB);
            this.LoginPagePnl.Controls.Add(this.userTB);
            this.LoginPagePnl.Controls.Add(this.signInLbl);
            this.LoginPagePnl.Controls.Add(this.userLbl);
            this.LoginPagePnl.Controls.Add(this.passwordLbl);
            this.LoginPagePnl.Location = new System.Drawing.Point(180, 66);
            this.LoginPagePnl.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPagePnl.Name = "LoginPagePnl";
            this.LoginPagePnl.Size = new System.Drawing.Size(483, 414);
            this.LoginPagePnl.TabIndex = 6;
            this.LoginPagePnl.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPagePnl_Paint);
            // 
            // enterAsLbl
            // 
            this.enterAsLbl.AutoSize = true;
            this.enterAsLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterAsLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.enterAsLbl.Location = new System.Drawing.Point(123, 297);
            this.enterAsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterAsLbl.Name = "enterAsLbl";
            this.enterAsLbl.Size = new System.Drawing.Size(64, 16);
            this.enterAsLbl.TabIndex = 11;
            this.enterAsLbl.Text = "Enter As:";
            // 
            // teacherRB
            // 
            this.teacherRB.AutoSize = true;
            this.teacherRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teacherRB.Location = new System.Drawing.Point(284, 295);
            this.teacherRB.Name = "teacherRB";
            this.teacherRB.Size = new System.Drawing.Size(77, 20);
            this.teacherRB.TabIndex = 10;
            this.teacherRB.TabStop = true;
            this.teacherRB.Text = "Teacher";
            this.teacherRB.UseVisualStyleBackColor = true;
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.BackColor = System.Drawing.Color.Transparent;
            this.adminRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminRB.Location = new System.Drawing.Point(194, 295);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(67, 20);
            this.adminRB.TabIndex = 9;
            this.adminRB.TabStop = true;
            this.adminRB.Text = "Admin";
            this.adminRB.UseVisualStyleBackColor = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginBtn.Location = new System.Drawing.Point(126, 345);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(112, 40);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.DarkGray;
            this.clearBtn.Location = new System.Drawing.Point(249, 345);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 40);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTB.Location = new System.Drawing.Point(126, 231);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(235, 22);
            this.passwordTB.TabIndex = 6;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // userTB
            // 
            this.userTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTB.ForeColor = System.Drawing.Color.DimGray;
            this.userTB.Location = new System.Drawing.Point(126, 144);
            this.userTB.Margin = new System.Windows.Forms.Padding(4);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(235, 22);
            this.userTB.TabIndex = 5;
            this.userTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signInLbl
            // 
            this.signInLbl.AutoSize = true;
            this.signInLbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signInLbl.Location = new System.Drawing.Point(122, 31);
            this.signInLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInLbl.Name = "signInLbl";
            this.signInLbl.Size = new System.Drawing.Size(220, 24);
            this.signInLbl.TabIndex = 4;
            this.signInLbl.Text = "Sign in to dashboard";
            this.signInLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.userLbl.Location = new System.Drawing.Point(123, 115);
            this.userLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(86, 16);
            this.userLbl.TabIndex = 2;
            this.userLbl.Text = "Enter UserID";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.passwordLbl.Location = new System.Drawing.Point(123, 201);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(106, 16);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Enter Password";
            // 
            // binaryMakersDS1
            // 
            this.binaryMakersDS1.DataSetName = "BinaryMakersDS";
            this.binaryMakersDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userLoginTableAdapter1
            // 
            this.userLoginTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.adminsTableAdapter = null;
            this.tableAdapterManager1.adminTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.classesTableAdapter = null;
            this.tableAdapterManager1.PaymentServiceTableAdapter = null;
            this.tableAdapterManager1.studentsTableAdapter = null;
            this.tableAdapterManager1.studentTableAdapter = null;
            this.tableAdapterManager1.subjectResultsTableAdapter = null;
            this.tableAdapterManager1.subjectsTableAdapter = null;
            this.tableAdapterManager1.subjectTeacherTableAdapter = null;
            this.tableAdapterManager1.TeachersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = M2_Snapshots.BinaryMakersDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserLoginTableAdapter = this.userLoginTableAdapter1;
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 512);
            this.Controls.Add(this.LoginPagePnl);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginUI";
            this.Text = "Login UI";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.LoginPagePnl.ResumeLayout(false);
            this.LoginPagePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaryMakersDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPagePnl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Label signInLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label enterAsLbl;
        private System.Windows.Forms.RadioButton teacherRB;
        private System.Windows.Forms.RadioButton adminRB;
        private BinaryMakersDS binaryMakersDS1;
        private BinaryMakersDSTableAdapters.UserLoginTableAdapter userLoginTableAdapter1;
        private BinaryMakersDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}