﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PageObject
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons close']")]
        [CacheLookup]
        public IWebElement Features_Close { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons close']")]
        [CacheLookup]
        public IWebElement KraftCrm_Close { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Privacy Policy')]")]
        [CacheLookup]
        public IWebElement PrivacyPollicy { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Terms of Use')]")]
        [CacheLookup]
        public IWebElement TermsOfUse { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Improve teamwork')]")]
        [CacheLookup]
        public IWebElement Features_ImproveTeamwork { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'User Friendly')]")]
        [CacheLookup]
        public IWebElement Features_UserFriendly { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='easy-share-information']//div[@class='ka-bind-txt']")]
        [CacheLookup]
        public IWebElement Features_EasyShareInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='accurate-and-rapid']//div[@class='ka-bind-txt']")]
        [CacheLookup]
        public IWebElement Features_AccurateRapid { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='awesome-ui-and-ux']//div[@class='ka-bind-txt']")]
        [CacheLookup]
        public IWebElement Features_AwesomeUI { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='no-limits']//div[@class='ka-bind-txt']")]
        [CacheLookup]
        public IWebElement Features_NoLimits { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='CRM-Basic-Plan']//div//a[contains(text(),'Get Started')]")]
        [CacheLookup]
        public IWebElement KraftCrmPlans_BasicPlan_GetStarted { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='CRM-Basic-Plan']//div//a[@class='ka-app-planitem-modalbutton article'][contains(text(),'see all...')]")]
        [CacheLookup]
        public IWebElement KraftCrmPlans_BasicPlan_SeeAll { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='play-demo-crm']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftCrm_PlayDemo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='customized-features']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftCrm_CustomizedFeatures { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='company-and-individual-cards']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftCrm_CompanyAndIndividualCards { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Assigning many different tasks and calls to your c')]")]
        [CacheLookup]
        public IWebElement KraftCrm_PrivateAndSharedCrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='Board-Basic-Plan-free']//div//a[contains(text(),'Get Started')]")]
        [CacheLookup]
        public IWebElement KraftBoardPlans_GetStarted { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='Board-Basic-Plan-free']//div//a[@class='ka-app-planitem-modalbutton article'][contains(text(),'see all...')]")]
        [CacheLookup]
        public IWebElement KraftBoardPlansBasicPlan_SeeAll { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='play-demo-boads']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftBoard_PlayDemo{ get; set; }

        [FindsBy(How =How.XPath, Using = "//span[contains(text(),'Activities and Boards')]")]
        [CacheLookup]
        public IWebElement KraftBoard_ActivitiesAndBoards { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ellipsis'][contains(text(),'Best practices are to assign task to few projects ')]")]
        [CacheLookup]
        public IWebElement KraftBoard_Teams { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons close']")]
        [CacheLookup]
        public IWebElement KraftMenuClose { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='diversified-access-rights']//div[@class='ka-app-feature-content']")]
        [CacheLookup]
        public IWebElement KraftBoard_DiversifiedAccessRight { get; set; }

        [FindsBy(How =How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'Home')]")]
        [CacheLookup]
        public IWebElement Home { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'Features')]")]
        [CacheLookup]
        public IWebElement Features { get; set; }

        [FindsBy(How =How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'Kraft CRM plans')]")]
        [CacheLookup]
        public IWebElement KraftCrmPlans { get; set; }

        [FindsBy(How =How.XPath, Using = "//div[@class='nav-container']//a[contains(text(),'Kraft Board plans')]")]
        [CacheLookup]
        public IWebElement KraftBoardPlansMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[4]//a[1]")]
        [CacheLookup]
        public IWebElement KraftCrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[2]//a[1]")]
        [CacheLookup]
        public IWebElement KraftBoard { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ka-btn-start is-active']//a[contains(text(),'Get Started')]")]
        [CacheLookup]
        public IWebElement GetStarted { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void WindowMaximize()
        {
            driver.Manage().Window.Maximize();
        }
        
        public void KraftBoardMenu()
        {
            Task.Delay(2000).Wait();
            KraftBoard.Click();
            Task.Delay(2000).Wait();
            KraftBoard_ActivitiesAndBoards.Click();
            Task.Delay(2000).Wait();
            KraftMenuClose.Click();
            Task.Delay(2000).Wait();
            KraftBoard_Teams.Click();
            Task.Delay(2000).Wait();
            KraftMenuClose.Click();
            Task.Delay(2000).Wait();
            KraftBoard_DiversifiedAccessRight.Click();
            Task.Delay(2000).Wait();
            KraftMenuClose.Click();
            Task.Delay(2000).Wait();
            KraftBoard_PlayDemo.Click();
            Task.Delay(2000).Wait();
            KraftMenuClose.Click();
            Task.Delay(2000).Wait();
            KraftBoardPlansMenu.Click();
            Task.Delay(2000).Wait();
            KraftBoardPlansBasicPlan_SeeAll.Click();
            Task.Delay(2000).Wait();
            KraftMenuClose.Click();
            Task.Delay(2000).Wait();
            KraftBoardPlans_GetStarted.Click();
            Task.Delay(2000).Wait();
            driver.Navigate().Back();
            Task.Delay(2000).Wait();
            KraftCrm.Click();
            Task.Delay(2000).Wait();
            KraftCrm_PrivateAndSharedCrm.Click();
            Task.Delay(2000).Wait();
            KraftCrm_Close.Click();
            Task.Delay(2000).Wait();
            KraftCrm_CompanyAndIndividualCards.Click();
            Task.Delay(2000).Wait();
            KraftCrm_Close.Click();
            Task.Delay(2000).Wait();
            KraftCrm_CustomizedFeatures.Click();
            Task.Delay(2000).Wait();
            KraftCrm_Close.Click();
            Task.Delay(2000).Wait();
            KraftCrm_PlayDemo.Click();
            Task.Delay(2000).Wait();
            KraftCrm_Close.Click();
            Task.Delay(2000).Wait();
            KraftCrmPlans.Click();
            Task.Delay(2000).Wait();
            KraftCrmPlans_BasicPlan_SeeAll.Click();
            Task.Delay(2000).Wait();
            KraftCrm_Close.Click();
            Task.Delay(2000).Wait();
            KraftCrmPlans_BasicPlan_GetStarted.Click();
            Task.Delay(2000).Wait();
            driver.Navigate().Back();
            Task.Delay(2000).Wait();
            Features.Click();
            Task.Delay(2000).Wait();
            Features_NoLimits.Click();
            Task.Delay(2000).Wait();
            Features_Close.Click();
            Task.Delay(2000).Wait();
            Features_AwesomeUI.Click();
            Task.Delay(2000).Wait();
            Features_Close.Click();
            Task.Delay(2000).Wait();
            Features_AccurateRapid.Click();
            Task.Delay(2000).Wait();
            Features_Close.Click();
            Task.Delay(2000).Wait();
            Features_EasyShareInformation.Click();
            Task.Delay(2000).Wait();
            Features_Close.Click();
            Task.Delay(2000).Wait();
            Features_UserFriendly.Click();
            Task.Delay(2000).Wait();
            Features_Close.Click();
            Task.Delay(2000).Wait();
            Features_ImproveTeamwork.Click();
            Task.Delay(2000).Wait();
            Features_Close.Click();
            Task.Delay(2000).Wait();
            Home.Click();
        }
        public void GoToLoginPage()
        {
            Task.Delay(2000).Wait();
            GetStarted.Click();
        }
    }
}
