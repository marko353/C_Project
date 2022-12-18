using System.Collections.Generic;
using CProject.pages;
using NUnit.Framework;
using OpenQA.Selenium;


public class LoginTest : BaseTests
{
    string emailField = "test123!22@gmail.com";
    string passwordField = "hekitekive18***^&";
    string errorText = "! Invalid username or password CLOSE";
    string logiTitle = "Login";
    string eMail = "testMail2@gmail.com";
    string flexMasage = "An email has been sent to your inbox.";



    [Test]
    public void clickLoginButton()
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.basePage();
        loginPage.loginButton();
        loginPage.loginWrogCrede(emailField, passwordField);

        try
        {
            Thread.Sleep(5000);
        }
        catch (ThreadInterruptedException e)
        {
            e.GetBaseException();
        }
    }
    [Test]
    public void assortErrorContauner()
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.basePage();
        loginPage.loginButton();
        loginPage.loginWrogCrede(emailField, passwordField);
        loginPage.errorMasege(errorText);
        try
        {
            Thread.Sleep(5000);
        }
        catch (ThreadInterruptedException e)
        {
        }
    }
    [Test]
    public void loginTitle()
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.basePage();
        loginPage.loginButton();
        loginPage.logTitle(logiTitle);
        try
        {
            Thread.Sleep(5000);
        }
        catch (ThreadInterruptedException e)
        {
            e.GetBaseException();
        }
    } 
    [Test]
    public void flexForgeMasage()
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.basePage();
        loginPage.loginButton();
        loginPage.forSendMail(eMail);
        loginPage.forgPasswMesage(flexMasage);

        try
        {
            Thread.Sleep(5000);
        }
        catch (ThreadInterruptedException e)
        {
            e.GetBaseException();
        }
    } 
      [Test]
    public void seeButtonclick()
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.basePage();
        loginPage.loginButton();
        loginPage.seeButtonPassw(passwordField);
        loginPage.clickSee();

        try
        {
            Thread.Sleep(5000);
        }
        catch (ThreadInterruptedException e)
        {
            e.GetBaseException();
        }
    }
                 
}




