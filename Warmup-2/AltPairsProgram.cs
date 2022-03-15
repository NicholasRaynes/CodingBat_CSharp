using System;

namespace GitHubSandbox
{
	public class AltPairsProgram
  {
        public static string AltPairs(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i += 4)
            {
                int end = i + 2;

                if (end > input.Length)
                {
                    end = input.Length;
                }

                output = output + input.Substring(i, end);
            }

            return output;
        }
  }
}
