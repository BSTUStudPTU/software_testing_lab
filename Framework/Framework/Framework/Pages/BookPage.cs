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
    public class BookPage
    {
        private const string BASE_URL = "https://book.uralairlines.ru/";

        // [FindsBy(How = How.XPath, Using = "//p[@class='departure']//span[@class='city truncate']")]
        [FindsBy(How = How.XPath, Using = "//div[@id='app']")]
        private IWebElement depCity;

        private IWebDriver driver;

        public BookPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }
        public string returnDepCity()
        {
            return depCity.Text;
        }

       /* public void InsertArrivalCity(string cityName)
        {
            arrCity.Clear();
            arrCity.SendKeys(cityName);
            arrCity.Click();
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
        }*/
    }
}
