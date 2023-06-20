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
using MySql.Data.MySqlClient;

namespace REMS_2
{
    public partial class ImageSliderForm : Form
    {
        public ImageSliderForm()
        {
            InitializeComponent();
        }

        private void ImageSliderForm_Load(object sender, EventArgs e)
        {

        }

        DataTable images;
        int position=0;


        //create a function to display the images
        public void getImage(int propertyId)
        {
            try
            {
                PROPERTY_IMAGE propertyImage = new PROPERTY_IMAGE();
                images = propertyImage.getPropertyImages(propertyId);

                if (images.Rows.Count > 0) labelCount.Text = "1";

                displayImage(position);

            }
            catch
            {
                MessageBox.Show("This Property Does not have any images To Display", "No Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void displayImage(int index)
        {
          

            //display the total
            labelTotal.Text = Convert.ToString(images.Rows.Count);

            //display the image in the picture box
            pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])images.Rows[index]["image"]));
        
        
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
             position +=  1;

            if(position >= images.Rows.Count)
            {
                position = images.Rows.Count - 1;
                
            }
            labelCount.Text = Convert.ToString(position + 1);
            displayImage(position);

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            position -= 1;
            if(position < 0)
            {
                position=0;
            }
            labelCount.Text = (Convert.ToInt32(labelCount.Text)-1).ToString();
            if(Convert.ToInt32(labelCount.Text) < 1)
            {
                labelCount.Text = "1";
            }
            displayImage(position);
        }
    }
}
