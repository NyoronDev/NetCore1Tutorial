using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04_Lists
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Madrid");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            cities.RemoveAt(1);

            cities.Insert(0, "Sydney");

            cities.Remove("Milan");
        }
    }
}