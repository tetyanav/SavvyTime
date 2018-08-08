using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavvyTime.Pages
{
    public class EventPage
    {
        private IWebDriver _driver;

        public EventPage (IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement EventHeader => _driver.FindElement(By.ClassName("title countdown-name"));
        public IWebElement TimeString => _driver.FindElement(By.ClassName("time-string"));


        public string GetEventHeaderText()
        {
            return EventHeader.Text;
        }

        public string GetTimeString()
        {
            return TimeString.Text;
        }


    }
}
