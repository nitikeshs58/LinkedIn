using LinkedinLoginPOM.Linkedin;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedinLoginPOM.LoginPages
{
    public class WritePost
    {
        public IWebDriver driver;

        //Intializing web elements
        public WritePost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //Start a post link web element
        [FindsBy(How = How.XPath, Using = "//button[text()='Start a post']")]
        public IWebElement StartPost;

        [FindsBy(How = How.XPath, Using = "//div[contains(@aria-label,'What do you want to talk about?')]")]
        public IWebElement EnterTitle;

        [FindsBy(How = How.XPath, Using = "//span[text()='Add hashtag']")]

        public IWebElement AddHashTag;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'#')]")]

        public IWebElement EnterHashTag;

        [FindsBy(How = How.XPath, Using = "//li-icon[contains(@type,'camera-icon')]")]

        public IWebElement PhotoUpload;

        [FindsBy(How = How.XPath, Using = "//span[text()='Done']")]
        public IWebElement DoneButton;

        [FindsBy(How = How.XPath, Using = "//span[text()='Post']")]

        public IWebElement PostButton;


        public void WritePostOnLinkedin()
        {
            Thread.Sleep(3000);
            StartPost.Click();
            Thread.Sleep(2000);
            EnterTitle.SendKeys(RequiredCredentials.enterTitle);
            Thread.Sleep(3000);
            AddHashTag.Click();
            EnterHashTag.SendKeys(RequiredCredentials.Hashtags);
            Thread.Sleep(3000);
            PhotoUpload.Click();
            Thread.Sleep(3000);
            Process.Start("C://Users//Admin//source//repos//LinkedinLoginPOM//LinkedinLoginPOM//Linkedin//FileUpload.exe");
            Thread.Sleep(3000);
            DoneButton.Click();
            Thread.Sleep(3000);
            PostButton.Click();
        }
    }
}
