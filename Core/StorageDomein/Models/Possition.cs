using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageDomein.Models
{
    public class Possition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepId { get; set; }
        public decimal Salary { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
