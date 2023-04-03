using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace QD_PageObjModel
{
    public class MyAccTests
    {
        //создаем отдельный класс и реализуем автотесты для всех методов из пейдж класса с использованием ассертов NUnit.
        private IWebDriver driver;
        private WebDriverWait wait;
        private MyAccPage myAccPage;

        private string URL = "https://practice.automationtesting.in/my-account/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            myAccPage = new MyAccPage(driver);
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestLostPswrdLinkText()
        {
            string expectedText = "Lost your password?";
            string actualText = myAccPage.LostYourPswrdText();
            Assert.AreEqual(expectedText, actualText, "LostPswrdLinkText values are not matched");
        }

        [Test]
        public void TestRememberMeText()
        {
            string expextedText = "Remember me";
            string actualText = myAccPage.RememberMeText();
            Assert.AreEqual(expextedText, actualText, "RememberMeText values are not matched");
        }

        [Test]
        public void TestRegisterTextButton() 
        {
            string expextedText = "Register";
            string actualText = myAccPage.RegisterText();
            Assert.AreEqual(expextedText, actualText, "RegisterTextButton values are not matched");
        }
        [Test]
        //реализовать тесты для логин флоу метода
        public void TestLoginInvalidUserName()
        {
            string username = "hhhhpepepellalfjf";
            string password = "qwerty";
            myAccPage.LoginFlow(username,password);
            Assert.AreEqual($"Error: the username {username} is not registered on this site. If you are unsure of your username, try your email address instead.", driver.FindElement(By.XPath("//ul[@class=\"woocommerce-error\"]")).Text);
        }

        [Test]
        public void TestLoginInvalidEmail() 
        {
            string username = "mmm@cc.com";
            string password = "qwerty";
            myAccPage.LoginFlow(username, password);
            Assert.AreEqual("Error: A user could not be found with this email address.", driver.FindElement(By.XPath("//ul[@class=\"woocommerce-error\"]")).Text);
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
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
