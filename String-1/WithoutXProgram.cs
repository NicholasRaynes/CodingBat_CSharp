using System;

namespace GitHubSandbox
{
    public class WithoutXProgram
    {
        public static String WithoutX(String str)
        {
            if(str.Length == 0)
            {
                return str;
            }
            
            if(str.Length == 1)
            {
                if(str[0] == 'x')
                {
                    return "";
                }
                else
                {
                    return str;
                }
            }

            if(str[0] == 'x')
            {
                str = str.Substring(1, str.Length);
            }

            if(str[str.Length - 1] == 'x')
            {
                str = str.Substring(0, str.Length - 1);
            }

            return str;
        }
    }
}
