using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09_JoiningGrouping
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var database = new Northwind();

            var categories = database.Categories.Select(c => new { c.CategoryID, c.CategoryName }).ToArray();
            var products = database.Products.Select(p => new { p.ProductID, p.ProductName, p.CategoryID }).ToArray();

            // Join every product to its category to return 77 matches
            var queryJoin = categories.Join(products, category => category.CategoryID, product => product.CategoryID,
                                            (c, p) => new { c.CategoryName, p.ProductName, p.ProductID });

            // Group all products by their category to return 8 matches
            var queryGroup = categories.GroupJoin(products, category => category.CategoryID, product => product.CategoryID,
                                                  (c, Products) => new { c.CategoryName, Products });
        }
    }
}