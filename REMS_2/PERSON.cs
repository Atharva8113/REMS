using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace REMS_2
{
    internal class PERSON
    {
        // we will use this class for owners as clients

        FUNC func = new FUNC();

        private int id;
        private string fname;
        private string lname;
        private string phone;
        private string email;
        private string address;


        public PERSON() { }

        public PERSON(int ID, string FNAME, string LNAME, string PHONE, string EMAIL, string ADDRESS)
        {
            this.id = ID;
            this.fname = FNAME;
            this.lname = LNAME;
            this.phone = PHONE;
            this.email = EMAIL;
            this.address = ADDRESS;
        }

        //get all  owners
        public DataTable getAllPersons(string ownerORclient)

        {
            string tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("SELECT * FROM `"+tableName+"`");

            return func.getData(command);

        }

        //inserting a new person (owner/client)

        public Boolean insertPerson(String ownerORclient, PERSON person )

        {
            string tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("INSERT INTO `"+tableName+"`( `first_name`, `last_name`, `phone`, `email`, `address`) VALUES (@fn,@ln,@phn,@email,@adrs) ");

            //@fn,@ln,@phn,@email,@adrs


            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address;

            return func.ExecQuery(command);
        }

        //editing the  new person (owner/client)

        public Boolean updatePERSON(String ownerORclient, PERSON person)
        {

            string tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("UPDATE `"+tableName+"` SET `first_name`=@fn,`last_name`=@ln,`phone`=@phn,`email`=@email,`address`=@adrs WHERE `id`=@id");
            
            //@fn,@ln,@phn,@email,@adrs


            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address;

            return func.ExecQuery(command);

        }

        public Boolean deletePERSON(String ownerORclient, int id)
        {

            string tableName = ownerORclient;

            MySqlCommand command = new MySqlCommand("DELETE FROM `"+tableName+"` WHERE `id`=@id");

            //@fn,@ln,@phn,@email,@adrs


            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


            return func.ExecQuery(command);

        }












    }
}
