using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projekt_bazy
{

    class bazaDanych
    {
        private MySqlConnection connection = new MySqlConnection("server=hosting2043243.online.pro;port=3306;username=00344320_wypozyczalnia;password=ramziuch12;database=00344320_wypozyczalnia");
        public void openConn()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConn()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
