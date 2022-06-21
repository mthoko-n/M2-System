namespace M2_Snapshots
{
    partial class PaymentUI
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
            this.payAddBtn = new System.Windows.Forms.Button();
            this.paySearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.paySearchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payReceiptNoTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.payStuIdTB = new System.Windows.Forms.TextBox();
            this.payAmountTB = new System.Windows.Forms.TextBox();
            this.payDetailsTB = new System.Windows.Forms.TextBox();
            this.payDateTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payAdminIdTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.payTypeCB = new System.Windows.Forms.ComboBox();
            this.payClearBtn = new System.Windows.Forms.Button();
            this.payDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // payAddBtn
            // 
            this.payAddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.payAddBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.payAddBtn.Location = new System.Drawing.Point(596, 466);
            this.payAddBtn.Name = "payAddBtn";
            this.payAddBtn.Size = new System.Drawing.Size(98, 40);
            this.payAddBtn.TabIndex = 4;
            this.payAddBtn.Text = "Add Payment";
            this.payAddBtn.UseVisualStyleBackColor = false;
            this.payAddBtn.Click += new System.EventHandler(this.payAddBtn_Click);
            // 
            // paySearchBtn
            // 
            this.paySearchBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.paySearchBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paySearchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.paySearchBtn.Location = new System.Drawing.Point(194, 466);
            this.paySearchBtn.Name = "paySearchBtn";
            this.paySearchBtn.Size = new System.Drawing.Size(98, 40);
            this.paySearchBtn.TabIndex = 2;
            this.paySearchBtn.Text = "Search";
            this.paySearchBtn.UseVisualStyleBackColor = false;
            this.paySearchBtn.Click += new System.EventHandler(this.paySearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(593, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search Student ID";
            // 
            // paySearchTB
            // 
            this.paySearchTB.Location = new System.Drawing.Point(702, 22);
            this.paySearchTB.Name = "paySearchTB";
            this.paySearchTB.Size = new System.Drawing.Size(163, 20);
            this.paySearchTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Payment Details";
            // 
            // payReceiptNoTB
            // 
            this.payReceiptNoTB.Location = new System.Drawing.Point(111, 37);
            this.payReceiptNoTB.Name = "payReceiptNoTB";
            this.payReceiptNoTB.Size = new System.Drawing.Size(185, 20);
            this.payReceiptNoTB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pay Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pay Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(19, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receipt No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pay Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "Pay Details:";
            // 
            // payStuIdTB
            // 
            this.payStuIdTB.Location = new System.Drawing.Point(111, 80);
            this.payStuIdTB.Name = "payStuIdTB";
            this.payStuIdTB.Size = new System.Drawing.Size(185, 20);
            this.payStuIdTB.TabIndex = 7;
            // 
            // payAmountTB
            // 
            this.payAmountTB.Location = new System.Drawing.Point(482, 37);
            this.payAmountTB.Name = "payAmountTB";
            this.payAmountTB.Size = new System.Drawing.Size(185, 20);
            this.payAmountTB.TabIndex = 10;
            // 
            // payDetailsTB
            // 
            this.payDetailsTB.Location = new System.Drawing.Point(482, 130);
            this.payDetailsTB.Name = "payDetailsTB";
            this.payDetailsTB.Size = new System.Drawing.Size(185, 20);
            this.payDetailsTB.TabIndex = 12;
            this.payDetailsTB.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // payDateTB
            // 
            this.payDateTB.Location = new System.Drawing.Point(482, 80);
            this.payDateTB.Name = "payDateTB";
            this.payDateTB.Size = new System.Drawing.Size(185, 20);
            this.payDateTB.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payAdminIdTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.payTypeCB);
            this.groupBox1.Controls.Add(this.payDateTB);
            this.groupBox1.Controls.Add(this.payDetailsTB);
            this.groupBox1.Controls.Add(this.payAmountTB);
            this.groupBox1.Controls.Add(this.payStuIdTB);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.payReceiptNoTB);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(58, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 205);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add  Payment";
            // 
            // payAdminIdTB
            // 
            this.payAdminIdTB.Location = new System.Drawing.Point(111, 130);
            this.payAdminIdTB.Name = "payAdminIdTB";
            this.payAdminIdTB.Size = new System.Drawing.Size(185, 20);
            this.payAdminIdTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Admin ID:";
            // 
            // payTypeCB
            // 
            this.payTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payTypeCB.FormattingEnabled = true;
            this.payTypeCB.Items.AddRange(new object[] {
            "",
            "EFT",
            "Cash"});
            this.payTypeCB.Location = new System.Drawing.Point(111, 169);
            this.payTypeCB.Name = "payTypeCB";
            this.payTypeCB.Size = new System.Drawing.Size(185, 22);
            this.payTypeCB.TabIndex = 9;
            // 
            // payClearBtn
            // 
            this.payClearBtn.Location = new System.Drawing.Point(410, 467);
            this.payClearBtn.Name = "payClearBtn";
            this.payClearBtn.Size = new System.Drawing.Size(89, 39);
            this.payClearBtn.TabIndex = 6;
            this.payClearBtn.Text = "Clear";
            this.payClearBtn.UseVisualStyleBackColor = true;
            this.payClearBtn.Click += new System.EventHandler(this.payClearBtn_Click);
            // 
            // payDGV
            // 
            this.payDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payDGV.Location = new System.Drawing.Point(91, 63);
            this.payDGV.Name = "payDGV";
            this.payDGV.Size = new System.Drawing.Size(747, 150);
            this.payDGV.TabIndex = 40;
            this.payDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payDGV_CellClick);
            // 
            // PaymentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 538);
            this.Controls.Add(this.payDGV);
            this.Controls.Add(this.payClearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paySearchTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paySearchBtn);
            this.Controls.Add(this.payAddBtn);
            this.Name = "PaymentUI";
            this.Text = "PaymentUI";
            this.Load += new System.EventHandler(this.PaymentUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button payAddBtn;
        private System.Windows.Forms.Button paySearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paySearchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payReceiptNoTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox payStuIdTB;
        private System.Windows.Forms.TextBox payAmountTB;
        private System.Windows.Forms.TextBox payDetailsTB;
        private System.Windows.Forms.TextBox payDateTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox payTypeCB;
        private System.Windows.Forms.Button payClearBtn;
        private System.Windows.Forms.TextBox payAdminIdTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView payDGV;
    }
}