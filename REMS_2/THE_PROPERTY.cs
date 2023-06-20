using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace REMS_2
{
    internal class THE_PROPERTY
    {
        private int id;
        private int type;
        private int ownerId;
        private int size;
        private int age;
        private int bedrooms;
        private int bathrooms;
        private string price;
        private string address;
        private string comment;
        private bool balcony;
        private bool backyard;
        private bool fireplace;
        private bool garage;
        private bool pool;


        FUNC func = new FUNC();

        public THE_PROPERTY() { }

        public THE_PROPERTY(int ID,int TYPE,int OWNER,int SIZE,int AGE,int BATHROOM,int BEDROOM, string PRICE,string ADDRESS,string COMMENT,bool BALCONY,bool BACKYARD,bool GARAGE,bool FIREPLACE,bool POOL ) 
        {
            this.id=ID;
            this.type=TYPE;
            this.ownerId=OWNER;
            this.size=SIZE;
            this.age=AGE;
            this.bedrooms=BATHROOM;
            this.bathrooms=BEDROOM;
            this.price=PRICE;
            this.address=ADDRESS;
            this.comment=COMMENT;
            this.balcony=BALCONY;
         this.backyard=BACKYARD;
            this.fireplace=FIREPLACE;
            this.garage=GARAGE;
            this.pool=POOL;


        }

        // insert a new property

        public Boolean insertProperty(THE_PROPERTY property)

        { 
            MySqlCommand command = new MySqlCommand("INSERT INTO `the_property`(`type`, `square_feet`, `owner_id`, `price`, `address`, `bedroom`, `bathroom`, `age`, `balcony`, `backyard`, `pool`, `garage`, `fireplace`, `comment`) VALUES (@tp,@size,@owner,@price,@adrs,@bedr,@bathr,@age,@balc,@backy,@pool,@grg,@fire,@cmnt)");

                                                                                                    //@tp,@size,@owner,@price,@adrs,@bedr,@bathr,@age,@balc,@backy,@pool,@grg,@fire,@cmnt


            command.Parameters.Add("@tp", MySqlDbType.Int32).Value =property.type;
            command.Parameters.Add("@size", MySqlDbType.Int32).Value = property.size;
            command.Parameters.Add("@owner", MySqlDbType.Int32).Value = property.ownerId;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = property.price;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = property.address;
            command.Parameters.Add("@bedr", MySqlDbType.Int32).Value = property.bedrooms;
            command.Parameters.Add("@bathr", MySqlDbType.Int32).Value = property.bathrooms;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = property.age;
            command.Parameters.AddWithValue("@balc", property.balcony);
            command.Parameters.AddWithValue("@backy",property.backyard);
            command.Parameters.AddWithValue("@pool",  property.pool);
            command.Parameters.AddWithValue("@grg",property.garage);
            command.Parameters.Add("@fire", MySqlDbType.VarChar).Value = property.fireplace;
            command.Parameters.Add("@cmnt", MySqlDbType.VarChar).Value = property.comment;




            return func.ExecQuery(command);
        }
        //edit the dselected property
        public Boolean updateProperty(THE_PROPERTY property)

        {
            MySqlCommand command = new MySqlCommand("UPDATE `the_property` SET `type`=@tp,`square_feet`=@size,`owner_id`=@owner,`price`=@price,`address`=@adrs,`bedroom`=@bedr,`bathroom`=@bathr,`age`=@age,`balcony`=@balc,`backyard`=@backy,`pool`=@pool,`garage`=@grg,`fireplace`=@fire,`comment`=@cmnt WHERE `id`=@id");
            //@tp,@size,@owner,@price,@adrs,@bedr,@bathr,@age,@balc,@backy,@pool,@grg,@fire,@cmnt

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = property.id;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = property.type;
            command.Parameters.Add("@size", MySqlDbType.Int32).Value = property.size;
            command.Parameters.Add("@owner", MySqlDbType.Int32).Value = property.ownerId;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = property.price;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = property.address;
            command.Parameters.Add("@bedr", MySqlDbType.Int32).Value = property.bedrooms;
            command.Parameters.Add("@bathr", MySqlDbType.Int32).Value = property.bathrooms;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = property.age;
            command.Parameters.AddWithValue("@balc", property.balcony);
            command.Parameters.AddWithValue("@backy", property.backyard);
            command.Parameters.AddWithValue("@pool", property.pool);
            command.Parameters.AddWithValue("@grg", property.garage);
            command.Parameters.Add("@fire", MySqlDbType.VarChar).Value = property.fireplace;
            command.Parameters.Add("@cmnt", MySqlDbType.VarChar).Value = property.comment;




            return func.ExecQuery(command);
        }
        //remove the selected property
        public Boolean deleteProperty(int id)

        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `the_property` WHERE `id`=@id");
            //@tp,@size,@owner,@price,@adrs,@bedr,@bathr,@age,@balc,@backy,@pool,@grg,@fire,@cmnt

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
           



            return func.ExecQuery(command);
        }
        //get all property's

        //get property by id
        public DataTable getPropertyById(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `the_property` WHERE `id`=@id");
            command.Parameters.Add("@id",MySqlDbType.Int32).Value=id;
            return func.getData(command);


        }


    }
}
