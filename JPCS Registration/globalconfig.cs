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

        #region ConnectionString
        private static string connectionstring;
        private static string _host;
        private static string _port;
        private static string _uname;
        private static string _pwd;
        private static string _dbname;

        public static string hostname
        {
            get { return _host; }
            set { _host = value; }
        }
        public static string port
        {
            get { return _port; }
            set { _port = value; }
        }
        public static string username
        {
            get { return _uname; }
            set { _uname = value; }
        }
        public static string password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        public static string dbname
        {
            get { return _dbname; }
            set { _dbname = value; }
        }
        public static string connstring
        {
            get { return connectionstring; }
            set { connectionstring = value; }
        }
        #endregion
        static String path = "Log" + DateTime.Now.ToString("MMddyyyyHHmmss") + ".txt";

        //public string conn = "SERVER=localhost;PORT=3306; DATABASE=jpcsregistration; USERNAME=root; PASSWORD=root;";
        public MySqlCommand command = new MySqlCommand();
        public MySqlDataReader reader;
        public MySqlDataAdapter adapter;
        private static Boolean DebugMode;
        //public List<string> Locals
        //{
        //    get;set;
        //}
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
        
        private static string Connection;
        public static string ConnectionType
        {
            get { return Connection; }
            set { Connection = value; }
        }

        //This is the variable that will be used on Editing or deleting a Student.
        private static string selectedstudent;
        public static string selection
        {
            get { return selectedstudent; }
            set { selectedstudent = value; }
        }
        private static List<String>  Locals;
        public static List<String> LocalConnections
        {
            get { return Locals; }
            set { Locals = value; }
        }

        //End

        private static double money;
        public static double totalMoney
        {
            get { return money; }
            set { money = value; }
        }
        private static int studentcount;
        public static int currentTotal
        {
            get { return studentcount; }
            set { studentcount = value; }
        }
        private static string eventid;
        public static string currentEventId
        {
            get { return eventid; }
            set { eventid = value; }
        }
        public static void Logger(String msg, String Action)
        {
            if (ConsoleIsShown)
            {
                logfile = File.AppendText(path);
                logfile.WriteLine("[" + "MM-dd-yyyy HH:mm" + "] " + msg +" "+ Action);
                logfile.Close();
            }
        }

    }
}
