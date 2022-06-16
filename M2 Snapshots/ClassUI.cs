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
    public partial class ClassUI : Form
    {
        public ClassUI()
        {
            InitializeComponent();
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

        private void ViewDetalisButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "")
            {
                SqlCommand command = new SqlCommand("select * from classes where class_id = '" + int.Parse(SearchTextBox.Text) + "'", con);
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
                        con.Open();
                        SqlCommand command = new SqlCommand("Delete classes where class_id = '" + int.Parse(SearchTextBox.Text) + "'", con);
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully Removed");
                        BindData();
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
            catch {
                MessageBox.Show("Enter VALID class ID","Class ID not valid",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((ClassIDTextBox.Text!="") && (teachID.Text!="") && (ClassRollTextBox.Text!="") && (GradeTextBox.Text!="") && (DivisionTextBox.Text!=""))
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into classes values ('" + int.Parse(ClassIDTextBox.Text) + "','" + teachID.Text + "','" + int.Parse(ClassRollTextBox.Text) + "', '" + int.Parse(BuildingNoTextBox.Text) + "', '" + int.Parse(GradeTextBox.Text) + "', '" + char.Parse(DivisionTextBox.Text) + "')", con);
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if ((ClassIDTextBox.Text != "") || (teachID.Text != "") || (ClassRollTextBox.Text != "") || (BuildingNoTextBox.Text != "") || (GradeTextBox.Text != "") || (DivisionTextBox.Text != ""))
            {
                con.Open();

                if ((teachID.Text != "") && (ClassIDTextBox.Text != ""))
                        
                {
                    SqlCommand command = new SqlCommand("update classes set teacher_id = '" + teachID.Text + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((ClassRollTextBox.Text != "") && (ClassIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update classes set numStudents = '" + int.Parse(ClassRollTextBox.Text) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((BuildingNoTextBox.Text != "") && (ClassIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update classes set buildingNo = '" + int.Parse(BuildingNoTextBox.Text) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((GradeTextBox.Text != "") && (ClassIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update classes set grade = '" + int.Parse(GradeTextBox.Text) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                if ((DivisionTextBox.Text != "") && (ClassIDTextBox.Text != ""))
                {
                    SqlCommand command = new SqlCommand("update classes set Division = '" + char.Parse(DivisionTextBox.Text) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                    command.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Successfully Updated");
                BindData();
            }
            else
            {
                MessageBox.Show("Fill in appropriate fields");
            }
           
           
        }

        private void ClassUI_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void classClearBtn_Click(object sender, EventArgs e)
        {
            BindData();
            SearchTextBox.Clear();
            ClassIDTextBox.Clear();
            //teachID.Clear();
            BuildingNoTextBox.Clear();
            DivisionTextBox.Clear();
            GradeTextBox.Clear();
            ClassRollTextBox.Clear();
        }

        private void SearchClassDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teacherID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
