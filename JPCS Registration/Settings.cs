using System;
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
        Login log = new Login();
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
                    RadMessageBox.Show("Succesfully Saved!", "JPCS Registration");
                }
            }
        }

        private void Settings_Enter(object sender, EventArgs e)
        {
            AcceptButton = set_btn_save;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            log.ShowDialog();
        }
    }
}
