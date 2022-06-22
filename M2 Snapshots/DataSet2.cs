using M2_Snapshots.DataSet2TableAdapters;
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


    partial class DataSet2

    {

    }
}

namespace M2_Snapshots.DataSet2TableAdapters {


    public partial class DataTable1TableAdapter
    {
        public string userID ="22010";
        public string txt;

        public string textS
        {
            get { return txt; }
            set { txt = value; }
        }

        private void DataTable1TableAdapter_Load(object sender, EventArgs e)
        {
            this.InitCommandCollection();
            userID = txt;
        }

        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT student.*, subjectResults.*, subjects.*\r\nFROM   student INNER JOIN\r\n      " +
                "       subjectResults ON student.stu_ID = subjectResults.studentID INNER JOIN\r\n " +
                "            subjects ON subjectResults.subjectID = subjects.subject_ID where stu_ID="+int.Parse(userID);
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
    }
}
