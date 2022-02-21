/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://codingbat.com/prob/p167430
 */

using System;

namespace GitHubSandbox 
{
  /// <summary>
  /// The program includes the declaration, implementation,
  /// and testing for the Has271 method.
  /// </summary>
  public class Has271Program 
  {
    public static void Main(string[] args)
    {
      // Testing 
      int[] test1 = { 1, 2, 7, 1 };
      int[] test2 = { 1, 2, 8, 1 };
      int[] test3 = { 2, 7, 1 };

      Console.WriteLine("Test #1 - Has271([1, 2, 7, 1])\nOutput: {0}\n", Has271(test1));
      Console.WriteLine("Test #2 - Has271([1, 2, 8, 1])\nOutput: {0}\n", Has271(test2));
      Console.WriteLine("Test #3 - Has271([2, 7, 1])\nOutput: {0}\n", Has271(test3));

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
    
    /// <summary>
    /// Given an array of ints, return true if it contains a 2, 7, 1 pattern: a value, followed by the 
    /// value plus 5, followed by the value minus 1. Additionally the 271 counts even if the "1" differs 
    /// by 2 or less from the correct value.
    /// </summary>
    /// <param name="nums">The array of integers to be searched through.</param>
    /// <returns>Whether or not the provided array contains a 2, 7, 1 pattern.</returns>
    public static bool Has271(int[] nums) 
    {
      for (int i = 0; i < (nums.Length - 2); i++) 
      {
        int val = nums[i];

        if (nums[i + 1] == (val + 5) && Math.Abs(nums[i + 2] - (val - 1)) <= 2) 
        {
          return true;
        }
      }

      return false;
    }
  }
}
