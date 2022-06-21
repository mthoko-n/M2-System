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

        public int getNumStudents()
        {
            int sum = 0;
            foreach (DataRow row in binaryMakersDS1.classes.Rows)
            {
                sum = sum + int.Parse(row.ItemArray[2].ToString());

            }

            return sum;
        }

        private void nosBtn_Click(object sender, EventArgs e)
        {
        
            textBox1.Text = getNumStudents().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateReportsUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'binaryMakersDS1.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.binaryMakersDS1.classes);

        }
    }
}
