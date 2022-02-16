namespace GitHubSandbox
{
    public class Diff21Program
    {
        public static int Diff21(int number)
        {
            if (number <= 21)
            {
                return 21 - number;
            }
            else
            {
                return (number - 21) * 2;
            }
        }
    }
}
