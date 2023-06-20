using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace REMS_2
{
    public partial class The_PropertyForm : Form
    {
        public The_PropertyForm()
        {
            InitializeComponent();
        }

        THE_PROPERTY property = new THE_PROPERTY();
        private void The_PropertyForm_Load(object sender, EventArgs e)
        {
            //populating the combobox with property types
            PROPERTY_TYPE pType = new PROPERTY_TYPE();
            comboBoxType.DataSource = pType.getAllType();
            comboBoxType.DisplayMember = "name";
            comboBoxType.ValueMember = "id";

        }
        //insert a new property
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                int owner = Convert.ToInt32(textBoxOwner.Text);
                int size = Convert.ToInt32(textBoxSize.Text);
                string price = textBoxPrice.Text;
                string address = textBoxAddress.Text;
                string comment = textBoxComment.Text;
                int bedrooms = (int)numericUpDownBedroom.Value;
                int bathrooms = (int)numericUpDownBathroom.Value;
                int age = (int)numericUpDownAge.Value;


                Boolean hasBalcony = checkBoxBalcony.Checked;
                Boolean hasBackyard = checkBoxBackyard.Checked;
                Boolean hasGarage = checkBoxGarage.Checked;
                Boolean hasPool = checkBoxPool.Checked;
                Boolean hasFireplace = checkBoxFireplace.Checked;

                // MessageBox.Show(" *Balcony - " +hasBalcony+ "*Backyard - " +hasBackyard+"*Garage - " +hasGarage+"*Pool - " +hasPool+ "*Fireplace - " +hasFireplace);

                if (verifTextBoxes())
                {
                    if (property.insertProperty(new THE_PROPERTY(0, type, owner, size, age, bedrooms, bathrooms, price, address, comment, hasBalcony, hasBackyard, hasGarage, hasFireplace, hasPool)))
                    {
                        MessageBox.Show("New Property Added", "Add Property", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Property Not Added", "Add Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter the required Fields", "Add Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Property Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //update the selected property
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                int owner = Convert.ToInt32(textBoxOwner.Text);
                int size = Convert.ToInt32(textBoxSize.Text);
                string price = textBoxPrice.Text;
                string address = textBoxAddress.Text;
                string comment = textBoxComment.Text;
                int bedrooms = (int)numericUpDownBedroom.Value;
                int bathrooms = (int)numericUpDownBathroom.Value;
                int age = (int)numericUpDownAge.Value;


                Boolean hasBalcony = checkBoxBalcony.Checked;
                Boolean hasBackyard = checkBoxBackyard.Checked;
                Boolean hasGarage = checkBoxGarage.Checked;
                Boolean hasPool = checkBoxPool.Checked;
                Boolean hasFireplace = checkBoxFireplace.Checked;

                // MessageBox.Show(" *Balcony - " +hasBalcony+ "*Backyard - " +hasBackyard+"*Garage - " +hasGarage+"*Pool - " +hasPool+ "*Fireplace - " +hasFireplace);

                if (verifTextBoxes())
                {
                    if (property.updateProperty(new THE_PROPERTY(id, type, owner, size, age, bedrooms, bathrooms, price, address, comment, hasBalcony, hasBackyard, hasGarage, hasFireplace, hasPool)))
                    {
                        MessageBox.Show("Property Data Updated", "Edit Property", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Property Not Updated", "Edit Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter the required Fields", "Edit Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Property Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //remove the selected property
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);

                //show confirmation message before deleting the property
                if(MessageBox.Show("Are You Sure You Want To Delete This property?","Delete Property", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (property.deleteProperty(id))
                    {
                        MessageBox.Show("Property Deleted", "Remove Property", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    
                    }
                    else
                    {
                        MessageBox.Show("Property Not Deleted", "Remove Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid property id", "Remove Property Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //show all properties in new form
        private void buttonShowProperties_Click(object sender, EventArgs e)
        {
            PropertiesListForm propListF = new PropertiesListForm();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `the_property`");


            propListF.populateDataGridView1(command);

            propListF.ShowDialog();



          }

        //show the selected property immages

        private void buttonShowPropertyImages_Click(object sender, EventArgs e)
        {
            try
            {
                int propertyId = Convert.ToInt32(textBoxID.Text);

                ImageSliderForm sliderForm = new ImageSliderForm();
                sliderForm.getImage(propertyId);

                sliderForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Empty Or Invalid Property ID", "Property Id Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // open a new form to select the property owner
        private void buttonSelectOwner_Click(object sender, EventArgs e)
        {
            OwnerListForm ownersForm = new OwnerListForm();
            ownersForm.ShowDialog();

            textBoxOwner.Text = ownersForm.dataGridView1.CurrentRow.Cells[0].Value.ToString();





        }
        //search property by id
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //get the property id
                int id = Convert.ToInt32(textBoxID.Text);
                //get the property data using the id
                DataTable propertyData = property.getPropertyById(id);

                //display the property data



                textBoxOwner.Text = propertyData.Rows[0]["owner_id"].ToString();
                textBoxSize.Text = propertyData.Rows[0]["square_feet"].ToString();
                textBoxPrice.Text = propertyData.Rows[0]["price"].ToString();
                textBoxAddress.Text = propertyData.Rows[0]["address"].ToString();
                textBoxComment.Text = propertyData.Rows[0]["comment"].ToString();
                comboBoxType.SelectedValue = propertyData.Rows[0]["type"];
                numericUpDownAge.Value = Convert.ToDecimal(propertyData.Rows[0]["age"]);
                numericUpDownBedroom.Value = Convert.ToDecimal(propertyData.Rows[0]["bedroom"]);
                numericUpDownBathroom.Value = Convert.ToDecimal(propertyData.Rows[0]["bathroom"]);
                checkBoxBalcony.Checked = Convert.ToBoolean(propertyData.Rows[0]["balcony"]);
                checkBoxBackyard.Checked = Convert.ToBoolean(propertyData.Rows[0]["backyard"]);
                checkBoxGarage.Checked = Convert.ToBoolean(propertyData.Rows[0]["garage"]);
                checkBoxFireplace.Checked = Convert.ToBoolean(propertyData.Rows[0]["fireplace"]);
                checkBoxPool.Checked = Convert.ToBoolean(propertyData.Rows[0]["pool"]);

                //had a problem with cast
            }
            catch
            {
                if (textBoxID.Text.Trim().Equals(""))

                {
                    MessageBox.Show("Enter the property id first", "Enter Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearFields();
                }
                else
                {

                    MessageBox.Show("Property does not exist", "Property not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
            }
                
                
    

}
          // crewate a function to verify the required fields is empty 
        public bool verifTextBoxes()
        {

            string size = textBoxSize.Text.Trim();
            string price = textBoxPrice.Text.Trim();
            string address = textBoxAddress.Text.Trim();
          

            if (size.Equals("") || price.Equals("") ||  address.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        //create a function to clear  all fields
        public void clearFields()
        {
            textBoxID.Text = "";
            textBoxOwner.Text = "";
            textBoxSize.Text = "";
            textBoxPrice.Text = "";
            textBoxAddress.Text = "";
            textBoxComment.Text = "";
            comboBoxType.SelectedIndex = 0;
            numericUpDownAge.Value = 0;
            numericUpDownBedroom.Value = 0;
            numericUpDownBathroom.Value =0;
            checkBoxBalcony.Checked = false;
            checkBoxBackyard.Checked = false;
            checkBoxGarage.Checked = false;
            checkBoxFireplace.Checked = false;
            checkBoxPool.Checked = false;
        }

        private void checkBoxBalcony_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
