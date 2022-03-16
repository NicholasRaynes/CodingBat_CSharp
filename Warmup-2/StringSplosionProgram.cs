using System;

namespace GitHubSandbox
{
    public class StringSplosionProgram
    {
        public string StringSplosion(string input)
        {
            String result = "";

            for (int i = 0; i < input.Length; i++)
            {
                result += input.Substring(0, i + 1);
            }
            return result;
        }
    }
}
