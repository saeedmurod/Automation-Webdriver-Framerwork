using Core;
using OpenQA.Selenium;
using Pages;
using Pages.User;

namespace Tests
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = DriverProvider.GetDriver(Drivers.Chrome);
            driver.Manage().Window.Maximize();
            driver.Url = "https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fmail.google.com&ec=GAlAFw&hl=en&service=mail&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S1678429287%3A1696101771657405&theme=glif";
        }

        [Test]
        public void Test1()
        {
            User currentUser = new User("saidmurodtestepam@gmail.com", "x@iysu27");
            LoginPage loginPage = new LoginPage(driver);
            var mainPage = loginPage.Login(currentUser);
            mainPage.SendEmail("saidmurod11@gmail.com", "Job ", "Hello I will pay you 2.000.000");
            Assert.Pass();
        }

        
    }
}