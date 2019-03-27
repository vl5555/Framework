using EtsyAutomationTests.Pages;
using Framework2.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace EtsyAutomationTests
{
    public class EtsyTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.etsy.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestSearch()
        {
            var searchText = "Men's Martin Boots";
            EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
            etsyMainPage.searchArea.searchField.SetText(searchText);
            etsyMainPage.searchArea.searchButton.Click();
            //Thread.Sleep(2000);

            EtsySearchPage etsySearchPage = new EtsySearchPage(driver);

            foreach (var textItem in etsySearchPage.searchResultTextItem)
            {
                Console.WriteLine(textItem.Text.Trim());
            }
            
        }
    }
}
