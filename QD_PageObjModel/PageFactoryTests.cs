using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void SomeTest()
        {
          
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
