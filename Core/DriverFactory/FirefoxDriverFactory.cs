using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace Core.DriverFactory
{
    public class FirefoxDriverFactory : BaseDriverFactory
    {
        public override IWebDriver CreateDriver()
        {
            var options = new FirefoxOptions();
            return new FirefoxDriver(options);
        }
    }
}
