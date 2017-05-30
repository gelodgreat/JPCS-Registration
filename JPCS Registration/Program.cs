using System;
using System.Linq;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            globalconfig.fullname = "Guest Mode";
            String server = Properties.Settings.Default.db_server;
            String bahalaka;
            String username = Properties.Settings.Default.db_username;
            String port = Properties.Settings.Default.db_port;
            String password = Properties.Settings.Default.db_password;
            String database = Properties.Settings.Default.db_database;
            globalconfig.connstring = "server="+server+ ";port="+port+";username="+username+ ";password=" +password+";database="+database+";";
            Application.Run(new Login());
        }
    }
}