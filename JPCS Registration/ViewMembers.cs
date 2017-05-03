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
    public partial class ViewMembers : Telerik.WinControls.UI.RadForm
    {
        globalconfig gc = new globalconfig();
        MySqlConnection MySQLConn = new MySqlConnection();
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            load_memberlist();
        }
        public void load_memberlist()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dbdataset = new DataTable();
            if (MySQLConn.State == ConnectionState.Open)
            {
                MySQLConn.Close();
            }

            MySQLConn.ConnectionString = gc.conn;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = gc.command;
                comm = new MySqlCommand("SELECT ornumber AS 'OR #', studno AS 'Student #', lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', courseyearsection AS 'Course, Year and Section', emailaddress AS 'E-mail Address', birthday AS 'Birthday', nationality AS 'Nationality', cityaddress AS 'City Address', provinceaddress AS 'Province Address', contactnumber AS 'Contact #', emergencycontactname 'Emergency Contact', emergencycontactnumber AS 'Emergency Contact Number' FROM `memberlist`;", MySQLConn);
				//comm = new MySqlCommand("SELECT * FROM memberlist WHERE studno IN (SELECT * FROM test);", MySQLConn);
                adapter.SelectCommand = comm;
                adapter.Fill(dbdataset);
                radGridMembers.DataSource = dbdataset;
                adapter.Update(dbdataset);
                MySQLConn.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }
    }
}
