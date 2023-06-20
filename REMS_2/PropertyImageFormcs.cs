using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS_2
{
    public partial class PropertyImageFormcs : Form
    {
        public PropertyImageFormcs()
        {
            InitializeComponent();
        }
        PROPERTY_IMAGE propertyImage = new PROPERTY_IMAGE();
        PROPERTY_TYPE propertyType= new PROPERTY_TYPE();
        FUNC func = new FUNC();
        private void PropertyImageFormcs_Load(object sender, EventArgs e)
        {
            //populate the datagridview with images
            FUNC func = new FUNC();
            MySqlCommand commandProps = new MySqlCommand("SELECT `id`, `age`, `address` FROM `the_property` ");

            dataGridView1.DataSource = func.getData(commandProps);

            //populate the listbox with images
   
            listBoxType.DataSource = propertyType.getAllType();
            listBoxType.DisplayMember = "name";
            listBoxType.ValueMember = "id";

            //clear the selection
            listBoxType.SelectedItem = null;
            listBoxImagesId.SelectedItem= null;
            dataGridView1.ClearSelection();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //add a new image
            try
            {
                //get the property id
                int propertyId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                //get the image
                MemoryStream pic = new MemoryStream();
                pictureBoxPropertyImage.Image.Save(pic, pictureBoxPropertyImage.Image.RawFormat);


                //insert the image 
                if (propertyImage.insertImage(propertyId, pic))
                {
                    MessageBox.Show("New Image Added", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Image Not Added", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("You Need To Select The Property And Choose The Image", "Add Image Error`", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            //choose the image from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPropertyImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //remove the selected image
            try
            {
                //get the property id
                int propertyId = Convert.ToInt32(listBoxImagesId.SelectedValue) ;

                // show a confirmation message
                if (MessageBox.Show("DO You Want To Delete This Image", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (propertyImage.deleteImage(propertyId))
                    {
                        MessageBox.Show("Image Deleted", "Remove Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Image Not Deleted", "Add Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {


            }
        }

        private void buttonShowPropertyImg_Click(object sender, EventArgs e)
        {
            try
            {
                //display the selected propertty images in a new form
                ImageSliderForm sliderF = new ImageSliderForm();

                //get the property if from the data gridview '
                int propertyId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                sliderF.getImage(propertyId);
                sliderF.ShowDialog();
            }
            catch
            {
                // show an error messagge if the property does not have any images to display
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    MessageBox.Show("This Property Does not have any images To Display", "No Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("You need to slect the property first", "Select Property", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
         
        

        private void listBoxType_Click(object sender, EventArgs e)
        {
            //display the property in this type on the datagridview

            MySqlCommand commandProps = new MySqlCommand("SELECT `id`, `address`, `age` FROM `the_property` WHERE `type`=@tp");
            int typeId = Convert.ToInt32(listBoxType.SelectedValue);
            commandProps.Parameters.Add("@tp", MySqlDbType.Int32).Value = typeId;
            dataGridView1.DataSource = func.getData(commandProps);
            


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //displaying the selectedd property images in the listbox

            int propertyId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            listBoxImagesId.DataSource= propertyImage.getPropertyImages(propertyId);
            listBoxImagesId.DisplayMember = "id";
            listBoxImagesId.ValueMember = "id";


        }

        private void listBoxImagesId_Click(object sender, EventArgs e)
        {
            //display the seleccted image from the listbox in the picture box

            // get the image id
            int picId=Convert.ToInt32(listBoxImagesId.SelectedValue);
            pictureBoxPropertyImage.Image= Image.FromStream(propertyImage.getImageById(picId));
        
        
        }

        private void listBoxImagesId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
