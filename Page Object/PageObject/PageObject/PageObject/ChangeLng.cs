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
    class ChangeLng
    {
        private IWebDriver driver;
        private By lngBtn = By.XPath("//span[@class='cur-lang']");
        private By engLng = By.XPath("//a[@href='/en/']");
        public ChangeLng(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void PushLngButton()
        {
            driver.FindElement(lngBtn).Click();
        }
        public void SetEngLng()
        {
            driver.FindElement(engLng).Click();
        }
    }
}
