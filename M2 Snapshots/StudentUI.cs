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
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();

           
        }

        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupPmb2;Persist Security Info=True;User ID=GroupPmb2;Password=b45dc2");


        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            if ((stuAddressTB.Text != "")&& (stuClassIdTB.Text != "") && (stuIdTB.Text != "") && (stuGenderCB.Text != "")  && (stuFeesTB.Text != "") && (stuLastNameTB.Text != "") && (stuNameTB.Text != "") && (stuParentNoTB.Text != "") && (stuAgeTB.Text != ""))
            {
                con.Open();
                string stuEmail = stuIdTB.Text+"@stu.kharina.ac.za";
               
               if(stuIdTB.Text.All(char.IsDigit) && stuIdTB.Text != "")
                {
                    if (stuClassIdTB.Text != "" && stuClassIdTB.Text.All(char.IsDigit))
                    {
                        if (stuNameTB.Text!="")
                        {
                            if (stuLastNameTB.Text != "")
                            {
                                if(stuAddressTB.Text!="" && stuAddressTB.Text.Length >= 10)
                                {
                                    if (stuGenderCB.Text != "")
                                    {
                                        if(stuAgeTB.Text.All(char.IsDigit) && (int.Parse(stuAgeTB.Text)>12) && (int.Parse(stuAgeTB.Text) < 23))
                                        {
                                           
                                                if (stuFeesTB.Text!="" && stuFeesTB.Text.All(char.IsDigit))
                                                {
                                                    if (stuParentNoTB.Text!="" && (stuParentNoTB.Text.All(char.IsDigit) && stuParentNoTB.Text.Length == 10))
                                                    {
                                                        SqlCommand command = new SqlCommand("INSERT INTO student values('" + int.Parse(stuIdTB.Text) + "','" + int.Parse(stuClassIdTB.Text) + "','" + stuNameTB.Text + "','" + stuLastNameTB.Text + "','" + stuAddressTB.Text + "','" + stuEmail + "','" + int.Parse(stuAgeTB.Text) + "','" + stuGenderCB.Text + "','" + decimal.Parse(stuFeesTB.Text) + "','" + stuParentNoTB.Text + "')", con);

                                                        command.ExecuteNonQuery();
                                                        con.Close();
                                                        BindData();
                                                        MessageBox.Show("Successfully added", "Success!", MessageBoxButtons.OK);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Parent's contact number must be 10 digits long");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Enter a fee amount for the Student");
                                                }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Student Age must be a number between 12-23");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Select a gender");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Student Address is too short");
                                }
                            }
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Enter Class ID, can only contain numbers");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Student ID, can only contain numbers");
                }
                con.Close();  
            }
            else {
                MessageBox.Show("Enter all fields","Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT* FROM student", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            studentDGV.DataSource = dt;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StudentUI_Load(object sender, EventArgs e)
        {
            BindData();
            
        }

        private void stuRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (stuSearchTB.Text != "")
                {

                    DialogResult res = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("Delete student where stu_ID = '" + int.Parse(stuSearchTB.Text) + "'", con);
                        if(command.ExecuteNonQuery()>0)
                            MessageBox.Show("Successfully Removed Student","Remove Student", MessageBoxButtons.OK);
                        con.Close();
                        BindData();
                        MessageBox.Show("Invalid student data, Student does not exist", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        this.Show();
                    }


                }

                else
                {
                    MessageBox.Show("Enter Student ID in the search box", "Student ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Enter VALID Student ID", "Student ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void stuUpdateBtn_Click(object sender, EventArgs e)
        {
            if ((stuIdTB.Text != "" && stuIdTB.Text.All(char.IsDigit)) && ((stuAddressTB.Text != "") || (stuSearchTB.Text != "") || (stuClassIdTB.Text != "") || (stuGenderCB.Text != "") /*|| (stuEmailTB.Text != "")*/ || (stuFeesTB.Text != "") || (stuLastNameTB.Text != "") || (stuNameTB.Text != "") || (stuParentNoTB.Text != "") || (stuAgeTB.Text != "")))
            {
                con.Open();

                if ((stuClassIdTB.Text != "" && stuClassIdTB.Text.All(char.IsDigit)) && (stuIdTB.Text != ""))

                {
                    SqlCommand command = new SqlCommand("update student set classID = '" + int.Parse(stuClassIdTB.Text) + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }

                if ((stuNameTB.Text != "") && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_name = '" + stuNameTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }

                if ((stuLastNameTB.Text != "") && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_surname = '"+stuLastNameTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }

                if ((stuAddressTB.Text != "" && stuAddressTB.Text.Length >= 10) && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_address= '" + stuAddressTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }

                /*if ((stuEmailTB.Text != "") && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_email = '" + stuEmailTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }*/

                if ((stuAgeTB.Text.All(char.IsDigit) && (int.Parse(stuAgeTB.Text) > 12) && (int.Parse(stuAgeTB.Text) < 23)) && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_age = '" + int.Parse(stuAgeTB.Text) + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }

                if ((stuGenderCB.Text != "") && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_gender = '" + stuGenderCB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }

                
                if ((stuFeesTB.Text != "" && stuFeesTB.Text.All(char.IsDigit)) && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_Fees = '" + decimal.Parse(stuFeesTB.Text) + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }

                if ((stuParentNoTB.Text != "" && (stuParentNoTB.Text.All(char.IsDigit) && stuParentNoTB.Text.Length == 10)) && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set parentContact = '" + stuParentNoTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
               
                con.Close();
                BindData();
                MessageBox.Show("Student Successfully Updated","Student Details Updated", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Enter Student ID and at least one other field", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void stuViewBtn_Click(object sender, EventArgs e)
        {
            if (stuSearchTB.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from student where " +
                   "stu_ID LIKE '%" + stuSearchTB.Text + "%' OR " +
                   "stu_name LIKE '%" + stuSearchTB.Text + "%' OR " +
                   "stu_surname LIKE '%" + stuSearchTB.Text + "%' OR " +
                   "parentContact LIKE '%" + stuSearchTB.Text + "%' OR " +
                   "stu_gender LIKE '%" + stuSearchTB.Text + "%' OR " +
                   "stu_address LIKE '%" + stuSearchTB.Text + "%' OR " +
                   "stu_email LIKE '%" + stuSearchTB.Text + "%'"
                   , con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                studentDGV.DataSource = dt;
               
            }
            else
            {
                MessageBox.Show("Enter Student ID in the Search box","Search Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stuIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void stuFeesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void stuDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            BindData();
            stuAddressTB.Clear();
            stuAgeTB.Clear();
            stuClassIdTB.Clear();
            //stuEmailTB.Clear();
            stuFeesTB.Clear();
            stuLastNameTB.Clear();
            stuNameTB.Clear();
            stuParentNoTB.Clear();
            stuIdTB.Clear();
            stuSearchTB.Clear();
           
            stuGenderCB.ResetText();
        }

        private void studentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentDGV.SelectedRows.Count == 1) {
                string id = studentDGV.SelectedRows[0].Cells[0].Value + string.Empty;
                stuIdTB.Text = id;

                string classID = studentDGV.SelectedRows[0].Cells[1].Value + string.Empty;
                stuClassIdTB.Text = classID;

                string name = studentDGV.SelectedRows[0].Cells[2].Value + string.Empty;
                stuNameTB.Text = name;

                string surname = studentDGV.SelectedRows[0].Cells[3].Value + string.Empty;
                stuLastNameTB.Text = surname;

                string address = studentDGV.SelectedRows[0].Cells[4].Value + string.Empty;
                stuAddressTB.Text = address;

                /*
                 * string email = studentDGV.SelectedRows[0].Cells[5].Value + string.Empty;
                stuEmailTB.Text = email;
                */

                string age= studentDGV.SelectedRows[0].Cells[6].Value + string.Empty;
                stuAgeTB.Text = age;

                string gender = studentDGV.SelectedRows[0].Cells[7].Value + string.Empty;
                stuGenderCB.Text = gender;

                string fees = studentDGV.SelectedRows[0].Cells[8].Value + string.Empty;
                stuFeesTB.Text = fees;

                string pContact = studentDGV.SelectedRows[0].Cells[9].Value + string.Empty;
                stuParentNoTB.Text = pContact;

            }
        }

        private void studentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
