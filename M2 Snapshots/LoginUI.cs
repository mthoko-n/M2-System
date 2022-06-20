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
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupPmb2;Persist Security Info=True;User ID=GroupPmb2;Password=b45dc2");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPagePnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.Gray;
            loginBtn.Enabled = false;
            passwordTB.UseSystemPasswordChar = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username, password;

            try {
                String querry = "SELECT * FROM UserLogin WHERE userID = '" + userTB.Text+ "' AND Password = '" + passwordTB.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,con);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    username = userTB.Text;
                    password = passwordTB.Text;


                    MainMenu m = new MainMenu();





                    if (adminRB.Checked == true)
                    { 
                    m.login.Enabled = false;
                    m.stu.Enabled = true;
                    m.sub.Enabled = true;
                    m.tea.Enabled = true;
                    m.cla.Enabled = true;
                    m.adm.Enabled = true;
                    m.pay.Enabled = true;
                    m.aca.Enabled = true;
                    m.mstrip.Enabled = true;
                    m.gen.Enabled = true;
                    m.logout.Enabled = true;
                    }


                    if (teacherRB.Checked == true)
                    {
                        m.login.Enabled = false;
                        m.stu.Enabled = true;
                        m.sub.Enabled = true;
                        m.cla.Enabled = true;
                        m.aca.Enabled = true;
                        m.mstrip.Enabled = false;
                        m.logout.Enabled = true;
                    }

                    





                    this.Close();
                    m.Show();

                }




                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK);
                    userTB.Clear();
                    passwordTB.Clear();
                    userTB.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Invalid Login Details", "Error");

            }

            finally
            {
                con.Close();
            }
        }

    private void clearBtn_Click(object sender, EventArgs e)
        {
            userTB.Clear();
            passwordTB.Clear();
        }

        private void adminRB_CheckedChanged(object sender, EventArgs e)
        {

            loginBtn.Enabled = true;
            loginBtn.BackColor = Color.RoyalBlue;
        }

        private void teacherRB_CheckedChanged(object sender, EventArgs e)
        {
            loginBtn.Enabled = true;
            loginBtn.BackColor = Color.RoyalBlue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTB.UseSystemPasswordChar = false;
            }

            else {
                passwordTB.UseSystemPasswordChar = true;
            }
        }
    } }

        
  
