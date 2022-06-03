using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XVV_1
{
    //создаем класс логина
    internal class LoginPageShluz : BrowserShluz
    {
        private IWebDriver _driver;

        //создаем метод драйвера,чтобы драйвер понимал, что речь идет о элементах браузера
        public LoginPageShluz(IWebDriver driver)
        {
            _driver = driver;
        }
        //указываем как драйверу найти элементы куда вносить данные
        public IWebElement userNameField => _driver.FindElement(By.XPath("//input[@placeholder='Логин']"));
        //public IWebElement userNameField => _driver.FindElement(By.Name("//input[@placeholder='Логин']"));
        public IWebElement passwordField => _driver.FindElement(By.XPath("//input[@placeholder='Пароль']"));

        public IWebElement btnLogin => _driver.FindElement(By.XPath("//button[@type='submit']"));
        //public IWebElement btnLogin => _driver.FindElement(By.LinkText("Войти"));

        //button[@type = "submit"]
        //далее пишем конструктор в котором определяются два поля Юзернейм и пароль
        public void LoginOnShluz(string userName, string userPassword)
        {
            //в конструкторе указывается что нужно сделать с полем (отправить значения, нажать кнопку и тд.)
            userNameField.SendKeys(userName);
            passwordField.SendKeys(userPassword);
            btnLogin.Submit();
        }
    }
}
