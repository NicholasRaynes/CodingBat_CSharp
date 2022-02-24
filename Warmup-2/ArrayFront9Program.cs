/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://codingbat.com/prob/p186031
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// The program includes the declaration, implementation,
    /// and testing for the ArrayFront9 method.
    /// </summary>
    public class ArrayFront9Program
    {
	public static void Main(string[] args)
        {
            // Testing 
            int[] test1 = { 1, 2, 9, 3, 4 };
            int[] test2 = { 1, 2, 3, 4, 9 };
            int[] test3 = { 1, 2, 3, 4, 5 };

       	    Console.WriteLine("Test #1 - ArrayFront9([1, 2, 9, 3, 4])\nOutput: {0}\n", ArrayFront9(test1));
            Console.WriteLine("Test #2 - ArrayFront9([1, 2, 3, 4, 9])\nOutput: {0}\n", ArrayFront9(test2));
            Console.WriteLine("Test #3 - ArrayFront9([1, 2, 3, 4, 5])\nOutput: {0}\n", ArrayFront9(test3));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
	    
	/// <summary>
        /// This method is given an array of ints, and returns true if one of the first 4 elements in the array 
        /// is a 9. The array length may be less than 4.
        /// </summary>
        /// <param name="nums">The provided array of integers.</param>
        /// <returns>Whether or not one of the first 4 elements in the array is a 9.</returns>
        public static bool ArrayFront9(int[] nums)
        {
            int arrayEnd = nums.Length;

            if (arrayEnd > 4)
            {
                arrayEnd = 4;
            }

            for (int i = 0; i < arrayEnd; i++)
            {
                if (nums[i] == 9)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
