using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Suplier:Core
    {
        public string CompanyName { get; set; }
        public string ContactPersonName { get; set; }
        public DateTime DealDate { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
