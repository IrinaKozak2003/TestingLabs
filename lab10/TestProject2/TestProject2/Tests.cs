using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TestProject2.Properties;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;
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
          
            PageObjectMenu pageObjectMenu = new PageObjectMenu(driver);
            pageObjectMenu.dostavkaButtonClick();
            pageObjectMenu.CatalogButtonClick();
            pageObjectMenu.ContactsButtonClick();
            pageObjectMenu.KonstructorButtonClick();
            pageObjectMenu.SkidkiButtonClick();
            pageObjectMenu.AboutBrandButtonClick();
            pageObjectMenu.OPtButtonClick();
            pageObjectMenu.FAQButtonClick();
        }
    }
}