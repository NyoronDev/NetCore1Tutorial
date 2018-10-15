using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09_MyLINQExtensions
{
    public static class MyLINQExtensions
    {
        // This is a chainable LINQ extension method
        public static IEnumerable<T> ProcessSequence<T>(this IEnumerable<T> sequence)
        {
            return sequence;
        }
    }
}