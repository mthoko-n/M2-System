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
    public partial class SubjectResults_UI : Form
    {
        public SubjectResults_UI()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupPmb2;Persist Security Info=True;User ID=GroupPmb2;Password=b45dc2");

        void BindData()
        {
            
            SqlCommand command = new SqlCommand("select * from subjectResults", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            SubjectResultsGridView.DataSource = dt;
        }
        private void SubjectResults_UI_Load(object sender, EventArgs e)
        {
            BindData();
            con.Open();
            SqlCommand command = new SqlCommand("select subject_ID from subjects order by subject_ID", con);
            SqlDataReader reader;
            reader = command.ExecuteReader();
       
            DataTable dt = new DataTable();
            dt.Columns.Add("subject_ID", typeof(string));
            dt.Load(reader);
            subjIDCB.ValueMember = "subject_ID";
            subjIDCB.DataSource = dt;
            subjIDCB.ResetText();
            con.Close();
        }

        private void ClearSubjectBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddResultBtn_Click(object sender, EventArgs e)
        {
            
            if ((SubjectResID.Text == "") && (StudentIDTextBox.Text != "") && (subjIDCB.Text != "") && (subjTeachID.Text!=" " )&& (termResult.Text!= "") && (termNoCB.Text != ""))
            {
                if (StudentIDTextBox.Text.All(char.IsDigit))
                {
                    if (subjIDCB.Text != "")
                    {
                        if(subjTeachID.Text!="" && subjTeachID.Text.All(char.IsDigit))
                        {
                            if((termResult.Text!="") && (termResult.Text.All(char.IsDigit) && (int.Parse(termResult.Text)>=0) && (int.Parse(termResult.Text)<=100)))
                            {
                                if (termNoCB.Text != "")
                                {
                                    string num = "";
                                    double num2 = 0;
                                    con.Open();
                                    SqlCommand a = new SqlCommand("select subResultID from subjectResults order by subResultID desc", con);
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
                                    double num4 = (num3 + 1);
                                    int num5 = Convert.ToInt32(num4);

                                    con.Open();
                                    SqlCommand command = new SqlCommand("insert into subjectResults values ('" + /*int.Parse(SubjectResID.Text)*/ num5 + "','" + int.Parse(StudentIDTextBox.Text) + "','" + subjIDCB.Text + "','" + int.Parse(subjTeachID.Text) + "','" + int.Parse(termResult.Text) + "','" + (termNoCB.Text) + "')", con);
                                    if (command.ExecuteNonQuery() > 0)
                                        MessageBox.Show("Student Results Successfully Inserted", "Student Results Inserted", MessageBoxButtons.OK);
                                    else
                                        MessageBox.Show("Ensure all details are correct", "Result insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    con.Close();
                                    BindData();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Select a term number for the results");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Term result must be a number between 0-100 ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Subject Teacher ID can only contain numbers");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a valid Subject ID");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid StudentID, Student ID can only contain numbers");
                }
            }
            else
            {
                MessageBox.Show("Enter All Fields except Subject Results ID", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SubjectIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjID_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjTeachID_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectResultsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void termResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void termNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchSubjectBtn_Click(object sender, EventArgs e)
        {
            if (searchRes.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from subjectResults where " +
                    "subResultID LIKE '%" + searchRes.Text + "%' OR " +
                    "studentID LIKE '%" + searchRes.Text + "%' OR " +
                    "subjectID LIKE '%" + searchRes.Text + "%' OR "+
                    "subjectTeachID LIKE '%" + searchRes.Text+ "%'"
                    , con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                SubjectResultsGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enter Results ID ,Student ID or Subject ID in the Search box", "Search Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearSubjectBtn_Click_1(object sender, EventArgs e)
        {
            termNoCB.ResetText();
            subjIDCB.ResetText();
            SubjectResID.Clear();
            StudentIDTextBox.Clear();
            termResult.Clear();
            subjTeachID.Clear();
        }

        private void UpdateSubjectBtn_Click(object sender, EventArgs e)
        {
            int error = 0;

            if ((SubjectResID.Text != "") && ((StudentIDTextBox.Text != "") || (subjIDCB.Text != "") || (subjTeachID.Text != " ") || (termResult.Text != "") || (termNoCB.Text != "")))
            {
                if (SubjectResID.Text.All(char.IsDigit))
                {
                    con.Open();

                    if ((StudentIDTextBox.Text != "") && (StudentIDTextBox.Text.All(char.IsDigit)))
                    {
                        SqlCommand command = new SqlCommand("update subjectResults set studentID = '" + int.Parse(StudentIDTextBox.Text) + "' where subResultID = '" + int.Parse(SubjectResID.Text) + "'", con);
                        if (command.ExecuteNonQuery() > 0)
                            error += 0;
                        else
                        {
                            MessageBox.Show("Enter an appropriate Student ID");
                            error++;
                        }
                    }
                    if ((subjIDCB.Text != ""))
                    {

                        SqlCommand command = new SqlCommand("update subjectResults set subjectID = '" + subjIDCB.Text + "' where subResultID = '" + int.Parse(SubjectResID.Text) + "'", con);
                        if (command.ExecuteNonQuery() > 0)
                            error += 0;
                        else
                        {
                            MessageBox.Show("Select an appropriate Student Subject");
                            error++;
                        }
                    }
                    if ((subjTeachID.Text != "") && (subjTeachID.Text.All(char.IsDigit)))
                    {
                        SqlCommand command = new SqlCommand("update subjectResults set subjectTeachID = '" + int.Parse(subjTeachID.Text) + "' where subResultID = '" + int.Parse(SubjectResID.Text) + "'", con);
                        if (command.ExecuteNonQuery() > 0)
                            error += 0;
                        else
                        {
                            MessageBox.Show("Enter an appropriate Teacher ID");
                            error++;
                        }
                    }
                    if ((termResult.Text != "") && (termResult.Text.All(char.IsDigit) && (int.Parse(termResult.Text) >= 0) && (int.Parse(termResult.Text) <= 100)))
                    {
                        SqlCommand command = new SqlCommand("update subjectResults set termResult = '" + int.Parse(termResult.Text) + "' where subResultID = '" + int.Parse(SubjectResID.Text) + "'", con);
                        if (command.ExecuteNonQuery() > 0)
                            error += 0;
                        else
                        {
                            MessageBox.Show("Term result must be a number between 0-100 ");
                            error++;
                        }

                    }
                    if ((termNoCB.Text != ""))
                    {
                        SqlCommand command = new SqlCommand("update subjectResults set TermNo = '" + termNoCB.Text + "' where subResultID = '" + int.Parse(SubjectResID.Text) + "'", con);
                        if (command.ExecuteNonQuery() > 0)
                            error += 0;
                        else
                        {
                            MessageBox.Show("Select an appropriate Term Number");
                            error++;
                        }
                    }

                    con.Close();
                    if (error == 0)
                        MessageBox.Show("Subject Result Successfully Updated", "Result Updated", MessageBoxButtons.OK);
                    BindData();
                }
                else
                {
                    MessageBox.Show("Subject Result ID must be a number");
                }
               
            }
            else
            {
                MessageBox.Show("Enter a Subject Result ID and at least one other field", "Update Result Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RemoveSubjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchRes.Text != "" && searchRes.Text.All(char.IsDigit))
                {

                    DialogResult res = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        if (searchRes.Text.All(char.IsDigit))
                        {
                            con.Open();

                            SqlCommand command = new SqlCommand("Delete subjectResults where subResultID = '" + int.Parse(searchRes.Text) + "'", con);
                            //command.ExecuteNonQuery();
                            //con.Close();
                            if (command.ExecuteNonQuery() > 0)
                                MessageBox.Show("Subject Result Successfully Removed ", "Result Removed", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Invalid data, data does not exist", "Subject Result ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                            BindData();
                        }
                        else
                            MessageBox.Show("Enter VALID Subject Result ID", "Subject Result ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        this.Show();
                    }


                }

                else
                {
                    MessageBox.Show("Enter VALID Subject Result ID", "Subject Result ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Enter VALID Subject Result ID", "Subject Result ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubjectResultsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SubjectResultsGridView.SelectedRows.Count == 1)
            {
                string id = SubjectResultsGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                SubjectResID.Text = id;

                string studentid = SubjectResultsGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                StudentIDTextBox.Text = studentid;

                string subjectid = SubjectResultsGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                subjIDCB.Text = subjectid;

                string teachid = SubjectResultsGridView.SelectedRows[0].Cells[3].Value + string.Empty;
                subjTeachID.Text = teachid;

                string res = SubjectResultsGridView.SelectedRows[0].Cells[4].Value + string.Empty;
                termResult.Text = res;

                string term = SubjectResultsGridView.SelectedRows[0].Cells[5].Value + string.Empty;
                termNoCB.Text = term;
            }
        }
    }
}
