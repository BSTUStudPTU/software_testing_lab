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

        [FindsBy(How = How.XPath, Using = "//div[@class='butsWr']")]
        private IWebElement searchBtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='avia-to']")]
        private IWebElement arrCity;

        [FindsBy(How = How.XPath, Using = "//input[@id='avia-from']")]
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

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }
        public void InsertDepartureCity(string cityName)
        {
            depCity.Clear();
            depCity.SendKeys(cityName);
        }

        public void InsertArrivalCity(string cityName)
        {
            arrCity.Clear();
            arrCity.SendKeys(cityName);
        }
        public void PushSearchButton()
        {
            searchBtn.Click();
        }
        public void FindOnCiteByText(string text)
        {
            srchOnCiteBtn.Click();
            srchOnCiteTextBox.Clear();
            srchOnCiteTextBox.SendKeys(text);
            srchOnCiteBtnActive.Click();
        }
        public void ChangeToEng()
        {
            lngBtn.Click();
            engLng.Click();
        }
    }
}
