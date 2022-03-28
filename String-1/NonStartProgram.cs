using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the NonStart method.
    /// </summary>
    public class NonStartProgram
    {
        public static void Main(string[] args)
        {
            // Testing 
            Console.WriteLine("Test #1 - NonStart('Hello', 'There')\nOutput: {0}\n", NonStart("Hello", "There"));
            Console.WriteLine("Test #2 - NonStart('java', 'code')\nOutput: {0}\n", NonStart("java", "code"));
            Console.WriteLine("Test #3 - NonStart('shotl', 'java')\nOutput: {0}\n", NonStart("shotl", "java"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Given 2 strings, this method returns their concatenation, except omit the first char of each. 
        /// The strings will be at least length 1.
        /// </summary>
        /// <param name="a">The first provided string.</param>
        /// <param name="b">The second provided string.</param>
        /// <returns>The concatenation of the strings, without the first char of each.</returns>
        public static string NonStart(string a, string b)
        {
            string output = "";

            a = a.Substring(1);
            b = b.Substring(1);

            output = a + b;

            return output;
        }
    }
}
