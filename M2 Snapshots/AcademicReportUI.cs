﻿using M2_Snapshots.DataSet2TableAdapters;
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

        public string textS;
        public AcademicReport_UI()
        {
            InitializeComponent();
        }
        public AcademicReport_UI(string search)
        {

        }
        private void SeartchText_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void searchbutton_Click(object sender, EventArgs e)
        {

            DataTable1TableAdapter F = new DataTable1TableAdapter();
            F.textS = SeartchText.Text;
            this.reportViewer1.RefreshReport();
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AcademicReport_UI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet21.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet21.DataTable1);
            // TODO: This line of code loads data into the 'binaryMakersDS.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.binaryMakersDS.student);
            // TODO: This line of code loads data into the 'binaryMakersDS.subjectResults' table. You can move, or remove it, as needed.
            this.subjectResultsTableAdapter.Fill(this.binaryMakersDS.subjectResults);
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

