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
using System.Net.NetworkInformation;

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


        String connstring = globalconfig.connstring;
        globalconfig gc = new globalconfig();
        MySqlCommand comm = new MySqlCommand();
        String[] args = Environment.GetCommandLineArgs();
        public Parent()
        {
            InitializeComponent();

        }

        private void Parent_Load(object sender, EventArgs e)
        {

            get_schoolyear();
            GetActiveEvent(globalconfig.schoolyearactive);

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
                catch //(InvalidCastException ex)
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
            radLabelMode.Text = globalconfig.fullname;
            radLabelServer.Text = "Server: " + Properties.Settings.Default.db_server;
            radLabelEvent.Text = "Event: " + globalconfig.eventName;
            check_connection_type();

        }

        private void MemberAdd_Click(object sender, EventArgs e)
        {
            globalconfig.Mainaction = "add";
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
            }
            else
            {
                RadMessageBox.Show(this, "Elevated mode is required to access Member Management. To enter elevated mode, close the Main Window and enter your correct account credentials. ", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        public void get_schoolyear()
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySQLConn.ConnectionString = globalconfig.connstring;
            try
            {
                MySQLConn.Open();
                MySqlCommand comm = new MySqlCommand("CALL get_active_schoolyear()", MySQLConn);
                MySqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    globalconfig.schoolyearactive = reader.GetString("schoolyear");
                }
                MySQLConn.Close();

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(this, ex.Message);
            }
            finally
            {
                MySQLConn.Dispose();
            }
        }
        #region GetActiveEvent

        public void GetActiveEvent(String schoolyear)
        {
            MySqlConnection MySQLConn = new MySqlConnection();
            MySqlCommand comm;
            MySqlDataReader reader;

            MySQLConn.ConnectionString = globalconfig.connstring;

            try
            {
                MySQLConn.Open();
                comm = new MySqlCommand("CALL get_active_event(@1);", MySQLConn);
                comm.Parameters.AddWithValue("1", schoolyear);
                reader = comm.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    globalconfig.eventID = reader.GetInt32("eventId");
                    globalconfig.eventName = reader.GetString("eventname");
                    globalconfig.eventDate = reader.GetString("eventdate");
                    globalconfig.eventTime= reader.GetString("eventTimeFrom")+" to "+reader.GetString("eventTimeTo");
                    count++;
                }
                MySQLConn.Close();
            }
            catch
            {
                RadMessageBox.Show(this, "A fatal error occured. Please report this error to the Developers immediately", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #endregion

        private void MemberRenew_Click(object sender, EventArgs e)
        {


            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();

            }
            foreach (Form f in Application.OpenForms)
            {
                if (f is Renewal)
                {
                    f.Dispose();
                    return;
                }
            }
            Renewal ren = new Renewal();
            ren.MdiParent = this;
            ren.Show();
        }

        private void Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.Show();

        }

        private void radMenuSchoolYear_Click(object sender, EventArgs e)
        {
            if (globalconfig.isAuthenticated)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();

                }
                foreach (Form f in Application.OpenForms)
                {
                    if (f is SchoolYearManagement)
                    {
                        f.Dispose();
                        return;
                    }
                }

                SchoolYearManagement symgmt = new SchoolYearManagement();
                symgmt.MdiParent = this;
                symgmt.Show();
            }
            else
            {
                RadMessageBox.Show(this, "Elevated mode is required to access Member Management. To enter elevated mode, close the Main Window and enter your correct account credentials. ", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void radMenuManageAccount_Click(object sender, EventArgs e)
        {
            if (globalconfig.isAuthenticated)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();

                }
                foreach (Form f in Application.OpenForms)
                {
                    if (f is AddAccount)
                    {
                        f.Dispose();
                        return;
                    }
                }

                AddAccount acctmgmt = new AddAccount();
                acctmgmt.MdiParent = this;
                acctmgmt.Show();
            }
            else
            {
                RadMessageBox.Show(this, "Elevated mode is required to access Member Management. To enter elevated mode, close the Main Window and enter your correct account credentials. ", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        public void check_connection_type()
        {
           
            List<String> Locals = new List<String>();


            foreach (NetworkInterface nics in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nics.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in nics.GetIPProperties().UnicastAddresses)
                    {
                        Locals.Add(ip.Address.ToString());
                    }
                }
                Locals.Add("localhost");
                Locals.Add(Environment.MachineName);
            }
            if (Locals.Contains(Properties.Settings.Default.db_server))
            {
                
                radLabelServer.Text = radLabelServer.Text + "(Local)";
            }
            else
            {
               
                radLabelServer.Text = radLabelServer.Text + "(Remote)";
            }
        }

        private void radLabelServer_Click(object sender, EventArgs e)
        {

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();

            }
            foreach (Form f in Application.OpenForms)
            {
                if (f is AddAccount)
                {
                    f.Dispose();
                    return;
                }
            }

            DatabaseConnection DBConn = new DatabaseConnection();
            DBConn.MdiParent = this;
            DBConn.Show();
        }

        private void ParticipantAdd_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();

            }
            foreach (Form f in Application.OpenForms)
            {
                if (f is EventRegistration)
                {
                    f.Dispose();
                    return;
                }
            }

            if (String.IsNullOrEmpty(globalconfig.eventName))
            {
                RadMessageBox.Show(this, "There is no active event. To activate an event, go to Events Mangement.", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }else
            {
                EventRegistration eventReg = new EventRegistration();
                eventReg.MdiParent = this;
                eventReg.Show();
            }            
        }

        private void EventManage_Click(object sender, EventArgs e)
        {
            if (globalconfig.isAuthenticated)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();

                }
                foreach (Form f in Application.OpenForms)
                {
                    if (f is EventManagement)
                    {
                        f.Dispose();
                        return;
                    }
                }

                EventManagement eventmgmt = new EventManagement();
                eventmgmt.MdiParent = this;
                eventmgmt.Show();
            }
            else
            {
                RadMessageBox.Show(this, "Elevated mode is required to access Member Management. To enter elevated mode, close the Main Window and enter your correct account credentials. ", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
