/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://codingbat.com/prob/p111624
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the CatDog method.
    /// </summary>
    public class CatDogProgram
    {
        public static bool CatDog(string str)
        {
            int len = str.Length;
            int cat = 0;
            int dog = 0;

            for (int i = 0; i < len - 2; i++)
            {
                string temp = str.Substring(i, 3);

                if (temp.CompareTo("cat") == 0)
                {
                    cat++;
                }
                if (temp.CompareTo("dog") == 0)
                {
                    dog++;
                }
            }

            if (cat == dog)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
