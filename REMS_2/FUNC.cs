using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS_2
{
    internal class FUNC
    {
        DB_CONNECTION connection = new DB_CONNECTION();
        //insert
        public Boolean ExecQuery(MySqlCommand command)
        {


            command.Connection = connection.getConnection;

            connection.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }


        //get data
        public  DataTable getData(MySqlCommand command)
        {
            command.Connection = connection.getConnection;


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
