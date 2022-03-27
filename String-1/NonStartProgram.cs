using System;

namespace GitHubSandbox
{
    public class NonStartProgram
    {
        public static string NonStart(string a, string b)
        {
            string output = "";

            a = a.Substring(1);
            b = b.Substring(1);

            output = a + b;

            return output;
        }
    }
}
