
using System.ComponentModel.Design;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

public class BaseTests
{

    public WebDriver driver;
    


    [SetUp]
    public void setup()
    {

        System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\\geckodriver_win32\\chromedriver.exe");
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }
    [TearDown]
    public void tearDown()
    {
        driver.Quit();
    }

}