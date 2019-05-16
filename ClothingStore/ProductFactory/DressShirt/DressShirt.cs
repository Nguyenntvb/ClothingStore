using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothingStore.Enum;

namespace ClothingStore.ProductFactory
{
    public class DressShirt : Product
    {
        public MaterialEnum Material { get; set; }
        public DressShirt(double price,string suppliers) : base(price, suppliers)
        {
            SetName("DressShirt");
        }
        public DressShirt(double price, string suppliers, string name, MaterialEnum material) : base(price, suppliers)
        {
            SetName(name);
            Material = Material;
        }
    }
}
