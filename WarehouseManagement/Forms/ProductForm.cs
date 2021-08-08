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
    public partial class ProductForm : Form
    {
        List<Product> products = new List<Product>();
        List<Category> categories = new List<Category>();
        List<Supplier> suppliers = new List<Supplier>();
        List<Department> departments = new List<Department>();

        public ProductForm()
        {
            InitializeComponent();
            DataAccess db = new DataAccess();
            products = db.GetAllProducts();
            categories = db.RetrieveCatergories();
            suppliers = db.RetrieveSupplier();
            departments = db.RetrieveDepartment();
        }
        private void UpdateList() 
        {
            DataAccess db = new DataAccess();
            products = db.GetAllProducts();
            pGridView.DataSource = products;
            
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            
            UpdateList();
            FormatGrid();
            pCatCombo.DataSource = categories;
            pCatCombo.DisplayMember = "cname";
            pSuppCombo.DataSource = suppliers;
            pSuppCombo.DisplayMember = "name";
            pDepCombo.DataSource = departments;
            pDepCombo.DisplayMember = "department_name";
            pUnitCombo.Items.Add("szt");
            pUnitCombo.Items.Add("kg");
            pUnitCombo.Items.Add("m");
        }

        private void FormatGrid()
        {
            pGridView.Columns[0].HeaderText = "ID";
            pGridView.Columns[1].HeaderText = "Nazwa Produktu";
            pGridView.Columns[2].HeaderText = "Kategoria";
            pGridView.Columns[3].HeaderText = "Producent";
            pGridView.Columns[4].HeaderText = "Dział";
            pGridView.Columns[5].HeaderText = "Ilość na stanie";
            pGridView.Columns[6].HeaderText = "Jednostka";
            pGridView.Columns[7].HeaderText = "Cena";
            pGridView.Columns[8].HeaderText = "Waluta";
        }

        private void Clear()
        {
            pNameTextBox.Text = "";
            pAmmoTextBox.Text = "";
            pPriceText.Text = "";
        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBox_Enter(object sender, EventArgs e)
        {
            FormatGrid();
            UpdateList();
        }

        private void pExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pSubmit_Click(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();
            int ammo;
            float price;
            string currency = "PLN";
            db.AddProduct(pNameTextBox.Text, pCatCombo.Text, pSuppCombo.Text, pDepCombo.Text, ammo = int.Parse(pAmmoTextBox.Text), pUnitCombo.Text, price = float.Parse(pPriceText.Text), currency);
            MessageBox.Show("Dodano nowy produkt !");
            Clear();

        }

        private void pDepCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddinBox_Enter(object sender, EventArgs e)
        {

        }

        private void pDeleteSelected_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int selectedIndex = pGridView.CurrentCell.RowIndex;
            DataGridViewRow index = pGridView.Rows[selectedIndex];
            int id = int.Parse(index.Cells[0].Value.ToString());
            db.RemoveProduct(id);
            MessageBox.Show("Poprawnie usunięto produkt!");
            UpdateList();


        }
    }
}

