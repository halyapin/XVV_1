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
    internal class SmevSettingsPositiveTest : BaseTest

    {
        /*
        [SetUp]
        //делаем метод для тестирования
        public void baseAuthorisation()
        {
            //driver.Navigate().GoToUrl(urlSmev);
            //driver.FindElement(_Auth).Click();
            driver.FindElement(_userName).SendKeys(userName);
            driver.FindElement(_password).SendKeys(userPassword);
            driver.FindElement(_enterLocator).Click();
            driver.Navigate().GoToUrl(urlSmev);
            driver.FindElement(_Auth).Click();
            driver.FindElement(_userName).SendKeys(userName);
            driver.FindElement(_password).SendKeys(userPassword);
            driver.FindElement(_enterLocator).Click();
        }*/




        [Test]
        //делаем метод для тестирования
        public void SmevSettingTest()
        {
            // baseAuthorisation();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevConfigField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSignservicesField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevEndpointsField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevAdaptersField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevVsField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevTemplatesField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevDictsField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevThumbsField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();

        }

        [Test]

        public void SmevTestRequestTest()
        {
            Thread.Sleep(delay1);
            driver.FindElement(_smevTestField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevTestJsonField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevTestField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevTestXmlField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevTestField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevTestAdaptersField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevTestField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevTestTaskField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
        }

        [Test]
        public void SmevMagTest()
        {
            Thread.Sleep(delay1);
            driver.FindElement(_smevMagField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevRequestsField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevMagField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevResponsesField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevMagField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevFilesField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
            Thread.Sleep(delay1);
            driver.FindElement(_smevMagField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevLogsField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
        }
        [Test]
        public void SmevJobsTest()
        {
            Thread.Sleep(delay1);
            driver.FindElement(_smevJobsField).Click();
            Thread.Sleep(delay1);
            driver.Navigate().Back();
        }

    }
}
