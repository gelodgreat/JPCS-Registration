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
            get_schoolyear_list();
            lvSchoolYear.SelectedIndex = 0;
            lblActiveSchoolYear.Text = globalconfig.schoolyearactive;
        }
        public void get_schoolyear_list()
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

        private void btnActivate_Click(object sender, EventArgs e)
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {

                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL ChangeSchoolYear(@1)", MySQLConn);
                comm.Parameters.AddWithValue("1", lvSchoolYear.SelectedItem.ToString());
                comm.ExecuteNonQuery();
                RadMessageBox.Show(this, "The School Year has been successfully Changed!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                MySQLConn.Close();
                get_schoolyear();
                lblActiveSchoolYear.Text = globalconfig.schoolyearactive;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lvSchoolYear.Text);
            DialogResult ConfirmDelete = RadMessageBox.Show(this, "Are you sure you want to delete the selected School Year? Deleting a School Year Deletes all members registered for the Scpecific School Year. This action cannot be undone.", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ConfirmDelete == DialogResult.Yes)
            {
                MySqlConnection MySQLConn = new MySqlConnection();
                MySQLConn.ConnectionString = globalconfig.connstring;
                try
                {

                    MySQLConn.Open();
                    MySqlCommand comm = new MySqlCommand("CALL Delete_schoolyear(@1)", MySQLConn);
                    comm.Parameters.AddWithValue("1", lvSchoolYear.Text);
                    comm.ExecuteNonQuery();
                    RadMessageBox.Show(this, "The School Year has been successfully Deleted!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                    MySQLConn.Close();
                    lblActiveSchoolYear.Text = globalconfig.schoolyearactive;
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
                finally
                {
                    MySQLConn.Dispose();
                    get_schoolyear_list();
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mtbSchoolYear.MaskCompleted)
            {
                MySqlConnection MySQLConn = new MySqlConnection();
                MySQLConn.ConnectionString = globalconfig.connstring;
                try
                {

                    MySQLConn.Open();
                    MySqlCommand comm = new MySqlCommand("CALL Add_SchoolYear(@1)", MySQLConn);
                    comm.Parameters.AddWithValue("1", mtbSchoolYear.Text);
                    comm.ExecuteNonQuery();
                    RadMessageBox.Show(this, "The School Year has been successfully Changed!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                    MySQLConn.Close();
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
                finally
                {
                    MySQLConn.Dispose();
                }
                get_schoolyear_list();
            }else
            {
                RadMessageBox.Show(this, "Please tye a School Year in a correct Format (YYYY-YYYY)", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            

        }
        public void get_schoolyear()
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL get_active_schoolyear()", MySQLConn);
                MySqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    globalconfig.schoolyearactive = reader.GetString("schoolyear");
                }
                MySQLConn.Close();

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message);
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }
    }
}
