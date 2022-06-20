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
            textBox1.Text = ClassUI.classForm.total; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
