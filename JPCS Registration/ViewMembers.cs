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
        public globalconfig gc = new globalconfig();
       
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
                comm = new MySqlCommand("SELECT ornum, memberlist.studno, memberlist.lname, memberlist.fname, memberlist.mname, memberlist.courseyearsection, memberlist.emailaddress, memberlist.birthday, memberlist.nationality, memberlist.cityaddress, memberlist.provinceaddress, memberlist.contactnumber, memberlist.emergencycontactname, memberlist.emergencycontactnumber FROM `"+globalconfig.schoolyearactive+"` INNER JOIN memberlist ON `20162017`.studno=memberlist.studno ORDER BY ornum ASC;", MySQLConn);
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
