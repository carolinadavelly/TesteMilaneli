using TechTalk.SpecFlow;

namespace Milaneli.FapOnline.Testes.Framework.Driver
{
    [Binding]
    public class CenarioHook
    {
        private MilaneliDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new MilaneliDriver(ScenarioContext.Current);
            ScenarioContext.Current["mDriver"] = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.CleanUp();
        }
    }
}
