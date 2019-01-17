using Framework.Lib.Driver;
using MyShows.Lib.Features;
using MyShows.Lib.Pages;
using MyShows.Lib.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing;

namespace Framework
{
    [TestFixture]
    public class Test
    {
        public IWebDriver WebDriver;

        public void SetUp()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.PlatformName = "linux";

            //WebDriver = new ChromeDriver("D:\\study\\MyShows\\resources");
            WebDriver = new RemoteWebDriver(new Uri("http://l192.168.0.104:4444/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(120));
            WebDriver.Manage().Window.Size = new Size(1920, 1080);
        }

        [Test]
        public void Logintest()
        {
            WebDriver.Navigate().GoToUrl("https://myshows.me");
            WebDriver.FindElement(By.XPath(".//a[@class='linkInlineBlock modal_login']")).Click();
            WebDriver.FindElement(By.XPath(".//input[@id='ajax_login_login']")).SendKeys("deadbyapril");
            WebDriver.FindElement(By.XPath(".//input[@id='ajax_login_password']")).SendKeys("belka123");
            WebDriver.FindElement(By.XPath(".//button[@id='ajax_login']")).Click();

            string name = WebDriver.FindElement(By.XPath(".//a[@class='linkInlineBlock modal_login']")).Text;

            Assert.That(name, Is.EqualTo("Deadbyapril"));
        }

        //LoginService LoginService = new LoginService();
        //MainPage MainPage = new MainPage();

        //private readonly string _loginPopUperrorMsg = "Sorry, the user with such username or E-mail does not seem to be registered here.";

        //private readonly string _correctLoginName = "deadbyapril";
        //private readonly string _correctLoginPass = "belka123";

        //private readonly string _incorrectLoginName = "deadbyapril1";
        //private readonly string _incorrectLoginPath = "123456";

        //[Test]
        //public void AnErrorMsgIfIncorrectPassLoginTest()
        //{
        //    LoginService.LogIn(_incorrectLoginName, _incorrectLoginPath);
        //    AssertService.AssetEqual(LoginService.GetErrorMessage(), _loginPopUperrorMsg);            
        //}

        ////[Test]
        ////public void KDTLoginTest()
        ////{
        ////    // File path GetFilePath.GetPath(KDTFilePathAdd)
        ////    var obj = YamlDeserializer.KDTObjects("D:/study/MyShows/Tests/Resources/KDTCorrectLoginTest.yml");
        ////    foreach (var item in obj.Action)
        ////    {
        ////        LoginService.PerformAction(item.name, item.value);
        ////    }
        ////}

        //[Test]
        //public void CorrectLoginTest()
        //{
        //    LoginService.LogIn(_correctLoginName, _correctLoginPass);
        //    AssertService.AssetEqual(LoginService.GetLoginName(), StringTransform.FirstUpper(_correctLoginName));
        //}

        //[OneTimeTearDown]
        //public void AfterTestSuit()
        //{
        //    Browser.Instanse.StopBrowser();
        //}


    }
}
