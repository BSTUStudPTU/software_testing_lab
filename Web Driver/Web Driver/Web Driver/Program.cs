using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

/*Тест-кейс 1.1: Проверка автокоррекции введенных данных при типе маршрута «В обе стороны»
1.	Зайти на сайт https://aviabilet.kz/
2.	Выберите тип маршрута «В обе стороны»
3.	В первой строке ввести города в полях (Откуда? и Куда?; Например: Минск -> Москва)
4.	Во второй строке изменить город в первом поле (Например: Москва на Берлин)
5.	Во второй строке изменить город во втором столе (Например:  Минск на Лондон)
Ожидаемый результат: Приложение должно изменить соответственно города в полях в первой строчке на измененные во второй. */
namespace Web_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver chromeWebDriver = new ChromeDriver();
            chromeWebDriver.Navigate().GoToUrl("https://aviabilet.kz");
        }
    }
}
