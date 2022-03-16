using System;

namespace GitHubSandbox
{
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
