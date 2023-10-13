using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class SentPage
    {
        private IWebDriver driver;

        public SentPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Url()
        {
            return driver.Url;
        }

    }
}
