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
        static public MainPage mainPage;
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

        //test1
        public void InsertDepCityAndArrCity(string cityName_dep, string cityName_arr)
        {
            mainPage.InsertArrivalCity(cityName_arr);
            mainPage.InsertDepartureCity(cityName_dep);
        }
        public void ClickSearchBtn()
        {
            mainPage.PushSearchButton();
        }
        public string findDepCity()
        {
            BookPage bookPage = new BookPage(driver);
            return bookPage.returnDepCity();
        }


        //test2
        public void FindOnCite(string text)
        {
            mainPage.FindOnCiteByText(text);
        }
        public string returnSearchResult()
        {
            return mainPage.SearchOnCiteText();
        }

        //test3
        public void ChangeToEnglish()
        {
            mainPage.ChangeToEng();
        }
        public string returnCurLng()
        {
            return mainPage.CurLng();
        }

        //test4
        public void GoToRegister()
        {
            mainPage.GoToRegistrationPage();
            mainPage.PushRegistrationPageLink();
        }
        //test5
        public void AddNewPassengers(int number)
        {
            mainPage.PushPassengersButton();
            mainPage.AddAdultPassengers(number);
        }
        public string returnCurPassengersNumber()
        {
            return mainPage.PassengersCount();
        }
        //test6
        public void RemoveAllPassengers(int numb)
        {
            mainPage.PushPassengersButton();
            mainPage.RemoveAdultPassengers(1);
        }
        //test7

        public string ReturnCurDepCityTextValue()
        {
            return mainPage.ReturnCurDepCityText();
        }
        public string GetRegisterMsg()
        {
            return mainPage.GetRegisterMsg();
        }
        public string ReturnCurArrCityTextValue()
        {
            return mainPage.ReturnCurArrCityText();
        }
        public void ClearDepCity()
        {
            mainPage.ClearDepCityText();
        }
        public void ClearArrCity()
        {
            mainPage.ClearArrCityText();
        }
        public void AddNewChildPassengers(int number)
        {
            mainPage.PushPassengersButton();
            mainPage.AddChildPassengers(number);
        }
        public bool IsAddNewChildDisabled()
        {
            return mainPage.IsEnabledAddChildPassengers();
        }
        public void AddNewChildPassWhenDisabled()
        {
            mainPage.AddChildPassDis();
        }
        public string GetInfantsErrorMsg()
        {
            return mainPage.GetErrorInfantMsg();
        }
    }
}
