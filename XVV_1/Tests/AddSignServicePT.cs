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
    internal class SignServicesAddPositiveTest : BaseTest

    {


        [Test]
        //делаем метод для тестирования
        public void SignServicesAddTest()
        {

            Thread.Sleep(delay1);
            driver.FindElement(_smevSettingsField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSignservicesField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_smevSignservicesAddField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_recNameSignServiceField).SendKeys(recName);
            Thread.Sleep(delay1);
            driver.FindElement(_serviceTypeEnumSignServiceField).Click();
            Thread.Sleep(delay1);
            driver.FindElement(_typeEnumSignServiceField).Click();
            Thread.Sleep(delay1);
            if (driver.FindElement(_typeEnumSignServiceField).Text == "Удалённый Redoc")
            {
                driver.FindElement(_urlSignServiceField).SendKeys(urlSignService);
            }
            else return;
            driver.FindElement(_trumbprintSignServiceField).SendKeys(trumbprintSignService);
            Thread.Sleep(delay1);
            driver.FindElement(_btnSaveSignServiceField).Submit();
            //вставить проверку на появление надписи ниже кнопки "Запись успешно сохранена".
            //if (driver.FindElement(_labelSaveField).Text == "Запись успешно сохранена.")
            //Assert.AreEqual(_labelSaveField.Text.ToLower(), "Запись успешно сохранена.".ToLower());
            Thread.Sleep(delay2);
            driver.FindElement(_btnBackSignServiceField).Click();
            Thread.Sleep(delay1);
            //вставить проверку на нахождение на странице сервиса подписания с recName каким мы только что создали.
            //путь до таблицы сервисов подписания tbody/tr/td text=АвтотестСервисПодписания
            //Assert.AreEqual(_labelSaveField.Text.ToLower(), "Запись успешно сохранена.".ToLower());
            if (driver.FindElement(_nameSignservicesField).Text != recName)
            {
                Thread.Sleep(delay1);
                driver.FindElement(_smevSignservicesAddField).Click();
            }
        }

    }
}
