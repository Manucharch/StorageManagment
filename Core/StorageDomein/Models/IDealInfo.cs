using System.Collections.Generic;

namespace StorageDomein.Models
{
    public interface IDealInfo
    {
        string Address { get; set; }
        string ClientId { get; set; }
        int Id { get; set; }
        string Info { get; set; }
        string Note { get; set; }
        decimal Price { get; set; }
        List<Product> Products { get; set; }

        void AddProductToDeal(Product product);

        void RemoveProductFromDeal(Product product);
    }
}