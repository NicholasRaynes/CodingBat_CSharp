using System;

namespace GitHubSandbox
{
    internal class Program
    {
        public string StartOz(string str)
        {
            string result = "";

            if (str.Length >= 1 && str[0] == 'o')
            {
                result += str[0];
            }

            if (str.Length >= 2 && str[1] == 'z')
            {
                result += str[1];
            }

            return result;
        }
    }
}
