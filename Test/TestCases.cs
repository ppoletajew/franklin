using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFranklin.Pages;

namespace SuperFranklin.Test
{
    [TestClass]
    public class PageNavigation : TestBase
    {
        [TestMethod]
        public void SurveyQuestion1Test()
        {
            HomePage homePage = new HomePage(Driver);
            BaseApplicationPage baseApplicationPage = new BaseApplicationPage(Driver);
            SurveyPage surveyPage = new SurveyPage(Driver);
            QuestionPage questionPage = new QuestionPage(Driver);

            baseApplicationPage.GoFrankly();

            homePage.LoginWithDemoUser();

            surveyPage.VerifySuccesfulLogin();
            surveyPage.ClickOnFirstQuestion();
            questionPage.SlideGrowingSliderUp();
            questionPage.SubmitAnswer();
            surveyPage.VerifyThatQuestion1IsAnswered();
        }

        [TestMethod]
        public void SurveyQuestion2Test()
        {
            HomePage homePage = new HomePage(Driver);
            BaseApplicationPage baseApplicationPage = new BaseApplicationPage(Driver);
            SurveyPage surveyPage = new SurveyPage(Driver);
            QuestionPage questionPage = new QuestionPage(Driver);

            baseApplicationPage.GoFrankly();

            homePage.LoginWithDemoUser();

            surveyPage.VerifySuccesfulLogin();
            surveyPage.ClickOnSecondQuestion();
            questionPage.SlideOKSliderUp();
            questionPage.SubmitAnswer();
            surveyPage.VerifyThatQuestion2IsAnswered();
        }

        [TestMethod]
        public void SurveyQuestion3Test()
        {
            HomePage homePage = new HomePage(Driver);
            BaseApplicationPage baseApplicationPage = new BaseApplicationPage(Driver);
            SurveyPage surveyPage = new SurveyPage(Driver);
            QuestionPage questionPage = new QuestionPage(Driver);

            baseApplicationPage.GoFrankly();

            homePage.LoginWithDemoUser();

            surveyPage.VerifySuccesfulLogin();
            surveyPage.ClickOnThirdQuestion();
            questionPage.SlideXYSliderBR();
            questionPage.SubmitAnswer();
            surveyPage.VerifyThatQuestion3IsAnswered();
        }
    }
}
