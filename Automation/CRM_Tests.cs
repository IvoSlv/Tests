using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support;
using NUnit;
using OpenQA.Selenium.IE;
using System.Configuration;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;



namespace Automation
{

    public class CRM_Tests
    {
        //private static IWebDriver driverChrome = new ChromeDriver();
        // WebDriverWait wait = new WebDriverWait(driverChrome, TimeSpan.FromSeconds(10));
        private string browser = ConfigurationManager.AppSettings["browser"];
        public static IWebDriver webDriver;

        public CRM_Tests(string browser)
        {
            this.browser = browser;

        }

        [SetUp]
        public void Init()
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "ie":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
        }

        public void LoginBK()
        {
            webDriver.Url = "https://www.bindkraft.com/en/";
            webDriver.FindElement(By.XPath("//a[contains(text(),'Get Started')]")).Click();
        }

        public void Login()
        {

            IWebElement email = webDriver.FindElement(By.Id("Email"));
            IWebElement password = webDriver.FindElement(By.Id("Password"));
            email.SendKeys("drake@abv.bg");
            password.SendKeys("Dsa_123");

            webDriver.FindElement(By.XPath("//*[contains(text(),'Login')]")).Click();
            //Assert.Pass();
            //webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            

            //password.Submit();
        }
        

    public void ProfileMenu()
        {
            
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(@id,'Layer_1')]")));
            clickableElement.Click();
        }

        public void DisableNotification()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-notifications");
            options.AddArguments("--disable-application-cache");
            webDriver = new ChromeDriver(options);

        }

        public void EndTest()
        {
            webDriver.Quit();

        }


        // TODO : example
        public void TestWithChromeDriver()
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"https://www.bindkraft.com/en/");
                var link = driver.FindElement(By.PartialLinkText("Get Started"));
                var jsToBeExecuted = $"window.scroll(0, {link.Location.Y});";
                ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted);
                var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("Get Started")));
                clickableElement.Click();

                //PageFactory
            }
        }
                
               [FindsBy(How = How.XPath, Using = "pwd")]
              public IWebElement Password { get; set; }







        public void GoToCRMHomePage()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(text(),'KraftCRM')]")));
            clickableElement.Click();
            //Assert.True(false, "Test false");
        }

        public void GoToCRMCompanyTab()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(text(),'Companies:')]")));
            clickableElement.Click();
        }

        public void CRMCreateCompany()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='bk-box-create bk-innerer-box-width']")));
            clickableElement.Click();
            IWebElement name = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@placeholder='Enter the name of the company']")));
            name.SendKeys("Company1");
            webDriver.FindElement(By.XPath("//*[contains(text(),'Save')]")).Click();
        }

        public void GoToCRM_PeopleTab()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(text(),'People')]")));
            clickableElement.Click();
        }

        public void CRM_CreatePerson()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='bk-people-container full-height']//div//span[@class='bk-box-create-icon'][contains(text(),'+')]")));
            clickableElement.Click();
            IWebElement FirstName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@placeholder='Enter the first name of your contact']")));
            IWebElement LastName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@placeholder='Enter the last name of your contact']")));
            FirstName.SendKeys("Person1");
            LastName.SendKeys("Person1");
            webDriver.FindElement(By.XPath("//*[contains(text(),'Save')]")).Click();
        }

        public void GoTo_Reminders()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(text(),'Reminders')]")));
            clickableElement.Click();
            // Assert.True(false, "ahgsdjag");
        }

        public void CRM_CreateReminder()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@data-class='KCRM_RemindersMain']//span[@class='bk-box-create-icon'][contains(text(),'+')]")));
            clickableElement.Click();
            IWebElement description = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@placeholder='Enter your text']")));
            description.SendKeys("My new Reminder");
            webDriver.FindElement(By.XPath("//*[contains(text(),'Save')]")).Click();

        }

        public void CRM_CreateCRM()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(5000));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class='bk-box-create-icon']")));
            clickableElement.Click();
            IWebElement name = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Name']")));
            
            name.SendKeys("Test_CRM");
            webDriver.FindElement(By.XPath("//button[@id='createCRM']")).Click();
        }

        public void Dispose()
        {
            webDriver.Quit();
            throw new NotImplementedException();
        }
    }
}

    




