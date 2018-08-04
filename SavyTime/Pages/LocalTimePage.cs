using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavvyTime.Pages
{
    public class LocalTimePage
    {
        private IWebDriver _driver;

        public LocalTimePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Header => _driver.FindElement(By.XPath("//h1[@class='title']"));
        public IWebElement KievQuery => _driver.FindElement(By.XPath("//div[@class='list-group']/a[@href='/local/ukraine-kiev']"));
        public IWebElement SearchField => _driver.FindElement(By.Id("place-search"));
        
        

        public KievTimePage ClickKievUkraineQuery()
        {
            KievQuery.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return new KievTimePage(_driver);
        }

        public void FillOutSearchField(string input)
        {
            SearchField.SendKeys(input);
        }
    }
}
