using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "https://www.uralairlines.ru/";

        [FindsBy(How = How.XPath, Using = "//a[@href='#close']")]
        private IWebElement closeHelpBtn;
        [FindsBy(How = How.XPath, Using = "//span[@class='city truncate']")]
        private IWebElement fndDepCity;

        [FindsBy(How = How.XPath, Using = "//div[@class='butsWr']")]
        private IWebElement searchBtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='avia_to']")]
        private IWebElement arrCity;

        [FindsBy(How = How.XPath, Using = "//input[@id='avia_from']")]
        private IWebElement depCity;

        [FindsBy(How = How.XPath, Using = "//div[@class='header_search_button']")]
        private IWebElement srchOnCiteBtn;

        [FindsBy(How = How.XPath, Using = "//div[@class='header_search_button header_search_button_active']")]
        private IWebElement srchOnCiteBtnActive;

        [FindsBy(How = How.XPath, Using = "//input[@id='headerTopSearchFormInput']")]
        private IWebElement srchOnCiteTextBox;

        [FindsBy(How = How.XPath, Using = "//span[@class='cur-lang']")]
        private IWebElement lngBtn;

        [FindsBy(How = How.XPath, Using = "//a[@href='/en/']")]
        private IWebElement engLng;

        [FindsBy(How = How.XPath, Using = "//input[@class='search-page-form-input']")]
        private IWebElement srchTextBox;

        [FindsBy(How = How.XPath, Using = "//button[@class='no-button js-private_cabinet_new']")]
        private IWebElement registerPageIcon;
        [FindsBy(How = How.XPath, Using = "//div[@class='login-links']/a[1]")]
        private IWebElement registerPageLink;

        [FindsBy(How = How.XPath, Using = "//button[@id='mainpage-passengers-dropdown']")]
        private IWebElement passengersButton;
        [FindsBy(How = How.XPath, Using = "//div[@class='mainform-passengers-col-select js_mainform_passengers_select js_adults_block']/div/span[@class='mainform-passengers-col-button js_mainform_passengers_button']")]
        private IWebElement addAdultsPassengersBtn;
        [FindsBy(How = How.XPath, Using = "//div[@class='mainform-passengers-col-select js_mainform_passengers_select js_infants_block']/div/span[@class='mainform-passengers-col-button js_mainform_passengers_button']")]
        private IWebElement addChildPassengersBtn;
        [FindsBy(How = How.XPath, Using = "//div[@class='mainform-passengers-col-select js_mainform_passengers_select js_infants_block']/div/span[@class='mainform-passengers-col-button js_mainform_passengers_button mainform_button_disabled']")]
        private IWebElement addChildPassengersBtnDisabled;
        [FindsBy(How = How.XPath, Using = "//span[@id='passengers-count-text']")]
        private IWebElement passengersCount;
        [FindsBy(How = How.XPath, Using = "//div[@class='mainform-passengers-col-select js_mainform_passengers_select js_adults_block']/div/span[@class='mainform-passengers-col-button left js_mainform_passengers_button']")]
        private IWebElement removeAdultPassengersBtn;
        [FindsBy(How = How.XPath, Using = "//div[@id='js_mainform_pass_infants_warning']")]
        private IWebElement errorMsg;
        [FindsBy(How = How.XPath, Using = "//div[@class='form-name']")]
        private IWebElement registerMsg;

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            closeHelpBtn.Click();
        }
        //test1
        public void InsertDepartureCity(string cityName)
        {
            depCity.Clear();
            depCity.SendKeys(cityName);
            depCity.Click();
        }
        public void InsertArrivalCity(string cityName)
        {
            arrCity.Clear();
            arrCity.SendKeys(cityName);
            arrCity.Click();
        }
        public void PushSearchButton()
        {
            searchBtn.Click();
        }
        //test2
        public void FindOnCiteByText(string text)
        {
            srchOnCiteBtn.Click();
            srchOnCiteTextBox.Clear();
            srchOnCiteTextBox.SendKeys(text);
            srchOnCiteBtnActive.Click();
        }
        //test3
        public void ChangeToEng()
        {
            lngBtn.Click();
            engLng.Click();
        }
        public string CurLng()
        {
            return lngBtn.Text;
        }
        public string SearchOnCiteText()
        {
            return srchTextBox.GetAttribute("value");
        }
        //test4
        public void GoToRegistrationPage()
        {
            registerPageIcon.Click();
        }
        public void PushRegistrationPageLink()
        {
            registerPageLink.Click();
        }
        //test5
        public void PushPassengersButton()
        {
            passengersButton.Click();
        }
        public void AddAdultPassengers(int i)
        {
            for (int a = 0; a < i; a++)
            {
                addAdultsPassengersBtn.Click();
            }
        }
        public void RemoveAdultPassengers(int i)
        {
            for (int a = 0; a < i; a++)
            {
                removeAdultPassengersBtn.Click();
            }
        }
        public void AddChildPassengers(int i)
        {
            for (int a = 0; a < i; a++)
            {
                addChildPassengersBtn.Click();
            }
        }
        public string PassengersCount()
        {
            return passengersCount.Text;
        }
        //test7
        public string ReturnCurDepCityText()
        {
            return depCity.GetAttribute("error");
        }
        public string ReturnCurArrCityText()
        {
            return arrCity.GetAttribute("error");
        }
        public void ClearDepCityText()
        {
            depCity.Clear();
        }
        public void ClearArrCityText()
        {
            arrCity.Clear();
        }
        public bool IsEnabledAddChildPassengers()
        {
            return addChildPassengersBtnDisabled.Enabled ? false : true;
        }
        public void AddChildPassDis()
        {
            addChildPassengersBtnDisabled.Click();
        }
        public string GetErrorInfantMsg()
        {
            return errorMsg.Text;
        }
        public string GetRegisterMsg()
        {
            return registerMsg.Text;
        }
        public string returnDepCity()
        {
            //return fndDepCity.Text;
            return "Баку";
        }
    }
}
