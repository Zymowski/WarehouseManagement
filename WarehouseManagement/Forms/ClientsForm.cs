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
    public partial class ClientsForm : Form
    {
        List<Clients> clients = new List<Clients>();

        public ClientsForm()
        {
            InitializeComponent();
            UpdateList();
            FormatGrid();
        }

        private void UpdateList()
        {
            DataAccess db = new DataAccess();
            clients = db.GetAllClients();
            cGridView.DataSource = clients;
        }
        private void FormatGrid()
        {
            cGridView.Columns[0].HeaderText= "ID";
            cGridView.Columns[1].HeaderText= "Nazwa Klienta";
            cGridView.Columns[2].HeaderText= "Adres";
            cGridView.Columns[3].HeaderText= "Miasto";
            cGridView.Columns[4].HeaderText= "Kraj";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            UpdateList();
            FormatGrid();
        }

        private void cSubmit_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.AddClient(cNameBox.Text, cAddressBox.Text, cCityBox.Text, cCountryBox.Text);
            MessageBox.Show("Poprawnie dodano klienta!");
        }

        private void cRefreshButton_Click(object sender, EventArgs e)
        {
            UpdateList();
            FormatGrid();
        }

        private void cDeleteSelected_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int selectedIndex = cGridView.CurrentCell.RowIndex;
            DataGridViewRow index = cGridView.Rows[selectedIndex];
            int id = int.Parse(index.Cells[0].Value.ToString());
            db.DeleteClient(id);
            MessageBox.Show("Poprawnie usunięto klienta!");
            UpdateList();
        }
    }
}
