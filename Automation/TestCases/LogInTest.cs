using ConsoleApp1.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver(@"D:\_Development\ChromeDriverOld"); ;
            driver.Url = "https://www.bindkraft.com/en/";

            var homePage = new HomePage(driver);
            homePage.MyAccount.Click();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication();

            driver.Close();
        }

         

    }
}
