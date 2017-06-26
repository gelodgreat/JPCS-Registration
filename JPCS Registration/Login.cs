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
using System.Data.SqlClient;

namespace JPCS_Registration
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        MySqlConnection conn;
        globalconfig gc = new globalconfig();
        String connstring = globalconfig.connstring;
        public string query;
        ViewMembers vm = new ViewMembers();
        string[] args = Environment.GetCommandLineArgs();
        Parent p = new Parent();
        Settings settings = new Settings();
        bool constate;
        Settings _settings = new Settings();
        Boolean SettingsFormStatus = false;
        public Login()
        {
            InitializeComponent();
        }
        void SettigsWindow()
        {
            _settings.ShowDialog();
        }
        void CheckForm() 
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Settings")
                    SettingsFormStatus = true;
            }

        }
        void dbStatus()
        {
            Boolean stat = false;
            stat = checkdbstat();
            if (stat == false)
            {

                RadMessageBox.Show(this, "Unable to connect to MySQL database. Please fix your configuration.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                SettigsWindow();
            }
        }
        private void log_btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection();

                conn.ConnectionString = globalconfig.connstring;
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
                        //query = "SELECT * FROM auth_accounts WHERE studno=@studno OR username=@username AND password=sha2(@password, 512);";
                        query = "CALL login(@1, @2);";
                        
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("1", log_tb_username.Text);
                        command.Parameters.AddWithValue("2", log_tb_password.Text);
                        reader = command.ExecuteReader();
                        String fullname = "";
                        int count = 0;
                        while (reader.Read())
                        {
                            count += 1;
                            fullname = reader.GetString("fname")+ " " + reader.GetString("lname");
                        }

                        if (count >= 1)
                        {
                            log_tb_password.Clear();
                            log_tb_username.Clear();
                            log_tb_username.Focus();

                            globalconfig.isAuthenticated = true;
                            globalconfig.fullname = fullname;
                            this.Hide();
                            p.Show();
                            
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
            globalconfig.isAuthenticated = false;
            globalconfig.fullname = "Guest Mode";
            p.Show();
            this.Hide();

        }
        private void radLabel3_Click(object sender, EventArgs e)
        {
            //op.Show();
            //this.Hide();
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("Action: Bypass button Clicked.");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";

            Boolean check = checkdbstat();
            if (check == false)
            {
                RadMessageBox.Show(this, "Unable to connect to MySQL database. Please fix your configuration.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Info);
                log_server_status.Text = "Offline";
                log_server_status.ForeColor = Color.Red;
                SettigsWindow();
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

            SettigsWindow();
          
        }

        private void log_rgb_container_Enter(object sender, EventArgs e)
        {
            AcceptButton = log_btn_login;
        }
        public Boolean checkdbstat()
        {
            Boolean loopstopper = false;
            conn = new MySqlConnection();
            conn.ConnectionString = globalconfig.connstring;

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                constate = false;
                loopstopper = false;
                conn.Open();
                constate = true;
                loopstopper = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                loopstopper = false;
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
            return loopstopper;
        }

        private void log_tb_username_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("Fire!");
            if (SettingsFormStatus == true)
            {
                return;
            }
            else
            {
                dbStatus();
            }
        }

        private void log_btn_settings_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("Fire!");
            if (SettingsFormStatus == true)
            {
                return;
            }
            else
            {
                dbStatus();
            }
        }
    }
}
