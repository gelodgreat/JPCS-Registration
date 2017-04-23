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
using System.Runtime.InteropServices;

namespace JPCS_Registration
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {

        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

        MySqlConnection conn;
        globalconfig gc = new globalconfig();
        public string query;
        Main MainForm = new Main();
        OfficersPage op = new OfficersPage();
        string[] args = Environment.GetCommandLineArgs();
        bool constate;
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
                        RadMessageBox.Show("Please fill all fields", "JPCS Registration");
                    }
                    else
                    {
                        conn.Open();
                        query = "SELECT * FROM auth_accounts WHERE studno=@studno OR username=@username AND password=sha2(@password, 512);";
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
                            RadMessageBox.Show("Account not found or not Registered!", "JPCS Registration");
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
                RadMessageBox.Show(ex.Message, "JPCS Registration");
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

        public void checkdbstat()
        {
            conn = new MySqlConnection();
            MySqlCommand command = gc.command;
            try
            {
                if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            constate = false;
            conn.ConnectionString = gc.conn;
            conn.Open();
            constate = true;
            conn.Close();
            }
            catch(Exception ex)
            {
                RadMessageBox.Show("Please correct your connection configuration", "JPCS Registration");
            }
            finally
            {
                conn.Dispose();
                if (constate == true)
                {
                    log_server_status.Text = "Online";
                    log_server_status.ForeColor = Color.Green;
                }
                else
                {
                    log_server_status.Text = "Offline";
                    log_server_status.ForeColor = Color.Red;
                }
            }
        }

        private void radLabel3_Click(object sender, EventArgs e)
        {
            op.Show();
            this.Hide();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Action: Bypass button Clicked.");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
          
            if (!globalconfig.ConsoleIsShown)
            {
                for (int i = 0; i < args.Length; i++)
                {

                    if (args[i] == "ShamWoWDebug")
                    {
                        AllocConsole();
                        Console.WriteLine("Welcome to JPCS Mebership Registration System!");
                        Console.WriteLine("The System has detected a CommandLine Argument \"ShamWoWDebug\". This will lauch the System in Debug mode");
                        Console.WriteLine("Please do not Close this Console Window because it will also close the GUI application");
                        globalconfig.ConsoleIsShown = true;
                    }
                }
            }

            try
            {
                checkdbstat();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "JPCS Registration");
            }
            
        }

        private void log_btn_forgotpass_Click(object sender, EventArgs e)
        {
            ForgotPasswordPage fpp = new ForgotPasswordPage();
            fpp.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void log_btn_settings_Click(object sender, EventArgs e)
        {

            Settings settings = new Settings();
            this.Hide();
            settings.ShowDialog();
          
        }

        private void log_rgb_container_Enter(object sender, EventArgs e)
        {
            AcceptButton = log_btn_login;
        }
    }
}
