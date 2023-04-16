using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QD_PageObjModel
{
    internal class PageFactoryTests
    {
        IWebDriver driver;
        PageFactoryPage pageFactoryPage;
        string URL = "https://practice.automationtesting.in/my-account/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
            pageFactoryPage = new PageFactoryPage();
            PageFactory.InitElements(driver, pageFactoryPage);
        }

        [Test]
        public void SomeExampleTest()
        {
            string actualText = pageFactoryPage.LoginLostPswrd.Text;
            string expectedTest = "Lost your password?";
            Assert.AreEqual(actualText, expectedTest);
        }
            [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
