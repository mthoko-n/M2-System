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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupPmb2;Persist Security Info=True;User ID=GroupPmb2;Password=b45dc2");


        //add admin
        private void button3_Click(object sender, EventArgs e)
        {
            if ((AdminIDTextBox.Text == "") && (AdminNameTextBox.Text != "") && (AdminEmailTextBox.Text != "") && (AdminDetailsTextBox.Text != ""))
            {

                string num = "";
                double num2 = 0;
                con.Open();
                SqlCommand a = new SqlCommand("select admin_id from admins order by admin_id desc", con);
                SqlDataReader read = a.ExecuteReader();
                while (read.Read())
                {
                    num = num + "  " + read.GetValue(0).ToString();
                    num2 = double.Parse(num);
                    break;
                }

                read.Close();
                con.Close();

                double num3 = Convert.ToInt32(num2);
                double num4 = (num3 + 10000);
                int num5 = Convert.ToInt32(num4);


                con.Open();
                SqlCommand command = new SqlCommand("insert into admins values ('" + /*AdminIDTextBox.Text*/ num5 + "','" + AdminNameTextBox.Text + "','" + AdminDetailsTextBox.Text + "','" + AdminEmailTextBox.Text +  "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Admin Successfully Inserted\n\n\nAdmin ID is:\t" + num5,"Add Admin", MessageBoxButtons.OK);
                con.Close();
                BindData();
            }
            else
            {
                MessageBox.Show("Enter All Fields except Admin ID","Add Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from admins", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            AdminDataGridView.DataSource = dt;
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            BindData();

        }

        private void AdminSearchButton_Click(object sender, EventArgs e)
        {
            if (SearchAdminIDTextBox.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from admins where " +
                     "admin_id LIKE '%" + SearchAdminIDTextBox.Text + "%' OR " +
                     "admin_name LIKE '%" + SearchAdminIDTextBox.Text + "%' OR " +
                     "admin_details LIKE '%" + SearchAdminIDTextBox.Text + "%' OR " +
                     "admin_email LIKE '%" + SearchAdminIDTextBox.Text + "%'"
                     , con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                AdminDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enter Admin ID in the Search box","Search Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminClearBtn_Click(object sender, EventArgs e)
        {
            BindData();
            AdminNameTextBox.Clear();
            AdminIDTextBox.Clear();
            AdminEmailTextBox.Clear();
            AdminDetailsTextBox.Clear();
            SearchAdminIDTextBox.Clear();
        }

        private void AdminRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AdminSearchButton.Text != "")
                {

                    DialogResult res = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("Delete admins where admin_id = '" + SearchAdminIDTextBox.Text + "'", con);
                        //command.ExecuteNonQuery();
                        if (command.ExecuteNonQuery() > 0)
                            MessageBox.Show("Successfully Removed");
                        else
                            MessageBox.Show("Invalid data, please provide Admin ID to remove a field", "Admin ID not valid",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Enter Admin ID in the Search box", "Admin ID not valid", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Enter VALID Admin ID", "Admin ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAdminButton_Click(object sender, EventArgs e)
        {
            if ((AdminIDTextBox.Text != "") && ((AdminNameTextBox.Text != "") || (AdminDetailsTextBox.Text != "") || (AdminEmailTextBox.Text != "")))
            {
                int error = 0;
                con.Open();

                if ((AdminNameTextBox.Text != "") && (AdminIDTextBox.Text != ""))

                {
                    SqlCommand command = new SqlCommand("update admins set admin_name = '" + AdminNameTextBox.Text + "' where admin_id = '" + AdminIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid Admin ID");
                        error++;
                    }
                }
                if ((AdminEmailTextBox.Text != "") && (AdminIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update admins set admin_email = '" + AdminEmailTextBox.Text + "' where admin_id = '" + AdminIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid Admin ID");
                        error++;
                    }
                }
                
                if ((AdminDetailsTextBox.Text != "") && (AdminIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update admins set admin_details = '" + AdminDetailsTextBox.Text + "' where admin_id = '" + AdminIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid Admin ID");
                        error++;
                    }
                }


                con.Close();
                if(error==0)
                     MessageBox.Show("Admin Successfully Updated","Update Admin", MessageBoxButtons.OK);
                BindData();
            }
            else
            {
                MessageBox.Show("Enter Admin ID and at least one other field","Update Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AdminDataGridView.SelectedRows.Count == 1)
            {

                string id = AdminDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                AdminIDTextBox.Text = id;

                string name = AdminDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                AdminNameTextBox.Text = name;

                string details = AdminDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                AdminDetailsTextBox.Text = details;

                string email = AdminDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
                AdminEmailTextBox.Text = email;
            }
        }
    }
}
