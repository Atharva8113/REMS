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
using MySql.Data.MySqlClient;

namespace REMS_2
{
    public partial class PropertiesListForm : Form
    {
        public PropertiesListForm()
        {
            InitializeComponent();
        }

      

        private void PropertiesListForm_Load(object sender, EventArgs e)
        {

            
        }

        public void populateDataGridView1(MySqlCommand command)
        {
            //change the datagridview row height 
            dataGridView1.RowTemplate.Height = 50;

            // populate the datagridview
            FUNC func = new FUNC();
            dataGridView1.DataSource = func.getData(command);

            //display the properties count
            labelCount.Text = func.getData(command).Rows.Count  + " Properties";


            // clear the se;ectiom from the ddatagridview
            dataGridView1.ClearSelection();
        }
    }
}
