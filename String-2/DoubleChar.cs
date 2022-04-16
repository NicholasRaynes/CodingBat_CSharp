using System;

namespace GitHubSandbox
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
    
    public class DoubleCharProgram
    {
        public static string DoubleChar(string str)
        {
            string love = "";

            for(int i = 0; i < str.Length; i++)
            {
                love += str[i];

                love += str[i];
            }

            return love;
        }
    }
}
