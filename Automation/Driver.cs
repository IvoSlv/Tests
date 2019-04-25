using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using NUnit;
using NUnit.Framework;
using System.Configuration;

namespace Automation
{
    
    
        public static class Driver
        {
             private static WebDriverWait browserWait;
             private static string browserType = ConfigurationManager.AppSettings["browser"];
             public static IWebDriver webDriver;
          public static IWebDriver Browser
            {
                get
                {
                    if (webDriver == null)
                    {
                        throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                    }
                    return webDriver;
                }
                private set => webDriver = value;
            }
            public static WebDriverWait BrowserWait
            {
                get
                {
                    if (browserType == null || webDriver == null)
                    {
                        throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                    }
                    return browserWait;
                }
                private set => browserWait = value;
            }

        
        }

    public void Init()
    {
        switch (webD.ToLower())
        {
            case "chrome":
                webDriver = new ChromeDriver();
                break;
            case "ie":
                webDriver = new InternetExplorerDriver();
                break;
            case "firefox":
                B = new FirefoxDriver();
                break;
        }
        webDriver.Manage().Window.Maximize();
    }
    public static void StartBrowser( )
            {
                switch (browserType.ToLower())
                {
                case "chrome":
                _browser = new ChromeDriver();
                    break;
                case "ie":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "firefox":
                    Browser = new FirefoxDriver();
                    break;
                    default:
                        throw new ArgumentException("You need to set a valid browser type.");
                }
                BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultTimeOut));
                webDriver.Manage().Window.Maximize();
        }
            public static void StopBrowser()
            {
                Browser.Quit();
                Browser = null;
                BrowserWait = null;
            }

        }
    }

