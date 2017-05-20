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
    public partial class SchoolYearManagement : Telerik.WinControls.UI.RadForm
    {
        public SchoolYearManagement()
        {
            InitializeComponent();
        }

        private void SchoolYearManagement_Load(object sender, EventArgs e)
        {
            get_schoolyear();
        }
        public void get_schoolyear()
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                lvSchoolYear.Items.Clear();
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL list_schoolyear()", MySQLConn);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    lvSchoolYear.Items.Add(reader.GetString("School Year"));
                }
                MySQLConn.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration");
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }
    }
}
