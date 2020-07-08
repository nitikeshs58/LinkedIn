using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedinLoginPOM.LoginPages
{
    
    public class SignOut
    {
        public IWebDriver driver;
        public SignOut(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#nav-settings__dropdown")]
        public  IWebElement ProcideToSignout;

        [FindsBy(How = How.XPath, Using = "//a[text()='Sign out']")]
        public  IWebElement SignoutButton;

        public void SignOutLinkedin()
        {
            ProcideToSignout.Click();
            Thread.Sleep(3000);
            SignoutButton.Click();
            Thread.Sleep(3000);
        }

    }
}
