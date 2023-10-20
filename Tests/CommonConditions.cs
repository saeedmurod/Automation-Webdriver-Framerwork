using Core;
using Core.DriverFactory;
using OpenQA.Selenium;
using Pages;
using Pages.User;
using System;
using System.Drawing.Imaging;

namespace Tests
{
    public class CommonConditions
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var browser = (Drivers)Enum.Parse(typeof(Drivers), Configuration.Model.Browser);
            driver = DriverProvider.GetDriverFactory(browser).CreateDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fmail.google.com&ec=GAlAFw&hl=en&service=mail&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S1678429287%3A1696101771657405&theme=glif";
        }

        [Test]
        public void LoginSendEmail_CorrectCredentials_SuccesfulLoggingAndSending()
        {
            try
            {
                User currentUser = UserCreator.FirstUserCredentials();
                LoginPage loginPage = new LoginPage(driver);
                var mainPage = loginPage.Login(currentUser);
                mainPage.SendEmail("saidmurod11@gmail.com", "Achievement ", "Congratulations on your achievement");
                var sentPage = mainPage.Check();
                string expectedUrl = "https://mail.google.com/mail/u/1/#inbox?compose=new";
                Assert.AreNotEqual(expectedUrl, sentPage.Url());
            }

            catch
            {
                string filePath = "C:\\Users\\Saidmurod\\source\\repos\\Tests\\Tests\\Screenshots\\";
                DateTime time = DateTime.Now;
                string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(filePath + "Exception" + dateToday + ".png", ScreenshotImageFormat.Png);
                throw;
            }
        }

        [Test]
        public void Login_CorrectCredentials_SuccesfulLogin()
        {
            try
            {
                User currentUser = UserCreator.FirstUserCredentials();
                LoginPage loginPage = new LoginPage(driver);
                var mainPage = loginPage.Login(currentUser);
                string expectedUrl = "https://mail.google.com/mail/u/1/#inbox";
                Assert.AreNotEqual(expectedUrl, mainPage.Url());
            }

            catch
            {
                string filePath = "";
                DateTime time = DateTime.Now;
                string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(filePath + "Exception" + dateToday + ".png", ScreenshotImageFormat.Png);
                throw;
            }
        }

        [TearDown] 
        public void Close()
        {
            driver.Quit();
        }
        
    }
}