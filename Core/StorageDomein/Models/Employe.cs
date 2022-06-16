using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageDomein.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Possition { get; set; }
        public string IdentityNumber { get; set; }
        public string Addrres { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BankAccaunt { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
