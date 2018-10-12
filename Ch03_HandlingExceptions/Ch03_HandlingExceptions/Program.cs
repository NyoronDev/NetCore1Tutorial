using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_HandlingExceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Before parsing");
            Console.Write("What is your age? ");

            var input = Console.ReadLine();
            try
            {
                var age = int.Parse(input);
                Console.WriteLine($"You are {age} years old.");
            }
            catch
            {
            }

            Console.WriteLine("After parsing");
        }
    }
}