using Framework.Lib.Driver;
using MyShows.Lib.Element;
using OpenQA.Selenium;

namespace MyShows.Lib.Pages
{
    public class MainPage
    {
        private static readonly string _loginLinkXPathLocator = ".//a[@class='linkInlineBlock modal_login']";
        private static readonly string _loginNameInputXPathLocator = ".//input[@id='ajax_login_login']";
        private static readonly string _loginPassInputXPathLocator = ".//input[@id='ajax_login_password']";
        private static readonly string _loginSubmitButtonInputXPathLocator = ".//button[@id='ajax_login']";

        private static readonly string _loginNameOnMainPageXPathLocator = ".//div[@class='headerUser']/div/span";

        private static readonly string _wrongPassMsgXPathLocator = ".//div[@class='loginPopupTabsBody _active']//span[@class ='loginPopupError']/span";

        public WebElement LoginLink = new WebElement(By.XPath(_loginLinkXPathLocator));
        public WebElement LoginNameInput = new WebElement(By.XPath(_loginNameInputXPathLocator));
        public WebElement LoginPassInput = new WebElement(By.XPath(_loginPassInputXPathLocator));
        public WebElement LoginSubmitButton = new WebElement(By.XPath(_loginSubmitButtonInputXPathLocator));

        public WebElement LoginNameOnMainPage = new WebElement(By.XPath(_loginNameOnMainPageXPathLocator));

        public WebElement WrongPassMsg = new WebElement(By.XPath(_wrongPassMsgXPathLocator));

        public void Navigate(string url)
        {
            Browser.Instanse.WebDriver.Navigate().GoToUrl(url);
        }
    }
}
