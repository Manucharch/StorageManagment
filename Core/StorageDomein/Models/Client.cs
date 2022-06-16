﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageDomein.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string Addrres { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BankAccaunt { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
