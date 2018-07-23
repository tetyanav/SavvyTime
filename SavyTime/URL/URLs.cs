using OpenQA.Selenium;
using SavvyTime.Configuration;
using SavvyTime.Pages;

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
