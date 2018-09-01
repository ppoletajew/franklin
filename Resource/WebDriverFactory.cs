using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Reflection;


namespace SuperFranklin.Resource
{
    public class WebDriverFactory
    {
        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return UseChromeDriver();
                case BrowserType.Firefox:
                    return UseFirefoxDriver();
                default:
                    throw new ArgumentOutOfRangeException("This browser is not supported");
            }
        }
        private IWebDriver UseChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        private IWebDriver UseFirefoxDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new FirefoxDriver(outPutDirectory);
        }
    }
}
