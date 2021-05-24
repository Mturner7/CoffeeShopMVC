using System;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public class ProductData
    {
        private static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=Northwind;Uid=root;Password=Whitereaper12;");
        
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
