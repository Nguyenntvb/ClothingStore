using ClothingStore.ProductFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothingStore.InventoryProvider;

namespace ClothingStore.User
{
    public class Vendor : IUser, ISupplier
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public void Order(Product product)
        {
            product.Seller = Id;
            Inventory.Add(product);
        }

        public void Sell()
        {
            //Do Sell
        }

        public List<Product> ListProducts()
        {
            return Inventory.Products.Where(x=>x.Seller == Id).ToList();
        }

        public void SetRetailPrice(Product product, double? retailPrice)
        {
            double price = retailPrice == null ? product.GetPrice() : (double)retailPrice;
            product.SetRetailPrice(price);
        }

        public void Add(Product product)
        {
            Inventory.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Inventory.RemoveProduct(product.Id);
        }

        public List<Product> ListCanBuy()
        {
            return Inventory.Products;
        }
    }
}
