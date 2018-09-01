using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace SuperFranklin.Pages
{
    public class QuestionPage : BaseApplicationPage
    {
        public QuestionPage(IWebDriver driver) : base(driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        private IWebElement sliderGrowing => Driver.FindElement(By.Id("growingslider96"));
        private IWebElement sliderXY => Driver.FindElement(By.Id("sliderimage98"));
        private IWebElement sliderOk => Driver.FindElement(By.Id("sliderimage1063"));
        private IWebElement buttonSubmit => Driver.FindElement(By.XPath("//img[@src='/img/insight/pil@2x.png']"));

        internal void SlideGrowingSliderUp()
        {
            Actions actions = new Actions(Driver);
            actions.DragAndDropToOffset(sliderGrowing, 0, -500);
            actions.Perform();

        }

        internal void SlideGrowingSliderDown()
        {
            Actions actions = new Actions(Driver);
            actions.DragAndDropToOffset(sliderGrowing, 0, -500);
            actions.Perform();
        }

        internal void SlideXYSliderBR()
        {
            Actions actions = new Actions(Driver);
            actions.DragAndDropToOffset(sliderXY, 100, 100);
            actions.Perform();
        }

        internal void SlideOKSliderUp()
        {
            Actions actions = new Actions(Driver);
            actions.DragAndDropToOffset(sliderOk, 0, -500);
            actions.Perform();
        }

        internal void SubmitAnswer()
        {
            buttonSubmit.Click();
        }


    }
}
