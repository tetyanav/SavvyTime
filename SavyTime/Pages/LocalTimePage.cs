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

        public IWebElement Header => _driver.FindElement(By.XPath("//div[@class='page-header']/h1"));
        public IWebElement KievQuery => _driver.FindElement(By.XPath("//div[@class='list-group']/a[@href='/local/ukraine-kiev']"));
        public IWebElement SearchField => _driver.FindElement(By.Id("place-search"));
        string input = "Kiev";
        public KievTimePage ClickKievUkraineQuery()
        {
            KievQuery.Click();
            return new KievTimePage(_driver);
        }

        public void FillOutSearchField()
        {
            SearchField.SendKeys(input);
        }
    }
}
