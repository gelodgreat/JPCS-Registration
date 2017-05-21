using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using MySql.Data.MySqlClient;
using Telerik.WinControls.UI;

namespace JPCS_Registration
{
    public partial class AddAccount : Telerik.WinControls.UI.RadForm
    {
        MySqlConnection conn;
        globalconfig gc = new globalconfig();
        public string query;
        DialogResult addYn;
        DialogResult delYn;
        DialogResult updYn;
        string gender;
        string isofficerstat;
        int timerusername = 0;
        int studnotimeer = 0;
        string storeusername, storestudno;

        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            load_registered_auth_accounts();
            aa_lbl_studnostat.ForeColor = Color.Gold;
            aa_lbl_usernamestat.ForeColor = Color.Gold;
        }

        private void load_registered_auth_accounts()
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
                query = "CALL GET_Accounts();";
                command = new MySqlCommand(query, conn);
                sda.SelectCommand = command;
                sda.Fill(dbdataset);
                bsource.DataSource = dbdataset;
                rgv_registeredaccounts.DataSource = bsource;
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

        private void aa_btn_clear_Click(object sender, EventArgs e)
        {
            aa_tb_studno.Clear();
            aa_tb_fname.Clear();
            aa_tb_lname.Clear();
            aa_rb_male.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            aa_rb_female.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            aa_rb_yes.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            aa_rb_no.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            aa_tb_address.Clear();
            aa_tb_username.Clear();
            aa_tb_password.Clear();
            aa_tb_repass.Clear();
            aa_tb_studno.Focus();
            aa_lbl_usernamestat.Text = "Status";
            aa_lbl_studnostat.Text = "Status";
            aa_lbl_studnostat.ForeColor = Color.Gold;
            aa_lbl_usernamestat.ForeColor = Color.Gold;
        }

        private void aa_btn_register_Click(object sender, EventArgs e)
        {

            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = globalconfig.connstring;
            MySqlDataReader reader = default(MySqlDataReader);
            try
            {
                if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

                if ((string.IsNullOrEmpty(aa_tb_studno.Text)) | (string.IsNullOrEmpty(aa_tb_fname.Text)) | (string.IsNullOrEmpty(aa_tb_lname.Text)) | (string.IsNullOrEmpty(aa_tb_address.Text)) | (string.IsNullOrEmpty(aa_tb_password.Text)) | (string.IsNullOrEmpty(aa_tb_repass.Text)) | (aa_cb_security_ques.SelectedIndex ==-1) | (string.IsNullOrEmpty(aa_tb_security_ans.Text)) |(string.IsNullOrEmpty(aa_tb_username.Text)))
                {
                    RadMessageBox.Show("Please fill all fields", "JPCS Registration");
                }
                else
                {

                    if (aa_lbl_studnostat.Text == "Not Available" | aa_lbl_usernamestat.Text == "Not Available")
                    {
                        RadMessageBox.Show("Please check either your username or your student number!", "JPCS Registration");
                    }
                    else
                    {
                        if (aa_tb_password.Text != aa_tb_repass.Text)
                        {
                            RadMessageBox.Show("Password doesn't match!", "JPCS Registration");
                        }
                        else
                        {
                          
                            addYn = RadMessageBox.Show(this, "Are you sure you want to register?", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                            if (addYn == DialogResult.Yes)
                            {
                                conn.Open();

                                query = "CALL AddAccount(@studno, @fname, @lname, @gender, @isofficer, @address, @username, @password, @securityquestion, @securityanswer";
                                command = new MySqlCommand(query, conn);
                                command.Parameters.AddWithValue("studno", aa_tb_studno.Text);
                                command.Parameters.AddWithValue("fname", aa_tb_fname.Text);
                                command.Parameters.AddWithValue("lname", aa_tb_lname.Text);
                                command.Parameters.AddWithValue("gender", gender);
                                command.Parameters.AddWithValue("isofficer", isofficerstat);
                                command.Parameters.AddWithValue("address", aa_tb_address.Text);
                                command.Parameters.AddWithValue("username", aa_tb_username.Text);
                                command.Parameters.AddWithValue("password", aa_tb_password.Text);
                                command.Parameters.AddWithValue("securityquestion", aa_cb_security_ques.Text);
                                command.Parameters.AddWithValue("securityanswer", aa_tb_security_ans.Text);
                                reader = command.ExecuteReader();

                                RadMessageBox.Show(this, "Successfully Registered!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                                conn.Close();
                                load_registered_auth_accounts();
                            }
                        }
                    }
                }
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


        private void aa_timer_studno_Tick(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = globalconfig.connstring;
            MySqlDataReader reader = default(MySqlDataReader);

            try
            {
                studnotimeer++;

                if (studnotimeer == 20)
                {
                    conn.Open();
                    query = "SELECT * FROM auth_accounts WHERE studno=@studno";
                    command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("studno", aa_tb_studno.Text);
                    reader = command.ExecuteReader();
                    int count = 0;

                    while (reader.Read())
                    {
                        count += 1;
                    }

                    if (count >= 1)
                    {
                        RadMessageBox.Show(this, "Student # " + aa_tb_studno.Text + " is already in used!", "JPCS Registration", MessageBoxButtons.OK,
                            RadMessageIcon.Error);
                        aa_lbl_studnostat.ForeColor = Color.Red;
                        aa_lbl_studnostat.Text = "Not Available";
                        aa_tb_studno.Clear();
                        aa_tb_studno.Focus();
                     
                    }
                    else
                    {
                        aa_lbl_studnostat.ForeColor = Color.Green;
                        aa_lbl_studnostat.Text = "Available";
                    }
                    aa_timer_studno.Stop();
                    studnotimeer = 0;
                }
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

        private void aa_timer_username_Tick(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = globalconfig.connstring;
            MySqlDataReader reader = default(MySqlDataReader);

            try
            {
                timerusername++;

                if (timerusername == 20)
                {
                    conn.Open();
                    query = "SELECT * FROM auth_accounts WHERE username=@username";
                    command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("username", aa_tb_username.Text);
                    reader = command.ExecuteReader();
                    int count = 0;

                    while (reader.Read())
                    {
                        count += 1;
                    }

                    if (count >= 1)
                    {
                        RadMessageBox.Show(this, "Username " + aa_tb_username.Text + " is already in used!", "JPCS Registration", MessageBoxButtons.OK,
                            RadMessageIcon.Error);
                        aa_lbl_usernamestat.ForeColor = Color.Red;
                        aa_lbl_usernamestat.Text = "Not Available";
                        aa_tb_username.Clear();
                        aa_tb_username.Focus();
                     } 
                    else
                    {
                        aa_lbl_usernamestat.ForeColor = Color.Green;
                        aa_lbl_usernamestat.Text = "Available";
                    }
                    aa_timer_username.Stop();
                    timerusername = 0;
                }
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


        private void aa_rb_male_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            gender = "Male";
            lbltestgen.Text = gender;   
        }

        private void aa_rb_female_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            gender = "Female";
            lbltestgen.Text = gender;

        }

        private void aa_rb_yes_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            isofficerstat = "Yes";
            lbltestisjp.Text = isofficerstat;
        }

        private void aa_rb_no_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            isofficerstat = "No";
            lbltestisjp.Text = isofficerstat;
        }

        private void aa_tb_username_TextChanged(object sender, EventArgs e)
        {
            aa_timer_username.Start();
        }

        private void aa_tb_studno_TextChanged(object sender, EventArgs e)
        {
                aa_timer_studno.Start();
        }

        private void rgv_registeredaccounts_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = globalconfig.connstring;
            MySqlDataReader reader = default(MySqlDataReader);
            try
            {
                if (e.RowIndex >= 0)
                {
                    Telerik.WinControls.UI.GridViewRowInfo row = this.rgv_registeredaccounts.Rows[e.RowIndex];
                    row = this.rgv_registeredaccounts.Rows[e.RowIndex];
                    storestudno = row.Cells["Student #"].Value.ToString();

                    delYn = RadMessageBox.Show(this, "Are you sure you want to delete this selected account?", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                    if (delYn == DialogResult.Yes)
                    {
                        conn.Open();

                        query = "DELETE FROM auth_accounts WHERE studno=@studno";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("studno", storestudno);
                        reader = command.ExecuteReader();

                        RadMessageBox.Show(this, "Successfully Deleted!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                        conn.Close();
                        load_registered_auth_accounts();
                    }
                }
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
    }
}
