using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS_2
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }
  
        SALE sale= new SALE();
        FUNC func= new FUNC();
        string query;

        private void SaleForm_Load(object sender, EventArgs e)
        {
            //populate the sales datagridview
            dataGridViewSales.DataSource = sale.getSales();

            //populate the clients datagridview
            
            populateDatagridView(dataGridViewClients, "SELECT `id`, `first_name`, `last_name` FROM `property_client`");

            //populate the property datagridview
            query = "SELECT `id`,`owner_id`, `address`, `price` FROM `the_property` ";
            populateDatagridView(dataGridViewProperties, query);

            //clear selection form gridviews
            dataGridViewSales.ClearSelection();
            dataGridViewClients.ClearSelection();
            dataGridViewProperties.ClearSelection();
       


        }

        //add a new sale
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //int id = Convert.ToInt32(textBoxID.Text);
                int propertyid = Convert.ToInt32(textBoxPropertyId.Text);
                int clientid = Convert.ToInt32(textBoxClientId.Text);
                string sellingprice = textBoxSellingPrice.Text;
                DateTime sellingdate = dateTimePickersalesDate.Value;

                if (sale.insertSale(new SALE(0, propertyid, clientid, sellingprice, sellingdate))) 
                {
                    MessageBox.Show("New Sale Added", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the sales datagridview
                    dataGridViewSales.DataSource = sale.getSales();

                }
                else
                {
                    MessageBox.Show("Sale Not Added", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //edit a new sale
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                int propertyid = Convert.ToInt32(textBoxPropertyId.Text);
                int clientid = Convert.ToInt32(textBoxClientId.Text);
                string sellingprice = textBoxSellingPrice.Text;
                DateTime sellingdate = dateTimePickersalesDate.Value;

                if (sale.updateSale(new SALE(id, propertyid, clientid, sellingprice, sellingdate)))
                {
                    MessageBox.Show("New Sale Edited", "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the sales datagridview
                    dataGridViewSales.DataSource = sale.getSales();
                }
                else
                {
                    MessageBox.Show("Sale Not Edited", "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //remove a new sale
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);

                if (sale.deleteSale(id))
                {
                    MessageBox.Show("Sale Deleted", "Delete Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the sales datagridview
                    dataGridViewSales.DataSource = sale.getSales();


                    //clear fields
                    textBoxID.Text = "";
                    textBoxClientId.Text = "";
                    textBoxPropertyId.Text = "";
                    textBoxSellingPrice.Text = "";
                    dateTimePickersalesDate.Value = DateTime.Now;



                }
                else
                {
                    MessageBox.Show("Sale Not Deleted", "Delete Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //get the client id
        private void dataGridViewClients_Click(object sender, EventArgs e)
        {
            textBoxClientId.Text = dataGridViewClients.CurrentRow.Cells[0].Value.ToString();
        }
        //get the property id
        private void dataGridViewProperties_Click(object sender, EventArgs e)
        {
           textBoxPropertyId.Text= dataGridViewProperties.CurrentRow.Cells[0].Value.ToString();
            textBoxSellingPrice.Text= dataGridViewProperties.CurrentRow.Cells[3].Value.ToString();
        }
        //display the selected sale dates
        private void dataGridViewSales_Click(object sender, EventArgs e)
        {
            textBoxID.Text=dataGridViewSales.CurrentRow.Cells[0].Value.ToString();
            textBoxPropertyId.Text = dataGridViewSales.CurrentRow.Cells[1].Value.ToString();
            textBoxClientId.Text = dataGridViewSales.CurrentRow.Cells[2].Value.ToString();
            textBoxSellingPrice.Text = dataGridViewSales.CurrentRow.Cells[3].Value.ToString();
            dateTimePickersalesDate.Value =Convert.ToDateTime(dataGridViewSales.CurrentRow.Cells[4].Value);
        }

        //button refresh the datagriidviews
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            populateDatagridView(dataGridViewClients, "SELECT `id`, `first_name`, `last_name` FROM `property_client`");
        }


        //button to display only the soldd properties
        private void buttonSoldProperties_Click(object sender, EventArgs e)
        {
             query = "SELECT `id`,`owner_id`, `address`, `price` FROM `the_property` WHERE `id` IN (SELECT propert_id from sale)";
            populateDatagridView(dataGridViewProperties,query);


        }

        //button to display only the properties that are not sold 
        private void buttonNotSoldProperties_Click(object sender, EventArgs e)
        {

             query = "SELECT `id`,`owner_id`, `address`, `price` FROM `the_property` WHERE `id` not IN (SELECT propert_id from sale)";
            populateDatagridView(dataGridViewProperties, query);

        }

        //button to display All the properties
        private void buttonAllProperties_Click(object sender, EventArgs e)
        {

             query = "SELECT `id`,`owner_id`, `address`, `price` FROM `the_property`";
            populateDatagridView(dataGridViewProperties, query);


        }

        //create a function to populate the datagridview
        public void populateDatagridView(DataGridView dgv,string query)
        {
            MySqlCommand command = new MySqlCommand(query);
         dgv.DataSource = func.getData(command);
        }

        //button will show the new client form
        private void buttonAddNewClient_Click(object sender, EventArgs e)
        {
             PropertyClient propClientF = new PropertyClient();
            propClientF.Show();
        }

        private void dateTimePickersalesDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

//FOREIGN KEYS
//ALTER TABLE the_property ADD CONSTRAINT fk_type_id FOREIGN KEY (type) REFERENCES property_type(id) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE property_images ADD CONSTRAINT fk_property_id FOREIGN KEY(property_id) REFERENCES the_property(id) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE sale ADD CONSTRAINT fk_sale_property_id FOREIGN KEY(propert_id) REFERENCES the_property(id) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE sale ADD CONSTRAINT fk_sale_client_id FOREIGN KEY(client_id) REFERENCES property_client(id) on UPDATE CASCADE on DELETE CASCADE;

