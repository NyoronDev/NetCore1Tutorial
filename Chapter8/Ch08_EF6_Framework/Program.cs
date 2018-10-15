using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08_EF6_Framework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var database = new NorthWind();
            // database.Database.Log = new Action<string>(message => { Console.WriteLine(message); });

            SeeAllProducts(database);

            Console.ReadLine();

            AddNewProduct(database);

            SeeAllProducts(database);

            Console.ReadLine();

            database.Database.Connection.Close();
        }

        private static void AddNewProduct(NorthWind database)
        {
            var newProduct = new Products
            {
                ProductName = "Bob Burger",
                UnitPrice = 500M
            };

            database.Products.Add(newProduct);

            database.SaveChanges();
        }

        public static void UpdateProduct(NorthWind database)
        {
            var updateProduct = database.Products.Find(78);
            updateProduct.UnitPrice += 20M;

            database.SaveChanges();
        }

        private static void SeeAllProducts(NorthWind database)
        {
            var price = 5;

            IQueryable<Products> query = database.Products.Where(product => product.UnitPrice > price).
                                                           OrderByDescending(product => product.UnitPrice);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
            }
        }
    }
}