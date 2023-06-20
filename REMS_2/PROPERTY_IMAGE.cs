using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace REMS_2
{
    internal class PROPERTY_IMAGE
    {


        FUNC func = new FUNC();
        //inserting the property image
        public bool insertImage(int propertyId, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `property_images`(`property_id`, `image`) VALUES (@prId,@pic)");

            command.Parameters.Add("@prId", MySqlDbType.Int32).Value = propertyId;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            return func.ExecQuery(command);

        }

        //deleting the selected property image
        public bool deleteImage(int propertyId)
        {

            MySqlCommand command = new MySqlCommand("  DELETE FROM `property_images` WHERE `id` = @id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = propertyId;
            
                
                return func.ExecQuery(command);

        }

            //no update image

            //to change an existing image you have to delete and add the correct one

            //you can add mulltiple images to a property

        //get the image by id
       public MemoryStream getImageById(int imageId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property_images` WHERE `id`=@id");
            command.Parameters.Add("@id",MySqlDbType.Int32).Value = imageId;
            DataTable table = func.getData(command);

            MemoryStream picture = new MemoryStream((byte[])table.Rows[0]["image"]);

            return picture;
        }



            //get the selected property images
           
            public DataTable getPropertyImages(int propertyId)
            {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `property_images` WHERE `property_id`=@pId");
            command.Parameters.Add("@pId", MySqlDbType.Int32).Value = propertyId;
          return func.getData(command);
        }


        
    }
}
