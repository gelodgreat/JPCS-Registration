using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using MySql.Data.MySqlClient;

namespace JPCS_Registration
{
    public partial class OfficersPage : Telerik.WinControls.UI.RadForm
    {
        Main main = new Main();
        globalconfig gc = new globalconfig();
        MySqlConnection conn;
        public string query;
        public OfficersPage()
        {
            InitializeComponent();
        }

        private void load_sections()
        {
            op_cb_combosections.Items.Clear();
            //main.courses();
            foreach (string courses in main.course_section)
            {
           
                op_cb_combosections.Items.Add(courses);
            }
        }

        private void OfficersPage_Load(object sender, EventArgs e)
        {
            load_sections();
            load_records();
          
        }

        public void load_records()
        {
            conn = new MySqlConnection();
            
            MySqlCommand command = new MySqlCommand();
            conn.ConnectionString = globalconfig.connstring;
            MySqlDataReader reader = default(MySqlDataReader);
            DataTable dbdataset = new DataTable();
            BindingSource bsource = new BindingSource();
            MySqlDataAdapter sda = new MySqlDataAdapter();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                query = "SELECT ornumber AS 'OR Number', studno AS 'Student Number', lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', courseyearsection AS 'Course, Year and Section', emailaddress AS 'E-mail Address', birthday AS 'Birthday', nationality AS 'Nationality', cityaddress AS 'City Address', provinceaddress AS 'Province Address', contactnumber AS 'Contact Number', emergencycontactname 'Emergency Contact Name', emergencycontactnumber AS 'Emergency Contact Number' FROM memberlist;";
                command = new MySqlCommand(query, conn);
                sda.SelectCommand = command;
                sda.Fill(dbdataset);
                bsource.DataSource = dbdataset;
                rgv_registeredmembers.DataSource = bsource;
                sda.Update(dbdataset);
                conn.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "JPCS Registration");
            }
            finally
            {
                conn.Dispose();
            }

        }

        private void op_rb_bsit_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            controlfiltercourse();
        }

        private void op_rb_bscs_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            controlfiltercourse();
        }

        private void op_rb_bscpe_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            controlfiltercourse();
        }

        private void op_btn_clearselection_Click(object sender, EventArgs e)
        {
            op_rb_bsit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            op_rb_bscs.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            op_rb_bscpe.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            load_records();
        }

        private void controlfiltercourse()
        {
            conn = new MySqlConnection();

            MySqlCommand command = new MySqlCommand();
            conn.ConnectionString = globalconfig.connstring;
            MySqlDataReader reader = default(MySqlDataReader);
            DataTable dbdataset = new DataTable();
            BindingSource bsource = new BindingSource();
            MySqlDataAdapter sda = new MySqlDataAdapter();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {

                conn.Open();
                query = "SELECT ornumber AS 'OR Number', studno AS 'Student Number', lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', courseyearsection AS 'Course, Year and Section', emailaddress AS 'E-mail Address', birthday AS 'Birthday', nationality AS 'Nationality', cityaddress AS 'City Address', provinceaddress AS 'Province Address', contactnumber AS 'Contact Number', emergencycontactname 'Emergency Contact Name', emergencycontactnumber AS 'Emergency Contact Number' FROM memberlist;";
                command = new MySqlCommand(query, conn);
                sda.SelectCommand = command;
                sda.Fill(dbdataset);
                bsource.DataSource = dbdataset;
                rgv_registeredmembers.DataSource = bsource;
                sda.Update(dbdataset);
                conn.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "JPCS Registration");
            }
            finally
            {
                conn.Dispose();
            }

            if (op_rb_bsit.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                if (rgv_registeredmembers.Rows.Count == 0)
                {
                    RadMessageBox.Show("Data is empty","JPCS Registration");
                }
                else
                {
                    string bsit = "BSIT";
                    DataView DV = new DataView(dbdataset);
                    DV.RowFilter = string.Format("Course Like '%{0}%'", bsit);
                    rgv_registeredmembers.DataSource = DV;
                }
            }
            else if (op_rb_bscs.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                if (rgv_registeredmembers.Rows.Count == 0)
                {
                    RadMessageBox.Show("Data is empty","JPCS Registration");
                }
                else
                {
                    string bscs = "BSCS";
                    DataView DV = new DataView(dbdataset);
                    DV.RowFilter = string.Format("Course Like '%{0}%'", bscs);
                    rgv_registeredmembers.DataSource = DV;
                }
            }
            else
            {
                if (rgv_registeredmembers.Rows.Count == 0)
                {
                    RadMessageBox.Show("Data is empty","JPCS Registration");
                }
                else
                {
                    string bscpe = "BSCPE";
                    DataView DV = new DataView(dbdataset);
                    DV.RowFilter = string.Format("Course Like '%{0}%'", bscpe);
                    rgv_registeredmembers.DataSource = DV;
                }
            }

        }

        private void op_cb_combosections_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            conn = new MySqlConnection();

            MySqlCommand command = new MySqlCommand();
            conn.ConnectionString = globalconfig.connstring;
            MySqlDataReader reader = default(MySqlDataReader);
            DataTable dbdataset = new DataTable();
            BindingSource bsource = new BindingSource();
            MySqlDataAdapter sda = new MySqlDataAdapter();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {

                conn.Open();
                query = "SELECT ornumber AS 'OR Number', studno AS 'Student Number', lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', courseyearsection AS 'Course, Year and Section', emailaddress AS 'E-mail Address', birthday AS 'Birthday', nationality AS 'Nationality', cityaddress AS 'City Address', provinceaddress AS 'Province Address', contactnumber AS 'Contact Number', emergencycontactname 'Emergency Contact Name', emergencycontactnumber AS 'Emergency Contact Number' FROM memberlist;";
                command = new MySqlCommand(query, conn);
                sda.SelectCommand = command;
                sda.Fill(dbdataset);
                bsource.DataSource = dbdataset;
                rgv_registeredmembers.DataSource = bsource;
                sda.Update(dbdataset);
                conn.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message,"JPCS Registration");
            }
            finally
            {
                conn.Dispose();
            }
            if (rgv_registeredmembers.Rows.Count == 0)
            {
                RadMessageBox.Show("Data is empty","JPCS Registration");
            }
            else
            {
                DataView DV = new DataView(dbdataset);
                DV.RowFilter = string.Format("Course Like '%{0}%'", op_cb_combosections.Text);
                rgv_registeredmembers.DataSource = DV;
            }
            

        }

        private void op_btn_add_account_Click(object sender, EventArgs e)
        {
            AddAccount ac = new AddAccount();
            ac.ShowDialog();
          
        }

        private void OfficersPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Dispose();
        }

    }
}
