using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;

namespace JPCS_Registration
{
    public class globalconfig
    {
        public string conn = "SERVER='" + Properties.Settings.Default.db_server + "'; PORT='" + Properties.Settings.Default.db_port + "'; DATABASE='" + Properties.Settings.Default.db_database + "'; USERNAME='" + Properties.Settings.Default.db_username + "'; PASSWORD='" + Properties.Settings.Default.db_password + "';";
        static StreamWriter logfile;
        static String path = "Log" + DateTime.Now.ToString("MMddyyyyHHmmss") + ".txt";

        //public string conn = "SERVER=localhost;PORT=3306; DATABASE=jpcsregistration; USERNAME=root; PASSWORD=root;";
        public MySqlCommand command;
        public MySqlDataReader reader;
        public MySqlDataAdapter adapter;

        private static Boolean DebugMode;
        public static Boolean ConsoleIsShown
        {
            get { return DebugMode; }
            set { DebugMode = value; }
        }
        public static void Logger(String msg)
        {
            if (ConsoleIsShown)
            {
                logfile = File.AppendText(path);
                logfile.WriteLine("[" + "MM-dd-yyyy HH:mm" + "] " + msg);
                Console.WriteLine("[" + "MM-dd-yyyy HH:mm" + "] " + msg);
                logfile.Close();
            }
        }

    }
}
