namespace GitHubSandbox 
{
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
