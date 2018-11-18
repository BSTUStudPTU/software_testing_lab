using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Framework.Driver;
using Framework.Pages;

namespace Framework.Steps
{
    public class Steps
    {
        private IWebDriver driver;
        static MainPage mainPage; 
        public void InitBrowser()
        {
            driver = DriverInit.GetInstance();
        }
        public void CloseBrowser()
        {
            DriverInit.CloseBrowser();
        }
        public void InitMainPage()
        {
            mainPage = new MainPage(driver);
            mainPage.OpenPage();
        }
        public void InsertDepCity(string cityName)
        {
            mainPage.InsertDepartureCity(cityName);
        }
        public void InsertArrCity(string cityName)
        {
            mainPage.InsertArrivalCity(cityName);
        }
        public void ClickSearchBtn()
        {
            mainPage.PushSearchButton();
        }
        public void FindOnCite(string text)
        {
            mainPage.FindOnCiteByText(text);
        }
        public void ChangeToEnglish()
        {
            mainPage.ChangeToEng();
        }
    }
}
