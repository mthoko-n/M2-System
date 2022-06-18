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
                && (teachTitle.Text != "") && (teachAddress.Text != "") && (teachEmail.Text != "") && (teachID.Text == ""))
            {
                var rand = new Random();
                int number = rand.Next(1, 10000);


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
                                        if (teachEmail.Text.Length > 9)
                                        {
                                            string teachID = teacherName.Text + teachLName.Text + number;
                                            con.Open();
                                            SqlCommand comm = new SqlCommand("INSERT INTO UserLogin values('" + teachID + "','" + teachID + "')", con);
                                            SqlCommand command = new SqlCommand("INSERT INTO Teachers values('" + teachID + "','" + teacherName.Text + "','" + teachLName.Text + "','" + teachEmail.Text + "','" + teachTitle.Text + "','" + teachGender.Text + "','" + teachcellNum.Text + "','" + teachAddress.Text + "')", con);

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
                MessageBox.Show("Enter All Fields except Teacher ID");
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
            if ((teachID.Text != "") && ((teacherName.Text != "") || (teachLName.Text != "") || (teachEmail.Text != "") || (teachGender.Text != "") || (teachTitle.Text != "") || (teachcellNum.Text != "") || (teachAddress.Text != "")))
            {
                con.Open();

                if ((teacherName.Text != "") && (search.Text != "")) //This is to update/change the teacher's name
                {
                    SqlCommand command = new SqlCommand("update Teachers set teach_firstname = '" + teacherName.Text + "' where teach_ID = '" + teachID.Text + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((teachLName.Text != "") && (teachID.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update Teachers set teach_lastname = '" + teachLName.Text + "' where teach_ID = '" + teachID.Text + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((teachEmail.Text != "") && (teachID.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update Teachers set teach_email = '" + teachEmail.Text + "' where teach_ID = '" + teachID.Text + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((teachGender.Text != "") && (teachID.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update Teachers set gender = '" + teachGender.Text + "' where teach_ID = '" + teachID.Text + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((teachTitle.Text != "") && (search.Text != "")) //This is to update/change the teacher's title
                {
                    SqlCommand command = new SqlCommand("update Teachers set teach_title = '" + teachTitle.Text + "' where teach_ID = '" + teachID.Text + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((teachcellNum.Text != " ") && (teachID.Text != " "))
                {
                    SqlCommand command = new SqlCommand("update Teachers set contactNum = '" + teachcellNum.Text + "' where teach_ID = '" + teachID.Text + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((teachAddress.Text != "") && (teachID.Text != " "))
                {
                    SqlCommand command = new SqlCommand("update Teachers set contactNum = '" + teachAddress.Text + "' where teach_ID = '" + teachID.Text + "'", con);
                    command.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Successfully Updated");
                BindData2();
            }
            else
            {
                MessageBox.Show("Fill in appropriate fields");
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
            teachEmail.Clear();
            teachID.Clear();
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
                                MessageBox.Show("Successfully Removed");
                            else
                                MessageBox.Show("Invalid data, data does not exist");
                            con.Close();
                            BindData2();
                        }
                        else
                            MessageBox.Show("Enter a valid Class ID, only numbers allowed");
                    }

                    else
                    {
                        this.Show();
                    }


                }
            }

            catch
            {

                MessageBox.Show("Invalid");
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
                MessageBox.Show("Enter Teacher ID in the Search box");
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
    }
}