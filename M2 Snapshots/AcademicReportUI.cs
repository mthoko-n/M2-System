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
    public partial class AcademicReport_UI : Form
    {
        public AcademicReport_UI()
        {
            InitializeComponent();
        }

        private void SeartchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AcademicReport_UI_Load(object sender, EventArgs e)
        {
            /*this.subjResult.Fill();*/
            this.reportViewer1.RefreshReport();
            this.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
        }
    }
}

