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
          

            if ((stuAddressTB.Text != "")&&  (StuClassIDCB.Text!="") && (stuIdTB.Text == "") && (stuGenderCB.Text != "")  && (stuFeesTB.Text != "") && (stuLastNameTB.Text != "") && (stuNameTB.Text != "") && (stuParentNoTB.Text != "") && (stuAgeCB.Text != ""))
            {
               
               if(stuIdTB.Text == "")
                {
                    /*if (stuClassIdTB.Text != "" && stuClassIdTB.Text.All(char.IsDigit))*/
                    if (StuClassIDCB.Text != "" && StuClassIDCB.Text.All(char.IsDigit))
                    {
                        if (stuNameTB.Text!="")
                        {
                            if (stuLastNameTB.Text != "")
                            {
                                if(stuAddressTB.Text!="" && stuAddressTB.Text.Length >= 10)
                                {
                                    if (stuGenderCB.Text != "")
                                    {
                                        if(stuAgeCB.Text.All(char.IsDigit) && (int.Parse(stuAgeCB.Text)>12) && (int.Parse(stuAgeCB.Text) < 23) && (stuAgeCB.Text!=""))
                                        {
                                           
                                                if (stuFeesTB.Text!="" && stuFeesTB.Text.All(char.IsDigit))
                                                {
                                                    if (stuParentNoTB.Text!="" && (stuParentNoTB.Text.All(char.IsDigit) && stuParentNoTB.Text.Length == 10))
                                                    {
                                                    //increment student ID
                                                    string num = "";
                                                    double num2 = 0;
                                                    con.Open();
                                                    SqlCommand a = new SqlCommand("select stu_ID from student order by stu_ID desc", con);
                                                    SqlDataReader read = a.ExecuteReader();
                                                    while (read.Read())
                                                    {
                                                        num = num + "  " + read.GetValue(0).ToString();
                                                        num2 = double.Parse(num);
                                                        break;
                                                    }

                                                    read.Close();
                                                    con.Close();
                                                    //end of student id

                                                    double num3 = Convert.ToInt32(num2);
                                                    double num4 = (num3 + 1);
                                                    int num5 = Convert.ToInt32(num4);

                                                    //increment roll of class
                                                    string roll = "";
                                                    double roll2 = 0;
                                                    con.Open();
                                                    SqlCommand b = new SqlCommand("select numStudents from classes where class_id = " + int.Parse(StuClassIDCB.Text), con);
                                                    SqlDataReader read2 = b.ExecuteReader();
                                                    while (read2.Read())
                                                    {
                                                        roll = roll + "  " + read2.GetValue(0).ToString();
                                                        roll2 = double.Parse(roll);
                                                        break;
                                                    }

                                                    read2.Close();
                                                    con.Close();

                                                    double roll3 = Convert.ToInt32(roll2);
                                                    double roll4 = (roll3 + 1);
                                                    int roll5 = Convert.ToInt32(roll4);
                                                    //end of roll

                                                    con.Open();

                                                    string stuEmail = num5 + "@stu.kharina.ac.za";

                                                    if (roll5 < 31)
                                                    {
                                                        SqlCommand command1 = new SqlCommand("update classes set numStudents = '" + roll5 + "' where class_id = '" + int.Parse(StuClassIDCB.Text) + "'", con);


                                                        SqlCommand command = new SqlCommand("INSERT INTO student values('" + /*int.Parse(stuIdTB.Text)*/ num5 + "','" + int.Parse(StuClassIDCB.Text) + "','" + stuNameTB.Text + "','" + stuLastNameTB.Text + "','" + stuAddressTB.Text + "','" + stuEmail + "','" + int.Parse(stuAgeCB.Text) + "','" + stuGenderCB.Text + "','" + decimal.Parse(stuFeesTB.Text) + "','" + stuParentNoTB.Text + "')", con);

                                                        if ((command.ExecuteNonQuery() > 0) && (command1.ExecuteNonQuery() > 0))
                                                            MessageBox.Show("Successfully added \n\n\nStudent ID is:\t" + num5 + "\nStudent Email is:\t" + stuEmail, "Success!", MessageBoxButtons.OK);
                                                        else
                                                            MessageBox.Show("Enter a valid Student number", "Add Student Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Cannot enroll student into this class, Class is already at full capacity of 30 students", "Add Student Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    con.Close();
                                                    BindData();
                                                       
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Parent's contact number must be 10 digits long");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Enter a fee amount for the Student, Fee amount must not contain decimals");
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
                    MessageBox.Show("Remove Student ID");
                }
                
            }
            else {
                MessageBox.Show("Enter all fields except Student ID","Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // TODO: This line of code loads data into the 'binaryMakersDS.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter1.Fill(this.binaryMakersDS.student);
            // TODO: This line of code loads data into the 'groupPmb2DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.groupPmb2DataSet.student);
            // TODO: This line of code loads data into the 'groupPmb2DataSet1.student' table. You can move, or remove it, as needed.
         
            BindData();

            con.Open();
            SqlCommand command = new SqlCommand("select class_id from classes", con);
            SqlDataReader reader;
            reader = command.ExecuteReader();

            DataTable dt = new DataTable(); 
            dt.Columns.Add("class_id", typeof(string));
            dt.Load(reader);
            StuClassIDCB.ValueMember = "class_id";
            StuClassIDCB.DataSource = dt;
            StuClassIDCB.ResetText();
            con.Close();

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
                        //increment roll of class
                        string roll = "";
                        double roll2 = 0;
                        con.Open();
                        SqlCommand b = new SqlCommand("select numStudents from classes where class_id = " + int.Parse(StuClassIDCB.Text), con);
                        SqlDataReader read = b.ExecuteReader();
                        while (read.Read())
                        {
                            roll = roll + "  " + read.GetValue(0).ToString();
                            roll2 = double.Parse(roll);
                            break;
                        }

                        read.Close();
                        con.Close();

                        double roll3 = Convert.ToInt32(roll2);
                        double roll4 = (roll3 - 1);
                        int roll5 = Convert.ToInt32(roll4);
                        //end of roll

                        con.Open();
                        if (roll5 > 0)
                        {
                            SqlCommand command1 = new SqlCommand("update classes set numStudents = '" + roll5 + "' where class_id = '" + int.Parse(StuClassIDCB.Text) + "'", con);

                            SqlCommand command = new SqlCommand("Delete student where stu_ID = '" + int.Parse(stuSearchTB.Text) + "'", con);
                            if ((command.ExecuteNonQuery() > 0) && (command1.ExecuteNonQuery() > 0))
                                MessageBox.Show("Successfully Removed Student", "Remove Student", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Invalid student data, Student does not exist", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Class is currently empty", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            if ((stuIdTB.Text != "" && stuIdTB.Text.All(char.IsDigit)) && ((stuAddressTB.Text != "") || (stuSearchTB.Text != "") || /*(stuClassIdTB.Text != "")*/ (StuClassIDCB.Text!="") || (stuGenderCB.Text != "") /*|| (stuEmailTB.Text != "")*/ || (stuFeesTB.Text != "") || (stuLastNameTB.Text != "") || (stuNameTB.Text != "") || (stuParentNoTB.Text != "") || (stuAgeCB.Text != "")))
            {
                int error = 0;
                con.Open();

                if ((StuClassIDCB.Text != "" && StuClassIDCB.Text.All(char.IsDigit)) && (stuIdTB.Text != ""))

                {
                    SqlCommand command = new SqlCommand("update student set classID = '" + int.Parse(StuClassIDCB.Text) + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter valid class ID \nEnter a valid Student ID");
                        error++;
                    }
                }

                if ((stuNameTB.Text != "") && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_name = '" + stuNameTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid Student ID");
                        error++;
                    }
                }

                if ((stuLastNameTB.Text != "") && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_surname = '"+stuLastNameTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid Student ID");
                        error++;
                    }
                }

                if ((stuAddressTB.Text != "" && stuAddressTB.Text.Length >= 10) && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_address= '" + stuAddressTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Student address must be at least 10 characters long  \nEnter a valid Student ID");
                        error++;
                    }
                }

                /*if ((stuEmailTB.Text != "") && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_email = '" + stuEmailTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    command.ExecuteNonQuery();
                }*/

                if ((stuAgeCB.Text.All(char.IsDigit) && (int.Parse(stuAgeCB.Text) > 12) && (int.Parse(stuAgeCB.Text) < 23)) && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_age = '" + int.Parse(stuAgeCB.Text) + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter valid student age between ages 12-23\nEnter a valid Student ID");
                        error++;
                    }
                }

                if ((stuGenderCB.Text != "") && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_gender = '" + stuGenderCB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Select a valid gender \nEnter a valid Student ID");
                        error++;
                    }
                }

                
                if ((stuFeesTB.Text != "" && stuFeesTB.Text.All(char.IsDigit)) && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set stu_Fees = '" + decimal.Parse(stuFeesTB.Text) + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter a valid fee amount for the student (Number must be a whole number and must not contain decimals) \nEnter a valid Student ID");
                        error++;
                    }
                }

                if ((stuParentNoTB.Text != "" && (stuParentNoTB.Text.All(char.IsDigit) && stuParentNoTB.Text.Length == 10)) && (stuIdTB.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update student set parentContact = '" + stuParentNoTB.Text + "' where stu_ID = '" + int.Parse(stuIdTB.Text) + "'", con);
                    if (command.ExecuteNonQuery() > 0)
                        error += 0;
                    else
                    {
                        MessageBox.Show("Enter valid parent cell number, must contain 10 digits \nEnter a valid Student ID");
                        error++;
                    }
                }
               
                con.Close();
                BindData();
                if(error==0)
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
            
            stuAgeCB.ResetText();
            
            stuFeesTB.Clear();
            stuLastNameTB.Clear();
            stuNameTB.Clear();
            stuParentNoTB.Clear();
            stuIdTB.Clear();
            stuSearchTB.Clear();
            StuClassIDCB.ResetText();
            stuGenderCB.ResetText();
        }

        private void studentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentDGV.SelectedRows.Count == 1) {
                string id = studentDGV.SelectedRows[0].Cells[0].Value + string.Empty;
                stuIdTB.Text = id;

                string classID = studentDGV.SelectedRows[0].Cells[1].Value + string.Empty;
                StuClassIDCB.Text = classID;
                //stuClassIdTB.Text = classID;

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
                stuAgeCB.Text = age;

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
