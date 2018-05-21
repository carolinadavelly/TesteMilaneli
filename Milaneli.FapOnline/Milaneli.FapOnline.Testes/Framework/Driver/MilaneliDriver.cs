using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Milaneli.FapOnline.Testes.Framework.Driver
{
    public class MilaneliDriver
    {
        private readonly ScenarioContext scenarioContext;
        private const string WEBDRIVER_SCENARIO_KEY = "webDriver";

        public MilaneliDriver(ScenarioContext context)
        {
            this.scenarioContext = context;
        }

        internal void CleanUp()
        {
            ((IWebDriver)ScenarioContext.Current[WEBDRIVER_SCENARIO_KEY]).Quit();
        }

        public IWebDriver Setup()
        {
            if (scenarioContext.ContainsKey(WEBDRIVER_SCENARIO_KEY)) return (IWebDriver)ScenarioContext.Current[WEBDRIVER_SCENARIO_KEY];

            IWebDriver driver = new ChromeDriver();

            ScenarioContext.Current.Add(WEBDRIVER_SCENARIO_KEY, driver);

            return (IWebDriver)ScenarioContext.Current[WEBDRIVER_SCENARIO_KEY];
        }
    }
}