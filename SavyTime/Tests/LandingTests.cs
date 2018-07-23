using NUnit.Framework;
using OpenQA.Selenium;
using SavvyTime.Selenium;
using SavvyTime.URL;
using System;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavvyTime.Tests
{
    [TestFixture]
    public class LandingTests
    {
        [Test]
        public void LandingPage_Test()
        {
            IWebDriver driver = DriverUtils.CreateDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            TestWrapper.Test(driver, () =>
            {
                // Open Landing Page
                var landingPage = URLs.OpenUrl(driver);

                //Verify text on the page
                //var alltext = landingPage.GetAllText();
                //alltext.ShouldBe(landingPage.paragraphsText);


                //Verify Header Menu Items 
                string header = landingPage.LandingHeaderHome.Text;
                header.ShouldBe("Home");

                string header = landingPage.LandingHeaderConverter.Text;
                header.ShouldBe("Converter");

                string header = landingPage.LandingHeaderLocalTime.Text;
                header.ShouldBe("Local Time");

                string header = landingPage.LandingHeaderTimers.Text;
                header.ShouldBe("Timers");

                string header = landingPage.LandingHeaderCalendar.Text;
                header.ShouldBe("Calendar");

                //Verify logo
                var imageLogo = landingPage.LandingLogoImage.Displayed;
                imageLogo.ShouldBeTrue();

                string logoText = landingPage.LandingLogoText.Text;
                logoText.ShouldBe("Savvy Time World Clock");





                //Verify images of the page
                var image1 = landingPage.CatImage.Displayed;
                var image2 = landingPage.DogImage.Displayed;
                image1.ShouldBeTrue();
                image2.ShouldBeTrue();



	            //Verify text on the page
	            var alltext = landingPage.GetAllText();
	            alltext.ShouldBe(landingPage.paragraphsText, "Page text");
                //Verify Header text
                string header = landingPage.LandingHeader.Text;
                header.ShouldBe("Alex's Pet Business", "Header text");

                //Verify images of the page
                landingPage.CatImage.Displayed.ShouldBeTrue("Cat img");
                landingPage.DogImage.Displayed.ShouldBeTrue("Dog img");
            });
        }
    }
}
