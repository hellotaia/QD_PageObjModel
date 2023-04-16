using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QD_PageObjModel
{
    public class MyAccountPage
    {
       private IWebDriver driver;
       private WebDriverWait wait;

        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        //добавить локаторы на все основные элементы страницы (тайтлы, поля, кнопки);
        //login column
        public IWebElement LoginTitle => driver.FindElement(By.XPath("//div[@id='customer_login']/div/h2"));
        public IWebElement LoginEmailField => driver.FindElement(By.XPath("//input[@id='username']"));
        public IWebElement LoginPasswordField => driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//input[@name='login']"));
        public IWebElement LoginRememberCheckBox => driver.FindElement(By.XPath("//label[@for='rememberme']"));
        public IWebElement LoginLostPswrd => driver.FindElement(By.XPath("//div[@id='customer_login']/div/form/p/a"));
        // register column 
        public IWebElement RegisterTitle => driver.FindElement(By.XPath("//div[contains(@class,'col-2')]/h2"));
        public IWebElement RegisterEmailField => driver.FindElement(By.XPath("//input[@id='reg_email']"));
        public IWebElement RegisterPasswordField => driver.FindElement(By.XPath("//input[@id='reg_password']"));
        public IWebElement RegisterButton => driver.FindElement(By.XPath("//input[@value='Register']"));

        //написать методы, возвращающие текстовые значения из: "Lost your password?", "Remember me" и кнопки "Register";
        public string LostYourPswrdText()
        {
            return LoginLostPswrd.Text;
        }
        public string RememberMeText() 
        {
           return LoginRememberCheckBox.Text;
        }
        public string RegisterText()
        {
            string value = RegisterButton.GetAttribute("value");
            return value; 
        }

        //написать метод который вводит переданные в данный метод значения в поля "Username or email address" и "Password" и после кликает по кнопке "Login";
        public void LoginFlow(string username, string password)
        {
            LoginEmailField.SendKeys(username);
            LoginPasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}
