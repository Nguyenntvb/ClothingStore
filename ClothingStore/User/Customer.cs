using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothingStore.InventoryProvider;
using ClothingStore.ProductFactory;

namespace ClothingStore.User
{
    class Customer : IUser
    {
        public List<Product> ListCanBuy()
        {
            return Inventory.Products;
        }

        public void Order(Product product)
        {
            // Do order
        }
    }
}
