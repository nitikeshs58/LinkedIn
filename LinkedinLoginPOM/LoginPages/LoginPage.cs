using LinkedinLoginPOM.Linkedin;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;

namespace LinkedinLoginPOM.LoginPages
{
    public class LoginPage
    {
        public IWebDriver driver;

        //Intializing Web elememts
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //Username textfield webelement
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UserName;

        //Password textfield webelement
        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password;

        //SignIn button webelement
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement SignIn;

        public void LoginData()
        {
            Thread.Sleep(2000);
            UserName.SendKeys(RequiredCredentials.Email);
            Thread.Sleep(2000);
            Password.SendKeys(RequiredCredentials.Password);
            SignIn.Click();
        }
    }
}
