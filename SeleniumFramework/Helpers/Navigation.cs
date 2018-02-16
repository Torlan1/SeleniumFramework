using SeleniumFramework.Settings;
using SeleniumFramework.Core;

namespace SeleniumFramework.Helpers
{
    public class Navigation : TestBase
    {
        Config config = new Config();

        public void GoToBaseUrl(string extension = "")
        {
            LaunchBrowser(Browser.Chrome);
            OpenPage(config.GetBaseUrl() + extension);
        }
    }
}
