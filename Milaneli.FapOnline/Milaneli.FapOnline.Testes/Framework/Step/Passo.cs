using Milaneli.FapOnline.Testes.Framework.Driver;
using Milaneli.FapOnline.Testes.Framework.Page;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Milaneli.FapOnline.Testes.Framework.Step
{
    public class Passo
    {
        protected readonly IWebDriver driver;

        public Passo()
        {
            MilaneliDriver milaneliDriver = (MilaneliDriver)ScenarioContext.Current["mDriver"];
            driver = milaneliDriver.Setup();
        }

        public Pagina PaginaAtual
        {
            get
            {
                return (Pagina)ScenarioContext.Current["paginaAtual"];
            }
            set
            {
                ScenarioContext.Current["paginaAtual"] = value;
            }
        }
    }
}
