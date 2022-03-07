using System;

namespace GitHubSandbox
{
    public class ParrotTroubleProgram
    {
        public bool parrotTrouble(bool isTalking, int hour)
        {
            return (isTalking && (hour < 7 || hour > 20));
        }
    }
}
