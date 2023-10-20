using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace Core.DriverFactory
{
    public class EdgeDriverFactory : BaseDriverFactory
    {
        public override IWebDriver CreateDriver()
        {
            var options = new EdgeOptions();
            return new EdgeDriver(options);
        }
    }
}
