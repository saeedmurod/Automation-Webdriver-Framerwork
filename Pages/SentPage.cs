﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class SentPage : BasePage
    {
        public SentPage(IWebDriver driver) : base(driver)
        {
        }

        public string Url()
        {
            return driver.Url;
        }

    }
}
