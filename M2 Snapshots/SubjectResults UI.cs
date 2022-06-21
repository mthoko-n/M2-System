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
                    }

        private void ClearSubjectBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddResultBtn_Click(object sender, EventArgs e)
        {
            if ((SubjectResID.Text != "") && (StudentIDTextBox.Text != "") && (subjID.Text != "") && (subjTeachID.Text!=" " )&& (termResult.Text!= "") && (termNO.Text != ""))
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into subjectResults values ('" + int.Parse(SubjectResID.Text) + "','" + int.Parse(StudentIDTextBox.Text) + "','" + subjID.Text + int.Parse(subjTeachID.Text) + int.Parse(termResult.Text)+ (termNO.Text)+ "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Inserted");
                con.Close();
                BindData();
            }
            else
            {
                MessageBox.Show("Enter All Fields", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    "subResultID LIKE '%" + int.Parse(searchRes.Text) + "%' OR " +
                    "studentID LIKE '%" + int.Parse(searchRes.Text) + "%' OR " +
                    "subjectID LIKE '%" + searchRes.Text + "%'"+
                    "subjectTeachID LIKE '%" + int.Parse(searchRes.Text)+ "%'"
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
    }
}
