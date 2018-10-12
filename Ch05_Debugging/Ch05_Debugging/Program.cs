using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05_Debugging
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Debug.WriteLine("Hello debug");
            Trace.WriteLine("Hello trace");
        }
    }
}