using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Net.NetworkInformation;

namespace JPCS_Registration
{
    public partial class DatabaseConnection : Telerik.WinControls.UI.RadForm
    {


        String LocalNames;
        public DatabaseConnection()
        {
            InitializeComponent();
        }

        private void DatabaseConnection_Load(object sender, EventArgs e)
        {

            List_LocalHosts();
            lblLocalHosts.Text = LocalNames;
            //Current
            lblHostname.Text = Properties.Settings.Default.db_server;
            lblPort.Text = Properties.Settings.Default.db_port;
            lblUsername.Text = Properties.Settings.Default.db_username;

            //LocalHost Names



        }
        public void List_LocalHosts()
        {
            
            List<String> Locals = new List<String>();


            foreach (NetworkInterface nics in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nics.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in nics.GetIPProperties().UnicastAddresses)
                    {
                        LocalNames = LocalNames+ip.Address.ToString();
                        LocalNames = LocalNames + Environment.NewLine;
                    }
                }
                
            }
            LocalNames = LocalNames + "localhost" + Environment.NewLine;
            LocalNames=LocalNames+Environment.MachineName;


        }
    }
}
