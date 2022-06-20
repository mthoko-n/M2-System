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
    public partial class ClassUI : Form
    

    {

        public static ClassUI classForm;
        public string total;
        public ClassUI()
        {
            InitializeComponent();
            classForm = this;
            total = getNumStudents().ToString();
        }

        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupPmb2;Persist Security Info=True;User ID=GroupPmb2;Password=b45dc2");

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from classes", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            SearchClassDataGridView.DataSource = dt;
        }

        private int getNumStudents()
        {
            int sum = 0;
            foreach (DataRow row in SearchClassDataGridView.Rows)
            {
                sum = sum + int.Parse(row.ItemArray[2].ToString());

            }

            return sum;
        }

        private void ViewDetalisButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from classes where " +
                    "class_id LIKE '%" + SearchTextBox.Text + "%' OR " +
                    "teacher_id LIKE '%" + SearchTextBox.Text + "%' OR " +
                    "numStudents LIKE '%" + SearchTextBox.Text + "%' OR " +
                    "buildingNo LIKE '%" + SearchTextBox.Text + "%' OR " +
                    "grade LIKE '%" + SearchTextBox.Text + "%'"
                    , con);
                
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                SearchClassDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enter Class ID in the Search box");
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (SearchTextBox.Text != "")
                {

                    DialogResult res = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        if (SearchTextBox.Text.All(char.IsDigit))
                        {
                            con.Open();

                            SqlCommand command = new SqlCommand("Delete classes where class_id = '" + int.Parse(SearchTextBox.Text) + "'", con);
                            //command.ExecuteNonQuery();
                            //con.Close();
                            if (command.ExecuteNonQuery() > 0)
                                MessageBox.Show("Successfully Removed");
                            else
                                MessageBox.Show("Invalid data, data does not exist");
                            con.Close();
                            BindData();
                        }
                        else
                            MessageBox.Show("Enter a valid Class ID, only numbers allowed");
                    }

                    else
                    {
                        this.Show();
                    }


                }

                else
                {
                    MessageBox.Show("Enter Class ID in the search box");
                }
            }
            catch
            {
                MessageBox.Show("Enter VALID Class ID", "Class ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((ClassIDTextBox.Text != "") && (teachID.Text != "") && (ClassRollTextBox.Text != "") && (GradeTextBox.Text != "") && (DivisionTextBox1.Text != ""))
            {
                if (ClassIDTextBox.Text.All(char.IsDigit))
                {
                    if (teachID.Text != "")
                    {
                        if (ClassRollTextBox.Text.All(char.IsDigit) && (int.Parse(ClassRollTextBox.Text) != 0))
                        {
                            if (GradeTextBox.Text.All(char.IsDigit) && (int.Parse(GradeTextBox.Text) >= 8) && (int.Parse(GradeTextBox.Text) <= 12))
                            {
                                if (DivisionTextBox1.Text.Length == 1 && DivisionTextBox1.Text.All(char.IsLetter))
                                {

                                    if (BuildingNoTextBox.Text == "")
                                    {
                                        con.Open();
                                        SqlCommand command = new SqlCommand("insert into classes values ('" + int.Parse(ClassIDTextBox.Text) + "','" + teachID.Text + "','" + int.Parse(ClassRollTextBox.Text) + "', '" + -1 + "', '" + int.Parse(GradeTextBox.Text) + "', '" + char.Parse(DivisionTextBox1.Text.ToUpper()) + "')", con);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Successfully Inserted");
                                        con.Close();
                                        BindData();
                                    }
                                    else if (BuildingNoTextBox.Text.All(char.IsDigit) && (int.Parse(BuildingNoTextBox.Text) > 0))
                                    {
                                        con.Open();
                                        SqlCommand command = new SqlCommand("insert into classes values ('" + int.Parse(ClassIDTextBox.Text) + "','" + teachID.Text + "','" + int.Parse(ClassRollTextBox.Text) + "', '" + int.Parse(BuildingNoTextBox.Text) + "', '" + int.Parse(GradeTextBox.Text) + "', '" + char.Parse(DivisionTextBox1.Text.ToUpper()) + "')", con);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Successfully Inserted");
                                        con.Close();
                                        BindData();
                                    }
                                    else
                                        MessageBox.Show("Enter a valid building number or leave blank");
                                }
                                else
                                    MessageBox.Show("Division must be a single letter");
                            }
                            else
                                MessageBox.Show("Enter a valid grade between grades 8 and 12");

                        }
                        else
                            MessageBox.Show("Enter valid roll of class");
                    }
                    else
                        MessageBox.Show("Select a valid teacher");
                }
                else
                    MessageBox.Show("Enter valid Class ID");
            }
            else
            {
                MessageBox.Show("Enter All Fields");
            }


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            int error = 0;
            if ((ClassIDTextBox.Text != "") && ((teachID.Text != "") || (ClassRollTextBox.Text != "") || (BuildingNoTextBox.Text != "") || (GradeTextBox.Text != "") || (DivisionTextBox1.Text != "")))
            {
                if (ClassIDTextBox.Text.All(char.IsDigit) && (ClassIDTextBox.Text != ""))
                {
                    con.Open();

                    if ((teachID.Text != ""))
                    {
                        SqlCommand command = new SqlCommand("update classes set teacher_id = '" + teachID.Text + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                        command.ExecuteNonQuery();
                    }
                    if ((ClassRollTextBox.Text != ""))
                    {
                        if (ClassRollTextBox.Text.All(char.IsDigit) && (int.Parse(ClassRollTextBox.Text) != 0))
                        {
                            SqlCommand command = new SqlCommand("update classes set numStudents = '" + int.Parse(ClassRollTextBox.Text) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Enter valid roll of class");
                            error++;
                        }
                    }
                    if ((BuildingNoTextBox.Text != ""))
                    {
                        if (BuildingNoTextBox.Text.All(char.IsDigit) && (int.Parse(BuildingNoTextBox.Text) > 0))
                        {
                            SqlCommand command = new SqlCommand("update classes set buildingNo = '" + int.Parse(BuildingNoTextBox.Text) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Enter an appropriate building number");
                            error++;
                        }
                    }
                    if ((GradeTextBox.Text != ""))
                    {
                        if ((GradeTextBox.Text.All(char.IsDigit)) && (int.Parse(GradeTextBox.Text) >= 8) && (int.Parse(GradeTextBox.Text) <= 12))
                        {
                            SqlCommand command = new SqlCommand("update classes set grade = '" + int.Parse(GradeTextBox.Text) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Enter an appropriate grade between grades 8 and 12");
                            error++;
                        }

                    }
                    if ((DivisionTextBox1.Text != ""))
                    {
                        if (DivisionTextBox1.Text.Length == 1 && DivisionTextBox1.Text.All(char.IsLetter))
                        {
                            SqlCommand command = new SqlCommand("update classes set Division = '" + char.Parse(DivisionTextBox1.Text.ToUpper()) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Grade Divisions are only a single letter long");
                            error++;
                        }
                    }

                    con.Close();
                    if (error == 0)
                        MessageBox.Show("Successfully Updated");
                    BindData();
                }
                else
                {
                    MessageBox.Show("Fill in appropriate fields");
                }

            }
            else
                MessageBox.Show("Fill in a Class ID and at least one more field to update information");

        }

        private void ClassUI_Load(object sender, EventArgs e)
        {
            BindData();
            con.Open();
            SqlCommand command = new SqlCommand("select teach_ID from Teachers", con);
            SqlDataReader reader;
            reader = command.ExecuteReader();

            //SqlDataAdapter sd = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //sd.Fill(dt);
            //command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Columns.Add("teach_ID", typeof(string));
            dt.Load(reader);
            teachID.ValueMember = "teach_ID";
            teachID.DataSource = dt;
            teachID.ResetText();
            con.Close();


            //teachID.DataSource = dt.TableName[0];
            //teachID.DisplayMember = "teach_ID";
            //teachID.ValueMember = "teach_ID";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void classClearBtn_Click(object sender, EventArgs e)
        {
            BindData();
            SearchTextBox.Clear();
            ClassIDTextBox.Clear();
            teachID.ResetText();
            BuildingNoTextBox.Clear();
            DivisionTextBox.Clear();
            GradeTextBox.Clear();
            ClassRollTextBox.Clear();
            DivisionTextBox1.Clear();
        }

        private void SearchClassDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teacherID_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand command = new SqlCommand("select teach_firstname from Teachers", con);
            SqlDataReader reader;
            reader = command.ExecuteReader();

            //SqlDataAdapter sd = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //sd.Fill(dt);
            //command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Columns.Add("teach_firstname", typeof(string));
            dt.Load(reader);
            teachID.ValueMember = "teach_firstname";
            teachID.DataSource = dt;
            con.Close();
            */
            //teach_firstname
            //teachID.DataSource = dt.TableName[0];
            //teachID.DisplayMember = "teach_ID";
            //teachID.ValueMember = "teach_ID";

        }
    }
}
