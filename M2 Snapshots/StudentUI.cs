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
            con.Open();
            int age = DateTime.Today.Year - stuDateTimePicker.Value.Year;
            stuAgeTB.Text = age.ToString();
            SqlCommand command = new SqlCommand("INSERT INTO students values('"+stuIdTB.Text+ "','" +stuClassIdTB.Text+ "','" + stuNameTB.Text+ "','" + stuLastNameTB.Text + "','" + stuAddressTB.Text + "','" + stuEmailTB.Text + "','" + age.ToString()+ "','" + stuGenderCB.Text+ "','" + stuDateTimePicker.Text + "','" + decimal.Parse(stuFeesTB.Text) + "','" + int.Parse(stuParentNoTB.Text) + "')", con);

            command.ExecuteNonQuery();
            MessageBox.Show("Successfully added","Success!",MessageBoxButtons.OK);
            con.Close();
            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT* FROM students", con);
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

        }

        private void stuUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void stuViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void stuIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void stuGenderCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
