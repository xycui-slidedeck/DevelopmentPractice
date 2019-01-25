using System;
using System.Linq;

namespace ComputeLib.ConsoleHost
{
    class Program
    {
        private static INumCompute _numCompute = new NumCompute();

        static void Main(string[] args)
        {
            while (args.Length == 0)
            {
                Console.WriteLine("input nums");
                args = Console.ReadLine().Split(",");
            }

            var num = _numCompute.ComputeAdd(args.Select(x => int.Parse(x)).ToArray());
            Console.WriteLine(num);
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
