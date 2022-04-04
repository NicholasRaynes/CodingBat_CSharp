using System;

namespace GitHubSandbox
{
    public class WithoutXProgram
    {
        public static void Main(string[] args)
        {
            // Testing 
            Console.WriteLine("Test #1 - WithoutX('xHix')\nOutput: {0}\n", WithoutX("xHix"));
            Console.WriteLine("Test #2 - WithoutX('xHi')\nOutput: {0}\n", WithoutX("xHi"));
            Console.WriteLine("Test #3 - WithoutX('Hxix')\nOutput: {0}\n", WithoutX("Hxix"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Given a string, if the first or last chars are 'x', this method returns the string without those 
        /// 'x' chars, and otherwise return the string unchanged.
        /// </summary>
        /// <param name="str">The provided string.</param>
        /// <returns>The evaluated version of the provided string.</returns>
        public static String WithoutX(String str)
        {
           if(str.Length > 0 && str[0] == 'x')
            {
                str = str.Substring(1);
            }

            if(str.Length > 0 && str[str.Length - 1] == 'x')
            {
                str = str.Substring(0, str.Length - 1);
            }

            return str;
        }
    }
}
