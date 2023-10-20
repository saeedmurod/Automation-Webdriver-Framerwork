using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class MainPage : BasePage
    {

        private By ComposeButton = By.XPath("//div[text()='Compose']");
        private By ReceiverEmail = By.CssSelector("input.agP.aFw");
        private By SubjectOfEmail = By.CssSelector("input.aoT");
        private By EmailText = By.CssSelector("div.Am.Al.editable.LW-avf.tS-tW");
        private By SendEmailButton = By.XPath("//div[text()='Send']");
        private By SentButton = By.XPath("//a[text()='Sent']");
        private By Inbox = By.XPath("//a[text()='Inbox']");

        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void SendEmail(string receiver, string emailSubject, string emailText)
        {
            driver.FindElement(ComposeButton).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(ReceiverEmail).SendKeys($"{receiver}");
            driver.FindElement(SubjectOfEmail).SendKeys($"{emailSubject}");
            driver.FindElement(EmailText).SendKeys($"{emailText}");
            driver.FindElement(SendEmailButton).Click();
            
        }

        public SentPage Check()
        {
            driver.FindElement(SentButton).Click();
            return new SentPage(driver);
        }

        public string InboxShower()
        {
            string actualInbox = driver.FindElement(Inbox).Text;
            return actualInbox;
        }
    }
}
