using System;

namespace GitHubSandbox
{
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
