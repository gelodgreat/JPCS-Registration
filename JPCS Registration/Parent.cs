﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using MySql.Data.MySqlClient;

namespace JPCS_Registration
{
    public partial class Parent : Telerik.WinControls.UI.RadForm
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();
        MdiClient ctlMDI;
        //Main register = new Main();
        Settings settings = new Settings();
        globalconfig gc = new globalconfig();
        MySqlConnection conn;
        MySqlCommand comm = new MySqlCommand();
        Boolean constate = false;
        String[] args = Environment.GetCommandLineArgs();
        public Parent()
        {
            InitializeComponent();

        }

        private void Parent_Load(object sender, EventArgs e)
        {
            
            get_schoolyear();

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            if (!globalconfig.ConsoleIsShown)
            {
                for (int i = 0; i < args.Length; i++)
                {

                    if (args[i] == "ShamWoWDebug")
                    {
                        AllocConsole();
                        globalconfig.Logger("Welcome to JPCS Mebership Registration System!");
                        globalconfig.Logger("The System has detected a CommandLine Argument \"ShamWoWDebug\". This will lauch the System in Debug mode");
                        globalconfig.Logger("Please do not Close this Console Window because it will also close the GUI application");
                        globalconfig.ConsoleIsShown = true;
                    }
                }
            }
            lbl_User.Text = globalconfig.fullname;

        }

        private void MemberAdd_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();

            }
            foreach (Form f in Application.OpenForms)
            {
                if (f is Main)
                {
                    f.Dispose();
                    return;
                }
            }

            Main register = new Main();
            register.MdiParent = this;
            register.Show();
        }
        
        private void MemberManage_Click(object sender, EventArgs e)
        {
            if (globalconfig.isAuthenticated)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();

                }
                foreach (Form f in Application.OpenForms)
                {
                    if (f is ViewMembers)
                    {
                        f.Dispose();
                        return;
                    }
                }

                ViewMembers vm = new ViewMembers();
                vm.MdiParent = this;
                vm.Show();
            }else
            {
                RadMessageBox.Show(this, "Elevated mode is required to access Member Management. To enter elevated mode, close the Main Window and enter your correct account credentials. ", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        public void get_schoolyear()
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = gc.conn;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT schoolyear FROM `schoolyear` WHERE isActive=1", MySQLConn);
                MySqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    globalconfig.schoolyearactive = reader.GetString("schoolyear");
                }
                MySQLConn.Close();
                
            }catch (Exception ex)
            {

            }
        }

        private void MemberRenew_Click(object sender, EventArgs e)
        {

        }

        private void Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.Show();

        }
        // Display a child form to show this is still an MDI application.
        //Form2 frm = new Form2();
        //frm.MdiParent = this;
        //frm.Show();
    }
}
