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

            var rand = new Random();
            int number = rand.Next(1, 10000);
            string teachID = teacherName.Text+teachLName.Text+number;
        


            con.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO UserLogin values('"+teachID+"','"+ teachID + "')", con);
            SqlCommand command = new SqlCommand("INSERT INTO Teachers values('"+ teachID + "','"+ teacherName.Text + "','" + teachLName.Text +"','" + teachEmail.Text+ "','" + teachTitle.Text+ "','" + teachGender.Text+ "','" + teachcellNum.Text + "','" + teachAddress.Text+ "')", con);

            comm.ExecuteNonQuery();
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully added", "Success!", MessageBoxButtons.OK);
            con.Close();
            BindData2();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void classClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }
    }
}
