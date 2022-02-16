using System;

namespace GitHubSandbox
{
    public class Diff21Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test #1 - Diff21(19)\nOutput: {0}\n", Diff21(19));
            Console.WriteLine("Test #2 - Diff21(10)\nOutput: {0}\n", Diff21(10));
            Console.WriteLine("Test #3 - Diff21(21)\nOutput: {0}\n", Diff21(21));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        public static int Diff21(int number)
        {
            if (number <= 21)
            {
                return 21 - number;
            }
            else
            {
                return (number - 21) * 2;
            }
        }
    }
}
