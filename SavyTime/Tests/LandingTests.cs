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
                itemHome.ShouldBe("Home");

                string itemConverter = landingPage.ConverterMenuItem.Text;
                itemConverter.ShouldBe("Converter");

                string itemLocalTime = landingPage.LocalTimeMenuItem.Text;
                itemLocalTime.ShouldBe("Local Time");

                string itemTimers = landingPage.TimersMenuItem.Text;
                itemTimers.ShouldBe("Timers");

                string itemCalendar = landingPage.CalendarMenuItem.Text;
                itemCalendar.ShouldBe("Calendar");

                //Verify logo
                var imageLogo = landingPage.LandingLogoImage.Displayed;
                imageLogo.ShouldBeTrue();

                var textLogo = landingPage.LandingLogoText.Displayed;
                textLogo.ShouldBeTrue();

                string logoText = landingPage.GetLogoText();
                logoText.ShouldBe("Savvy Time World Clock");

                //Verify 12/24 switch
                var hourSwitch = landingPage.LandingHourSwitch.Displayed;
                hourSwitch.ShouldBeTrue();

                //Verify Time/Date/Location Container
               // var container = landingPage.LandingInfoContainer.Displayed;
                //container.ShouldBeTrue();

                //Verify Search Field
                var searchField = landingPage.LandingSearchField.Displayed;
                searchField.ShouldBeTrue();

                //Verify Time Converter
                var timeConverter = landingPage.LandingTimeConverter.Displayed;
                timeConverter.ShouldBeTrue();

                //Verify Time Around the World
                var localTime = landingPage.LandingLocalTime.Displayed;
                localTime.ShouldBeTrue();

                //Verify Footer Items
                string estIst = landingPage.LandingFooterEstIst.Text;
                estIst.ShouldBe("EST to IST");

                string gmtEst = landingPage.LandingFooterGmtEst.Text;
                gmtEst.ShouldBe("GMT to EST");

                string pstEST = landingPage.LandingFooterPstEst.Text;
                pstEST.ShouldBe("PST to EST");

                string estGmt = landingPage.LandingFooterEstGmt.Text;
                estGmt.ShouldBe("EST to GMT");

                string pstGmt = landingPage.LandingFooterPstGmt.Text;
                pstGmt.ShouldBe("PST to GMT");

                string contactUs = landingPage.LandingFooterContactUs.Text;
                contactUs.ShouldBe("Contact Us");

                string disclaimer = landingPage.LandingFooterDisclaimer.Text;
                disclaimer.ShouldBe("Disclaimer");

            });
        }
    }
}
