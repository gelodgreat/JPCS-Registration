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
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        MySqlConnection conn;
        globalconfig gc = new globalconfig();
        public string query;
        Main MainForm = new Main();
        OfficersPage op = new OfficersPage();
        public Login()
        {
            InitializeComponent();
        }

        private void log_btn_login_Click(object sender, EventArgs e)
        {


            try
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
                    if ((string.IsNullOrEmpty(log_tb_username.Text)) | (string.IsNullOrEmpty(log_tb_password.Text)))
                    {
                        MessageBox.Show("Please fill all fields");
                    }
                    else
                    {
                        conn.Open();
                        query = "SELECT * FROM auth_accounts WHERE studno=@studno OR username=@username AND password=@password";
                        command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("studno", log_tb_username.Text);
                        command.Parameters.AddWithValue("username", log_tb_username.Text);
                        command.Parameters.AddWithValue("password", log_tb_password.Text);
                        reader = command.ExecuteReader();
                        int count = 0;
                        while (reader.Read())
                        {
                            count += 1;
                        }

                        if (count >= 1)
                        {
                            log_tb_password.Clear();
                            log_tb_username.Clear();
                            log_tb_username.Focus();


                            op.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Account not found or not Registered!");
                            log_tb_password.Clear();
                            log_tb_username.Clear();
                            log_tb_username.Focus();
                        }
                        conn.Close();
                    }
                }
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

        private void log_btn_main_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            this.Hide();
        }

        private void radLabel3_Click(object sender, EventArgs e)
        {
            op.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
        }

        private void log_btn_forgotpass_Click(object sender, EventArgs e)
        {
            ForgotPasswordPage fpp = new ForgotPasswordPage();
            fpp.ShowDialog();
        }
    }
}
