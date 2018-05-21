using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Milaneli.FapOnline.Testes.Framework.Page
{
    public class Pagina
    {
        protected IWebDriver _driver;
        protected virtual string Url { get; }

        protected Pagina(IWebDriver webdriver, bool voltar)
        {
            this._driver = webdriver;

            if (!string.IsNullOrEmpty(this.Url) && !voltar)
                this._driver.Navigate().GoToUrl(this.Url);

            PageFactory.InitElements(this._driver, this);
        }

        public void Voltar()
        {
            this._driver.Navigate().Back();
        }

        protected static T IrParaPagina<T>(IWebDriver _driver) where T : Pagina
        {
            return CriarPagina<T>(_driver);
        }

        protected static T VoltarParaPaginaAnterior<T>(IWebDriver _driver) where T : Pagina
        {
            _driver.Navigate().Back();
            return CriarPagina<T>(_driver, true);
        }

        private static T CriarPagina<T>(IWebDriver _driver, bool voltar = false) where T : Pagina
        {
            var pagina = (T)Activator.CreateInstance(typeof(T), _driver, voltar);
            return pagina;
        }  
    }
}
