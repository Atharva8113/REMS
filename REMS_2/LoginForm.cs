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
using System.Data;

namespace REMS_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


      
        /////////////////////////////////////////////////////////////////////////////////
       
        ////////////////////////////////////////////////////////////////////////
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonshut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLoginn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernamee.Text;
            string password = textBoxPasswordd.Text;
            FUNC func = new FUNC();
            


            if (checkFields())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Username`=@un AND `Password`=@pass");
                command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                DataTable table = func.getData(command);

                if (table.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    labelErrorr.Visible = true;
                }
            }
        }



        //Check if the username and password are empty
        public Boolean checkFields()
        {
            labelUsernameAstrikk.Visible = false;
            labelPasswordAstrikk.Visible = false;


            if ((textBoxUsernamee.Text.Trim().Equals("")) && textBoxPasswordd.Text.Trim().Equals(""))

            {
                labelUsernameAstrikk.Visible = true;
                labelPasswordAstrikk.Visible = true;
                return false;
            }

            else if (textBoxUsernamee.Text.Trim().Equals(""))
            {
                labelUsernameAstrikk.Visible = true;
                return false;
            }
            else if (textBoxPasswordd.Text.Trim().Equals(""))

            {
                labelPasswordAstrikk.Visible = true;
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
