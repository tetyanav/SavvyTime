using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavvyTime.Pages
{
    public class TimersPage
    {
        private IWebDriver _driver;

        public TimersPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement CountdownIcon => _driver.FindElement(By.ClassName("icon-hourglass"));


        public CountdownPage ClickCountdownIcon()
        {
            CountdownIcon.Click();
            return new CountdownPage(_driver);
        }
    }
}
