using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace REMS_2
{
    internal class PROPERTY_TYPE
    {

        FUNC func = new FUNC();

        //inserting a new type
        public Boolean insertType(String name, String description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `property_type`(`name`, `description`) VALUES (@nm, @dscr) ");

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@dscr", MySqlDbType.VarChar).Value = description;

            return func.ExecQuery(command);
        }

        //update the selected type
        public Boolean updateType(int id, String name, String description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `property_type` SET `name`=@nm,`description`=@dscr WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@dscr", MySqlDbType.VarChar).Value = description;

            return func.ExecQuery(command);
        }

        //deleting the selected type
        public Boolean deleteType(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `property_type` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


            return func.ExecQuery(command);
        }



        //get all  types
        public DataTable getAllType()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property_type`  ");

            return func.getData(command);

        }
    }
}
