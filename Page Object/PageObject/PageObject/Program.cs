using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using PageObject.Tests;
using PageObject.PageObject;

namespace PageObject
{
    class Program
    {
        static void Main(string[] args)
        {
            UTests myTests = new UTests();
            myTests.FromBakuToMinskTestSearch();
            myTests.ChangeLanguage();
        }
    }
}
