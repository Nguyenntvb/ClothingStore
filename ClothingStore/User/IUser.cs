using ClothingStore.ProductFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingStore.User
{
    public interface IUser
    {
        void Order(Product product);
        List<Product> ListCanBuy();
    }
}
