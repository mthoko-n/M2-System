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
    public partial class GenerateReportsUI : Form
    {
        public GenerateReportsUI()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void nosBtn_Click(object sender, EventArgs e)
        {

            int sum = 0;
           
            foreach (DataRow row in groupPmb2DataSet1.classes.Rows)
            {
                sum = sum + int.Parse(row.ItemArray[2].ToString());

               
            }

            textBox1.Text = sum.ToString();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateReportsUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupPmb2DataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.groupPmb2DataSet1.student);
            // TODO: This line of code loads data into the 'groupPmb2DataSet1.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter1.Fill(this.groupPmb2DataSet1.classes);
            // TODO: This line of code loads data into the 'binaryMakersDS1.classes' table. You can move, or remove it, as needed.
          

        }

        private void nfsLbl_Click(object sender, EventArgs e)
        {

        }

        private void nsfBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (DataRow row in groupPmb2DataSet1.student.Rows)
            {
                

                if (row.ItemArray[7].ToString().Equals("Female") || (row.ItemArray[7].ToString().Equals("female")))
                {
                    counter = counter + 1;
                }
            }

            textBox5.Text = counter.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nmsBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (DataRow row in groupPmb2DataSet1.student.Rows)
            {


                if (row.ItemArray[7].ToString().Equals("Male") || (row.ItemArray[7].ToString().Equals("male")))
                {
                    counter = counter + 1;
                }
            }

            textBox6.Text = counter.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
                
        }
    }
    }

