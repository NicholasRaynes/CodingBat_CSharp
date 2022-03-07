using System;

namespace GitHubSandbox
{
    public class ParrotTroubleProgram
    {
        static void Main(string[] args)
        {
            // Testing
            Console.WriteLine("Test #1 - ParrotTrouble(true, 6)\nOutput: {0}\n", ParrotTrouble(true, 6));
            Console.WriteLine("Test #2 - ParrotTrouble(true, 7)\nOutput: {0}\n", ParrotTrouble(true, 7));
            Console.WriteLine("Test #3 - ParrotTrouble(false, 6)\nOutput: {0}\n", ParrotTrouble(false, 6));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        public static bool ParrotTrouble(bool isTalking, int hour)
        {
            return (isTalking && (hour < 7 || hour > 20));
        }
    }
}
