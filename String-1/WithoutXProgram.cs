using System;

namespace GitHubSandbox
{
    public class WithoutXProgram
    {
        public static String WithoutX(String str)
        {
           if(str.Length > 0 && str[0] == 'x')
            {
                str = str.Substring(1);
            }

            if(str.Length > 0 && str[str.Length - 1] == 'x')
            {
                str = str.Substring(0, str.Length - 1);
            }

            return str;
        }
    }
}
