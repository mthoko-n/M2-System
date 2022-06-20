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
    public partial class SubjectUI : Form
    {
        public SubjectUI()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupPmb2;Persist Security Info=True;User ID=GroupPmb2;Password=b45dc2");

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from subjects", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            SubjectDataGridView.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Add subject 
        private void button3_Click(object sender, EventArgs e)
        {
            if ((SubjectNameTextBox.Text != "") && (SubjectIDTextBox.Text != "") && (SubjectDetailsTextBox.Text != ""))
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into subjects values ('" + SubjectIDTextBox.Text + "','" + SubjectNameTextBox.Text + "','" + SubjectDetailsTextBox.Text  + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Inserted");
                con.Close();
                BindData();
            }
            else
            {
                MessageBox.Show("Enter All Fields");
            }

        }
    

        private void SearchSubjectBtn_Click(object sender, EventArgs e)
        {
            if (SearchSubjectTextBox.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from subjects where " +
                    "subject_ID LIKE '%" + SearchSubjectTextBox.Text + "%' OR " +
                    "subject_name LIKE '%" + SearchSubjectTextBox.Text + "%' OR " +
                    "subjdetails LIKE '%" + SearchSubjectTextBox.Text + "%'"
                    , con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                SubjectDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enter Subject ID in the Search box", "Search Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSubjectBtn_Click(object sender, EventArgs e)
        {
            BindData();
            SearchSubjectTextBox.Clear();
            SubjectNameTextBox.Clear();
            SubjectIDTextBox.Clear();
            SubjectDetailsTextBox.Clear();
        }

        private void RemoveSubjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchSubjectTextBox.Text != "")
                {

                    DialogResult res = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("Delete subjects where subject_ID = '" + SearchSubjectTextBox.Text + "'", con);
                        //command.ExecuteNonQuery();
                        if (command.ExecuteNonQuery() > 0)
                            MessageBox.Show("Successfully Removed", "Subject Removed", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Invalid data, please provide Subject ID to remove a field", "Subject ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        //MessageBox.Show("Successfully Removed");
                        BindData();
                    }

                    else
                    {
                        this.Show();
                    }


                }

                else
                {
                    MessageBox.Show("Enter Subject ID in the Search box","Subjetc ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Enter VALID Subject ID", "Subject ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateSubjectBtn_Click(object sender, EventArgs e)
        {
            if ((SubjectIDTextBox.Text != "") && ((SubjectNameTextBox.Text != "") || (SubjectDetailsTextBox.Text != "")))
            {
                con.Open();

                if ((SubjectNameTextBox.Text != "") && (SubjectIDTextBox.Text != ""))

                {
                    SqlCommand command = new SqlCommand("update subjects set subject_name = '" + SubjectNameTextBox.Text + "' where subject_ID = '" + SubjectIDTextBox.Text + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((SubjectDetailsTextBox.Text != "") && (SubjectNameTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update subjects set subjDetails = '" + SubjectDetailsTextBox.Text + "' where subject_ID = '" + SubjectIDTextBox.Text + "'", con);
                    command.ExecuteNonQuery();
                }
               
               
                
                con.Close();
                MessageBox.Show("Subject Successfully Updated", "Subject Added", MessageBoxButtons.OK);
                BindData();
            }
            else
            {
                MessageBox.Show("Enter a Subject ID and at least one other field", "Subject ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SubjectUI_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void SearchSubjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
