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
        //public string conn = "SERVER='" + Properties.Settings.Default.db_server + "'; PORT='" + Properties.Settings.Default.db_port + "'; DATABASE='" + Properties.Settings.Default.db_database + "'; USERNAME='" + Properties.Settings.Default.db_username + "'; PASSWORD='" + Properties.Settings.Default.db_password + "';";
        static StreamWriter logfile;
        private static string connectionstring;
        public static string connstring
        {
            get { return connectionstring; }
            set { connectionstring = value; }
        }
        static String path = "Log" + DateTime.Now.ToString("MMddyyyyHHmmss") + ".txt";

        //public string conn = "SERVER=localhost;PORT=3306; DATABASE=jpcsregistration; USERNAME=root; PASSWORD=root;";
        public MySqlCommand command = new MySqlCommand();
        private static MySqlConnection sqlconnection;
        public MySqlDataReader reader;
        public MySqlDataAdapter adapter;
        private static Boolean DebugMode;
        public static Boolean ConsoleIsShown
        {
            get { return DebugMode; }
            set { DebugMode = value; }
        }
        private static string active;
        public static String schoolyearactive
        {
            get { return active; }
            set { active = value; }
        }
        private static Boolean auth;
        public static Boolean isAuthenticated
        {
            get { return auth; }
            set { auth = value; }
        }
        private static string action;
        public static string AuthAction
        {
            get { return action; }
            set { action = value; }
        }
        private static string uname;
        public static string fullname
        {
            get { return uname; }
            set { uname = value; }
        }
        private static string actiontext;
        public static string Mainaction
        {
            get { return actiontext; }
            set { actiontext = value; }
        }


        //This is the variable that will be used on Editing or deleting a Student.
        private static string selectedstudent;
        public static string selection
        {
            get { return selectedstudent; }
            set { selectedstudent = value; }
        }
        //End

        private static double money;
        public static double totalMoney
        {
            get { return money; }
            set { money = value; }
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
