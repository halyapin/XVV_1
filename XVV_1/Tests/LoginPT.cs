using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XVV_1
{
    internal class LoginPositiveTest : BrowserShluz

    {
        [Test]
        //делаем метод для тестирования
        public void UserNameAndPassword()
        {
            driver.FindElement(_userName).SendKeys(userName);
            driver.FindElement(_password).SendKeys(userPassword);
            driver.FindElement(_enterLocator).Click();

            // Assert.That(driver.FindElement(_userNameLocator).Text.Contains("Administrator"), Is.True, "Administrator");

        }

    }
}
