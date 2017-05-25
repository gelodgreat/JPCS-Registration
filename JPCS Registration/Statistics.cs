using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using MySql.Data.MySqlClient;

namespace JPCS_Registration
{
    public partial class Statistics : Telerik.WinControls.UI.RadForm
    {

        
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            lblTotalCash.Text = "Php."+globalconfig.totalMoney.ToString();
            lblSchoolYear.Text = "S.Y. " + globalconfig.schoolyearactive;
            get_stats();
        }
        public void get_stats()
        {

            DataTable dbdataset = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL Get_total_blocks(@schoolyear);", MySQLConn);
                adapter.SelectCommand = comm;
                adapter.SelectCommand.Parameters.AddWithValue("schoolyear", globalconfig.schoolyearactive);
                adapter.Fill(dbdataset);
                radGridStat.DataSource = dbdataset;
                adapter.Update(dbdataset);
                MySQLConn.Close();
            }catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }finally
            {
                MySQLConn.Dispose();
            }
        }
    }
}
