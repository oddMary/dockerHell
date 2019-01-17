using NUnit.Framework;

namespace MyShows.Lib.Services
{
    public class AssertService
    {
        public static void AssetEqual(string actualMsg, string expectedMsg)
        {
            Assert.That(actualMsg, Is.EqualTo(expectedMsg));
        }
    }
}
