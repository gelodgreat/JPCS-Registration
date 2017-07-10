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
using System.Data.Common;

namespace JPCS_Registration
{

    public partial class Main : Telerik.WinControls.UI.RadForm
    {

        #region local variables

        MySqlConnection conn;
        globalconfig gc = new globalconfig();
        String connstring = globalconfig.connstring;
        public string query;
        int errorCount;

        #endregion

        #region Main
        public Main()
        {
            InitializeComponent();
            AcceptButton = reg_btn_save;
        }
        #endregion

        #region errorProvider Processor
        void SetError(Control c, string message)
        {
            if (message == "")
                errorCount--;
            else
                errorCount++;
            errorProviderEntries.SetError(c, message);
        }
        #endregion

        #region Load
        private void Main_Load(object sender, EventArgs e)
        {
            //get_member_ranks_for_the_slot_number();
            //reg_tb_ornumber.Focus();
            if (globalconfig.Mainaction == "add")
            {
                reg_btn_save.Text = "Register";

            }
            else if (globalconfig.Mainaction == "edit")
            {
                reg_btn_save.Text = "Update";
                aa_tb_studo.Text = globalconfig.selection;
                aa_tb_studo.Enabled = false;
                Edit_pis(globalconfig.selection);


            }
            else
            {
                MessageBox.Show("The System has encountered a fatal error and needs to stop");
                Application.Exit();

            }
        }
        #endregion


        #region reg_btn_save

        private void reg_btn_save_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            ValidateChildren();
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = connstring;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (globalconfig.Mainaction == "add")
            {
                try
                {
                    if (errorCount!=0)
                    {
                        RadMessageBox.Show(this, "Please correct the invalid data.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    }
                    else
                    {

                        conn.Open();
                        query = "CALL Add_member(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13);";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("1", aa_tb_studo.Text);
                        command.Parameters.AddWithValue("2", reg_tb_lname.Text);
                        command.Parameters.AddWithValue("3", reg_tb_fname.Text);
                        command.Parameters.AddWithValue("4", reg_tb_mname.Text);
                        command.Parameters.AddWithValue("5", reg_cb_coursesect.Text);
                        command.Parameters.AddWithValue("6", reg_tb_email.Text);
                        command.Parameters.AddWithValue("7", reg_tb_bday.Text);
                        command.Parameters.AddWithValue("8", reg_tb_nationality.Text);
                        command.Parameters.AddWithValue("9", reg_tb_cityaddress.Text);
                        command.Parameters.AddWithValue("10", reg_tb_provaddress.Text);
                        command.Parameters.AddWithValue("11", reg_tb_contactnum.Text);
                        command.Parameters.AddWithValue("12", reg_tb_emergencycontactname.Text);
                        command.Parameters.AddWithValue("13", reg_tb_emergenctcontactnumber.Text);
                        globalconfig.Logger(PrintQuery(command));

                        command.ExecuteNonQuery();

                        RadMessageBox.Show(this, "Successfully Registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                        aa_tb_studo.Clear();
                        reg_tb_lname.Clear();
                        reg_tb_mname.Clear();
                        reg_tb_fname.Clear();
                        reg_cb_coursesect.SelectedIndex = -1;
                        reg_tb_email.Clear();
                        reg_tb_bday.Value = reg_tb_bday.MinDate;
                        reg_tb_nationality.Clear();
                        reg_tb_cityaddress.Clear();
                        reg_tb_provaddress.Clear();
                        reg_tb_contactnum.Clear();
                        reg_tb_emergencycontactname.Clear();
                        reg_tb_emergenctcontactnumber.Clear();
                        dateTimePicker1.Value = dateTimePicker1.MinDate;
                        //conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Duplicate"))
                    {
                        RadMessageBox.Show(this, "The Student Number you have entered is already registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);

                        #region Log
                        globalconfig.Logger(ex.Message);
                        #endregion

                    }
                    else
                    {
                        RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                }
                finally
                {
                    conn.Dispose();
                }
            }
            else if (globalconfig.Mainaction == "edit")
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("CALL Edit_member(@1, @2, @3, @4, @5, @6 @7, @8, @9, @10, @11, @12, @13);", conn);
                    comm.Parameters.AddWithValue("1", globalconfig.selection);
                    comm.Parameters.AddWithValue("2", reg_tb_lname.Text);
                    comm.Parameters.AddWithValue("3", reg_tb_fname.Text);
                    comm.Parameters.AddWithValue("4", reg_tb_mname.Text);
                    comm.Parameters.AddWithValue("5", reg_cb_coursesect.Text);
                    comm.Parameters.AddWithValue("6", reg_tb_email.Text);
                    comm.Parameters.AddWithValue("7", reg_tb_bday.Text);
                    comm.Parameters.AddWithValue("8", reg_tb_nationality.Text);
                    comm.Parameters.AddWithValue("9", reg_tb_cityaddress.Text);
                    comm.Parameters.AddWithValue("10", reg_tb_provaddress.Text);
                    comm.Parameters.AddWithValue("11", reg_tb_contactnum.Text);
                    comm.Parameters.AddWithValue("12", reg_tb_emergencycontactname.Text);
                    comm.Parameters.AddWithValue("13", reg_tb_emergenctcontactnumber.Text);
                    comm.ExecuteNonQuery();
                    globalconfig.Logger(PrintQuery(command));
                    conn.Close();


                    RadMessageBox.Show(this, "Saved!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);

                    #region Log

                    globalconfig.Logger(ex.Message);

                    #endregion

                }
                finally
                {
                    conn.Dispose();
                }


            }
            else
            {
                RadMessageBox.Show(this, "The System has encountered a fatal error! Please report to the Develpoers immediately.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                
            }
           


        }
        #endregion

        #region dateTimePicker1_ValueChanged
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Focus())
            {
                reg_tb_bday.Value = dateTimePicker1.Value;
                SetError(dateTimePicker1, "");

            }
        }
        #endregion

        #region PrintQuery
        public string PrintQuery(IDbCommand cmd)
        {
            StringBuilder result = new StringBuilder(cmd.CommandText);
            result.Append(System.Environment.NewLine + System.Environment.NewLine + "--Data to be inserted List: ");
            foreach (DbParameter p in cmd.Parameters)
            {
                result.AppendFormat("{0}--({1} —— {2})", System.Environment.NewLine, p.ParameterName, p.Value);
            }
            return result.ToString();

        }
        #endregion

        #region get_coyesec
        public void get_coyesec()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.ConnectionString = connstring;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("CALL show_registered_coyesec();", conn);
                MySqlDataReader reader = comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
        #endregion

        #region Edit_pis
        public void Edit_pis(String studno)
        {
            DateTime birthday;
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = connstring;
            MySqlDataReader reader = default(MySqlDataReader);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.ConnectionString = globalconfig.connstring;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("CALL Get_student_data_for_editing(@1);", conn);
                comm.Parameters.AddWithValue("1", studno);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    reg_tb_lname.Text = reader.GetString("lname");
                    reg_tb_fname.Text = reader.GetString("fname");
                    reg_tb_mname.Text = reader.GetString("mname");
                    reg_cb_coursesect.Text = reader.GetString("courseyearsection");
                    reg_tb_email.Text = reader.GetString("emailaddress");
                    birthday = reader.GetDateTime("birthday");
                    reg_tb_bday.Value = reader.GetDateTime("birthday");
                    reg_tb_nationality.Text = reader.GetString("nationality");
                    reg_tb_cityaddress.Text = reader.GetString("cityaddress");
                    reg_tb_provaddress.Text = reader.GetString("provinceaddress");
                    reg_tb_contactnum.Text = reader.GetString("contactnumber");
                    reg_tb_emergencycontactname.Text = reader.GetString("emergencycontactname");
                    reg_tb_emergenctcontactnumber.Text = reader.GetString("emergencycontactnumber");


                }
                conn.Close();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);

                #region Log
                globalconfig.Logger(ex.Message);
                #endregion


            }
        }
        #endregion

        #region aa_tb_studo events

        private void aa_tb_studo_Validating(object sender, CancelEventArgs e)
        {
            if (!aa_tb_studo.MaskCompleted)
            {
                SetError(aa_tb_studo, "Incorrect / Insufficient Student number");
                Console.WriteLine(errorProviderEntries.ToString());
            }
        }

        private void aa_tb_studo_TextChanged(object sender, EventArgs e)
        {
            SetError(aa_tb_studo, "");
        }


        #endregion

        #region reg_tb_lname events
        private void reg_tb_lname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(reg_tb_lname.Text))
            {
                SetError(reg_tb_lname, "* Last Name is required");
            }
        }

        private void reg_tb_lname_TextChanged(object sender, EventArgs e)
        {
            SetError(reg_tb_lname, "");
        }
        #endregion

        #region reg_tb_fname events
        private void reg_tb_fname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(reg_tb_fname.Text))
            {
                SetError(reg_tb_fname, "* First Name is Required");
            }
        }


        private void reg_tb_fname_TextChanged(object sender, EventArgs e)
     {
            errorProviderEntries.SetError(reg_tb_fname, "");
        }
        #endregion

        #region reg_tb_mname events
        private void reg_tb_mname_Validating(object sender, CancelEventArgs e)
        {
            if ((String.IsNullOrEmpty(reg_tb_mname.Text)))
            {
                SetError(reg_tb_mname, "* Middle Name is required");
            }
        }
        private void reg_tb_mname_TextChanged(object sender, EventArgs e)
        {
            SetError(reg_tb_mname, "");
        }
        #endregion

        #region reg_cb_coursesect events
        private void reg_cb_coursesect_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(reg_cb_coursesect.Text))
            {
                SetError(reg_cb_coursesect, "* Course / Program is required");
            }
        }

        private void reg_cb_coursesect_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            SetError(reg_cb_coursesect, "");
        }
        #endregion

        #region reg_tb_bday events
        private void reg_tb_bday_ValueChanged(object sender, EventArgs e)
        {
            reg_tb_bday.Value = reg_tb_bday.Value;
            SetError(reg_tb_bday, "");
            //reg_tb_bday.Focus();
        }
        private void reg_tb_bday_Validating(object sender, CancelEventArgs e)
        {
            if (reg_tb_bday.Value.ToString("yyyy-MM-dd")=="1970-01-01")
            {
                SetError(dateTimePicker1, "* Please Complete your birthday");
            }
        }
        #endregion

        #region reg_tb_contactum events
        private void reg_tb_contactnum_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(reg_tb_contactnum.Text))
            {
                SetError(reg_tb_contactnum, "* Contact Number is required");
            }
        }

        private void reg_tb_contactnum_TextChanged(object sender, EventArgs e)
        {
            SetError(reg_tb_contactnum, "");
        }

        #endregion

        #region reg_tb_emergencycontactname events
        private void reg_tb_emergencycontactname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(reg_tb_emergencycontactname.Text))
            {
                SetError(reg_tb_emergencycontactname, "* Emergency Contact is required");
            }
        }

        private void reg_tb_emergencycontactname_TextChanged(object sender, EventArgs e)
        {
            SetError(reg_tb_emergencycontactname, "");
        }
        #endregion

        #region reg_tb_emergencycontactnumber events
        private void reg_tb_emergenctcontactnumber_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(reg_tb_emergenctcontactnumber.Text))
            {
                SetError(reg_tb_emergenctcontactnumber, "* Emergency contact number is required");
            }
        }

        private void reg_tb_emergenctcontactnumber_TextChanged(object sender, EventArgs e)
        {
            SetError(reg_tb_emergenctcontactnumber, "");
        }
        #endregion
    }

}
