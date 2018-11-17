using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Web_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitTests a = new UnitTests();
            a.FromBakuToMinskTestSearch();
        }
    }
}
