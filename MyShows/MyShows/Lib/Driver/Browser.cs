using MyShows.Lib.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing;

namespace Framework.Lib.Driver
{
    public class Browser
    {
        private static Browser _instanse;
        public readonly IWebDriver WebDriver;

        private Wait wait = new Wait();

        public static Browser Instanse
        {
            get
            {
                if (_instanse is null)
                {
                    _instanse = new Browser();
                }
                return _instanse;
            }
        }

        private Browser()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.PlatformName = "linux";

            //WebDriver = new ChromeDriver("D:\\study\\MyShows\\resources");
            WebDriver = new RemoteWebDriver(new Uri("http://l192.168.0.104:4444/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(120));
            WebDriver.Manage().Window.Size = new Size(1920, 1080);
        }

        public IWebElement FindWebElement(By by)
        {
            wait.IsElementPresents(by, TimeSpan.FromMilliseconds(10000));
            return WebDriver.FindElement(by);
        }

        public void Navigate(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public void StopBrowser()
        {
            WebDriver.Quit();
        }
    }
}
