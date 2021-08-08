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
    public partial class OrdersHistoryForm : Form
    {
        List<OrderHistory> historyorders = new List<OrderHistory>();

        public OrdersHistoryForm()
        {
            InitializeComponent();
            UpdateList();
            FormatGrid();
        }

        private void UpdateList()
        {
            DataAccess db = new DataAccess();
            historyorders = db.GetAllOrderHistory();
            ohGridView.DataSource = historyorders;
        }

        private void FormatGrid()
        {
            ohGridView.Columns[0].HeaderText = "ID Zamówienia";
            ohGridView.Columns[1].HeaderText = "Nazwa Produktu";
            ohGridView.Columns[2].HeaderText = "Ilość";
            ohGridView.Columns[3].HeaderText = "Status";
            ohGridView.Columns[4].HeaderText = "Zapłacono";
            ohGridView.Columns[5].HeaderText = "Waluta";
            ohGridView.Columns[6].HeaderText = "Nazwa Klienta";
            ohGridView.Columns[7].HeaderText = "Data Realizacji";
        }

        private void ohExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrdersHistoryForm_Load(object sender, EventArgs e)
        {
            UpdateList();
            FormatGrid();
        }

        private void ohRefreshButton_Click(object sender, EventArgs e)
        {
            UpdateList();
            FormatGrid();
        }
    }
}
