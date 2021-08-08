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
    public partial class EmployeeForm : Form
    {
        List<EmployeeView> employees = new List<EmployeeView>();
        List<Position> positions = new List<Position>();
        List<Department> departments = new List<Department>();
        public EmployeeForm()
        {
            InitializeComponent();
            UpdateList();
            FormatGrid();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            UpdateList();
            FormatGrid();
        }
        private void UpdateList()
        {
            DataAccess db = new DataAccess();
            employees = db.GetAllEmployees();
            positions = db.RetrievePosition();
            departments = db.RetrieveDepartment();
            eGridView.DataSource = employees;
            ePositionCombo.DataSource = positions;
            ePositionCombo.DisplayMember = "pname";
            eDepartmentCombo.DataSource = departments;
            eDepartmentCombo.DisplayMember = "department_name";
        }
        private void FormatGrid()
        {
            eGridView.Columns[0].HeaderText = "ID Pracownika";
            eGridView.Columns[1].HeaderText = "Imię";
            eGridView.Columns[2].HeaderText = "Nazwisko";
            eGridView.Columns[3].HeaderText = "Stanowisko";
            eGridView.Columns[4].HeaderText = "Dział";
        }
        private void eExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eSubmit_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.AddEmployee(eNameBox.Text, eSurnameBox.Text, ePositionCombo.Text, eDepartmentCombo.Text);
            MessageBox.Show("Poprawno dodano pracownika!");
            UpdateList();
        }

        private void eDeleteSelected_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int selectedIndex = eGridView.CurrentCell.RowIndex;
            DataGridViewRow index = eGridView.Rows[selectedIndex];
            int id = int.Parse(index.Cells[0].Value.ToString());
            db.DeleteEmployee(id);
            MessageBox.Show("Poprawnie usunięto pracownika!");
            UpdateList();
        }

        private void eRefreshButton_Click(object sender, EventArgs e)
        {
            UpdateList();
            FormatGrid();
        }

  
    }
}
