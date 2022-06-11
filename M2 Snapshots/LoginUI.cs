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

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username, password;

            try {
                String querry = "SELECT * FROM userLogin WHERE userID = '"+userTB.Text+"' AND Password = '"+passwordTB.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,con);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    username = userTB.Text;
                    password = passwordTB.Text;
                    MainMenu main = new MainMenu();
                    MainMenu.main.loginLabel.Enabled = false;
                    MainMenu.main.loginPanel.Enabled = false;
                    MainMenu.main.studentPic.Enabled = true;
                    MainMenu.main.teacherPic.Enabled = true;
                    MainMenu.main.adminPic.Enabled = true;
                    MainMenu.main.classPic.Enabled = true;
                    MainMenu.main.paymentPic.Enabled = true;
                    MainMenu.main.academicPic.Enabled = true;
                    main.Show();
                    
                    this.Hide();
                }

                else {
                    MessageBox.Show("Invalid Login Details","Error",MessageBoxButtons.OK);
                    userTB.Clear();
                    passwordTB.Clear();
                    userTB.Focus();

                }
            }
            catch { MessageBox.Show("Invalid Login Details", "Error");
            }

            finally {
                con.Close();
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            userTB.Clear();
            passwordTB.Clear();
        }
    }
}
