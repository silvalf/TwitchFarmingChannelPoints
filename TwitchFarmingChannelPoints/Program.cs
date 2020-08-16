using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchFarmingChannelPoints.Management;
using TwitchFarmingChannelPoints.Models;

namespace TwitchFarmingChannelPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new Channel("jonvlogs");
            var monitor = new ChannelMonitor(channel);
            monitor.ConfigureIntervalInteration(TimeSpan.FromSeconds(4));
            monitor.Start();
            monitor.Stop();
            monitor.Cancel();
        }
    }
}
