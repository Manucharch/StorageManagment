using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageDomein.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
    }
}
