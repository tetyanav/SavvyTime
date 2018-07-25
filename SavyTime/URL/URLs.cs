using OpenQA.Selenium;
using SavvyTime.Configuration;
using SavvyTime.Pages;
using SavvyTime.Configuration;
using dnk.log2html.Support;
using dnk.log2html;
using log4net.Repository.Hierarchy;

namespace SavvyTime.URL
{
    class URLs
    {
        public static LandingPage OpenUrl(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(Config.GetURL("SavvyTimeURL"));

			var url = Config.GetURL("SavvytimeURL");
			Logger.Log.Info("Openning URL " + url);
			driver.Navigate().GoToUrl(url);
            return new LandingPage(driver);
        }
    }
}
