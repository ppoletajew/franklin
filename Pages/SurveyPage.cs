using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace SuperFranklin.Pages
{
    public class SurveyPage : BaseApplicationPage
    {

        public SurveyPage(IWebDriver driver) : base(driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        private IWebElement buttonSignOut => Driver.FindElement(By.LinkText("Sign out"));
        private IWebElement buttonQuestion1 => Driver.FindElement(By.XPath("//*[@id='answering']/div/div[2]/div/div[1]/div[1]"));
        private IWebElement buttonQuestion2 => Driver.FindElement(By.XPath("//*[@id='answering']/div/div[3]/div/div[1]/div[1]"));
        private IWebElement buttonQuestion3 => Driver.FindElement(By.XPath("//*[@id='answering']/div/div[4]/div/div[1]/div[1]"));
        private IWebElement textQuestionLast => Driver.FindElement(By.CssSelector("#answering > div > div:nth-child(7) > div > div.MoAp-kF_gqoQ6dtJnZw3p > div.pDhsDXLidvbk2OXBd1lYv > div.yg5soW4JJlxOfN7o_DCwD > div._2xtcHvKycdzasgvrb0R3SS"));

        internal void VerifySuccesfulLogin()
        {
            Assert.IsTrue(buttonSignOut.Displayed);
            Thread.Sleep(250);
        }

        internal void VerifyThatQuestion1IsAnswered()
        {
            Thread.Sleep(500);
            string answered = textQuestionLast.Text;
            Assert.AreEqual("I like my work at this very point...", answered);
        }

        internal void VerifyThatQuestion2IsAnswered()
        {
            Thread.Sleep(500);
            string answered = textQuestionLast.Text;
            Assert.AreEqual("If you had the chance today, woul...", answered);
        }

        internal void VerifyThatQuestion3IsAnswered()
        {
            Thread.Sleep(500);
            string answered = textQuestionLast.Text;
            Assert.AreEqual("Describe your current stress levels", answered);
        }

        internal void ClickOnFirstQuestion()
        {
            Thread.Sleep(500);
            buttonQuestion1.Click(); 
        }

        internal void ClickOnSecondQuestion()
        {
            Thread.Sleep(500);
            buttonQuestion2.Click();
        }

        internal void ClickOnThirdQuestion()
        {
            Thread.Sleep(500);
            buttonQuestion3.Click();
        }
    }
}
