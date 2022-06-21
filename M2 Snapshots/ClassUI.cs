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

        public int getNumStudents()
        {
            int sum = 0;
            foreach (DataRow row in binaryMakersDS.classes.Rows)
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
                MessageBox.Show("Enter Class ID in the Search box", "Search Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show("Class Successfully Removed ", "Class Removed", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Invalid data, data does not exist", "Class ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                            BindData();
                        }
                        else
                            MessageBox.Show("Enter a valid Class ID", "Class ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        this.Show();
                    }


                }

                else
                {
                    MessageBox.Show("Enter Class ID in the search box", "Class ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Enter VALID Class ID", "Class ID not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((ClassIDTextBox.Text != "") && (teachID.Text != "") && (ClassRollTextBox.Text != "") && (GradeCB.Text != "") && (DivisionCB.Text != ""))
            {
                if (ClassIDTextBox.Text.All(char.IsDigit))
                {
                    if (teachID.Text != "")
                    {
                        if (ClassRollTextBox.Text.All(char.IsDigit) && (int.Parse(ClassRollTextBox.Text) != 0))
                        {
                            if (GradeCB.Text.All(char.IsDigit) && (int.Parse(GradeCB.Text) >= 8) && (int.Parse(GradeCB.Text) <= 12))
                            {
                                if (DivisionCB.Text.Length == 1 && DivisionCB.Text.All(char.IsLetter))
                                {

                                    if (BuildingNoTextBox.Text == "")
                                    {
                                        con.Open();
                                        SqlCommand command = new SqlCommand("insert into classes values ('" + int.Parse(ClassIDTextBox.Text) + "','" + teachID.Text + "','" + int.Parse(ClassRollTextBox.Text) + "', '" + -1 + "', '" + int.Parse(GradeCB.Text) + "', '" + char.Parse(DivisionCB.Text.ToUpper()) + "')", con);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Class Successfully Added", "Class Added", MessageBoxButtons.OK);
                                        con.Close();
                                        BindData();
                                    }
                                    else if (BuildingNoTextBox.Text.All(char.IsDigit) && (int.Parse(BuildingNoTextBox.Text) > 0))
                                    {
                                        con.Open();
                                        SqlCommand command = new SqlCommand("insert into classes values ('" + int.Parse(ClassIDTextBox.Text) + "','" + teachID.Text + "','" + int.Parse(ClassRollTextBox.Text) + "', '" + int.Parse(BuildingNoTextBox.Text) + "', '" + int.Parse(GradeCB.Text) + "', '" + char.Parse(DivisionCB.Text.ToUpper()) + "')", con);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Class Successfully Added", "Class Added", MessageBoxButtons.OK);
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
                MessageBox.Show("Enter All Fields", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            int error = 0;
            if ((ClassIDTextBox.Text != "") && ((teachID.Text != "") || (ClassRollTextBox.Text != "") || (BuildingNoTextBox.Text != "") || (GradeCB.Text != "") || (DivisionCB.Text != "")))
            {
                if (ClassIDTextBox.Text.All(char.IsDigit) && (ClassIDTextBox.Text != ""))
                {
                    con.Open();

                    if ((teachID.Text != ""))
                    {
                        SqlCommand command = new SqlCommand("update classes set teacher_id = '" + teachID.Text + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                        if (command.ExecuteNonQuery() > 0)
                            error += 0;
                        else
                        {
                            MessageBox.Show("Enter an appropriate Class ID");
                            error++;
                        }
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
                    if ((GradeCB.Text != ""))
                    {
                        if ((GradeCB.Text.All(char.IsDigit)) && (int.Parse(GradeCB.Text) >= 8) && (int.Parse(GradeCB.Text) <= 12))
                        {
                            SqlCommand command = new SqlCommand("update classes set grade = '" + int.Parse(GradeCB.Text) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Enter an appropriate grade between grades 8 and 12");
                            error++;
                        }

                    }
                    if ((DivisionCB.Text != ""))
                    {
                        if (DivisionCB.Text.Length == 1 && DivisionCB.Text.All(char.IsLetter))
                        {
                            SqlCommand command = new SqlCommand("update classes set Division = '" + char.Parse(DivisionCB.Text.ToUpper()) + "' where class_id = '" + int.Parse(ClassIDTextBox.Text) + "'", con);
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
                        MessageBox.Show("Class Successfully Updated", "Class Updated", MessageBoxButtons.OK);
                    BindData();
                }
                else
                {
                    MessageBox.Show("Enter a valid Class ID", "Update Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("Enter a Class ID and at least one more field to update information", "Update Class", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ClassUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'binaryMakersDS.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.binaryMakersDS.classes);
            // TODO: This line of code loads data into the 'binaryMakersDS.PaymentService' table. You can move, or remove it, as needed.
          

            //textBox1.Text = getNumStudents().ToString();
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
            //DivisionTextBox.Clear();
            GradeCB.ResetText();
            ClassRollTextBox.Clear();
            DivisionCB.ResetText();
        }

        private void SearchClassDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void teacherID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchClassDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SearchClassDataGridView.SelectedRows.Count == 1)
            {
                string id = SearchClassDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                ClassIDTextBox.Text = id;

                string teacherID = SearchClassDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                teachID.Text = teacherID;

                string students = SearchClassDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                ClassRollTextBox.Text = students;

                string buidling = SearchClassDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
                BuildingNoTextBox.Text = buidling;

                string grade = SearchClassDataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
                GradeCB.Text = grade;

                string division = SearchClassDataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
                DivisionCB.Text = division;
            }
        }

        private void SearchClassDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
