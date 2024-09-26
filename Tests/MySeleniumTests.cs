using CsharpNunitTest;
using NUnit.Framework;

namespace SeleniumTests;

public class MySeleniumTests : TestBase
{

    private const string USERNAME = "UserName";
    private const string PASSWORD = "Password";

    [Test]
    public void UserCanLogIn()
    {
        WebFormPage webFormPage = new WebFormPage(Driver);
        webFormPage.Login(USERNAME, PASSWORD);
        SubmitPage submitPage= new SubmitPage(Driver);
        Assert.That("Received!".Equals(submitPage.GetReceivedMessage()), Is.True);
    }
}
