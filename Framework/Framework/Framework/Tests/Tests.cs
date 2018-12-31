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
        private const string foundDepCity = "Баку";
        private const string engLng = "EN";
        private const string srchOnSiteResult = "Москва";
        private const string passengersCountAfterAdding = "3 пассажирa";
        private const string passengersCountAfterRemoving = "1 пассажир";
        private const string errorDepCityMsg = "Укажите город отправления";
        private const string errorArrCityMsg = "Укажите город прибытия";
        private const string errMsg = "Младенцев не может быть больше, чем взрослых";
        private const string registerMsg = "Пожалуйста, заполните форму или зарегистрируйтесь как пользователь соц.сети";


        Framework.Steps.Steps steps = new Framework.Steps.Steps();
        [SetUp] public void Init()
        {
            steps.InitBrowser();

        }
        [TearDown] public void Cleanup()
        {
            steps.CloseBrowser();
        }
        [Test]
        public void FromBakuToMinskTestSearch()
        {
            steps.InsertDepCityAndArrCity("ББаку", "ММосква");
            steps.ClickSearchBtn();
            Assert.AreEqual(foundDepCity, steps.findDepCity());
        }
        [Test]
        public void ChangeToEng()
        {
            steps.ChangeToEnglish();
            Assert.AreEqual(engLng, steps.returnCurLng());
        }
        [Test]
        public void SearchOnSiteByTextMoscow()
        {
            steps.FindOnCite("Москва");
            Assert.AreEqual(srchOnSiteResult, steps.returnSearchResult());
        }
        [Test]
        public void GoToRegistrationPage()
        {
            steps.GoToRegister();
            Assert.AreEqual(registerMsg, );
        }
        [Test]
        public void AddSomeNewPassengers()
        {
            steps.AddNewPassengers(2);
            Assert.AreEqual(steps.returnCurPassengersNumber(), passengersCountAfterAdding);
        }
        [Test]
        public void UnableToRemoveAllPassengers()
        {
            steps.RemoveAllPassengers(5);
            Assert.AreEqual(steps.returnCurPassengersNumber(), passengersCountAfterRemoving);
        }
        [Test]
        public void UnableToFindTicketWithoutDepCitiesEntered()
        {
            steps.InsertDepCityAndArrCity("ББаку", "ММосква");
            steps.ClearDepCity();
            steps.ClickSearchBtn();
            Assert.AreEqual(errorDepCityMsg, steps.ReturnCurDepCityTextValue());
        }
        [Test]
        public void UnableToFindTicketWithoutArrCitiesEntered()
        {
            steps.InsertDepCityAndArrCity("ББаку", "ММосква");
            steps.ClearArrCity();
            steps.ClickSearchBtn();
            Assert.AreEqual(errorArrCityMsg, steps.ReturnCurArrCityTextValue());
        }
        [Test]
        public void UnableToAddChildPassengersMoreThanAdultPassengers()
        {
            steps.AddNewChildPassengers(1);
            Assert.AreEqual(false, steps.IsAddNewChildDisabled());
        }
        [Test]
        public void GetsErrorMsgWhenAddingChildPassengersMoreThanAdultPassengers()
        {
            steps.AddNewChildPassengers(1);
            steps.AddNewChildPassWhenDisabled();
            Assert.AreEqual(errMsg, steps.GetInfantsErrorMsg());
        }
    }
}
