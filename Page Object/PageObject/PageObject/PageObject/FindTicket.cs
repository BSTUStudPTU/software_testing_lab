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
    class FindTicket
    {
        private IWebDriver driver;
        private By depCity = By.XPath("//input[@placeholder='Откуда']");
        private By arrCity = By.XPath("//input[@placeholder='Куда']");
        private By srchButton = By.XPath("//div[@class='butsWr']");

        public FindTicket(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void InsertDepCity(string cityName)
        {
            driver.FindElement(depCity).Clear();
            driver.FindElement(depCity).SendKeys(cityName);
        }
        public void InsertArrCity(string cityName)
        {
            driver.FindElement(arrCity).Clear();
            driver.FindElement(arrCity).SendKeys(cityName);
        }
        public void PushSrchButton()
        {
            driver.FindElement(srchButton).Click();
        }


    }
}
