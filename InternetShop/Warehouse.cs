using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    class Warehouse:Warehouse_workers
    {
        string WarehouseName = "Number1";
        string WarehouseAdress = "Privolnij";
        public Dictionary<int, string> products = new Dictionary<int, string>();
        public Dictionary<int, string> workers = new Dictionary<int, string>();
        
    }
    
}
