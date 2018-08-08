using dnk.log2html.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using SavvyTime.Selenium;
using SavvyTime.URL;
using SavvyTime.Verification;
using System;

namespace SavyTime.Tests
{
    [TestFixture]
    public class KievTimeTests
    {
        [Test]
        public void KievlTime_Test()
        {
            IWebDriver driver = DriverUtils.CreateDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            TestWrapper.Test(driver, () =>
            {
                // Open Landing Page
                var landingPage = URLs.OpenUrl(driver);

                //Open Local Time Page
                var localTimePage = landingPage.ClickLocalTimeItem();

                string input = "Kiev";
                
                //Find Kiev  using the Search field???
                localTimePage.FillOutSearchField(input);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                var KievPage = localTimePage.ClickKievUkraineQuery();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                //Verify the time displayed in the search results is correct one
                DateTime kievTime = DateTime.UtcNow.AddHours(3);
                var kievTimeString = kievTime.ToLongTimeString();
                var appKievTimeString = KievPage.GetAppKievTime();
                kievTimeString.ShouldBe(appKievTimeString, "Local Kiev Time");

                //Verify the breadcrumbs say Home / Local Time / Ukraine / Kiev
                var breadcrumbs = KievPage.GetBreadcrumbsText();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                breadcrumbs.ShouldBe("Home Local Time Ukraine Kiev", "Breadcrumbs");

                // Verify Kiev-specific elements on the page
                var currentLocalTimeHeader = KievPage.CurrentLocalTimeHeader.Text;
                currentLocalTimeHeader.ShouldBe("Current local time in Kiev, Ukraine", "Container Header");

                var convertTimeHeader = KievPage.ConvertTimeHeader.Text;
                convertTimeHeader.ShouldBe("Convert Kiev Time", "Convert Kiev Time Header");

                var kievInformationHeader = KievPage.KievInformationHeader.Text;
                kievInformationHeader.ShouldBe("Kiev Information", "Kiev Information Header");

                var kievFactsHeader = KievPage.KievFactsHeader.Text;
                kievFactsHeader.ShouldBe("Kiev Facts", "Kiev Facts Header");

                var countryName = KievPage.CountryName.Text;
                countryName.ShouldBe("Ukraine", "Country Name");

                var currencyName = KievPage.CurrencyName.Text;
                currencyName.ShouldBe("Hryvnia (UAH)", "Currency Name");

                var timeZoneName = KievPage.TimeZoneName.Text;
                timeZoneName.ShouldBe("(EEST)", "Time Zone Name");
                                
            });
        }
    }
}
