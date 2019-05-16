using ClothingStore.ProductFactory;
using ClothingStore.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Product tShirt = new TShirt(6, "PULL");
            tShirt.AvailableColors = new List<ConsoleColor>() { ConsoleColor.Blue, ConsoleColor.Black};
            tShirt.AvailableSizes = new List<int>() { 41, 42 };
            tShirt.Quantity = 1;

            Product dressShirt = new TShirt(8, "POLO");
            dressShirt.AvailableColors = new List<ConsoleColor>() { ConsoleColor.Cyan, ConsoleColor.DarkBlue };
            dressShirt.AvailableSizes = new List<int>() {40, 41,42 };
            dressShirt.Quantity = 1;

            Vendor vendor = new Vendor();

            tShirt.SizeSelected = 41;
            tShirt.ColorSelected = ConsoleColor.Blue;

            vendor.Order(tShirt);

            dressShirt.SizeSelected = 41;
            dressShirt.ColorSelected = ConsoleColor.Blue;

            vendor.Order(dressShirt);

            vendor.SetRetailPrice(tShirt, 12);
            vendor.SetRetailPrice(dressShirt, 20);

            vendor.Sell();
        }
    }
}
