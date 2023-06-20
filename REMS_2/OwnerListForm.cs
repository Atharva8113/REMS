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
    public partial class OwnerListForm : Form
    {
        public OwnerListForm()
        {
            InitializeComponent();
        }

       

        private void OwnerListForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview
            FUNC func = new FUNC();
            MySqlCommand command = new MySqlCommand("SELECT `id`, `first_name`, `last_name` FROM `property_owner` ");
            dataGridView1.DataSource = func.getData(command);

            // clear the se;ectiom from the ddatagridview
            dataGridView1.ClearSelection();


        }
        //close this form on double clicking event
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
