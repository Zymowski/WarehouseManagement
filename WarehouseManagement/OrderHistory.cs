using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class OrderHistory
    {
        public int historical_order_id { get; set; }
        public string product_name { get; set; }
        public int ammount { get; set; }
        public bool execution_status { get; set; }
        public float summary { get; set; }
        public string currency { get; set; }
        public string name { get; set; }
        public DateTime done_date { get; set; }

    }
}
