using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothingStore.ProductFactory;


namespace ClothingStore.InventoryProvider
{
    public static class Inventory
    {
        public static List<Product> products;
        public static List<Product> Products
        {
            get
            {
                if (products.Count == 0)
                {
                    Load();
                }

                return products;
            }
            set { products = value; }
        }

        static Inventory()
        {
            Products = new List<Product>();
        }

        private static void Load()
        {
            //Products = DataManager.LoadProducts();
        }

        private static void Save()
        {
            //DataManager.SaveProducts(Products);
        }

        public static void RemoveProduct(int productId)
        {
            Inventory.Products.RemoveAll(x => x.Id == productId);
            Save();
        }

        public static void Add(Product product)
        {
            Products.Add(product);
            Save();
        }

        public static int GetProductCount()
        {
            return Inventory.Products.Count();
        }

        public static int GetUnitCount()
        {
            return Inventory.Products.Select(x => x.Quantity).Sum();
        }

        public static Double GetInventoryValue()
        {
            return Inventory.Products.Select(x => (x.GetPrice() * x.Quantity)).Sum();
        }
        public static void ClearInventory()
        {
            Inventory.Products.Clear();
            Save();
        }
    }
}
