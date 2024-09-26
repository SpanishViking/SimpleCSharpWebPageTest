using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace CsharpNunitTest
{
    public class TestBase
    {
        protected IWebDriver Driver {get; private set; }

        private static string BaseURL = "https://www.selenium.dev/selenium/web/web-form.html";
       
       [SetUp]
       public void SetUp()
       {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(BaseURL);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
       }

       [TearDown]
       public void TearDown() 
       {
            Driver.Quit();
       }
    }
}