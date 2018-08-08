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
        public IWebElement HeaderKiev => _driver.FindElement(By.XPath("//h1[@class='title']"));
        public IWebElement Breadcrumbs => _driver.FindElement(By.ClassName("breadcrumb"));
        public IWebElement CurrentLocalTimeHeader => _driver.FindElement(By.ClassName("current-time-header"));
        public IWebElement ConvertTimeHeader => _driver.FindElement(By.XPath("//h2[contains(., 'Convert Kiev Time')]"));
        public IWebElement KievInformationHeader => _driver.FindElement(By.XPath("//h2[contains(., 'Kiev Information')]"));
        public IWebElement KievFactsHeader => _driver.FindElement(By.ClassName("city-title"));
        public IWebElement CountryName => _driver.FindElement(By.XPath("//div[contains(@class, 'col-xs-8') and contains(., 'Ukraine')]"));
        public IWebElement CurrencyName => _driver.FindElement(By.XPath("//div[contains(@class, 'col-xs-8') and contains(., 'Hryvnia  (UAH)')]"));
        public IWebElement TimeZoneName => _driver.FindElement(By.XPath("//p[@class='lead details']//span"));
        public IWebElement KievHour => _driver.FindElement(By.XPath("//h2[@class='time format12']/span[@class='current-hours']"));
        public IWebElement KievMinutes => _driver.FindElement(By.XPath("//h2[@class='time format12']/span[@class='current-minutes']"));
        public IWebElement KievSeconds => _driver.FindElement(By.XPath("//h2[@class='time format12']/small[@class='time-extra']/span[@class='current-seconds']"));
        public IWebElement KievPmAm => _driver.FindElement(By.XPath("//small[@class='time-extra']/span[@class='current-ampm']"));



        public string GetBreadcrumbsText()
        {
            return Breadcrumbs.Text.Replace("\r\n", " ");
        }

        public string GetAppKievTime()
        {
            return KievHour.Text + ":" + KievMinutes.Text + ":" + KievSeconds + " " + KievPmAm.Text;
        }
    }
}