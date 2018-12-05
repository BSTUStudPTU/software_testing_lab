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
            mainPage = new MainPage(driver);
            mainPage.OpenPage();
        }
        public void CloseBrowser()
        {
            DriverInit.CloseBrowser();
        }
        public void InsertDepCityAndArrCity(string cityName_dep, string cityName_arr)
        {
            mainPage.InsertDepartureCity(cityName_dep);
            mainPage.InsertArrivalCity(cityName_arr);
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
