using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject.PageObject
{
    public class Init
    {
        private IWebDriver driver;
        public Init(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void Start()
        {
            driver.Navigate().GoToUrl("https://www.uralairlines.ru/");
            driver.FindElement(By.XPath("//a[@href='#close']")).Click();
        }
    }
}
