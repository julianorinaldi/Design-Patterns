using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DesignPatternsConsole
{
    public abstract class SeleniumRun : IDisposable
    {
        protected readonly IWebDriver Driver;

        public SeleniumRun()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"chromedriver.exe");
            var options = new ChromeOptions();
            options.AddArgument("headless");
            Driver = new ChromeDriver(options);
        }

        protected abstract void Run();

        public void Dispose()
        {
            if (Driver != null)
                Driver.Quit();
        }
    }
}