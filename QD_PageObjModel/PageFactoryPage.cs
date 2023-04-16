using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QD_PageObjModel
{
    public class PageFactoryPage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/h2")]
        private IWebElement LoginTitle { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/input[@id='username']")]
        private IWebElement LoginEmailField { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/input[@id='password']")]
        private IWebElement LoginPasswordField { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/input[@name = 'login']")]
        private IWebElement LoginButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/label[@for='rememberme']")]
        private IWebElement LoginRememberCheckBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-1')]/form/p/a")]
        public IWebElement LoginLostPswrd { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-2')]/h2")]
        private IWebElement RegisterTitle { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-2')]/form/p/input[@id='reg_email']")]
        private IWebElement RegisterEmailField { get; set; }



        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-2')]/form/p/input[@id='reg_password']")]
        private IWebElement RegisterPasswordField { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-2')]/form/p/input[@value='Register']")]
        private IWebElement RegisterButton { get; set; }

       
    }
}
