/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://codingbat.com/prob/p117334
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the StringSplosion method.
    /// </summary>
    public class StringSplosionProgram
    {
        public static void Main(string[] args)
        {
            // Testing 
            Console.WriteLine("Test #1 - StringSplosion('Code')\nOutput: {0}\n", StringSplosion("Code"));
            Console.WriteLine("Test #2 - StringSplosion('abc')\nOutput: {0}\n", StringSplosion("abc"));
            Console.WriteLine("Test #3 - StringSplosion('Hello')\nOutput: {0}\n", StringSplosion("Hello"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method is given a non-empty string like "Code", and returns a string like "CCoCodCode".
        /// </summary>
        /// <param name="input">The provided non-empty string.</param>
        /// <returns>The exploded string.</returns>
        public static string StringSplosion(string input)
        {
            String result = "";

            for (int i = 0; i < input.Length; i++)
            {
                result += input.Substring(0, i + 1);
            }
            return result;
        }
    }
}
