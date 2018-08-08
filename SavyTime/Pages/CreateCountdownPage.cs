using OpenQA.Selenium;
using System;
using SavvyTime.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;


namespace SavvyTime.Pages
{
    public class CreateCountdownPage
    {
        private IWebDriver _driver;

        public CreateCountdownPage(IWebDriver driver)
        {
            _driver = driver;
        }


        public IWebElement EventNameField => _driver.FindElement(By.Id("event-name"));
        public IWebElement DateInputField => _driver.FindElement(By.XPath("//div[@id='date-picker']/input"));
        public IWebElement CreateButton => _driver.FindElement(By.XPath("//input[@id='create-countdown']"));
        public IWebElement EventName => _driver.FindElement(By.ClassName("title countdown-name"));


        public EventPage ClickCreateButton()
        {
            CreateButton.Click();
            return new EventPage(_driver);
        }

    }
}
