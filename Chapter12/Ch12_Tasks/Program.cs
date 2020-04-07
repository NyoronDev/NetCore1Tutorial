using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch12_Tasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            //Console.WriteLine("Running methods synchronously on multiple threads.");

            //var taskA = new Task(MethodA);
            //taskA.Start();
            //var taskB = Task.Factory.StartNew(MethodB);
            //var taskC = Task.Run(new Action(MethodC));

            //Task[] tasks = { taskA, taskB, taskC };
            //Task.WaitAll(tasks);

            //Console.WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");

            Console.WriteLine("Passing the result of one task as an input into another.");

            var taskCallWebServiceAndThenStoredProcedure = Task.Factory.StartNew(CallWebService).ContinueWith(previousTask => CallStoredProcedure(previousTask.Result));

            Console.WriteLine($"{taskCallWebServiceAndThenStoredProcedure.Result}");

            Console.ReadLine();
        }

        private static void MethodA()
        {
            Console.WriteLine("Starting Method A...");
            Thread.Sleep(3000); // Simulate 3 seconds of work
            Console.WriteLine("Finished Method A.");
        }

        private static void MethodB()
        {
            Console.WriteLine("Starting Method B...");
            Thread.Sleep(2000); // Simulate 2 seconds of work
            Console.WriteLine("Finished Method B.");
        }

        private static void MethodC()
        {
            Console.WriteLine("Starting Method C...");
            Thread.Sleep(1000); // Simulate 1 seconds of work
            Console.WriteLine("Finished Method C.");
        }

        private static decimal CallWebService()
        {
            Console.WriteLine("Starting call to web service...");
            Thread.Sleep(new Random().Next(2000, 4000));
            Console.WriteLine("Finished call to web service");
            return 89.99M;
        }

        private static string CallStoredProcedure(decimal amount)
        {
            Console.WriteLine("Starting call to stored procedure...");
            Thread.Sleep(new Random().Next(2000, 4000));
            Console.WriteLine("Finished call to stored procedure");
            return $"12 products cost more than {amount:C}";
        }
    }
}