using System;
using System.Linq;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;

namespace CoffeeShop.Models
{
    public class ProductData
    {
        private static IDbConnection connection;

        public ProductData(IDbConnection _con)
        {
            connection = _con;
        }


        public static void Create(Product newProduct)
        {
            connection.Insert(newProduct);
        }

        public static Product ReadOne(int productId)
        {
            return connection.Get<Product>(productId);
        }

        public static List<Product> ReadAll()
        {
            return connection.GetAll<Product>().ToList();
        }
        
        public static void Update(Product updatedProduct)
        {
            if (ReadOne(updatedProduct.productId) != null)
            {
                connection.Update<Product>(updatedProduct);
            }
        }

        public static void Delete(Product outdatedProduct)
        {
            connection.Delete<Product>(outdatedProduct);
        }
    }
}
