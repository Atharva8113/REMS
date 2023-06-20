using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace REMS_2
{
    internal class DB_CONNECTION
    {
        MySqlConnection Connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=rems2_db");

        //Getting The connection
        public MySqlConnection getConnection
        {
            get

            {
                return Connection;
            }
        }




        //Opening The connection
        public void openConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }


        //Closing the connection
        public void closeConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

    }
}
