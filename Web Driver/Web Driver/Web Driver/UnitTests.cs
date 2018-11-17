using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Web_Driver
{
    class UnitTests
    {
        //Due to my website is create using only javascript -> i can't use it in order to test(i couldn't find how to do this) 
        //Because of this problem i use www.uralairlines.ru 
        [Test]
        public void FromBakuToMinskTestSearch()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.uralairlines.ru/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            driver.FindElement(By.XPath("//a[@href='#close']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Откуда']")).Clear();
            driver.FindElement(By.XPath("//input[@placeholder='Откуда']")).SendKeys("ББаку");
            driver.FindElement(By.XPath("//input[@placeholder='Куда']")).Clear();
            driver.FindElement(By.XPath("//input[@placeholder='Куда']")).SendKeys("ММинск");
            driver.FindElement(By.XPath("//div[@class='butsWr']")).Click();
            driver.Quit();
        }
    }
}
