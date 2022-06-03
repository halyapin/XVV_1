using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XVV_1
{
    //создаем класс логина
    internal class SmevSignServicesShluz : BrowserShluz
    {
        private IWebDriver _driver;

        //создаем метод драйвера,чтобы драйвер понимал, что речь идет о элементах браузера
        public SmevSignServicesShluz(IWebDriver driver)
        {
            _driver = driver;
        }
        //указываем как драйверу найти элементы куда вносить данные
        //settings
        public IWebElement smevSettingsField => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[1]/a"));
        public IWebElement smevSignservicesField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/signservices']"));

        public IWebElement smevSignservicesAddField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/addsignservice']"));
        //поиск по наименованию сервисов подписания
        public IWebElement nameSignservicesField => _driver.FindElement(By.XPath("//td"));

    }
}
