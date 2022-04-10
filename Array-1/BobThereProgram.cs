using System;

namespace GitHubSandbox
{
    public class BobThereProgram
    {
        public static bool BobThere(String str)
        {
            int length = str.Length;
     
            for (int i = 0; i < length - 2; i++)
            {
                if (str[i] == 'b' && str[i + 2] == 'b')
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
