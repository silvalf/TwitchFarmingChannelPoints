using System;
using System.Diagnostics;

namespace TwitchFarmingChannelPoints.Models
{
    public class Channel
    {
        private Stopwatch _stopwatch;
        private TimeSpan _timeSpan;
        public TimeSpan TimeElapsed
        {
            get
            {
                if (_timeSpan != null && _stopwatch != null)
                {
                    return _stopwatch.Elapsed;
                }
                return new TimeSpan(0);
            }
        }
        public string ChannelName { get; set; }
        public Channel(string channelName)
        {
            this.ChannelName = channelName;
        }
        public void InitUptime()
        {
            _stopwatch = new Stopwatch();
            Start();
        }

        public void Start()
        {
            if (_stopwatch != null)
                _stopwatch.Start();
        }

        private void StopUptime()
        {
            if (_stopwatch != null)
                _stopwatch.Stop();
        }
    }
}
