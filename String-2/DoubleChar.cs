/*
 * Name: Nicholas Raynes
 * Version: 0.0.2
 * Source: https://codingbat.com/prob/p165312
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the DoubleChar method.
    /// </summary>
    public class DoubleCharProgram
    {
        public static void Main(string[] args)
        {
            // Testing 
            Console.WriteLine("Test #1 - DoubleChar('The')\nOutput: {0}\n", DoubleChar("The"));
            Console.WriteLine("Test #2 - DoubleChar('AAbb')\nOutput: {0}\n", DoubleChar("AAbb"));
            Console.WriteLine("Test #3 - DoubleChar('Hi-There')\nOutput: {0}\n", DoubleChar("Hi-There"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Given a string, this method returns a string where for every char in the original, 
        /// there are two chars.
        /// </summary>
        /// <param name="str">The provided string to be evaluated.</param>
        /// <returns>A new string containing double of each char.</returns>
        public static string DoubleChar(string str)
        {
            string result = "";

            for(int i = 0; i < str.Length; i++)
            {
                result += str[i];

                result += str[i];
            }

            return result;
        }
    }
}
