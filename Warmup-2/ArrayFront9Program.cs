using System;

namespace GitHubSandbox
{
	public class ArrayFront9Program
    {
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
