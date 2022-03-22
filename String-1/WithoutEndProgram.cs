using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the WithoutEnd method.
    /// </summary>
    public class WithoutEndProgram
    {
        public static void Main(string[] args)
        {
            // Testing 
            Console.WriteLine("Test #1 - WithoutEnd('Hello')\nOutput: {0}\n", WithoutEnd("Hello"));
            Console.WriteLine("Test #2 - WithoutEnd('java')\nOutput: {0}\n", WithoutEnd("java"));
            Console.WriteLine("Test #3 - WithoutEnd('coding')\nOutput: {0}\n", WithoutEnd("coding"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        public static string WithoutEnd(string str)
        {
            string output = "";

            if (str.Length > 2)
            {
                output = str.Substring(1, str.Length - 1);
            }

            return output;
        }
    }
}
