using OpenQA.Selenium;

namespace Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        private readonly By LoginTextBox = By.Id("identifierId");
        private readonly By PassTextBox = By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input");

        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public MainPage Login(User.User user)
        {
            driver.FindElement(LoginTextBox).SendKeys($"{user.Username}{Keys.Enter}");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(PassTextBox).SendKeys($"{user.Password}{Keys.Enter}");
            return new MainPage(driver);
        }
    }
}