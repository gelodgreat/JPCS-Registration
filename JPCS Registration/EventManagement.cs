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
    public partial class EventManagement : Telerik.WinControls.UI.RadForm
    {

        public string selected;
        MySqlConnection MySQLConn;
        public DataTable dbdataset = new DataTable();

        public string selectedEventName;
        public string selectedEventDate;
        public int selectedEventID;
        public string selectedEventTime;

        public EventManagement()
        {
            InitializeComponent();
        }
        #region ShowParticipants
        public void ShowParticipants(int eventID)
        {
            selected = "";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection MySQLConn = new MySqlConnection();

            MySQLConn.ConnectionString = globalconfig.connstring;

            try
            {
                dbdataset.Clear();
                MySQLConn.Open();
                MySqlCommand comm;
                comm = new MySqlCommand("CALL get_eventAttendance(@1);", MySQLConn);
                comm.Parameters.AddWithValue("1", eventID);
                adapter.SelectCommand = comm;
                adapter.Fill(dbdataset);
                radGridParticipants.DataSource = dbdataset;
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
        #endregion

        public void GetEvents()
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                lbEvents.Items.Clear();
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL list_schoolyear()", MySQLConn);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    lbEvents.Items.Add(reader.GetString("eventname"));
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

        private void EventManagement_Load(object sender, EventArgs e)
        {
            ShowParticipants(globalconfig.eventID);
        }

        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                lbEvents.Items.Clear();
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL get_eventDetails(@1)", MySQLConn);
                comm.Parameters.AddWithValue("1", lbEvents.Text);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    selectedEventID = reader.GetInt32("eventId");
                    selectedEventName = reader.GetString("eventname");
                    selectedEventDate = reader.GetString("eventdate");
                    selectedEventTime = reader.GetString("eventTime");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                lbEvents.Items.Clear();
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL Add_event(@1, @2, @3, @4)", MySQLConn);
                comm.Parameters.AddWithValue("1", txtEventname.Text);
                comm.Parameters.AddWithValue("2", txtEventDate.Text);
                comm.Parameters.AddWithValue("3", txtStartTime.Text);
                comm.Parameters.AddWithValue("4", txtEndTime.Text);
                comm.ExecuteNonQuery();
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

        private void radGridParticipants_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            selected = "";
            if (e.RowIndex >= 0)
            {
                Telerik.WinControls.UI.GridViewRowInfo row = this.radGridParticipants.Rows[e.RowIndex];


                row = this.radGridParticipants.Rows[e.RowIndex];
                selected = row.Cells["Student Number"].Value.ToString();
                selected = "";
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selected))
            {
                RadMessageBox.Show(this, "Please choose a participant first!!", "JPCS Registration");
                return;
            }
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                lbEvents.Items.Clear();
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL delete_eventAttendance(@1, @2)", MySQLConn);
                comm.Parameters.AddWithValue("1", selected);
                comm.Parameters.AddWithValue("2", globalconfig.eventID);
                comm.ExecuteNonQuery();
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

        private void btnActivate_Click(object sender, EventArgs e)
        {
            //TODO: Activate
        }
    }
}
