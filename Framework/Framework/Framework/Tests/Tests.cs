using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            steps.CloseBrowser();
        }
        [Test]
        public void ChangeToEng()
        {
            steps.InitBrowser();
            steps.InitMainPage();
            steps.ChangeToEnglish();
            steps.CloseBrowser();
        }
        [Test]
        public void SearchOnSiteByTextMoscow()
        {
            steps.InitBrowser();
            steps.InitMainPage();
            steps.FindOnCite("Москва");
            
        }
    }
}
