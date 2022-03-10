/*
 * Name: Nicholas Raynes
 * Version: 0.0.2
 * Source: https://codingbat.com/prob/p140449
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the ParrotTrouble method.
    /// </summary>
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
        
        /// <summary>
        /// The "hour" parameter is the current hour time in the range 0..23. We are 
        /// in trouble if the parrot is talking and the hour is before 7 or after 20. This method returns whether
        /// or not we are in trouble.
        /// </summary>
        /// <param name="isTalking">Whether or not the parrot is talking.</param>
        /// <param name="hour">The hour of a day.</param>
        /// <returns></returns>
        public static bool ParrotTrouble(bool isTalking, int hour)
        {
            return (isTalking && (hour < 7 || hour > 20));
        }
    }
}
