using Framework2.Pages;
using OpenQA.Selenium;

namespace EtsyAutomationTests.Pages
{
    class EtsyMainPage : BasePage
    {
        public EtsyMainPage(IWebDriver driver) : base(driver)
        {
            searchArea = new SearchArea(driver);
        }

        public SearchArea searchArea;
    }
}
