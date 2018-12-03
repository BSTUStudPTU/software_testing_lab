using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Tests
{
    public class Tests
    {
        Framework.Steps.Steps steps = new Framework.Steps.Steps();
        [Test]
        public void FromBakuToMinskTestSearch()
        {
            steps.InitBrowser();
            steps.InitMainPage();
            steps.InsertDepCity("Баку");
            steps.InsertArrCity("Москва");
            steps.ClickSearchBtn();
            Assert.("Баку", driver.FindElement(By.XPath("//div[@data-v-6e19f88a class='flight-line']")).text);
            Assert.("MOW", driver.FindElement(By.XPath("//span[@data-v-6e19f88a class='airport-suffix']")).text);
            steps.CloseBrowser();
        }
        [Test]
        public void ChangeToEng()
        {
            steps.InitBrowser();
            steps.InitMainPage();
            steps.ChangeToEnglish();
            Assert.("EN", driver.FindElement(By.XPath("//span[@class='cur-lang']")).text);
            steps.CloseBrowser();
        }
        [Test]
        public void SearchOnSiteByTextMoscow()
        {
            steps.InitBrowser();
            steps.InitMainPage();
            steps.FindOnCite("Москва");
            Assert.("Москва", driver.FindElement(By.XPath("//input[@placeholder='Поиск']")).text);
            steps.CloseBrowser();

        }
    }
}
