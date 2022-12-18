using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static System.Net.Mime.MediaTypeNames;

namespace CProject.pages
{
    public class BasePage
    {
        public WebDriver driver;
        public WebDriverWait wait;
        public string baseUrl = "https://www.holywally.com/";
        public BasePage(WebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public void waitVisability(By elementBy)
        {
            this.wait.Until(d => d.FindElement(elementBy));
        }
        public void basePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }
        public void click (By elementBy){
            waitVisability(elementBy);
            driver.FindElement(elementBy).Click();
            

        }public void writeText(By elementBy,string text){
            waitVisability(elementBy);
            driver.FindElement(elementBy).Clear();
            driver.FindElement(elementBy).SendKeys(text);

        }
        public void assertErrorMesage(string expectedText,string actualText){
         Assert.AreEqual(expectedText,actualText);
        }
        public string readText(By elementBy){
            waitVisability(elementBy);
            return driver.FindElement(elementBy).Text;

        }

    }
}