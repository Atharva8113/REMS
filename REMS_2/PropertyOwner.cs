using MySql.Data.MySqlClient;
using System;
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
    public partial class PropertyOwner : Form
    {
        public PropertyOwner()
        {
            InitializeComponent();
        }

        PERSON person = new PERSON();

        private void PropertyOwner_Load(object sender, EventArgs e)
        {
            LoadDatagridviewOwners();
            displayOwnersCount();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;

            person = new PERSON(id, fname, lname, phone, email, address);

            if (verifTextBoxes())
            {
                if (person.insertPerson("property_owner", person))
                {
                    MessageBox.Show("Owner Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewOwners();
                    displayOwnersCount();
                }
                else
                {
                    MessageBox.Show("Owner Not Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the Owner First & Last Name + the phone number", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string fname = textBoxFName.Text;
                string lname = textBoxLName.Text;
                string phone = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                string address = textBoxAddress.Text;
                
                person = new PERSON(id, fname, lname, phone, email, address);
                if (person.updatePERSON("property_owner",person))
                    {
                        MessageBox.Show("Owner Data Updated", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatagridviewOwners();
                        displayOwnersCount();
                    }
                    else
                    {
                        MessageBox.Show("Owner Data Not Updated", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch
            {
                MessageBox.Show("Owner Id error", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (person.deletePERSON("property_owner", id))

                {
                    MessageBox.Show("Owner Data deleted", "Remove Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewOwners();
                    displayOwnersCount();

                    //clear textboxes
                    textBoxID.Text = "";
                    textBoxFName.Text = "";
                    textBoxLName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEmail.Text = "";
                    textBoxAddress.Text = "";
                }
                else
                {
                    MessageBox.Show("Owner Data Not Deleted", "Remove Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Owner Id error", "Remove Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    


        //create a function to check if the user entered the owner first and last namme as well as thier phone number

        public bool verifTextBoxes()
        {

            string fname = textBoxFName.Text.Trim();
            string lname = textBoxLName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();

            if (fname.Equals("") || lname.Equals("") || phone.Equals("") || address.Equals("") || email.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }




        //display the selected owner data from datagridview to textbox
        private void dataGridViewOwners_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewOwners.CurrentRow.Cells[0].Value.ToString();
            textBoxFName.Text = dataGridViewOwners.CurrentRow.Cells[1].Value.ToString();
            textBoxLName.Text = dataGridViewOwners.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewOwners.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewOwners.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewOwners.CurrentRow.Cells[5].Value.ToString();
        }



        // populate the datagridview

        public void LoadDatagridviewOwners() 
        {
            person = new PERSON();
            dataGridViewOwners.DataSource = person.getAllPersons("property_owner");



        }

        //display the owners total count 
        public void displayOwnersCount()
        {

            string ownersCount = person.getAllPersons("property_owner").Rows.Count.ToString();
            labelCount.Text = ownersCount + " Owner(s) ";
        }

        //show the properties of the selected owner
        private void buttonShowOwnerProperties_Click(object sender, EventArgs e)
        {
            try 
            {
                PropertiesListForm propListF = new PropertiesListForm();


                int id = Convert.ToInt32(textBoxID.Text);

                MySqlCommand command = new MySqlCommand("SELECT * FROM `the_property` WHERE `owner_id`=@id");
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


                propListF.populateDataGridView1(command);

                propListF.ShowDialog();
            }

            catch 
            {
                    MessageBox.Show("Enter the owner id first","Empty ID",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
          

        }
    }
}

