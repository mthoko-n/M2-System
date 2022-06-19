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
        public static MainMenu m;
      
        public ToolStripButton stu;
        public ToolStripButton login;
        public ToolStripButton tea;
        public ToolStripButton sub;
        public ToolStripButton adm;
        public ToolStripButton cla;
        public ToolStripButton aca;
        public ToolStripButton logout;
        public ToolStripButton pay;
        public MenuStrip mstrip;



        public MainMenu()
        {
            InitializeComponent();
            m = this;
          
            stu = studentsBtn;
            login = loginBtn;
            tea = teacherBtn;
            sub = subjectsBtn;
            adm = adminBtn;
            cla = classBtn;
            aca = academicReportBtn;
            pay = paymentBtn;
            logout = logoutBtn;
            mstrip = menuStrip1;

           

         }

        public void FormSetup(Form myForm)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }

            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
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
            foreach (Control ctrl in this.Controls) {

                if (ctrl is MdiClient) {
                    ctrl.BackColor = Color.WhiteSmoke;
                }


            }




           
           
           
                        
                


        }
                              
             
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
      
    
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherUI teachersObj = new TeacherUI();
            FormSetup(teachersObj);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginUI loginObj = new LoginUI();
            loginObj.MdiParent = this;
            loginObj.Show();
            
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            StudentUI studentObj = new StudentUI();
            FormSetup(studentObj);
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            TeacherUI teachersObj = new TeacherUI();
            FormSetup(teachersObj);
        }

        private void subjectsBtn_Click(object sender, EventArgs e)
        {
            SubjectUI subjectObj = new SubjectUI();
            FormSetup(subjectObj);
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminUI adminObj = new AdminUI();
            FormSetup(adminObj);
        }

        private void classBtn_Click(object sender, EventArgs e)
        {
            ClassUI classObj = new ClassUI();
            FormSetup(classObj);
        }

        private void academicReportBtn_Click(object sender, EventArgs e)
        {
            AcademicReport_UI academicObj = new AcademicReport_UI();
            FormSetup(academicObj); 

        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            PaymentUI paymentObj = new PaymentUI();
            FormSetup(paymentObj);
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectUI subjectObj = new SubjectUI();
            FormSetup(subjectObj);
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUI adminObj = new AdminUI();
            FormSetup(adminObj);
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassUI classObj = new ClassUI();
            FormSetup(classObj);
        }

        private void academicReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcademicReport_UI academicObj = new AcademicReport_UI();
            FormSetup(academicObj);
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PaymentUI paymentObj = new PaymentUI();
            FormSetup(paymentObj);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
           
           
        }
    }
}
