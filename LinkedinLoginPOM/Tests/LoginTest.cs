using LinkedinLoginPOM.Linkedin;
using LinkedinLoginPOM.LoginPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace LinkedinLoginPOM
{
    [TestFixture]
    public class LoginTest
    {
        public IWebDriver driver;
        //Method to initialize driver and launch website
        [OneTimeSetUp]
        public void initialization()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(RequiredCredentials.LinkedinURL);
        }

        [Test, Order(1)]
        public void CheckEndToEndScenarioOfLinkedin()
        {
            LoginPage loginPage = new LoginPage(driver);
            PageFactory.InitElements(driver, loginPage);
            loginPage.LoginData();
            Thread.Sleep(2000);
            WritePost publishArticle = new WritePost(driver);
            publishArticle.WritePostOnLinkedin();
            Thread.Sleep(2000);
            SignOut signOut = new SignOut(driver);
            signOut.SignOutLinkedin();
        }

        //Method to quit browser
        [OneTimeTearDown]
        public void TearDown()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
