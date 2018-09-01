using System;
using OpenQA.Selenium;

namespace SuperFranklin.Pages

{
    public class BaseApplicationPage
    {
        protected IWebDriver Driver { get; set; }
        public BaseApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        internal void GoFrankly()
        {
            Driver.Navigate().GoToUrl("https://www.andfrankly.com/");
        }
    }

    
}
