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
    public partial class EventRegistration : Telerik.WinControls.UI.RadForm
    {

        #region Local Variables

        public string eventName;
        public string eventDate;
        public string eventTimeFrom;
        public string eventTimeTo;

        #endregion

        #region Init
        public EventRegistration()
        {
            InitializeComponent();
        }
        #endregion

        private void EventRegistration_Load(object sender, EventArgs e)
        {
            lblEventName.Text = globalconfig.eventName;
            lblDate.Text = globalconfig.eventDate;
            lblTime.Text = globalconfig.eventTime;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MySqlConnection MySQLConn=new MySqlConnection();
            MySqlCommand comm;

            MySQLConn.ConnectionString = globalconfig.connstring;

            try
            {
                MySQLConn.Open();
                comm = new MySqlCommand("CALL Add_eventAttendance(@1, @2, @3)", MySQLConn);
                comm.Parameters.AddWithValue("1", mtbStudNum.Text);
                comm.Parameters.AddWithValue("2", globalconfig.eventID);
                comm.Parameters.AddWithValue("3", globalconfig.schoolyearactive);
                comm.ExecuteNonQuery();
                MySQLConn.Close();
                RadMessageBox.Show(this, "You have successfully registered to "+ globalconfig.eventName +". You may now proceed. ", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
            catch(Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }
    }
}
