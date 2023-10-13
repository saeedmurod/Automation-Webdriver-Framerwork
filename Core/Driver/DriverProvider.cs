using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;

namespace Core.Driver
{
    public enum Drivers
    {
        Chrome,
        Edge,
        Firefox
    }

    public class DriverProvider
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver(Drivers driver)
        {
            return driver switch
            {
                Drivers.Chrome => new ChromeDriver(),
                Drivers.Edge => new EdgeDriver(),
                Drivers.Firefox => new FirefoxDriver()
            };

        }
        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }
    }
}