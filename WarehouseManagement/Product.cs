using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string cname { get; set; }
        public string name { get; set; }
        public string department_name { get; set; }
        public int ammount_on_stock { get; set; }
        public string unit { get; set; }
        public float price { get; set; }
        public string currency { get; set; }
    }
}
