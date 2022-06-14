﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace M2_Snapshots
{
    public partial class PaymentUI : Form
    {
        public PaymentUI()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupPmb2;Persist Security Info=True;User ID=GroupPmb2;Password=b45dc2");

       
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void payAddBtn_Click(object sender, EventArgs e)
        {
            if ((payAdminIdTB.Text != "") && (payAmountTB.Text != "") && (payDateTB.Text != "") && (payDetailsTB.Text != "") && (payReceiptNoTB.Text != "") && (payStuIdTB.Text != "")) 
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into PaymentService values ('" + int.Parse(payReceiptNoTB.Text) + "','" + payAdminIdTB.Text + "','" + int.Parse(payStuIdTB.Text) + "', '" + payDateTB.Text + "', '" + int.Parse(payAmountTB.Text)+ "', '" + payTypeCB.Text + "','"+payDetailsTB.Text+"')", con);
                command.ExecuteNonQuery();
                con.Close();
                BindData();
                MessageBox.Show("Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Enter All Fields");
            }
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from PaymentService", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            payDGV.DataSource = dt;
        }

        private void PaymentUI_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void payUpdateBtn_Click(object sender, EventArgs e)
        {
            if ((payAdminIdTB.Text != "") ||(payAmountTB.Text != "") || (payDateTB.Text != "") ||(payDetailsTB.Text != "") ||(payReceiptNoTB.Text != "") ||(payStuIdTB.Text != ""))
            {

                con.Open();

                if ((payAdminIdTB.Text != "") && (payReceiptNoTB.Text != ""))

                {
                    SqlCommand command = new SqlCommand("update PaymentService set AdminID = '" + payAdminIdTB.Text + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((payStuIdTB.Text != "") && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymentService set stu_ID = '" + int.Parse(payStuIdTB.Text) + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((payDateTB.Text != "") && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymnetService set pay_Date = '" + payDateTB.Text + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((payAmountTB.Text != "") && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymentService set pay_Amount = '" + int.Parse(payAmountTB.Text) + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((payTypeCB.Text != "") && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymentService set pay_Type = '" + payTypeCB.Text + "' where receiptNum= '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((payDetailsTB.Text != "") && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymentService set pay_Details = '" + payDetailsTB.Text + "' where receiptNum = '" + int.Parse(payReceiptNoTB) + "'", con);
                    command.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Successfully Updated");
                BindData();
            }
            else
            {
                MessageBox.Show("Fill in appropriate fields");
            }

        }
    }
}
