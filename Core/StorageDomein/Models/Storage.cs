using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageDomein.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public string ProdName { get; set; }
        public decimal PriceIN { get; set; }
        public decimal PriceOUT { get; set; }
    }
}
