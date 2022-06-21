using System;
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
        {   con.Open();

            if (/*(PaymentAdminIDCB.Text != "") &&*/ (payAmountTB.Text != "") && (payDateTB.Text != "") && (payDetailsTB.Text != "") && (payReceiptNoTB.Text != "") && (payStuIdTB.Text != "")) 
            {
                if (payReceiptNoTB.Text.All(char.IsDigit))
                {
                    if (payStuIdTB.Text.All(char.IsDigit))
                    {
                        if (payAmountTB.Text.All(char.IsDigit))
                        {
                            
                            /*SqlCommand command = new SqlCommand("insert into PaymentService values ('" + int.Parse(payReceiptNoTB.Text) + "','" + PaymentAdminIDCB.Text + "','" + int.Parse(payStuIdTB.Text) + "', '" + payDateTB.Text + "', '" + int.Parse(payAmountTB.Text) + "', '" + payTypeCB.Text + "','" + payDetailsTB.Text + "')", con);
                            command.ExecuteNonQuery();*/

                            string num = "";
                            double num2 = 0;

                            SqlCommand a = new SqlCommand("select stu_Fees from student where stu_ID = " + int.Parse(payStuIdTB.Text), con);
                            SqlDataReader read = a.ExecuteReader();
                            while (read.Read())
                            {
                                num = num + read.GetValue(0).ToString();
                                num2 = double.Parse(num);
                            }
                            read.Close();

                            int fee = 0;
                            int val = Convert.ToInt32(num2);
                            int val2 = int.Parse(payAmountTB.Text);
                            if (val>val2) 
                            {
                                fee = val - val2;
                                SqlCommand c = new SqlCommand("update student set stu_Fees = " + fee + " where stu_ID = " + int.Parse(payStuIdTB.Text), con);
                                    if (c.ExecuteNonQuery() > 0)
                                    {
                                        SqlCommand command2 = new SqlCommand("insert into PaymentService values ('" + int.Parse(payReceiptNoTB.Text) + "','" + /*PaymentAdminIDCB.Text + "','"*/ + int.Parse(payStuIdTB.Text) + "', '" + payDateTB.Text + "', '" + int.Parse(payAmountTB.Text) + "', '" + payTypeCB.Text + "','" + payDetailsTB.Text + "')", con);
                                        if (command2.ExecuteNonQuery() > 0)
                                            MessageBox.Show("Payment Successfully Inserted", "Payment Success", MessageBoxButtons.OK);
                                        else
                                        {
                                            MessageBox.Show("Enter Details correctly", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter valid Student ID", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                
                                    BindData();

                            }else 
                            { 
                                MessageBox.Show("Payment higher than amount owed"); 
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Payment amount can only contain digits");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student ID can only contain digits");
                    }
                }
                else
                {
                    MessageBox.Show("Receipt number can only contain digits");
                }
            }
            else
            {
                MessageBox.Show("Enter all fields to add a payment", "Payment",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();
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
            // TODO: This line of code loads data into the 'binaryMakersDS.PaymentService' table. You can move, or remove it, as needed.
           
            BindData();

            BindData();

            con.Open();
            SqlCommand command = new SqlCommand("select admin_id from admins", con);
            SqlDataReader reader;
            reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("admin_id", typeof(string));
            dt.Load(reader);
            //PaymentAdminIDCB.ValueMember = "admin_id";
            //PaymentAdminIDCB.DataSource = dt;
            //PaymentAdminIDCB.ResetText();
            con.Close();


        }

        
       

        private void payUpdateBtn_Click(object sender, EventArgs e)
        {
            if ((payReceiptNoTB.Text != "" && payReceiptNoTB.Text.All(char.IsDigit)) && ((PaymentAdminIDCB.Text != "") ||(payAmountTB.Text != "") || (payDateTB.Text != "") ||(payDetailsTB.Text != "") ||(payStuIdTB.Text != "")))
            {
                int error = 0;
                con.Open();

                if ((PaymentAdminIDCB.Text != "") && (payReceiptNoTB.Text != ""))

                {
                    SqlCommand command = new SqlCommand("update PaymentService set AdminID = '" + PaymentAdminIDCB.Text + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error +=0;
                    else
                    {
                        MessageBox.Show("Enter a valid Admin ID");
                        error++;
                    }
                }
                
                if ((payStuIdTB.Text != "" && payStuIdTB.Text.All(char.IsDigit)) && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymentService set stu_ID = '" + int.Parse(payStuIdTB.Text) + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid Student ID");
                        error++;
                    }
                }
                if ((payDateTB.Text != "") && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymnetService set pay_Date = '" + payDateTB.Text + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid Date");
                        error++;
                    }
                }
                if ((payAmountTB.Text != "" && payAmountTB.Text.All(char.IsDigit)) && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymentService set pay_Amount = '" + int.Parse(payAmountTB.Text) + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid payment amount");
                        error++;
                    }
                }
                if ((payTypeCB.Text != "") && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymentService set pay_Type = '" + payTypeCB.Text + "' where receiptNum= '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Select a valid payment type");
                        error++;
                    }
                }
                if ((payDetailsTB.Text != "") && (payReceiptNoTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update PaymentService set pay_Details = '" + payDetailsTB.Text + "' where receiptNum = '" + int.Parse(payReceiptNoTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid payment description");
                        error++;
                    }
                }
                con.Close();
                MessageBox.Show("Payment Details Successfully Updated", "Payment Updated", MessageBoxButtons.OK);
                BindData();
            }
            else
            {
                MessageBox.Show("Enter a valid receipt number and at least one other field", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void payClearBtn_Click(object sender, EventArgs e)
        {
            BindData();
            PaymentAdminIDCB.ResetText();
            payAmountTB.Clear();
            payDateTB.Clear();
            payDetailsTB.Clear();
            payReceiptNoTB.Clear();
            paySearchTB.Clear();
            payStuIdTB.Clear();
            payTypeCB.ResetText();

            
        }

        private void paySearchBtn_Click(object sender, EventArgs e)
        {
            if (paySearchTB.Text != "" && paySearchTB.Text.All(char.IsDigit))
            {
                SqlCommand command = new SqlCommand("select * from PaymentService where stu_ID= '" + int.Parse(paySearchTB.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                payDGV.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enter a valid Student ID in the Search box","Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payRemoveBtn_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (paySearchTB.Text != "" && paySearchTB.Text.All(char.IsDigit))
                {

                    DialogResult res = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("Delete PaymentService where stu_ID = '" + int.Parse(paySearchTB.Text) + "'", con);
                        if(command.ExecuteNonQuery()>0)
                            MessageBox.Show("Successfully Removed Payment", "Payment", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Invalid data, Student ID does not exist", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close(); 
                        BindData();
                    }

                    else
                    {
                        this.Show();
                    }


                }

                else
                {
                    MessageBox.Show("Enter Student ID in the search box","Payment",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Enter VALID student ID", "Student ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void payDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (payDGV.SelectedRows.Count == 1)
            {
                string receiptno = payDGV.SelectedRows[0].Cells[0].Value + string.Empty;
                payReceiptNoTB.Text = receiptno;

                string adminID = payDGV.SelectedRows[0].Cells[1].Value + string.Empty;
                PaymentAdminIDCB.Text = adminID;

                string stuID = payDGV.SelectedRows[0].Cells[2].Value + string.Empty;
                payStuIdTB.Text = stuID;

                string payDate = payDGV.SelectedRows[0].Cells[3].Value + string.Empty;
                payDateTB.Text = payDate;

                string payAmt = payDGV.SelectedRows[0].Cells[4].Value + string.Empty;
                payAmountTB.Text = payAmt;

                string payType = payDGV.SelectedRows[0].Cells[5].Value + string.Empty;
                payTypeCB.Text = payType;

                string payDetails = payDGV.SelectedRows[0].Cells[6].Value + string.Empty;
                payDetailsTB.Text = payDetails;
            }
        }
    }
}
