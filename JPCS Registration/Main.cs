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
        public string[] quote_entry = new string[20];
        public string[] course_section = new string[13];
        MySqlConnection conn;
        globalconfig gc = new globalconfig();
        String connstring = globalconfig.connstring;
        DialogResult addYn;
        public string query;
        Boolean bdayValue = false;


        public Main()
        {
            InitializeComponent();
            AcceptButton = reg_btn_save;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            //get_member_ranks_for_the_slot_number();
            //reg_tb_ornumber.Focus();
            if (globalconfig.Mainaction == "add")
            {
                reg_btn_save.Text = "Register";

            } else if (globalconfig.Mainaction == "edit")
            {
                reg_btn_save.Text = "Update";
                aa_tb_studo.Text = globalconfig.selection;
                aa_tb_studo.Enabled = false;
                Edit_pis(globalconfig.selection);


            }else
            {
                MessageBox.Show("The System has encountered a fatal error and needs to stop");
                Application.Exit();
            }
        }


        private void reg_btn_save_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = connstring;
            MySqlDataReader reader = default(MySqlDataReader);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            if (globalconfig.Mainaction == "add")
            {
                try
                {
                    if (!aa_tb_studo.MaskCompleted)
                    {
                        RadMessageBox.Show(this, "Please enter the correct format for the Student Number!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    if ((string.IsNullOrEmpty(reg_tb_lname.Text)) | ((string.IsNullOrEmpty(reg_tb_fname.Text)) | ((string.IsNullOrEmpty(reg_tb_mname.Text)) | (string.IsNullOrEmpty(reg_cb_coursesect.Text)) | ((string.IsNullOrEmpty(reg_tb_cityaddress.Text)) | ((string.IsNullOrEmpty(reg_tb_contactnum.Text)) | ((string.IsNullOrEmpty(reg_tb_emergencycontactname.Text)) | ((string.IsNullOrEmpty(reg_tb_emergenctcontactnumber.Text)) | (!aa_tb_studo.MaskCompleted) | (reg_tb_bday.Text.Length == 0))))))))
                    {
                        RadMessageBox.Show(this, "Please fill-up all fileds Properly!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);

                    }
                    else
                    {

                        conn.Open();
                        //query = "INSERT INTO memberlist VALUES (@studno, @lname, @fname, @mname, @section, @emailaddress, @birthday, @nationality, @cityaddress, @provinceaddress, @contactnumber, @emergencycontactname, @emergencycontactnumber);";
                        query = "CALL addmember(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13);";
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
                        reg_tb_bday.ResetText();
                        reg_tb_nationality.Clear();
                        reg_tb_cityaddress.Clear();
                        reg_tb_provaddress.Clear();
                        reg_tb_contactnum.Clear();
                        reg_tb_emergencycontactname.Clear();
                        reg_tb_emergenctcontactnumber.Clear();
                        reg_tb_bday.ResetText();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Duplicate"))
                    {
                        RadMessageBox.Show(this, "The Student Number you have entered is already registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
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
            }else if (globalconfig.Mainaction=="edit")
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("CALL Editmember(@studno, @lname, @fname, @mname, @coyesec, @email, @birthday, @nationality, @cityaddress, @provaddress, @contactnum, @emergencycontactname, @emergencycontactnum);", conn);
                    comm.Parameters.AddWithValue("studno", globalconfig.selection);
                    comm.Parameters.AddWithValue("lname", reg_tb_lname.Text);
                    comm.Parameters.AddWithValue("fname", reg_tb_fname.Text);
                    comm.Parameters.AddWithValue("mname", reg_tb_mname.Text);
                    comm.Parameters.AddWithValue("coyesec", reg_cb_coursesect.Text);
                    comm.Parameters.AddWithValue("email", reg_tb_email.Text);
                    comm.Parameters.AddWithValue("birthday", reg_tb_bday.Text);
                    comm.Parameters.AddWithValue("nationality", reg_tb_nationality.Text);
                    comm.Parameters.AddWithValue("cityaddress", reg_tb_cityaddress.Text);
                    comm.Parameters.AddWithValue("provaddress", reg_tb_provaddress.Text);
                    comm.Parameters.AddWithValue("contactnum", reg_tb_contactnum.Text);
                    comm.Parameters.AddWithValue("emergencycontactname", reg_tb_emergencycontactname.Text);
                    comm.Parameters.AddWithValue("emergencycontactnum", reg_tb_emergenctcontactnumber.Text);
                    comm.ExecuteNonQuery();
                    conn.Close();


                    RadMessageBox.Show(this, "Saved!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                    this.Dispose();
                }catch (Exception ex)
                {
                    RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                }finally
                {
                    conn.Dispose();
                }


            }else
            {
                RadMessageBox.Show(this, "The System has encountered a fatal error! Please report to the Develpoers immediately.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            

        }
        int i = 0;
        private void timersec_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 100)
            {
                timersec.Stop();
                reg_cb_coursesect.DropDownStyle = RadDropDownStyle.DropDownList;
                i = 0;
            }
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Focus())
            {
                reg_tb_bday.Value = dateTimePicker1.Value;

            }
        }

        private void reg_tb_bday_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = reg_tb_bday.Value;
            //reg_tb_bday.Focus();
        }

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
        public void get_coyesec()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.ConnectionString = connstring;
            try { 
                conn.Open();
            MySqlCommand comm = new MySqlCommand("CALL show_registered_coyesec();", conn);
                MySqlDataReader reader = comm.ExecuteReader();

            } catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message, "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
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
                MySqlCommand comm = new MySqlCommand("CALL Get_student_data_for_editing(@studno);", conn);
                comm.Parameters.AddWithValue("studno", studno);
                reader=comm.ExecuteReader();
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
            }
        }
    }
}
