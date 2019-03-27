using Framework2.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EtsyAutomationTests.Pages
{
    class EtsySearchPage : BasePage
    {
        public EtsySearchPage(IWebDriver driver) : base(driver) {}
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'v2-listing-card__info') and not (contains(@class, 'flex'))]//h2")]
        public IList<IWebElement> searchResultTextItem;
    }
}
