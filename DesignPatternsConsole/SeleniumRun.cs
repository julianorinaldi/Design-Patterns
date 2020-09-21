using DesignPatterns;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DesignPatternsConsole
{
    public abstract class SeleniumRun : IDisposable
    {
        protected readonly IWebDriver Driver;
        protected readonly ISaidaDeTexto Output;

        public SeleniumRun(ISaidaDeTexto output)
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"chromedriver.exe");
            var options = new ChromeOptions();
            options.AddArgument("headless");
            Driver = new ChromeDriver(options);
            Output = output;
        }

        protected abstract void Run();

        public void Dispose()
        {
            if (Driver != null)
                Driver.Quit();
        }
    }
}