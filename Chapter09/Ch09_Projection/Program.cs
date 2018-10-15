using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09_Projection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var database = new Northwind();
            var query = database.Products.Where(product => product.UnitPrice < 10M).
                                          OrderByDescending(product => product.UnitPrice).
                                          Select(product => new { product.ProductID, product.ProductName, product.UnitPrice });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
            }

            Console.ReadLine();
        }
    }
}