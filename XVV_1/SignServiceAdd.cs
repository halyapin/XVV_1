using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XVV_1
{
    //создаем класс логина
    internal class SmevSignServiceAddShluz : BrowserShluz
    {
        private IWebDriver _driver;

        //создаем метод драйвера,чтобы драйвер понимал, что речь идет о элементах браузера
        public SmevSignServiceAddShluz(IWebDriver driver)
        {
            _driver = driver;
        }
        //указываем как драйверу найти элементы куда вносить данные
        //добавление сервиса подписания
        //наименование
        public IWebElement recNameSignServiceField => _driver.FindElement(By.XPath("//input[@placeholder ='Наименование']"));
        //Тип сервиса
        public IWebElement serviceTypeEnumSignServiceField => _driver.FindElement(By.XPath("//select[@placeholder ='Выбор типа сервиса']"));
        //подтип сервиса
        public IWebElement typeEnumSignServiceField => _driver.FindElement(By.XPath("//option[@value ='0']"));

        //Адрес до удаленного метода для подписи XML
        public IWebElement urlSignServiceField => _driver.FindElement(By.XPath("//input[@id ='url']"));
        //ток сертификата
        public IWebElement trumbprintSignServiceField => _driver.FindElement(By.XPath("//input[@id ='thumbprint']"));
        public IWebElement btnSaveSignServiceField => _driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement labelSaveField => _driver.FindElement(By.XPath("//label[@for='responseTemplate']"));

        public IWebElement btnBackSignServiceField => _driver.FindElement(By.XPath("//a[@title='Назад']"));


    }
}
