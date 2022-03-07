using System;

namespace GitHubSandbox
{
    public class ParrotTroubleProgram
    {
        public static bool ParrotTrouble(bool isTalking, int hour)
        {
            return (isTalking && (hour < 7 || hour > 20));
        }
    }
}
