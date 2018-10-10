using static System.Console;
using System.Linq;
using System.Reflection;

namespace Ch02_Basics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Loop through the assemblies that this application references
            foreach (var referencedAssembly in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
            {
                // Load the assembly so we can read its details
                var assembly = Assembly.Load(referencedAssembly.FullName);

                // Declare and set a variable to count the total number of methods
                var methodCount = 0;

                // Loop through all the types in the assembly
                foreach (var type in assembly.DefinedTypes)
                {
                    // Add up the counts of the methods
                    methodCount += type.GetMethods().Length;
                }

                // Output the count of types and their methods
                WriteLine($"{assembly.DefinedTypes.ToList().Count} types with {methodCount} methods in {referencedAssembly.Name} assembly.");
            }

            ReadLine();
        }

        private void SpecialTypes()
        {
            // Object
            object name = "Juan";

            // Cast to access members
            var length = ((string)name).Length;
        }
    }
}