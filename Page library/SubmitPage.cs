using OpenQA.Selenium;

public class SubmitPage {
    private readonly IWebDriver Driver;
    public SubmitPage (IWebDriver driver) 
    { 
        this.Driver = driver;
    }
    #region Locators
         IWebElement ReceivedMessage => Driver.FindElement(By.Id("message"));
    #endregion
    #region Actions
        public string GetReceivedMessage ()
        {
            return ReceivedMessage.Text;
        }
    #endregion
}