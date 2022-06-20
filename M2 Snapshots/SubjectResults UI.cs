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
    public partial class SubjectResults_UI : Form
    {
        public SubjectResults_UI()
        {
            InitializeComponent();
        }

        private void SubjectResults_UI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupPmb2DataSet.subjectResults' table. You can move, or remove it, as needed.
            this.subjectResultsTableAdapter.Fill(this.groupPmb2DataSet.subjectResults);
            //this.subjResultsTableAdapters;
            this.reportViewer1.RefreshReport();
        }
    }
}
