using JPCS_Registration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace JPCS_Registrations
{
    public partial class EventRegistration : Telerik.WinControls.UI.RadForm
    {
        #region InitializeComponent
        public EventRegistration()
        {
            InitializeComponent();
        }

        #endregion

        #region local variables

        int errorCount=0;
        #endregion

        #region errorProvider Processor
        void SetError(Control c, string message)
        {
            if (message == "")
                errorCount--;
            else
                errorCount++;
            errorProvider1.SetError(c, message);
        }
        #endregion

        #region mtbStudNum Validating
        private void mtbStudNum_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbStudNum.MaskCompleted)
            {
                errorProvider1.SetError(mtbStudNum, "Incorrect / Invalid Student number format.");
            }
        }
        #endregion

        #region btnRegister Click
        private void btnRegister_Click(object sender, EventArgs e)
        {

            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            if (errorCount == 0)
            {
                try
                {
                    MySQLConn.Open();
                    MySqlCommand comm = new MySqlCommand("CALL Add_eventAttendance(@1, @2);", MySQLConn);
                    comm.Parameters.AddWithValue("1", mtbStudNum.Text);
                    comm.Parameters.AddWithValue("2", globalconfig.currentEventId);
                    comm.ExecuteNonQuery();
                    MySQLConn.Close();
                }catch(Exception ex)
                {
                    //TODO: error on event registration

                }finally
                {
                    MySQLConn.Dispose();
                }
            }
        }
        #endregion
    }
}
