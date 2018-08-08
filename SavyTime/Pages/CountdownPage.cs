using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavvyTime.Pages
{
    public class CountdownPage
    {
        private IWebDriver _driver;

        public CountdownPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //public IWebElement CreateYourCountdownButton => _driver.FindElement(By.ClassName("create-link btn btn-primary"));
        public IWebElement CreateYourCountdownButton => _driver.FindElement(By.XPath("//div[@class='popular-countdown']/a"));

        public CreateCountdownPage ClickCreateYourCountdownIcon()
        {
            CreateYourCountdownButton.Click();
            return new CreateCountdownPage(_driver);
        }


    }
}
