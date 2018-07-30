using dnk.log2html.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using SavvyTime.Selenium;
using SavvyTime.URL;
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




            });
        }
    }
}
