using OpenQA.Selenium;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By CatalogButton = By.XPath("//a[text()='Каталог']");
        private readonly By KonstructorButton = By.XPath("//a[text()='Конструктор']");
        private readonly By AboutBrandButton = By.XPath("//a[text()='О бренде']");
        private readonly By ContactsButton = By.XPath("//a[text()='Контакты']");
        private readonly By SkidkiButton = By.XPath("//a[text()='Скидки']");
        private readonly By FAQButton = By.XPath("//a[text()='FAQ']");
        private readonly By OPtButton = By.XPath("//a[text()='Опт']");
        private readonly By dostavkaButton = By.XPath("//a[text()='Доставка']");
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://vokladki.by");
            driver.Manage().Window.Maximize();
            
        
        }

        [Test]
        public void Test1()
        {
           
            var catalog = driver.FindElement(CatalogButton);
            catalog.Click();
            var Konstructor= driver.FindElement(KonstructorButton);
            Konstructor.Click();
            var AboutBrand = driver.FindElement(AboutBrandButton);
            AboutBrand.Click();
            var Skidki = driver.FindElement(SkidkiButton);
            Skidki.Click();
            var Contacts= driver.FindElement(ContactsButton);
            Contacts.Click();
            var FAQ = driver.FindElement(FAQButton);
            FAQ.Click();
            var OPt = driver.FindElement(OPtButton);
            OPt.Click();
            var dostavka = driver.FindElement(dostavkaButton);
            dostavka.Click();
        }
    }
}