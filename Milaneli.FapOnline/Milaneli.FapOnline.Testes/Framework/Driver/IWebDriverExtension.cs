using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Milaneli.FapOnline.Testes.Framework.Driver
{
    public static class IWebDriverExtension
    {
        public static IWebElement WaitUntilElementIsVisible(this IWebDriver driver, By by, int waitForInSeconds = 1)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitForInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public static bool WaitUntilElementIsInvisible(this IWebDriver driver, By by, int waitForInSeconds = 1)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitForInSeconds));
            return wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        public static bool WaitUntilElementHasText(this IWebDriver driver, IWebElement webElement, string text, int waitForInSeconds = 1)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitForInSeconds));
            return wait.Until(ExpectedConditions.TextToBePresentInElementValue(webElement, text));
        }
    }
}
