using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2_Snapshots
{
    public partial class MainMenu : Form
    {

        public static MainMenu main;
        public Label loginLabel;
        public Panel loginPanel;
      

        public MainMenu()
        {
            InitializeComponent();
            main = this;
            loginPanel = LoginPnl;
            loginLabel = LoginLbl;
           
          

    }


    private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
                              
             
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
         private void StudentPB_Click_1(object sender, EventArgs e)
        {
            StudentUI studentObj = new StudentUI();
            studentObj.Show();
            
        }

        private void TeacherPB_Click_1(object sender, EventArgs e)
        {
            TeacherUI teachersObj = new TeacherUI();
            teachersObj.Show();

        }

        private void SubjectPB_Click_1(object sender, EventArgs e)
        {
            SubjectUI subjectObj = new SubjectUI();
            subjectObj.Show();
        }

        private void PaymentPB_Click_1(object sender, EventArgs e)
        {
            PaymentUI paymentObj = new PaymentUI();
            paymentObj.Show();
        }

        private void AdminPB_Click_1(object sender, EventArgs e)
        {
            AdminUI adminObj = new AdminUI();
            adminObj.Show();
        }

        private void ClassPB_Click_1(object sender, EventArgs e)
        {
            ClassUI classObj = new ClassUI();
            classObj.Show();
        }

        private void LoginPnl_Click_1(object sender, EventArgs e)
        {
            LoginUI loginObj = new LoginUI();
            loginObj.Show();
        }

        private void LoginLbl_Click(object sender, EventArgs e)
        {
            LoginUI loginObj = new LoginUI();
            loginObj.Show();
        }

        private void AcademicPB_Click(object sender, EventArgs e)
        {
            AcademicReport_UI academicObj = new AcademicReport_UI();
            academicObj.Show();
                
      }
    }
}
