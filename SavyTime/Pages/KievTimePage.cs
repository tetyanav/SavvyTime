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

        public IWebElement TimeKiev => _driver.FindElement(By.ClassName("time format12"));
        public IWebElement HeaderKiev => _driver.FindElement(By.XPath("//div[@class='page-header']//h1"));
        public IWebElement Breadcrumbs => _driver.FindElement(By.ClassName("breadcrumb"));
        public IWebElement BlockHeader => _driver.FindElement(By.ClassName("current - time - header"));
        public IWebElement ConvertTimeHeader => _driver.FindElement(By.XPath("//h2[contains(., 'Convert Kiev Time')]"));
        public IWebElement KievInformationHeader => _driver.FindElement(By.XPath("//h2[contains(., 'Kiev Information')]"));
        public IWebElement KievFactsHeared => _driver.FindElement(By.ClassName("city-title"));
        public IWebElement CountryName => _driver.FindElement(By.XPath("//div[contains(@class, 'col-xs-8') and contains(., 'Ukraine')]"));
        public IWebElement CurrencyName => _driver.FindElement(By.XPath("//div[contains(@class, 'col-xs-8') and contains(., 'Hryvnia  (UAH)')]"));
        public IWebElement TimeZoneName => _driver.FindElement(By.XPath("//p[@class='lead details']//span"));

        public string GetHeaderText()
        {
            return HeaderKiev.Text;
        }
    }
}