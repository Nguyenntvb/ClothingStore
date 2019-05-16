using ClothingStore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingStore.ProductFactory
{
    public class TShirt : Product
    {
        public MaterialEnum Material { get; set; }
        public TShirt(double price, string suppliers) : base(price, suppliers)
        {
            SetName("T-Shirt");
        }
        public TShirt(double price, string suppliers, string name, MaterialEnum material) : base(price, suppliers)
        {
            SetName(name);
            Material = Material;
        }
    }
}
