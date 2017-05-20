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
        String connstring = globalconfig.connstring;
       
        MySqlConnection MySQLConn = new MySqlConnection();
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            load_memberlist();
            lbl_schoolyear.Text = globalconfig.schoolyearactive;
        }
        public void load_memberlist()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dbdataset = new DataTable();
            if (MySQLConn.State == ConnectionState.Open)
            {
                MySQLConn.Close();
            }

            MySQLConn.ConnectionString = connstring;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = gc.command;
                comm = new MySqlCommand("CALL show_current_members(@schoolyear);", MySQLConn);
                comm.Parameters.AddWithValue("schoolyear", globalconfig.schoolyearactive);
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
        public void load_all_members()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dbdataset = new DataTable();
            if (MySQLConn.State == ConnectionState.Open)
            {
                MySQLConn.Close();
            }

            MySQLConn.ConnectionString = connstring;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = gc.command;
                comm = new MySqlCommand("CALL show_all_members();", MySQLConn);
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
