using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwitchFarmingChannelPoints.Helpers;
using TwitchFarmingChannelPoints.Models;

namespace TwitchFarmingChannelPoints.Management
{
    public class ChannelMonitor
    {
        private readonly Channel Channel;
        private Thread _threadMonitor;

        /// <summary>
        /// Define o tempo de interação com o canal
        /// </summary>
        public TimeSpan TimerInteration { get; private set; } = TimeSpan.FromSeconds(4);//Default

        internal void Cancel()
        {
            throw new NotImplementedException();
        }

        internal void Stop()
        {
            //if (ThreadHelper.ThreadCurrent.pau)
            //{
            //}
            // concluir fase de pause do monitor...
        }

        public IWebDriver Driver { get; private set; }

        public ChannelMonitor(Channel channel)
        {
            this.Channel = channel;
        }

        public void Start()
        {
            ThreadHelper.InvokeThread(StartAsync);
        }

        private void StartAsync()
        {
            ConfigureDriver(Driver);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Driver.Navigate().GoToUrl("https://www.twitch.tv/jonvlogs");
        }

        internal void ConfigureIntervalInteration(TimeSpan timeSpan)
        {
            this.TimerInteration = timeSpan;
        }
        private void ConfigureDriver(IWebDriver driver)
        {
            var pathChrome = GetRelativePathExecutableAddon();
            driver = new FirefoxDriver(pathChrome);
        }

        private string GetRelativePathExecutableAddon()
        {
            string pathFull = AppDomain.CurrentDomain.BaseDirectory;
            string pathAddon = pathFull.Replace(@"bin\Debug", "Addon");
            return pathAddon;
        }

        ~ChannelMonitor()
        {
            foreach (var process in Process.GetProcessesByName("geckodriver"))
            {
                process.Kill();
            }
        }
    }
}