using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QD_PageObjModel
{
    public class MyAccountTests
    {
        //создаем отдельный класс и реализуем автотесты для всех методов из пейдж класса с использованием ассертов NUnit.
        private IWebDriver driver;
        private WebDriverWait wait;
        private MyAccountPage myAccPage;

        private string URL = "https://practice.automationtesting.in/my-account/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            myAccPage = new MyAccountPage(driver);
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestLostPswrdLinkText()
        {
            string expectedText = "Lost your password?";
            string actualText = myAccPage.LostYourPswrdText();
            Assert.AreEqual(expectedText, actualText, 
                "LostPswrdLinkText values are not matched");
        }

        [Test]
        public void TestRememberMeText()
        {
            string expextedText = "Remember me";
            string actualText = myAccPage.RememberMeText();
            Assert.AreEqual(expextedText, actualText, 
                "RememberMeText values are not matched");
        }

        [Test]
        public void TestRegisterTextButton() 
        {
            string expextedText = "Register";
            string actualText = myAccPage.RegisterText();
            Assert.AreEqual(expextedText, actualText, 
                "RegisterTextButton values are not matched");
        }
        [Test]
        //реализовать тесты для логин флоу метода
        public void TestLoginInvalidUserName()
        {
            string username = "hhhhpepepellalfjf";
            string password = "qwerty";
            string expectedError = $"Error: the username {username} is not registered on this site. " +
                $"If you are unsure of your username, try your email address instead.";
            myAccPage.LoginFlow(username,password);
            Assert.AreEqual(expectedError, 
                driver.FindElement(By.XPath("//ul[@class=\"woocommerce-error\"]")).Text);
        }

        [Test]
        public void TestLoginInvalidEmail() 
        {
            string username = "mmm@cc.com";
            string password = "qwerty";
            myAccPage.LoginFlow(username, password);
            Assert.AreEqual("Error: A user could not be found with this email address.", 
                driver.FindElement(By.XPath("//ul[@class=\"woocommerce-error\"]")).Text);
        }
        
        [Test]
        public void TestLoginWithValidEmail()
    {
            string email = "testuser@test.com";
            string username = "testuser7";
            string password = "Password12345!@#$%";
            myAccPage.LoginFlow(email, password);          
            Assert.AreEqual(username, driver.FindElement(By.XPath("//*[@class=\"type-page\"]/div/div[1]/div/p[1]/strong")).Text);
        }

        [Test]
        public void TestLoginWithInvalidPassword()
        {
            string email = "testuser@test.com";
            string username = "testuser7";
            string password = "qwerty";
            string expectedErrorEmail = $"Error: the password you entered for the username {email} is incorrect. Lost your password?";
            string expectedErrorUser = $"Error: the password you entered for the username {username} is incorrect. Lost your password?";
            myAccPage.LoginFlow(email, password);
            Assert.AreEqual(expectedErrorEmail,
                driver.FindElement(By.XPath("//ul[@class=\"woocommerce-error\"]")).Text);
            myAccPage.LoginEmailField.Clear();
            myAccPage.LoginFlow(username, password);
            Assert.AreEqual(expectedErrorUser,
                driver.FindElement(By.XPath("//ul[@class=\"woocommerce-error\"]")).Text);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
