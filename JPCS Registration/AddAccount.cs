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
        DialogResult addYn;
        DialogResult delYn;
        DialogResult updYn;
        public string query;

        public AddAccount()
        {
            InitializeComponent();
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
        }

        private void aa_btn_register_Click(object sender, EventArgs e)
        {

            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = gc.conn;
            MySqlDataReader reader = default(MySqlDataReader);

            string gender,isofficerstat;


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                if ((string.IsNullOrEmpty(aa_tb_studno.Text)) | ((string.IsNullOrEmpty(aa_tb_fname.Text)) | ((string.IsNullOrEmpty(aa_tb_lname.Text)) | ((string.IsNullOrEmpty(aa_tb_address.Text)) | ((string.IsNullOrEmpty(aa_tb_password.Text)) | ((string.IsNullOrEmpty(aa_tb_repass.Text)) | (string.IsNullOrEmpty(aa_tb_username.Text))))))))
                {
                    MessageBox.Show("Please fill all fields");
                } else
                {
                    if (aa_rb_female.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        gender = "Female";
                    } else if (aa_rb_male.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        gender = "Male";
                    }

                    if (aa_rb_yes.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        isofficerstat = "Yes";

                    }else if (aa_rb_no.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        isofficerstat = "No";
                    }

                  


                }





                }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void aa_tb_fname_TextChanged(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = gc.conn;
            MySqlDataReader reader = default(MySqlDataReader);
            try
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
                    RadMessageBox.Show(this, "Student # " + aa_tb_studno.Text + " is already in used!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Dispose();
            }
            
        }
    }
}
