using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;

namespace REMS_2
{
    internal class SALE
    {
        private int id;
        private int propertyid;
        private int clientid;
        private string sellingprice;
        private DateTime sellingdate;

        public SALE() { }

        public SALE(int ID,int PR_ID,int CL_ID,string SALE_PRICE, DateTime SALE_DATE)
        {
            this.id = ID;
            this.propertyid = PR_ID;
            this.clientid = CL_ID;
            this.sellingprice= SALE_PRICE;
            this.sellingdate = SALE_DATE;

        }
        FUNC func = new FUNC();


        //insert a sale
        public bool insertSale(SALE sale)
        { 
            MySqlCommand command = new MySqlCommand("INSERT INTO `sale`(`propert_id`, `client_id`, `selling_price`, `sale_date`) VALUES (@pid,@cid,@slpr,@sldate)");

            //@pid,@cid,@slpr,@sldate


            command.Parameters.Add("@pid", MySqlDbType.Int32).Value = sale.propertyid;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = sale.clientid;
            command.Parameters.Add("@slpr", MySqlDbType.String).Value = sale.sellingprice;
            command.Parameters.Add("@sldate", MySqlDbType.DateTime).Value = sale.sellingdate;
           

            return func.ExecQuery(command);
        }

        //edit the selected sale
        public bool updateSale(SALE sale)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `sale` SET `propert_id`=@pid,`client_id`=@cid,`selling_price`=@slpr,`sale_date`=@sldate WHERE `id`=@id");

            //@pid,@cid,@slpr,@sldate

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = sale.id;
            command.Parameters.Add("@pid", MySqlDbType.Int32).Value = sale.propertyid;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = sale.clientid;
            command.Parameters.Add("@slpr", MySqlDbType.String).Value = sale.sellingprice;
            command.Parameters.Add("@sldate", MySqlDbType.DateTime).Value = sale.sellingdate;


            return func.ExecQuery(command);
        }

        //delete the sales
        public bool deleteSale(int id) 
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `sale` WHERE `id`=@id");

            //@pid,@cid,@slpr,@sldate

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;          
            return func.ExecQuery(command);
        }


        //get all sales
        public DataTable getSales()
        {
            MySqlCommand command = new MySqlCommand("SELECT `id`, `propert_id`as 'Property', `client_id`as 'Client', `selling_price` as 'Price', `sale_date`as 'Date' FROM `sale` ");
            return func.getData(command);
        }
    }
}
