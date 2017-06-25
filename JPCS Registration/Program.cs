using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;

namespace JPCS_Registration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            using (Mutex mutex = new Mutex(false, appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    RadMessageBox.Show("JPCS Registration is already running. If you cannot see the UI, go to Task Manager, terminate the Process and try again", "JPCS Registration", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                globalconfig.fullname = "Guest Mode";
                globalconfig.hostname = Properties.Settings.Default.db_server;
                globalconfig.username = Properties.Settings.Default.db_username;
                globalconfig.port = Properties.Settings.Default.db_port;
                globalconfig.password = Properties.Settings.Default.db_password;
                globalconfig.dbname = Properties.Settings.Default.db_database;
                globalconfig.connstring = "server=" + globalconfig.hostname + ";port=" + globalconfig.port + ";username=" + globalconfig.username + ";password=" + globalconfig.password + ";database=" + globalconfig.dbname + ";";
                Application.Run(new Login());
            }

        }
        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";
    }
}