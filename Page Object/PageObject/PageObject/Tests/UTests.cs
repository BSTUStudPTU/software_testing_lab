using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using PageObject.PageObject;

namespace PageObject.Tests
{
    public class UTests
    {
        [Test]
        public void FromBakuToMinskTestSearch()
        {

            IWebDriver driver = new ChromeDriver();
            Init startTest = new Init(driver);
            FindTicket testTicket = new FindTicket(driver);

            startTest.Start();
            testTicket.InsertDepCity("ББаку");
            testTicket.InsertArrCity("Мминск");
            testTicket.PushSrchButton();
            driver.Quit();
        }
        [Test]
        public void ChangeLanguage()
        {
            IWebDriver driver = new ChromeDriver();
            Init startTest = new Init(driver);
            ChangeLng testLanguage = new ChangeLng(driver);
            startTest.Start();
            testLanguage.PushLngButton();
            testLanguage.SetEngLng();
            driver.Quit();
        }
    }
}
