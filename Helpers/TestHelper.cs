using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBDD.Helpers
{
    public class TestHelper
    {
        public static IWebDriver GetWebDriver
        {
            get
            {
                var driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://blazorappinfis.azurewebsites.net/");
                driver.Manage().Window.Maximize();
                return driver;
            }
        }

        public static void CreateScreenshot(string name, IWebDriver driver)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{name}.png", ScreenshotImageFormat.Png);
        }
    }
}