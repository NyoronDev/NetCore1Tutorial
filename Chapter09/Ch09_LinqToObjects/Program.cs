using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09_LinqToObjects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var names = new string[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };
            var query = names.Where(new Func<string, bool>(NameLongerThanFour)).OrderBy(name => name.Length).ThenBy(name => name);

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }

        private static bool NameLongerThanFour(string name)
        {
            return name.Length > 4;
        }
    }
}