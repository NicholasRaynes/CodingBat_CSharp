using System;

namespace GitHubSandbox
{
    public class StringYakProgram
    {
        public static void Main(string[] args)
        {
            // Testing 
            Console.WriteLine("Test #1 - StringYak('yakpak')\nOutput: {0}\n", StringYak("yakpak"));
            Console.WriteLine("Test #2 - StringYak('pakyak')\nOutput: {0}\n", StringYak("pakyak"));
            Console.WriteLine("Test #3 - StringYak('yak123ya')\nOutput: {0}\n", StringYak("yak123ya"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        public static string StringYak(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i + 2 < input.Length && input[i] == 'y' && input[i + 2] == 'k')
                {
                    i = i + 2;
                }
                else
                {
                    output += input[i];
                }
            }

            return output;
        }
    }
}
