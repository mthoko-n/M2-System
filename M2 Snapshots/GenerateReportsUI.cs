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


        private int getTotalStudents() {


            int sum = groupPmb2DataSet1.student.Rows.Count;

           
            return sum;
        }
        private void nosBtn_Click(object sender, EventArgs e)
        {

           
                        
            textBox1.Text = getTotalStudents().ToString();
           
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
        private decimal getTotalPayments() {


            decimal sum = 0;
            foreach (DataRow row in groupPmb2DataSet1.student.Rows)
            {


                sum = sum + Decimal.Parse(row.ItemArray[8].ToString());

            }

            return sum;
        }



        private void tpsBtn_Click(object sender, EventArgs e)
        {
           
            textBox2.Text = "R"+getTotalPayments().ToString();
        }

        private void clearBtn1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void clearBtn2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void clearBtn3_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void clearBtn4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void clearBtn5_Click(object sender, EventArgs e)
        {
            //textBox4.Clear();
        }

        private void clearBtn6_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void sdBtn_Click(object sender, EventArgs e)
        {
            decimal fees = getTotalStudents() * 2500;
            decimal debt = fees - getTotalPayments();
            textBox3.Text = "R"+debt.ToString();
        }

        private void nspBtn_Click(object sender, EventArgs e)
        {

        }
    }
    }

