using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace SuperFranklin.Pages
{
    public class HomePage : BaseApplicationPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        private IWebElement buttonSignIn => Driver.FindElement(By.LinkText("Sign in"));
        private IWebElement buttonContinue => Driver.FindElement(By.Id("preauthbutton"));
        private IWebElement buttonLogin => Driver.FindElement(By.Id("loginbutton"));
        private IWebElement textfieldUsername => Driver.FindElement(By.Id("emailfield"));
        private IWebElement textfieldPassword => Driver.FindElement(By.Id("passwordfield"));

        internal void LoginWithDemoUser()
        {
            Assert.IsTrue(buttonSignIn.Displayed);
            buttonSignIn.Click();
            textfieldUsername.SendKeys("demo@andfrankly.com");
            buttonContinue.Click();
            textfieldPassword.SendKeys("demoaccount");
            Thread.Sleep(50);
            buttonLogin.Click();
            
        }
    }
}
