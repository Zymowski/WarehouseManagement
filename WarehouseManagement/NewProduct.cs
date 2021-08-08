using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class NewProduct
    {
        public string product_name { get; set; }
        public int id_category { get; set; }
        public int id_supplier { get; set; }
        public int id_department { get; set; }
        public int ammount_on_stock { get; set; }
        public string unit { get; set; }
        public float price { get; set; }
        public string currency { get; set; }


    }
}
