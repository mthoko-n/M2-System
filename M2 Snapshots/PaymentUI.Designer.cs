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
            this.PaymentAdminIDCB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.payTypeCB = new System.Windows.Forms.ComboBox();
            this.payClearBtn = new System.Windows.Forms.Button();
            this.payDGV = new System.Windows.Forms.DataGridView();
            this.printBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // payAddBtn
            // 
            this.payAddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.payAddBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.payAddBtn.Location = new System.Drawing.Point(795, 574);
            this.payAddBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payAddBtn.Name = "payAddBtn";
            this.payAddBtn.Size = new System.Drawing.Size(131, 49);
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
            this.paySearchBtn.Location = new System.Drawing.Point(259, 574);
            this.paySearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paySearchBtn.Name = "paySearchBtn";
            this.paySearchBtn.Size = new System.Drawing.Size(131, 49);
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
            this.label2.Location = new System.Drawing.Point(791, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search Student ID";
            // 
            // paySearchTB
            // 
            this.paySearchTB.Location = new System.Drawing.Point(936, 27);
            this.paySearchTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paySearchTB.Name = "paySearchTB";
            this.paySearchTB.Size = new System.Drawing.Size(216, 22);
            this.paySearchTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Payment Details";
            // 
            // payReceiptNoTB
            // 
            this.payReceiptNoTB.Location = new System.Drawing.Point(148, 46);
            this.payReceiptNoTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payReceiptNoTB.Name = "payReceiptNoTB";
            this.payReceiptNoTB.Size = new System.Drawing.Size(245, 23);
            this.payReceiptNoTB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pay Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pay Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(25, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Receipt No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pay Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Pay Details:";
            // 
            // payStuIdTB
            // 
            this.payStuIdTB.Location = new System.Drawing.Point(148, 98);
            this.payStuIdTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payStuIdTB.Name = "payStuIdTB";
            this.payStuIdTB.Size = new System.Drawing.Size(245, 23);
            this.payStuIdTB.TabIndex = 7;
            // 
            // payAmountTB
            // 
            this.payAmountTB.Location = new System.Drawing.Point(643, 46);
            this.payAmountTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payAmountTB.Name = "payAmountTB";
            this.payAmountTB.Size = new System.Drawing.Size(245, 23);
            this.payAmountTB.TabIndex = 10;
            // 
            // payDetailsTB
            // 
            this.payDetailsTB.Location = new System.Drawing.Point(643, 160);
            this.payDetailsTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payDetailsTB.Name = "payDetailsTB";
            this.payDetailsTB.Size = new System.Drawing.Size(245, 23);
            this.payDetailsTB.TabIndex = 12;
            this.payDetailsTB.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // payDateTB
            // 
            this.payDateTB.Location = new System.Drawing.Point(643, 98);
            this.payDateTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payDateTB.Name = "payDateTB";
            this.payDateTB.Size = new System.Drawing.Size(245, 23);
            this.payDateTB.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PaymentAdminIDCB);
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
            this.groupBox1.Location = new System.Drawing.Point(77, 292);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1076, 252);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add  Payment";
            // 
            // PaymentAdminIDCB
            // 
            this.PaymentAdminIDCB.Location = new System.Drawing.Point(148, 160);
            this.PaymentAdminIDCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentAdminIDCB.Name = "PaymentAdminIDCB";
            this.PaymentAdminIDCB.Size = new System.Drawing.Size(245, 23);
            this.PaymentAdminIDCB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
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
            this.payTypeCB.Location = new System.Drawing.Point(148, 208);
            this.payTypeCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payTypeCB.Name = "payTypeCB";
            this.payTypeCB.Size = new System.Drawing.Size(245, 24);
            this.payTypeCB.TabIndex = 9;
            // 
            // payClearBtn
            // 
            this.payClearBtn.Location = new System.Drawing.Point(547, 575);
            this.payClearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payClearBtn.Name = "payClearBtn";
            this.payClearBtn.Size = new System.Drawing.Size(119, 48);
            this.payClearBtn.TabIndex = 6;
            this.payClearBtn.Text = "Clear";
            this.payClearBtn.UseVisualStyleBackColor = true;
            this.payClearBtn.Click += new System.EventHandler(this.payClearBtn_Click);
            // 
            // payDGV
            // 
            this.payDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payDGV.Location = new System.Drawing.Point(121, 78);
            this.payDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payDGV.Name = "payDGV";
            this.payDGV.RowHeadersWidth = 51;
            this.payDGV.Size = new System.Drawing.Size(996, 185);
            this.payDGV.TabIndex = 40;
            this.payDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payDGV_CellClick);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.printBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printBtn.Location = new System.Drawing.Point(465, 673);
            this.printBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(301, 37);
            this.printBtn.TabIndex = 41;
            this.printBtn.Text = "Print Receipt";
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // PaymentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 862);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.payDGV);
            this.Controls.Add(this.payClearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paySearchTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paySearchBtn);
            this.Controls.Add(this.payAddBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox PaymentAdminIDCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView payDGV;
        private System.Windows.Forms.Button printBtn;
    }
}