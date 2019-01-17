using Framework.Lib.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MyShows.Lib.Driver
{
    class Wait
    {
        public void IsElementPresents(By by, TimeSpan timeout)
        {
            new WebDriverWait(Browser.Instanse.WebDriver, timeout).Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
