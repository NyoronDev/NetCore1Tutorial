using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // If Else
            if (args.Length == 0)
            {
                Console.WriteLine("There are no arguments");
            }
            else
            {
                Console.WriteLine("There is at least one argument");
            }

            // Switch Case
            var number = new Random().Next(1, 7);
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    goto case 1;

                case 3:
                case 4:
                    Console.WriteLine("Three or four");
                    goto case 1;

                default:
                    Console.WriteLine("Default");
                    break;
            }

            // While
            var x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            // Do-While
            var y = 0;
            do
            {
                Console.WriteLine(y);
                y++;
            } while (y < 10);

            // For
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Foreach
            string[] names = { "Juan", "Adam", "Charlie" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}