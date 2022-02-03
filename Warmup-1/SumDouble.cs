using System;

namespace GitHubSandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test #1 - Two different integer values.");
            Console.WriteLine("Expected: 3\nActual: {0}\n", SumDouble(1, 2));
            Console.WriteLine("Test #2 - Two identical integer values.");
            Console.WriteLine("Expected: 8\nActual: {0}\n", SumDouble(2, 2));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        public static int SumDouble(int a, int b)
        {
            int sum = a + b;

            if(a == b)
            {
                sum = sum * 2;
            }

            return sum;
        }
    }
}

