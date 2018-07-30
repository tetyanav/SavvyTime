using dnk.log2html.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using SavvyTime.Selenium;
using SavvyTime.URL;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                //Verify the breadcrumbs say Home / Local Time / Ukraine / Kiev
                var breadcrumbs = KievPage.Breadcrumbs.Text;
                breadcrumbs.ShouldBe("Home / Local Time / Ukraine / Kiev");

                // Verify Kiev-specific elements on the page
                var currentLocalTimeHeader = KievPage.CurrentLocalTimeHeader.Text;
                currentLocalTimeHeader.ShouldBe("Current local time in Kiev, Ukraine");

                var convertTimeHeader = KievPage.ConvertTimeHeader.Text;
                convertTimeHeader.ShouldBe("Convert Kiev Time");

                var kievInformationHeader = KievPage.KievInformationHeader.Text;
                kievInformationHeader.ShouldBe("Kiev Information");

                var kievFactsHeader = KievPage.KievFactsHeader.Text;
                kievFactsHeader.ShouldBe("Kiev Facts");

                var countryName = KievPage.CountryName.Text;
                countryName.ShouldBe("Ukraine");

                var currencyName = KievPage.CurrencyName.Text;
                currencyName.ShouldBe("Hryvnia (UAH)");

                var timeZoneName = KievPage.TimeZoneName.Text;
                timeZoneName.ShouldBe("EEST");

                
            });
        }
    }
}
