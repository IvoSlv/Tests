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
using Xunit;
using OpenQA.Selenium.IE;
using System.Configuration;
using Automation;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            
            CRM_Tests chrome = new CRM_Tests("chrome");
            chrome.Init();

            chrome.LoginBK();
            chrome.Login();
            chrome.GoToCRMHomePage();
            chrome.CRM_CreateCRM();
           // chrome.GoToCRMCompanyTab();
           // chrome.GoTo_Reminders();
           // chrome.CRM_CreateReminder();
            

          
         
           // chrome.Dispose();
           // chrome.CRMCreateCompany();
            //chrome.GoToCRM_PeopleTab();
            //chrome.CRM_CreatePerson();

           
            //chrome.ProfileMenu();
            //chrome.EndTest();







        }

        
    }
}
