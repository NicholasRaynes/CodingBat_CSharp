using System;

namespace GitHubSandbox
{
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
