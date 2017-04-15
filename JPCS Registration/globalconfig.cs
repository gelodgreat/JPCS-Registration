using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace JPCS_Registration
{
    class globalconfig
    {
        public string conn = "SERVER=localhost;PORT=3306;DATABASE=jpcsregistration;USERNAME=root;PASSWORD=root;";
        public MySqlCommand command;
        public MySqlDataReader reader;
        public MySqlDataAdapter adapter;
     
    }
}
