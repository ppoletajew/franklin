using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFranklin.Resource;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace SuperFranklin.Test
{
    [TestClass]
    public class TestBase
    {
        public IWebDriver Driver { get; private set; }

        [TestInitialize]
        public void Setup()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
    
}
