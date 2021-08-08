using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
namespace WarehouseManagement
{
    public class DataAccess
    {
        public bool CheckLogin (string username, string password)
        {
            var acc = new List<Accounts>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                acc = connection.Query<Accounts>($"select * from dbo.account where username = '{username}' and password = '{password}'").ToList();
                
                if (acc.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Product> GetAllProducts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output =  connection.Query<Product>($"dbo.list_product_proc").ToList();
                return output;
            }

        }

        public void AddProduct(string pname, string pcategory, string psupplier, string pdepartment, int pammount, string unit, float price, string currency)
        {


            var sqlidcategory = $"Select category_id from dbo.category where cname = '{pcategory}'";
            var sqlidsupplier = $"Select supplier_id from dbo.supplier where name = '{psupplier}'";
            var sqliddepartment = $"Select department_id from dbo.department where department_name = '{pdepartment}'";


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var idcategory = connection.Query(sqlidcategory).Single();
                var idsupplier = connection.Query(sqlidsupplier).Single();
                var iddepartment = connection.Query(sqliddepartment).Single();

                int idcategoryval = idcategory.category_id;
                int idsupplierval = idsupplier.supplier_id;
                int iddepartmentval = iddepartment.department_id;

                List<NewProduct> newProducts = new List<NewProduct>();

                newProducts.Add(new NewProduct { product_name = pname, id_category = idcategoryval, id_supplier = idsupplierval, id_department = iddepartmentval, ammount_on_stock = pammount, unit = unit, price = price, currency = currency });

                connection.Execute("dbo.add_new_product @product_name, @id_category, @id_supplier, @id_department, @ammount_on_stock, @unit, @price, @currency", newProducts);
               
            }
        }

        public void RemoveProduct(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                connection.Execute("dbo.delete_product @id", new { id });
            }
        }

        public List<Category> RetrieveCatergories()
        {
            var sql = "Select cname from dbo.category";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<Category>(sql).ToList();
                return output;
            }
        }

        public List<Supplier> RetrieveSupplier()
        {
            var sql = "Select name from dbo.supplier";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<Supplier>(sql).ToList();
                return output;
            }
        }

        public List<Department> RetrieveDepartment()
        {
            var sql = "Select department_name from dbo.department";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<Department>(sql).ToList();
                return output;
            }
        }


        public List<Clients> GetAllClients()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<Clients>($"dbo.list_clients_proc").ToList();
                return output;
            }
        }

        public void AddClient(string name, string address, string city, string country)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                List<Clients> clients = new List<Clients>();

                clients.Add(new Clients { name = name, address = address, city = city, country = country });

                connection.Execute("dbo.add_client @name, @address, @city, @country", clients);
                
            }
        }


        public void DeleteClient(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                connection.Execute("dbo.remove_client @id", new { id });
                
            }
        }

        public List<OrdersView> GetAllOrders()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<OrdersView>($"dbo.list_orders").ToList();
                return output;
            }
        }
        public void CreateOrder(int id, string product_name, int ammount, string client_name)
        {
            var sqlid_product = $"Select product_id from dbo.product where product_name ='{product_name}'";
            var sqlid_client = $"Select client_id from dbo.client where name = '{client_name}'";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var idproduct = connection.Query(sqlid_product).Single();
                var idclient = connection.Query(sqlid_client).Single();

                int idproductval = idproduct.product_id;
                int idclientval = idclient.client_id;

                List<NewOrder> newOrder = new List<NewOrder>();

                newOrder.Add(new NewOrder { orderID = id, id_product = idproductval, ammount = ammount, id_client = idclientval });

                connection.Execute("dbo.make_order @orderID, @id_product, @ammount, @id_client", newOrder);
            }
        }

        public List<Product> RetrieveProductName()
        {
            var sql = "Select product_name from dbo.product";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<Product>(sql).ToList();
                return output;
            }
        }

        public List<Clients> RetrieveClientName()
        {
            var sql = "Select name from dbo.client";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<Clients>(sql).ToList();
                return output;
            }
        }

        public void DeleteOrder(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                connection.Execute("dbo.delete_order @id", new { id });
            }
        }

        public void ExecuteOrder(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                connection.Execute("dbo.execute_order @id", new { id });
            }
        }

        public List<OrderHistory> GetAllOrderHistory()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<OrderHistory>("dbo.list_orders_history").ToList();
                return output;
            }
        }

        public List<EmployeeView> GetAllEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<EmployeeView>("dbo.list_employee").ToList();
                return output;
            }
        }

        public List<Position> RetrievePosition()
        {
            var sql = "Select pname from dbo.position";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                var output = connection.Query<Position>(sql).ToList();
                return output;
            }
        }

        public void AddEmployee(string name, string surname, string position, string department)
        {
            var sqlidposition = $"Select position_id from dbo.position where pname = '{position}'";
            var sqliddepartment = $"Select department_id from dbo.department where department_name = '{department}'";
            int idpositionval, iddepartmentval;
            List<NewEmployee> employees = new List<NewEmployee>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {

                var idposition = connection.Query(sqlidposition).Single();
                var iddepartment = connection.Query(sqliddepartment).Single();
                idpositionval = idposition.position_id;
                iddepartmentval = iddepartment.department_id;

                employees.Add(new NewEmployee { name = name, surname = surname, id_position = idpositionval, id_department = iddepartmentval });
                connection.Execute("dbo.add_employee @name, @surname, @id_position, @id_department", employees);

            }
        }

        public void DeleteEmployee(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLHelper.ConnectionStr("warehouse_db")))
            {
                connection.Execute("dbo.delete_employee @ID", new { id });
            }
        }

    }


}
