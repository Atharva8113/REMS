using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
namespace REMS_2
{
    public partial class PropertyTypeForm : Form
    {
        public PropertyTypeForm()
        {
            InitializeComponent();
        }

        PROPERTY_TYPE pType = new PROPERTY_TYPE();

        private void PropertyTypeForm_Load(object sender, EventArgs e)
        {
            //Populating the listbox 
            LoadListboxData();

            //display type count
            displayTypesCount();
        }

        //inserting a new type 
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            if (!name.Trim().Equals(""))
            {
                if (pType.insertType(name, description))
                {
                    MessageBox.Show("Type Added", "Add Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListboxData();

                    //display type count
                    displayTypesCount();
                }
                else
                {
                    MessageBox.Show("Type Not Added", "Add Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter The Type Name First", "Add Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxTypes_Click(object sender, EventArgs e)
        {
            DataRow dr = pType.getAllType().Rows[listBoxTypes.SelectedIndex];
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxName.Text = dr.ItemArray[1].ToString();
            textBoxDescription.Text = dr.ItemArray[2].ToString();
        }

        // Edit the selected type
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string name = textBoxName.Text;
                string description = textBoxDescription.Text;

                if (!name.Trim().Equals(""))
                {
                    if (pType.updateType(id, name, description))
                    {
                        MessageBox.Show("Type Edited", "Edit Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListboxData();

                        //display type count
                        displayTypesCount();
                    }
                    else
                    {
                        MessageBox.Show("Type Not Edited", "Edit Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Type Name First", "Edit Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("No type selected", "Edit Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //remove the selected type
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            //show a confirmation messeage text
            if (MessageBox.Show("Continue The Delete?", "Remove Type ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pType.deleteType(id))
                {
                    MessageBox.Show("Type Deleted", "Remove Type", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refreshing the listbox
                    LoadListboxData();

                    //display type count
                    displayTypesCount();

                    //clear textboxes
                    textBoxID.Text = "";
                    textBoxName.Text = "";
                    textBoxDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Type Not Deleted", "Remove Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //creating a function to populate a listbox
        public void LoadListboxData()
        {
            listBoxTypes.DataSource = pType.getAllType();
            listBoxTypes.DisplayMember = "name";
            listBoxTypes.ValueMember = "id";

            // removing selection from listbox
            listBoxTypes.SelectedItem = null;
        }

        //display type count
        public void displayTypesCount()
        {
            labelCount.Text = listBoxTypes.Items.Count + "Types(s)";
        }

      
    }
}
