using MyShows.Lib.Pages;

namespace MyShows.Lib.Services
{
    public class LoginService
    {
        MainPage MainPage = new MainPage();

        public void LogIn(string login, string pass)
        {
            MainPage.Navigate("https://myshows.me");

            MainPage.LoginLink.Click();

            MainPage.LoginNameInput.SetValue(login);
            MainPage.LoginPassInput.SetValue(pass);
            MainPage.LoginSubmitButton.Click();

        }

        public void PerformAction(string keyword, string value)
        {
            switch (keyword)
            {
                case ("navigate"):
                    MainPage.Navigate(value);
                    break;
                case ("openModal"):
                    MainPage.LoginLink.Click();
                    break;
                case ("setLogin"):
                    MainPage.LoginNameInput.SetValue(value);
                    break;
                case "setPass":
                    MainPage.LoginPassInput.SetValue(value);
                    break;
                case "submit":
                    MainPage.LoginSubmitButton.Click();
                    break;
                case "assert":
                    AssertService.AssetEqual(GetLoginName(), value);
                    break;
            }
        }

        public string GetErrorMessage()
        {
            return MainPage.WrongPassMsg.GetText();
        }

        public string GetLoginName()
        {
            return MainPage.LoginNameOnMainPage.GetText();
        }
    }
}
