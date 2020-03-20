using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class IlacBase:Core
    {
       
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public int StockNumber { get; set; }
    }
}
