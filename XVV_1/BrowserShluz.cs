using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace XVV_1
{

        public class BrowserShluz
        {
            public IWebDriver driver = null!;
            public readonly string urlLogin = "http://10.10.10.55:5000/login";
            public readonly string urlFeed = "http://10.10.10.55:5000/feed";
            public readonly string urlDashboard = "http://10.10.10.55:5000/admin/dashboard";
            public readonly string urlSmev = "http://10.10.10.55:5000/smev";

            //указываем логин и пароль? лучше вынести в другое место эти данные
            public readonly string userName = "superadmin";
            public readonly string userPassword = "2128506";
            //2 вида задержек так как не успевает браузер прогружать страницы
            public readonly int delay1 = 1000;
            public readonly int delay2 = 2000;
            //пишем как найти все элементы на странице, но почему мы повторяем это в pageObjectLogin?
            public readonly By _Auth = By.XPath("//a[@href='http://10.10.10.55:5000/login?return=%2Fsmev']");
            public readonly By _userName = By.XPath("//input[@placeholder='Логин']");
            public readonly By _password = By.XPath("//input[@placeholder='Пароль']");
            public readonly By _enterLocator = By.XPath("//button[@type='submit']");
            public readonly By _userNameLocator = By.XPath("//a[@href='/account']");
            public readonly By _adminLocator = By.XPath("//a[@href='/admin']");
            //settings
            public readonly By _smevSettingsField = By.XPath("/html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[1]/a");
            public readonly By _smevConfigField = By.XPath("//a[@href ='/smev/settings/config']");
            public readonly By _smevSignservicesField = By.XPath("//a[@href ='/smev/settings/signservices']");
            public readonly By _smevEndpointsField = By.XPath("//a[@href ='/smev/settings/endpoints']");
            public readonly By _smevAdaptersField = By.XPath("//a[@href ='/smev/settings']");
            public readonly By _smevVsField = By.XPath("//a[@href ='/smev/settings/ns']");
            public readonly By _smevTemplatesField = By.XPath("//a[@href ='/smev/templates']");
            public readonly By _smevDictsField = By.XPath("//a[@href ='/smev/settings/dicts']");
            public readonly By _smevThumbsField = By.XPath("//a[@href ='/smev/settings/thumbs']");
            //tests
            public readonly By _smevTestField = By.XPath("/html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[2]/a");
            public readonly By _smevTestJsonField = By.XPath("//a[@href ='/smev/testrequest']");
            public readonly By _smevTestXmlField = By.XPath("//a[@href ='/smev/testrequestxml']");
            public readonly By _smevTestAdaptersField = By.XPath("//a[@href ='/smev/testtmpl']");
            public readonly By _smevTestTaskField = By.XPath("//a[@href ='/smev/testasks']");
            //magazines
            public readonly By _smevMagField = By.XPath("//html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[3]/a");
            public readonly By _smevRequestsField = By.XPath("//a[@href ='/smev/requests']");
            public readonly By _smevResponsesField = By.XPath("//a[@href ='/smev/responses']");
            public readonly By _smevFilesField = By.XPath("//a[@href ='/smev/files']");
            public readonly By _smevLogsField = By.XPath("//a[@href ='/smev/settings/logs']");
            //jobs
            public readonly By _smevJobsField = By.XPath("//html/body/div[1]/div/div[1]/nav/div/div[2]/ul[1]/li[4]/a");
            public bool ChekText => driver.PageSource.Contains("Неправильный логин или пароль!");

            //addSignServices

            public readonly By _smevSignservicesAddField = By.XPath("//a[@href ='/smev/settings/addsignservice']");
            public readonly By _recNameSignServiceField = By.XPath("//input[@placeholder ='Наименование']");
            static Random rnd = new Random();
            static int numSignService = rnd.Next(0, 10);
            public readonly string recName = "АвтотестСервисПодписания" + numSignService;
            public readonly By _serviceTypeEnumSignServiceField = By.XPath("//select[@placeholder ='Выбор типа сервиса']");
            public readonly By _typeEnumSignServiceField = By.XPath("//option[@value ='1']");
            public readonly By _urlSignServiceField = By.XPath("//input[@id ='url']");
            public readonly string urlSignService = "http://10.10.12.34:8081/api/sign/xml";
            public readonly By _trumbprintSignServiceField = By.XPath("//input[@id ='thumbprint']");
            public readonly string trumbprintSignService = "40ce3fe910279606aa8b3166c586c6cfa92a0448";
            public readonly By _btnSaveSignServiceField = By.XPath("//button[@type='submit']");
            public readonly By _labelSaveField = By.XPath("//label[@for='responseTemplate']");
            public readonly By _btnBackSignServiceField = By.XPath("//a[@title='Назад']");
            public readonly By _nameSignservicesField = By.XPath("//td");



            [SetUp]
            public void startBrowser()
            {
                ChromeOptions option = new ChromeOptions();
                //option.AddArguments("--window-size=500,500");
                driver = new ChromeDriver();
                //driver.Manage().Window.Size = new System.Drawing.Size(200, 100);
                driver.Url = urlLogin;
                driver.Manage().Window.Maximize();
            }
            /*[TearDown]
            public void closeBrowser()
            {
                driver.Quit();
            }*/
        }
    }
