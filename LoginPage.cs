using NUnit.Framework;
using OpenQA.Selenium;

namespace CProject.pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(WebDriver driver) : base(driver)
        {
        }
        By loginButto = By.XPath("/html/body/div/header/div/div[1]/a[6]");
        By emailField = By.XPath("//*[@id='app']/div/div/form/div[1]/div/input");
        By passwordField = By.XPath("//*[@id='app']/div/div/form/div[2]/div/input");
        By loginButton1 = By.XPath("//*[@id='app']/div/div/form/div[4]/button/div");
        By errorContauner = By.XPath("//*[@id='17']/div/span[1]");
        By title = By.XPath("//*[@id='app']/div/div/form/span");
        By foMasage = By.XPath("//*[@id='app']/div/div/span[2]");
        By forButton = By.XPath("//*[@id='app']/div/div/form/div[4]/span");
        By forEmailFied = By.XPath("//*[@id='app']/div/div/form/div[1]/div/input");
        By sendButton = By.XPath("//*[@id='app']/div/div/form/div[2]/button/div/span");
        By seeButton = By.XPath("//*[@id='app']/div/div/form/div[2]/div/span");

        public LoginPage loginButton()
        {
            click(loginButto);
            return this;
        }
        public LoginPage loginWrogCrede(string email, string password)
        {
            writeText(emailField, email);
            writeText(passwordField, password);
            click(loginButton1);
            return this;

        }
        public LoginPage errorMasege(string expectedText)
        {
            string actualText = readText(errorContauner);
            Assert.AreEqual(expectedText, actualText);
            return this;
        }
        public LoginPage logTitle(string expectedText)
        {
            string actualText = readText(title);
            Assert.AreEqual(expectedText, actualText);
            return this;
        }
        public LoginPage forSendMail(string password)
        {
            click(forButton);
            writeText(forEmailFied, password);
            click(sendButton);
            return this;
        }
        public LoginPage forgPasswMesage(string expectedText)
        {
            string actualText = readText(foMasage);
            Assert.AreEqual(expectedText, actualText);
            return this;
        }
        
        public LoginPage seeButtonPassw(string password)
        {
            writeText(passwordField, password);
            

            return this;
    }
    public LoginPage clickSee(){
        click(seeButton);
        return this;

    }
    }
}
