/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://codingbat.com/prob/p199720
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// This class includes the declaration and implementation
    /// of the StartOz method.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Given a string, return a string made of the first 2 chars (if present), however 
        /// include first char only if it is 'o' and include the second only if it is 'z', so 
        /// "ozymandias" yields "oz".
        /// </summary>
        /// <param name="str">Provided string to search through</param>
        /// <returns>A string containing the letter(s) "o" or "z" from the provided string, if any.</returns>
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
