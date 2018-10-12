using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04_Dictionaries
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var keywords = new Dictionary<string, string>();
            keywords.Add("int", "32-bit integer data type");
            keywords.Add("long", "64-bit integer data type");
            keywords.Add("float", "single precision floating point number");

            foreach (var item in keywords)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}