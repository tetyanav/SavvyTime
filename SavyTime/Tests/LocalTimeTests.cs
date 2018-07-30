﻿using NUnit.Framework;
using OpenQA.Selenium;
using SavvyTime.Selenium;
using SavvyTime.URL;
using System;
using Shouldly;
using dnk.log2html.Support;
using SavvyTime.Pages;

namespace SavvyTime.Tests
{
    [TestFixture]
    public class LocalTimeTests
    {
        [Test]
        public void LocalTime_Test()
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

                // Verify the Page Header
                var header = localTimePage.Header.Text;
                header.ShouldBe("Local Time");

                //Find Kiev  using the Search field???
                localTimePage.FillOutSearchField(input);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                var KievPage = localTimePage.ClickKievUkraineQuery();

                //Verify the header of the page is Kiev Time
                GetHeaderText.ShouldBe("Kiev Time");



            });
        }
    }
}
