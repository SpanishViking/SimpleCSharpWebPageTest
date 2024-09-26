using System.Reflection.Metadata;
using CsharpNunitTest;
using OpenQA.Selenium;

namespace CsharpNunitTest
{
    public class WebFormPage {
        private readonly IWebDriver Driver;

        private const string USERNAME = "UserName";
        private const string PASSWORD = "Password";
        
        public WebFormPage(IWebDriver Driver) 
        { 
            this.Driver = Driver;
        }

        #region Locators
            IWebElement TextInput => Driver.FindElement(By.Id("my-text-id"));
            IWebElement Password => Driver.FindElement(By.Name("my-password"));
            IWebElement TextArea => Driver.FindElement(By.Name("my-textarea"));
            IWebElement DisabledInput => Driver.FindElement(By.Name("my-disabled"));
            IWebElement ReadonlyInput => Driver.FindElement(By.Name("my-readonly"));
            IWebElement DropdownSelect => Driver.FindElement(By.Name("my-select"));
            IWebElement DropdownDataList => Driver.FindElement(By.Name("my-datalist"));
            IWebElement FileInput => Driver.FindElement(By.Name("my-file"));
            IWebElement Checkbox1 => Driver.FindElement(By.Id("my-check-1"));
            IWebElement Checkbox2 => Driver.FindElement(By.Id("my-check-2"));
            IWebElement RadioButton1 => Driver.FindElement(By.Id("my-radio-1"));
            IWebElement RadioButton2 => Driver.FindElement(By.Id("my-radio-2"));
            IWebElement SubmitButton => Driver.FindElement(By.TagName("button"));
            IWebElement ColorPicker => Driver.FindElement(By.Name("my-colors"));
            IWebElement DatePicker => Driver.FindElement(By.Name("my-date"));
            IWebElement ExampleRange => Driver.FindElement(By.Name("my-range"));
            
        #endregion
        #region Actions
        public WebFormPage WriteTextToTextInput(string text)
        {
            TextInput.SendKeys(text);
            return this;
        }
        public WebFormPage WriteTextToPasswordField(string text)
        {
            Password.SendKeys(text);
            return this;
        }
        public WebFormPage WriteTextToTextArea(string text)
        {
            TextArea.SendKeys(text);
            return this;
        }
        public string GetTextFromReadOnlyField()
        {
            return ReadonlyInput.Text.ToString();
        }
        
        public void ClickSubmitButton ()
        {
            SubmitButton.Click();
        }

        public void Login (string username, string password)
        {
            TextInput.SendKeys (username); // Use TextInput as a username field for sake of test and insert a username
            Password.SendKeys (password); // Enter a password into Password field
            ClickSubmitButton(); // Click the submit button 
        }


        #endregion
    }
}
