using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XVV_1
{
    //создаем класс логина
    internal class SmevPageShluz : BrowserShluz
    {
        private IWebDriver _driver;

        //создаем метод драйвера,чтобы драйвер понимал, что речь идет о элементах браузера
        public SmevPageShluz(IWebDriver driver)
        {
            _driver = driver;
        }
        //указываем как драйверу найти элементы куда вносить данные
        //settings
        public IWebElement smevSettingsField => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[1]/a"));
        public IWebElement smevConfigField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/config']"));
        public IWebElement smevSignservicesField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/signservices']"));
        public IWebElement smevEndpointsField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/endpoints']"));
        public IWebElement smevAdaptersField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings']"));
        public IWebElement smevVsField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/ns']"));
        public IWebElement smevTemplatesField => _driver.FindElement(By.XPath("//a[@href ='/smev/templates']"));
        public IWebElement smevDictsField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/dicts']"));
        public IWebElement smevThumbsField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/thumbs']"));

        //test
        public IWebElement smevTestField => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[2]/a"));
        public IWebElement smevTestJsonField => _driver.FindElement(By.XPath("//a[@href ='/smev/testrequest']"));
        public IWebElement smevTestXmlField => _driver.FindElement(By.XPath("//a[@href ='/smev/testrequestxml']"));
        public IWebElement smevTestAdaptersField => _driver.FindElement(By.XPath("//a[@href ='/smev/testtmpl']"));
        public IWebElement smevTestTaskField => _driver.FindElement(By.XPath("//a[@href ='/smev/testasks']"));



        //magazines

        public IWebElement smevMagField => _driver.FindElement(By.XPath("//html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[3]/a"));
        public IWebElement smevRequestsField => _driver.FindElement(By.XPath("//a[@href ='/smev/requests']"));
        public IWebElement smevResponsesField => _driver.FindElement(By.XPath("//a[@href ='/smev/responses']"));
        public IWebElement smevFilesField => _driver.FindElement(By.XPath("//a[@href ='/smev/files']"));
        public IWebElement smevLogsField => _driver.FindElement(By.XPath("//a[@href ='/smev/settings/logs']"));


        //jobs

        public IWebElement smevJobsField => _driver.FindElement(By.XPath("//html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[4]/a"));
        //public readonly By _smevJobsField = By.XPath("//html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[4]/a");
        //main link
        public IWebElement smevSmevField => _driver.FindElement(By.XPath("//a[@href ='/smev/']"));
        //after smevHomeField Navigate().Back() will doesn`t work
        public IWebElement smevHomeField => _driver.FindElement(By.XPath("//a[@href ='http://10.10.10.55:5000']"));

    }
}
