using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavvyTime.Pages
{
    public class LandingPage
    {
        private IWebDriver _driver;

        public LandingPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement LandingHeaderHome => _driver.FindElement(By.XPath("//div[@class='nav navbar - nav']/li"));
        public IWebElement LandingHeaderConverter => _driver.FindElement(By.XPath("//div[@class='nav navbar - nav']/li[2]"));
        public IWebElement LandingHeaderLocalTime => _driver.FindElement(By.XPath("//div[@class='nav navbar - nav']/li[3]"));
        public IWebElement LandingHeaderTimers => _driver.FindElement(By.XPath("//div[@class='nav navbar - nav']/li[4]"));
        public IWebElement LandingHeaderCalendar => _driver.FindElement(By.XPath("//div[@class='nav navbar - nav']/li[5]"));
        public IWebElement LandingLogo => _driver.FindElement(By.ClassName("logo"));
        public IWebElement LandingLogoImage => _driver.FindElement(By.XPath("//div[@class='logo']/img"));
        public IWebElement LandingLogoText => _driver.FindElement(By.XPath("//div[@class='logo']/h5"));
        public IWebElement LandingHourSwitch => _driver.FindElement(By.ClassName("hour -switch"));
        public IWebElement LandingInfoContainer => _driver.FindElement(By.ClassName("content-block frame"));
        public IWebElement LandingSearchField => _driver.FindElement(By.Id("place-search"));
        public IWebElement LandingTimeConverter => _driver.FindElement(By.XPath("div[@class='big - services - box col - xs - 12 col - sm - 4 col - sm - offset - 2']/a"));
        public IWebElement LandingLocalTime => _driver.FindElement(By.XPath("div[@class='big-services-box col-xs-12 col-sm-4 ']/a"));
        public IWebElement LandingFooterEstIst => _driver.FindElement(By.XPath("div[@class='footer-links']/a"));
        public IWebElement LandingFooterGmtEst => _driver.FindElement(By.XPath("div[@class='footer-links']/a[2]"));
        public IWebElement LandingFooterPstEst => _driver.FindElement(By.XPath("div[@class='footer-links']/a[3]"));
        public IWebElement LandingFooterEstGmt => _driver.FindElement(By.XPath("div[@class='footer-links']/a[4]"));
        public IWebElement LandingFooterPstGmt => _driver.FindElement(By.XPath("div[@class='footer-links']/a[5]"));
        public IWebElement LandingFooterContactUs => _driver.FindElement(By.XPath("div[@class='footer-top']/a"));
        public IWebElement LandingFooterDisclaimer => _driver.FindElement(By.XPath("div[@class='footer-top']/a[2]"));

        
    }
}
