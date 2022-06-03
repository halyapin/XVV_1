using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XVV_1
{
    //создаем класс логина
    internal class DashboardPageShluz : BrowserShluz
    {
        private IWebDriver _driver;

        //создаем метод драйвера,чтобы драйвер понимал, что речь идет о элементах браузера
        public DashboardPageShluz(IWebDriver driver)
        {
            _driver = driver;
        }
        //указываем как драйверу найти элементы куда вносить данные
        public IWebElement userNameField => _driver.FindElement(By.XPath("//a[@title='Шлюз СМЭВ-3']"));
        //public IWebElement userNameField => _driver.FindElement(By.Name("//input[@placeholder='Логин']"));
        public IWebElement logsField => _driver.FindElement(By.XPath("//a[@href='/admin/logs']"));
        //кнопка скачивания логов последних
        public IWebElement lastLogDownloadButton => _driver.FindElement(By.Id("DownloadLogFile0"));

        public IWebElement dataBaseField => _driver.FindElement(By.XPath("//a[@href='/admin/database']"));
        //поле ввода SQL запроса
        public IWebElement executeSqlField => _driver.FindElement(By.Id("executeSql"));
        //кнопка выполнить SQL запрос не понял как определеить ее https://www.selenium.dev/documentation/webdriver/elements/locators/
        // public IWebElement requestSQLButton => _driver.FindElement(RelativeBy.WithLocator(By.XPath("//a[@href='/admin/database']")).Near(By.XPath("//a[@href='/admin/database']"));



    }
}
