using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework2.Utils
{
    public static class WebElementExtensions
    {
        public static void SetText(this IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void SetDropdownOptionsByText(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }
    }
}
