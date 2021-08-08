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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {
            Forms.ProductForm prd = new Forms.ProductForm();
            prd.ShowDialog();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Forms.ClientsForm clnt = new Forms.ClientsForm();
            clnt.ShowDialog();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            Forms.OrdersForm ordr = new Forms.OrdersForm();
            ordr.ShowDialog();
        }

        private void OrdersHistory_Click(object sender, EventArgs e)
        {
            Forms.OrdersHistoryForm ordrh = new Forms.OrdersHistoryForm();
            ordrh.ShowDialog();
        }
        private void Employee_Click(object sender, EventArgs e)
        {
            Forms.EmployeeForm emplo = new Forms.EmployeeForm();
            emplo.ShowDialog();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            Forms.UserAcc users = new Forms.UserAcc();
            users.ShowDialog();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
