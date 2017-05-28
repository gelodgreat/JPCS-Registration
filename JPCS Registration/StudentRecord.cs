using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace JPCS_Registration
{
    public partial class StudentRecord : Telerik.WinControls.UI.RadForm
    {
        public StudentRecord()
        {
            InitializeComponent();
        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {
            lblstudno.Text = globalconfig.selection;
            get_student_record();
        }
        public void get_student_record()
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dbdataset = new DataTable();

            MySQLConn.ConnectionString = globalconfig.connstring;

            try
            {
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL Get_student_records(@studno);", MySQLConn);
                adapter.SelectCommand = comm;
                adapter.SelectCommand.Parameters.AddWithValue("studno", globalconfig.selection);
                adapter.Fill(dbdataset);
                radGridRecords.DataSource = dbdataset;
                adapter.Update(dbdataset);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                MySQLConn.Dispose();
            }
        }
    }
}
