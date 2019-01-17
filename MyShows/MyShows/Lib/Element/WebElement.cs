using Framework.Lib.Driver;
using OpenQA.Selenium;

namespace MyShows.Lib.Element
{
    public class WebElement
    {
        public By Selector;

        public WebElement(By selector)
        {
            Selector = selector;
        }

        public IWebElement Element => Browser.Instanse.FindWebElement(Selector);

        public void Click()
        {
            Element.Click();
        }

        public void SetValue(string value)
        {
            Element.SendKeys(value);
        }

        public string GetText()
        {
            return Element.Text;
        }
    }
}
