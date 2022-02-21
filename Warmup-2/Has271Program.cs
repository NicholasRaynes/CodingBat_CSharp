namespace GitHubSandbox 
{
  public class Has271Program 
  {
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
