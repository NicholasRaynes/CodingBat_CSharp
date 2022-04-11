using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the BobThere method.
    /// </summary>
    public class BobThereProgram
    {
        public static void Main(string[] args)
        {
            // Testing 
            Console.WriteLine("Test #1 - BobThere('abcbob')\nOutput: {0}\n", BobThere("abcbob"));
            Console.WriteLine("Test #2 - BobThere('b9b')\nOutput: {0}\n", BobThere("b9b"));
            Console.WriteLine("Test #3 - BobThere('bac')\nOutput: {0}\n", BobThere("bac"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method returns true if the given string contains a "bob" string, 
        /// but where the middle 'o' char can be any char.
        /// </summary>
        /// <param name="str">The provided string to be evaluated.</param>
        /// <returns>Whether or not the given string contains a "bob" string, but where the 
        /// middle 'o' can be any char.</returns>
        public static bool BobThere(String str)
        {
            int length = str.Length;
     
            for (int i = 0; i < length - 2; i++)
            {
                if (str[i] == 'b' && str[i + 2] == 'b')
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
