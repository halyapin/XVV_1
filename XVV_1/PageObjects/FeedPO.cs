using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XVV_1
{
    //создаем класс логина
    internal class FeedPageShluz : BrowserShluz
    {
        private IWebDriver _driver;

        //создаем метод драйвера,чтобы драйвер понимал, что речь идет о элементах браузера
        public FeedPageShluz(IWebDriver driver)
        {
            _driver = driver;
        }
        //указываем как драйверу найти элементы куда вносить данные
        //найдем элемент Наименование пользователя "Administrator"
        public IWebElement userNameLocator => _driver.FindElement(By.XPath("//a[@href='/account']"));
        public IWebElement adminLocator => _driver.FindElement(By.XPath("//a[@href='/admin']"));

    }
}
