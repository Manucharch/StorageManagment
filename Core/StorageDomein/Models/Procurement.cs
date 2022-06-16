using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageDomein.Models
{
    public class Procurement : IDealInfo
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public decimal Price { get; set; }
        public string Info { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Product> Products { get; set; } = new List<Product>() { };


        public void AddProductToDeal(Product product)
        {
            Products.Add(product);
            Price += product.Quantity * product.Price;
        }

        public void RemoveProductFromDeal(Product product)
        {
            Products.Remove(product);
            Price -= product.Quantity * product.Price;
        }
    }
}
