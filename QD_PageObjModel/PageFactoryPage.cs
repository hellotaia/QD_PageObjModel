using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QD_PageObjModel
{
    public class PageFactoryPage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/h2")]
        private IWebElement loginTitle { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/input[@id='username']")]
        private IWebElement loginEmailField { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/input[@id='password']")]
        private IWebElement loginPasswordField { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/input[@name = 'login']")]
        private IWebElement loginButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/label[@for='rememberme']")]
        private IWebElement loginRememberCheckBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/a")]
        private IWebElement loginLostPswrd { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-2')]/h2")]
        private IWebElement registerTitle { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-2')]/form/p/input[@id='reg_email']")]
        private IWebElement registerEmailField { get; set; }



        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-2')]/form/p/input[@id='reg_password']")]
        private IWebElement registerPasswordField { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-2')]/form/p/input[@value='Register']")]
        private IWebElement registerButton { get; set; }

       
    }
}
