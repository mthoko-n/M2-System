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
    public partial class TeacherUI : Form
    {
        public TeacherUI()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupPmb2;Persist Security Info=True;User ID=GroupPmb2;Password=b45dc2");


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addteach_Click(object sender, EventArgs e)
        {
            if ((teacherName.Text != "") && (teachLName.Text != "") && (teachGender.Text != "") && (teachcellNum.Text != "")
                && (teachTitle.Text != "") && (teachAddress.Text != "") /*&& (teachEmail.Text != "")*/ && (TeacherIDTextBox.Text == ""))
            {
                var rand = new Random();
                int number = rand.Next(1, 10000);
                string email = teacherName.Text+ teachLName.Text+"@kharina.ac.za";

                if (teacherName.Text.Length > 1)
                {
                    if (teachLName.Text.Length > 1)
                    {
                        if ((teachGender.Text != "Male") || (teachGender.Text != "Female"))
                        {
                            if (teachcellNum.Text.All(char.IsDigit) && teachcellNum.Text.Length == 10)
                            {
                                if (teachTitle.Text.Length > 1)
                                {
                                    if (teachAddress.Text.Length > 10)
                                    {
                                        if (email.Length > 0)
                                        {
                                            string teachID = teacherName.Text + teachLName.Text + number;

                                            con.Open();
                                            SqlCommand comm = new SqlCommand("INSERT INTO UserLogin values('" + teachID + "','" + teachID + "')", con);
                                            SqlCommand command = new SqlCommand("INSERT INTO Teachers values('" + teachID + "','" + teacherName.Text + "','" + teachLName.Text + "','" + email + "','" + teachTitle.Text + "','" + teachGender.Text + "','" + teachcellNum.Text + "','" + teachAddress.Text + "')", con);

                                            comm.ExecuteNonQuery();
                                            command.ExecuteNonQuery();
                                            MessageBox.Show("Successfully added", "Success!", MessageBoxButtons.OK);
                                            con.Close();
                                            BindData2();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter a valid email address");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Address value is too short");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter a valid Teacher title");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cell number can only contain digits and must be exactly 10 digits long");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter valid gender: Male or Female)");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter complete surname");
                    }
                }
                else
                {
                    MessageBox.Show("Enter complete Firstname(s)");
                }


            }
            else
            {
                MessageBox.Show("Enter All Fields except Teacher ID","Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void BindData2()
        {
            SqlCommand command = new SqlCommand("SELECT* FROM Teachers", con);
            SqlDataAdapter ss = new SqlDataAdapter(command);
            DataTable dd = new DataTable();
            ss.Fill(dd);
            TeacherDGV.DataSource = dd;
        }
        private void TeacherUI_Load(object sender, EventArgs e)
        {
            BindData2();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void teachGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if ((TeacherIDTextBox.Text != "") && ((teacherName.Text != "") || (teachLName.Text != "") /*|| (teachEmail.Text != "")*/ || (teachGender.Text != "") || (teachTitle.Text != "") || (teachcellNum.Text != "") || (teachAddress.Text != "")))
            {
                int error = 0;
                con.Open();

                if ((teacherName.Text != "") && (TeacherIDTextBox.Text != "")) //This is to update/change the teacher's name
                {
                    SqlCommand command = new SqlCommand("update Teachers set teach_firstname = '" + teacherName.Text + "' where teach_ID = '" + TeacherIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter valid Teacher ID");
                        error++;
                    }
                }
                
                if ((teachLName.Text != "") && (TeacherIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update Teachers set teach_lastname = '" + teachLName.Text + "' where teach_ID = '" + TeacherIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter valid Teacher ID");
                        error++;
                    }
                }
                /*if ((teachEmail.Text != "") && (TeacherIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update Teachers set teach_email = '" + teachEmail.Text + "' where teach_ID = '" + TeacherIDTextBox.Text + "'", con);
                    command.ExecuteNonQuery();
                }*/
                if ((teachGender.Text != "") && (TeacherIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update Teachers set gender = '" + teachGender.Text + "' where teach_ID = '" + TeacherIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter valid Teacher ID");
                        error++;
                    }
                }
                if ((teachTitle.Text != "") && (TeacherIDTextBox.Text != "")) //This is to update/change the teacher's title
                {
                    SqlCommand command = new SqlCommand("update Teachers set teach_title = '" + teachTitle.Text + "' where teach_ID = '" + TeacherIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter valid Teacher ID");
                        error++;
                    }
                }
                if ((teachcellNum.Text != " " && teachcellNum.Text.All(char.IsDigit) && teachcellNum.Text.Length == 10) && (TeacherIDTextBox.Text != " "))
                {
                    SqlCommand command = new SqlCommand("update Teachers set contactNum = '" + teachcellNum.Text + "' where teach_ID = '" + TeacherIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Cell number must be 10 digits long and must only contain digits \nEnter valid Teacher ID ");
                        error++;
                    }
                }
               
                if ((teachAddress.Text!= "" && teachAddress.Text.Length > 10) && (TeacherIDTextBox.Text != " ") )
                {
                    SqlCommand command = new SqlCommand("update Teachers set Address = '" + teachAddress.Text + "' where teach_ID = '" + TeacherIDTextBox.Text + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Address must be at least 10 characters long \nEnter valid Teacher ID");
                        error++;
                    }
                }
                con.Close();
                if(error==0)
                    MessageBox.Show("Teacher Successfully Updated", "Teacher Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BindData2();
            }
            else
            {
                MessageBox.Show("Enter Teacher ID and at least one other field", "Update Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void classClearBtn_Click(object sender, EventArgs e)
        {
            BindData2();
            SearchTeacherTextBox.Clear();
            teacherName.Clear();
            teachLName.Clear();
            teachGender.ResetText();
            teachcellNum.Clear();
            teachTitle.Clear();
            teachAddress.Clear();
            //teachEmail.Clear();
            TeacherIDTextBox.Clear();
        }

        private void remove_Click(object sender, EventArgs e)
        {

            try
            {
                if (SearchTeacherTextBox.Text != "")
                {

                    DialogResult res = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        if (SearchTeacherTextBox.Text != "")
                        {
                            con.Open();

                            SqlCommand command = new SqlCommand("Delete Teachers where teach_id = '" + SearchTeacherTextBox.Text + "'", con);
                            //command.ExecuteNonQuery();
                            //con.Close();
                            if (command.ExecuteNonQuery() > 0)
                                MessageBox.Show("Teacher Successfully Removed", "Teacher Removed", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Invalid data, Teacher ID does not exist", "Teacher ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                            BindData2();
                        }
                        else
                            MessageBox.Show("Enter a valid Teacher ID", "Teacher ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        this.Show();
                    }


                }
                else
                {
                    MessageBox.Show("Enter Teacher ID in the search box", "Teacher ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {

                MessageBox.Show("Enter Teacher ID in the search box","Teacher ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (SearchTeacherTextBox.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from Teachers where " +
                    "teach_ID LIKE '%" + SearchTeacherTextBox.Text + "%' OR " +
                    "teach_firstname LIKE '%" + SearchTeacherTextBox.Text + "%' OR " +
                    "teach_lastname LIKE '%" + SearchTeacherTextBox.Text + "%' OR " +
                    "teach_email LIKE '%" + SearchTeacherTextBox.Text + "%' OR " +
                    "teach_title LIKE '%" + SearchTeacherTextBox.Text + "%' OR " +
                    "gender LIKE '%" + SearchTeacherTextBox.Text + "%' OR " +
                    "contactNum LIKE '%" + SearchTeacherTextBox.Text + "%' OR " +
                    "Address LIKE '%" + SearchTeacherTextBox.Text + "%'"
                    , con);

                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                TeacherDGV.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enter Teacher ID in the Search box", "Teacher ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teachID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void teachTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTeacherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TeacherDGV.SelectedRows.Count == 1)
            {
                string id = TeacherDGV.SelectedRows[0].Cells[0].Value + string.Empty;
                TeacherIDTextBox.Text = id;

                string name = TeacherDGV.SelectedRows[0].Cells[1].Value + string.Empty;
                teacherName.Text = name;

                string surname = TeacherDGV.SelectedRows[0].Cells[2].Value + string.Empty;
                teachLName.Text = surname;

                string title = TeacherDGV.SelectedRows[0].Cells[4].Value + string.Empty;
                teachTitle.Text = title;

                string gender = TeacherDGV.SelectedRows[0].Cells[5].Value + string.Empty;
                teachGender.Text = gender;

                string num = TeacherDGV.SelectedRows[0].Cells[6].Value + string.Empty;
                teachcellNum.Text = num;

                string address = TeacherDGV.SelectedRows[0].Cells[7].Value + string.Empty;
                teachAddress.Text = address;
            }

        }
    }
}