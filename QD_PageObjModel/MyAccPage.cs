using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace QD_PageObjModel
{
    public class MyAccPage
    {
       private IWebDriver driver;
       private WebDriverWait wait;

        public MyAccPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        //добавить локаторы на все основные элементы страницы (тайтлы, поля, кнопки);
        //login column
        public IWebElement loginTitle => driver.FindElement(By.XPath("//div[contains(@class,'col-1')]/h2"));
        public IWebElement loginEmailField => driver.FindElement(By.XPath("//div[contains(@class,'col-1')]/form/p/input[@id='username']"));
        public IWebElement loginPasswordField => driver.FindElement(By.XPath("//div[contains(@class,'col-1')]/form/p/input[@id='password']"));
        public IWebElement loginButton => driver.FindElement(By.XPath("//div[contains(@class,'col-1')]/form/p/input[@name = 'login']"));
        public IWebElement loginRememberCheckBox => driver.FindElement(By.XPath("//div[contains(@class,'col-1')]/form/p/label[@for='rememberme']"));
        public IWebElement loginLostPswrd => driver.FindElement(By.XPath("//div[contains(@class,'col-1')]/form/p/a"));
        // register column 
        public IWebElement registerTitle => driver.FindElement(By.XPath("//div[contains(@class,'col-2')]/h2"));
        public IWebElement registerEmailField => driver.FindElement(By.XPath("//div[contains(@class,'col-2')]/form/p/input[@id='reg_email']"));
        public IWebElement registerPasswordField => driver.FindElement(By.XPath("//div[contains(@class,'col-2')]/form/p/input[@id='reg_password']"));
        public IWebElement registerButton => driver.FindElement(By.XPath("//div[contains(@class,'col-2')]/form/p/input[@value='Register']"));

        //написать методы, возвращающие текстовые значения из: "Lost your password?", "Remember me" и кнопки "Register";
        public string LostYourPswrdText()
        {
            return loginLostPswrd.Text;
        }
        public string RememberMeText() 
        {
           return loginRememberCheckBox.Text;
        }
        public string RegisterText()
        {
            string value = registerButton.GetAttribute("value");
            return value; 
        }

        //написать метод который вводит переданные в данный метод значения в поля "Username or email address" и "Password" и после кликает по кнопке "Login";
        public void LoginFlow(string username, string password)
        {
            loginEmailField.SendKeys(username);
            loginPasswordField.SendKeys(password);
            loginButton.Click();
        }
    }
}
