using System;

namespace GitHubSandbox
{
    public class StringYakProgram
    {
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
