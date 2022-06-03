using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XVV_1
{
    internal class BaseTest : BrowserShluz

    {
        [SetUp]
        //делаем метод для тестирования
        public void baseAuthorisation()
        {
            //driver.Navigate().GoToUrl(urlSmev);
            //driver.FindElement(_Auth).Click();
            /*driver.FindElement(_userName).SendKeys(userName);
            driver.FindElement(_password).SendKeys(userPassword);
            driver.FindElement(_enterLocator).Submit();*/
            driver.Navigate().GoToUrl(urlSmev);
            Thread.Sleep(2000);
            driver.FindElement(_Auth).Click();
            driver.FindElement(_userName).SendKeys(userName);
            driver.FindElement(_password).SendKeys(userPassword);
            Thread.Sleep(2000);
            driver.FindElement(_enterLocator).Submit();
            Thread.Sleep(2000);
        }

    }
}
