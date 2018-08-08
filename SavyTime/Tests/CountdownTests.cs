using NUnit.Framework;
using OpenQA.Selenium;
using SavvyTime.Selenium;
using SavvyTime.URL;
using System;
using SavvyTime.Verification;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnk.log2html.Support;
using SavvyTime.Pages;
using Bogus;

namespace SavvyTime.Tests
{
    [TestFixture]
    public class CountdownTests
    {
        [Test]
        public void CountdownPage_Test()
        {
            IWebDriver driver = DriverUtils.CreateDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            TestWrapper.Test(driver, () =>
            {
                // Open Landing Page
                var landingPage = URLs.OpenUrl(driver);

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                //Open Timers Page
                var timersPage = landingPage.ClickTimersItem();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                //Open Countdown Page
                var countdownPage = timersPage.ClickCountdownIcon();

                //Click Create your Countdown button
                var createCountdown = countdownPage.ClickCreateYourCountdownIcon();
                
                //Unique name for event
                var faker = new Faker();
                var uniqueEventName = faker.Name.FirstName();

                createCountdown.EventNameField.SendKeys(uniqueEventName);
                
                //Input date in 10 days 
                DateTime inTenDays = DateTime.Now.AddDays(10);
                var inTenDaysString = inTenDays.ToShortDateString();
                createCountdown.DateInputField.SendKeys(inTenDaysString);

                //Click Create button
                var createButton = createCountdown.ClickCreateButton();

                //Verify event was created
                var eventName = eventPage.GetEventHeaderText();
                eventName.ShouldBe(uniqueEventName, "Header");

                //Verify event is scheduled for a correct date
                var inTenDaysLongString = inTenDays.ToLongDateString();
                var timeString = eventPage.GetTimeString();
                timeString.ShouldContain(inTenDaysLongString, "Correct date");




            });
        }
    }
}
