using System;

namespace GitHubSandbox
{
    public class WithoutEndProgram
    {
        public static string WithoutEnd(string str)
        {
            String output = "";

            if (str.Length > 2)
            {
                output = str.Substring(1, str.Length - 1);
            }

            return output;
        }
    }
}
