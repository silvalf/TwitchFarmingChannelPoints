using OpenQA.Selenium;
using TwitchFarmingChannelPoints.Models;

namespace TwitchFarmingChannelPoints.Controller
{
    public class ChannelController
    {
        public int PointsCollected { get; set; }
        private string xPathChannelOffilneOrNotExists = @"//*[@id='root']/div/div[2]/div/main/div[1]/div[3]/div/div/div/div[1]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div[2]/h2";
        private string xPathButtonColletPoints = @"/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/div/div/div/section/div/div[5]/div[2]/div[2]/div[1]/div/div/div/div[2]/div/div/div/button";
        private string xPathButtonTotalPoints = @"/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/div/div/div/section/div/div[5]/div[2]/div[2]/div[1]/div/div/div/div[1]/div[2]/button";
        private string xPathWithGetPoints = @"/html/body/div[1]/div/div[2]/div/div[2]/div/div[1]/div/div/div/div/div/section/div/div[5]/div[2]/div[2]/div[1]/div/div/div[2]/div/div/div/div/div/div/div[2]/div[3]/div/div/div/div/div[7]/button";

        public Channel Channel { get; private set; }
        private IWebDriver _driver;
        public ChannelController(IWebDriver driver)
        {
            _driver = driver;
        }

        public void InitializeChennel(string channelNamc)
        {
        }

        public bool IsChannelExisits(string channelName)
        {
            return GetChannel(channelName) != null;
        }

        public Channel GetChannel(string channelName)
        {
            return null;
        }

        public bool ColletPoints()
        {
            var button = _driver.FindElement(By.XPath(xPathButtonColletPoints));
            if (button != null)
            {
                button.Click();
                PointsCollected += 60;
                return true;
            }
            return false;
        }
    }
}
