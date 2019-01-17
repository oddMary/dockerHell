using Framework.Lib.Driver;
using MyShows.Lib.Features;
using MyShows.Lib.Pages;
using MyShows.Lib.Services;
using NUnit.Framework;

namespace Framework
{
    [TestFixture]
    public class Test
    {
        LoginService LoginService = new LoginService();
        MainPage MainPage = new MainPage();

        private readonly string _loginPopUperrorMsg = "Sorry, the user with such username or E-mail does not seem to be registered here.";

        private readonly string _correctLoginName = "deadbyapril";
        private readonly string _correctLoginPass = "belka123";

        private readonly string _incorrectLoginName = "deadbyapril1";
        private readonly string _incorrectLoginPath = "123456";

        [Test]
        public void AnErrorMsgIfIncorrectPassLoginTest()
        {
            LoginService.LogIn(_incorrectLoginName, _incorrectLoginPath);
            AssertService.AssetEqual(LoginService.GetErrorMessage(), _loginPopUperrorMsg);            
        }

        //[Test]
        //public void KDTLoginTest()
        //{
        //    // File path GetFilePath.GetPath(KDTFilePathAdd)
        //    var obj = YamlDeserializer.KDTObjects("D:/study/MyShows/Tests/Resources/KDTCorrectLoginTest.yml");
        //    foreach (var item in obj.Action)
        //    {
        //        LoginService.PerformAction(item.name, item.value);
        //    }
        //}

        [Test]
        public void CorrectLoginTest()
        {
            LoginService.LogIn(_correctLoginName, _correctLoginPass);
            AssertService.AssetEqual(LoginService.GetLoginName(), StringTransform.FirstUpper(_correctLoginName));
        }

        [OneTimeTearDown]
        public void AfterTestSuit()
        {
            Browser.Instanse.StopBrowser();
        }
    }
}
