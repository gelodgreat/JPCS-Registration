﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace JPCS_Registration
{
    public partial class Settings : Telerik.WinControls.UI.RadForm
    {
        //Login log = new Login();
        public Settings()
        {
            InitializeComponent();
        }

        private void set_btn_save_Click(object sender, EventArgs e)
        {
            savesettings();
        }

        private void savesettings()
        {
            
            string jpreg;
            DialogResult save;
            jpreg = "jpcsregistration";

            if (string.IsNullOrEmpty(set_tb_server.Text) | string.IsNullOrEmpty(set_tb_port.Text) | string.IsNullOrEmpty(set_tb_username.Text) | string.IsNullOrEmpty(set_tb_password.Text))
            {
                MessageBox.Show("Please complete all fields");
            } 
            else
            {
                save = RadMessageBox.Show("Do you want to save?", "JPCS Registration", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (save == DialogResult.Yes)
                {
                    Properties.Settings.Default.db_server = set_tb_server.Text;
                    Properties.Settings.Default.db_database = jpreg;
                    Properties.Settings.Default.db_port = set_tb_port.Text;
                    Properties.Settings.Default.db_username = set_tb_username.Text;
                    Properties.Settings.Default.db_password = set_tb_password.Text;
                    Properties.Settings.Default.Save();

                    String server = Properties.Settings.Default.db_server;
                    String username = Properties.Settings.Default.db_username;
                    String port = Properties.Settings.Default.db_port;
                    String password = Properties.Settings.Default.db_password;
                    String database = Properties.Settings.Default.db_database;


                    globalconfig.connstring = "server=" + server + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database + ";";
                    RadMessageBox.Show("Succesfully Saved!", "JPCS Registration");
                    this.Dispose();
                    Login log = new Login();
                    log.Show();
                }
            }
        }

        private void Settings_Enter(object sender, EventArgs e)
        {
            AcceptButton = set_btn_save;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login log = new Login();
            this.Dispose();
            log.Show();
        }

        private void set_tb_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar));
        }

        private void set_tb_port_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (set_tb_port.Text.Length > 0)
                {
                    set_tb_port.Text = set_tb_port.Text.Substring(0, set_tb_port.Text.Length - 1);
                    set_tb_port.Select(set_tb_port.Text.Length, 0);
                }

            }
        }
    }
}
