using NUnit.Framework;
using OpenQA.Selenium;
using SavvyTime.Selenium;
using SavvyTime.URL;
using System;
using SavvyTime.Verification;
using dnk.log2html.Support;

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

                //Verify Header Menu Items 
                string itemHome = landingPage.HomeMenuItem.Text;
                itemHome.ShouldBe("Home", "Home - Item Menu");

                string itemConverter = landingPage.ConverterMenuItem.Text;
                itemConverter.ShouldBe("Converter", "Converter - Item Menu");

                string itemLocalTime = landingPage.LocalTimeMenuItem.Text;
                itemLocalTime.ShouldBe("Local Time", "Local Time - Item Menu");

                string itemTimers = landingPage.TimersMenuItem.Text;
                itemTimers.ShouldBe("Timers", "Timers - Item Menu");

                string itemCalendar = landingPage.CalendarMenuItem.Text;
                itemCalendar.ShouldBe("Calendar", "Calendar - Item Menu");

                //Verify logo
                var imageLogo = landingPage.LandingLogoImage.Displayed;
                imageLogo.ShouldBeTrue("Logo img");

                var textLogo = landingPage.LandingLogoText.Displayed;
                textLogo.ShouldBeTrue("Logo Text img");

                string logoText = landingPage.GetLogoText();
                logoText.ShouldBe("Savvy Time World Clock", "Logo Text");

                //Verify 12/24 switch
                var hourSwitch = landingPage.LandingHourSwitch.Displayed;
                hourSwitch.ShouldBeTrue("12/24 switch");

                //Verify Time/Date/Location Container
               // var container = landingPage.LandingInfoContainer.Displayed;
                //container.ShouldBeTrue("Container");

                //Verify Search Field
                var searchField = landingPage.LandingSearchField.Displayed;
                searchField.ShouldBeTrue("Search field");

                //Verify Time Converter
                var timeConverter = landingPage.LandingTimeConverter.Displayed;
                timeConverter.ShouldBeTrue("Time Converter");

                //Verify Time Around the World
                var localTime = landingPage.LandingLocalTime.Displayed;
                localTime.ShouldBeTrue("Time Around the World");

                //Verify Footer Items
                string estIst = landingPage.LandingFooterEstIst.Text;
                estIst.ShouldBe("EST to IST", "EST to IST");

                string gmtEst = landingPage.LandingFooterGmtEst.Text;
                gmtEst.ShouldBe("GMT to EST", "GMT to EST");

                string pstEST = landingPage.LandingFooterPstEst.Text;
                pstEST.ShouldBe("PST to EST", "PST to EST");

                string estGmt = landingPage.LandingFooterEstGmt.Text;
                estGmt.ShouldBe("EST to GMT", "EST to GMT");

                string pstGmt = landingPage.LandingFooterPstGmt.Text;
                pstGmt.ShouldBe("PST to GMT", "PST to GMT");

                string contactUs = landingPage.LandingFooterContactUs.Text;
                contactUs.ShouldBe("Contact Us", "Contact Us");

                string disclaimer = landingPage.LandingFooterDisclaimer.Text;
                disclaimer.ShouldBe("Disclaimer", "Disclaimer");

            });
        }
    }
}
