using OpenQA.Selenium;

namespace SavvyTime.Pages
{
    public class KievTimePage
    {
        private IWebDriver _driver;

        public KievTimePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}