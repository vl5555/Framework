using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework2.Utils
{
    static class WebElementExtensions
    {
        public static void Setext(this IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void SetDropdownOptionsByText(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }
    }
}
