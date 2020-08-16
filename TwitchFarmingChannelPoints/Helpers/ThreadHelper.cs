using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitchFarmingChannelPoints.Helpers
{
    public static class ThreadHelper
    {
        public static Thread ThreadCurrent { get; private set; }

        public static void InvokeThread(Action action)
        {
            ThreadCurrent = new Thread(new ThreadStart(action));
        }

        public static void Abort()
        {
            if (ThreadCurrent !=null)
            {
                ThreadCurrent.Abort();
            }
        }
    }
}
