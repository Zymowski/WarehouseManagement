using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginsubmit_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string username = lusernamebox.Text;
            string password = lpasswordBox.Text;
            bool check = db.CheckLogin(username,password);

            if (check == true)
            {
                MessageBox.Show("Zalogowano poprawnie!");
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dane są niepoprawne!");
            }
            
            lusernamebox.Text = "";
            lpasswordBox.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
