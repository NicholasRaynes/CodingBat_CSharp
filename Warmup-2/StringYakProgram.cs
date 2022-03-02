using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the StringYak method.
    /// </summary>
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
        
        /// <summary>
        /// This method is given a string, and returns a version where all the "yak" are removed, 
        /// but the "a" can be any char. The "yak" strings will not overlap.
        /// </summary>
        /// <param name="input">The provided string to be searched through.</param>
        /// <returns>A new string that consists of the original string characters, excluding "yak".</returns>
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
