using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace Framework.Driver
{
    public class DriverInit
    {
        private static IWebDriver driver;
        private DriverInit()
        {

        }
        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }
    }
}
