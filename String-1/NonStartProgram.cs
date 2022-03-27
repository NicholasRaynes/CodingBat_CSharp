using System;

namespace GitHubSandbox
{
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
