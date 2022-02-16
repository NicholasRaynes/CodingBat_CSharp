/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://codingbat.com/prob/p116624
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// This class includes the declaration, implementation,
    /// and testing for the Diff21 method.
    /// </summary>
    public class Diff21Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test #1 - Diff21(19)\nOutput: {0}\n", Diff21(19));
            Console.WriteLine("Test #2 - Diff21(10)\nOutput: {0}\n", Diff21(10));
            Console.WriteLine("Test #3 - Diff21(21)\nOutput: {0}\n", Diff21(21));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Given an int, return the absolute difference between the integer and 21, except 
        /// return double the absolute difference if the integer is over 21.
        /// </summary>
        /// <param name="number">The integer input for determining the difference.</param>
        /// <returns>The absolute difference between the integer and 21, or double the absolute 
        /// difference if the integer is greater than 21.</returns>
        public static int Diff21(int number)
        {
            if (number <= 21)
            {
                return 21 - number;
            }
            else
            {
                return (number - 21) * 2;
            }
        }
    }
}
