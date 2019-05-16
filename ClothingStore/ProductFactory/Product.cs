using ClothingStore.Enum;
using ClothingStore.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingStore.ProductFactory
{
    public class Product : IProduct
    {
        private double _price = 0;
        private string _suppliers = "";

        protected Product(double price, string suppliers)
        {
            _price = price;
            _suppliers = suppliers;
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public double RetailPrice { get; protected set; }
        public string Name { get; set; }
        public List<int> AvailableSizes { get; set; }
        public List<ConsoleColor> AvailableColors { get; set; }
        public ConsoleColor ColorSelected { get; set; }
        public int SizeSelected { get; set; }
        public int Seller { get; set; }

        public virtual void SetRetailPrice(double retailprice)
        {
            RetailPrice = retailprice;
        }
        protected virtual void SetName(string name)
        {
            Name = name;
        }
        public virtual double GetPrice()
        {
            return _price * Quantity;
        }
    }
}
