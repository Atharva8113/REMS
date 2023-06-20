using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace REMS_2
{
    public partial class PropertyClient : Form
    {
        public PropertyClient()
        {
            InitializeComponent();
        }
        PERSON person = new PERSON();

        private void PropertyClient_Load(object sender, EventArgs e)
        {

            LoadDatagridviewClients();
            displayClientsCount();
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
                if (person.insertPerson("property_client", person))
                {
                    MessageBox.Show("Client Added", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewClients();
                    displayClientsCount();
                }
                else
                {
                    MessageBox.Show("Client Not Added", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the Client First & Last Name + the phone number", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (person.updatePERSON("property_client", person))
                {
                    MessageBox.Show("Client Data Updated", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewClients();
                    displayClientsCount();
                }
                else
                {
                    MessageBox.Show("Client Data Not Updated", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Client Id error", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (person.deletePERSON("property_client", id))

                {
                    MessageBox.Show("Client Data deleted", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewClients();
                    displayClientsCount();

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
                    MessageBox.Show("Client Data Not Deleted", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Client Id error", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // populate the datagridview

        public void LoadDatagridviewClients()
        {
            person = new PERSON();
            dataGridViewClients.DataSource = person.getAllPersons("property_client");



        }

        //display the Clients total count 
        public void displayClientsCount()
        {

            string ClientsCount = person.getAllPersons("property_client").Rows.Count.ToString();
            labelCount.Text = ClientsCount + " Client(s) ";
        }

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

        private void dataGridViewClients_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewClients.CurrentRow.Cells[0].Value.ToString();
            textBoxFName.Text = dataGridViewClients.CurrentRow.Cells[1].Value.ToString();
            textBoxLName.Text = dataGridViewClients.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewClients.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewClients.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewClients.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
