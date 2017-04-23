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

    public partial class ForgotPasswordPage : Telerik.WinControls.UI.RadForm
    {

        int userpasstimer = 0;
        MySqlConnection conn;
        globalconfig gc = new globalconfig();
        public string query;
     

        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void ForgotPasswordPage_Load(object sender, EventArgs e)
        {
            this.Size = new Size(424, 156);
        }

        private void fp_tb_userstudno_TextChanged(object sender, EventArgs e)
        {
            fp_timer_studnouser.Start();
        }

        private void fp_timer_studnouser_Tick(object sender, EventArgs e)
        {
           
            userpasstimer++;
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = gc.conn;
            MySqlDataReader reader = default(MySqlDataReader);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                if (userpasstimer == 3)
                {
                    fp_lbl_status.Text = "Checking...";
                    fp_lbl_status.ForeColor = Color.Gold;
                }
                else
                {
                    if (userpasstimer == 25)
                    {
                        conn.Open();
                        query = "SELECT * FROM auth_accounts WHERE studno=@studuser OR username=@studuser";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("studuser", fp_tb_userstudno.Text);
                        reader = command.ExecuteReader();
                        int count = 0;
                        while (reader.Read())
                        {
                            count += 1;
                        }
                        if (count >= 1)
                        {
                            fp_lbl_status.Text = "Account Found";
                            fp_lbl_status.ForeColor = Color.Green;
                            fp_rgb_secmeas.Visible = true;
                            this.Size = new Size(424, 345);
                        }
                        else
                        {
                            fp_lbl_status.Text = "Account doesn't exist";
                            fp_lbl_status.ForeColor = Color.Red;
                            fp_rgb_secmeas.Visible = false;
                            this.Size=new Size(424, 156);
                        }
                        fp_timer_studnouser.Stop();
                        userpasstimer = 0;
                    }
                }
            }
        }

        private void fp_btn_confirm_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = gc.conn;
            MySqlDataReader reader = default(MySqlDataReader);

            if (fp_cb_securityques.SelectedIndex == -1 | (string.IsNullOrEmpty(fp_tb_securityans.Text)))
            {
                RadMessageBox.Show("Please complete the fields!", "JPCS Registration");
            }
            else
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    query = "SELECT * FROM auth_accounts WHERE securityquestion=@securityquestion AND securityanswer=@securityanswer";
                    command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("securityquestion", fp_cb_securityques.Text);
                    command.Parameters.AddWithValue("securityanswer", fp_tb_securityans.Text);
                    reader = command.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count += 1;
                    }
                    if (count >= 1)
                    {
                        fp_rgb_changepass.Visible = true;
                        this.Size = new Size(424, 508);
                    }
                    else
                    {
                        fp_rgb_changepass.Visible = false;
                        RadMessageBox.Show("Wrong Question or Answer!", "JPCS Registration");
                    }
                }
            }
        }

        private void fp_btn_changepass_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            conn.ConnectionString = gc.conn;
            MySqlDataReader reader = default(MySqlDataReader);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                if ((string.IsNullOrEmpty(fp_tb_new_pass.Text)) | (string.IsNullOrEmpty(fp_tb_conf_new_pass.Text))){
                    RadMessageBox.Show("Please fill all fields", "JPCS Registration");
                }
                else
                {
                    if (fp_tb_new_pass.Text != fp_tb_conf_new_pass.Text)
                    {
                        RadMessageBox.Show("Password doesn't match!", "JPCS Registration");
                    }
                    else
                    {
                        conn.Open();
                        query = "UPDATE auth_accounts  SET password=@password WHERE username=@studuser OR studno=@studuser";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("studuser", fp_tb_userstudno.Text);
                        command.Parameters.AddWithValue("password", fp_tb_new_pass.Text);
                        reader = command.ExecuteReader();

                        RadMessageBox.Show(this, "Change Password Succesfully!", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                }
            }
        }
    }
}

