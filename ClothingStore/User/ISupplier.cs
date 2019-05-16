using ClothingStore.ProductFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingStore.User
{
    public interface ISupplier
    {
        void Sell();
        void Add(Product product);
        void RemoveProduct(Product product);

    }
}
