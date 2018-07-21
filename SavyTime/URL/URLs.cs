using OpenQA.Selenium;
using SavyTime.Configuration;
using SavyTime.Pages;

namespace PetCareTests.URL
{
    class URLs
    {
        public static LandingPage OpenUrl(IWebDriver driver)
        {
<<<<<<< HEAD
            driver.Navigate().GoToUrl(Config.GetURL("SavyTimeURL"));
=======
			var url = Config.GetURL("SavytimeURL");
			Logger.Log.Info("Openning URL " + url);
			driver.Navigate().GoToUrl(url);
>>>>>>> 7ac0a468b8b2306708936f1be62b6ed5c3051881
            return new LandingPage(driver);
        }
    }
}
