/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://codingbat.com/prob/p154485
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the SumDouble method.
    /// </summary>
    class SumDoubleProgram
    {
        static void Main(string[] args)
        {
            // Testing
            Console.WriteLine("Test #1 - Two different integer values.");
            Console.WriteLine("Expected: 3\nActual: {0}\n", SumDouble(1, 2));
            Console.WriteLine("Test #2 - Two identical integer values.");
            Console.WriteLine("Expected: 8\nActual: {0}\n", SumDouble(2, 2));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Given two int values, return their sum. Unless the two values 
        /// are the same, then return double their sum.
        /// </summary>
        /// <param name="a">The first integer value.</param>
        /// <param name="b">The second integer value.</param>
        /// <returns>The sum of the two integers, or the double of the sum 
        /// of the two integers</returns>
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
