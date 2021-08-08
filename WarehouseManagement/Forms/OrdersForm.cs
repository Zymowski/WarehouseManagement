using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement.Forms
{
    public partial class OrdersForm : Form
    {
        List<OrdersView> ordersview = new List<OrdersView>();
        List<Product> products = new List<Product>();
        List<Clients> clients = new List<Clients>();

        public OrdersForm()
        {
            InitializeComponent();
            UpdateList();
            
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            UpdateList();
            FormatGrid();
            oProdNameCombo.DataSource = products;
            oProdNameCombo.DisplayMember = "product_name";
            oClientNameCombo.DataSource = clients;
            oClientNameCombo.DisplayMember = "name";
        }
        private void UpdateList()
        {
            DataAccess db = new DataAccess();
            products = db.RetrieveProductName();
            ordersview = db.GetAllOrders();
            clients = db.RetrieveClientName();
            oGridView.DataSource = ordersview;
        }
        private void FormatGrid()
        {
            oGridView.Columns[0].HeaderText = "ID Zamówienia";
            oGridView.Columns[1].HeaderText = "Nazwa Produktu";
            oGridView.Columns[2].HeaderText = "Ilość";
            oGridView.Columns[3].HeaderText = "Status";
            oGridView.Columns[4].HeaderText = "Suma do zapłaty";
            oGridView.Columns[5].HeaderText = "Waluta";
            oGridView.Columns[6].HeaderText = "Nazwa Klienta";
            oGridView.Columns[7].HeaderText = "Data Zamówienia";
        }

        private void Clear()
        {
            oAmmoTextBox.Text = "";

        }
        private void oDeleteOrderBox_Enter(object sender, EventArgs e)
        {

        }

        private void cCNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oRefreshButton_Click(object sender, EventArgs e)
        {
            UpdateList();
            FormatGrid();
        }

        private void oSubmit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomized = random.Next(1, 500);
            int ammo;
            DataAccess db = new DataAccess();
            db.CreateOrder(randomized, oProdNameCombo.Text,ammo=int.Parse(oAmmoTextBox.Text), oClientNameCombo.Text);
            Clear();
            MessageBox.Show("Poprawnie utworzono zamówienie!");
            UpdateList();

        }

        private void oDeleteSelected_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int selectedIndex = oGridView.CurrentCell.RowIndex;
            DataGridViewRow index = oGridView.Rows[selectedIndex];
            int id = int.Parse(index.Cells[0].Value.ToString());
            db.DeleteOrder(id);
            MessageBox.Show("Poprawnie usunięto zamówienie !");
            UpdateList();
        }

        private void oExecute_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int selectedIndex = oGridView.CurrentCell.RowIndex;
            DataGridViewRow index = oGridView.Rows[selectedIndex];
            int id = int.Parse(index.Cells[0].Value.ToString());
            db.ExecuteOrder(id);
            MessageBox.Show("Poprawnie zrealizowano zamówienie !");
            UpdateList();
        }
    }
}
