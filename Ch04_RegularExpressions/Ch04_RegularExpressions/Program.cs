using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ch04_RegularExpressions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            var input = Console.ReadLine();

            var ageChecker = new Regex(@"\d");
            if (ageChecker.IsMatch(input))
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                Console.WriteLine($"This is not a valid age {input}");
            }
        }
    }
}