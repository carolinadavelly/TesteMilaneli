using Milaneli.FapOnline.Testes.Dominio;
using Milaneli.FapOnline.Testes.Framework.Driver;
using Milaneli.FapOnline.Testes.Framework.Page;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace Milaneli.FapOnline.Testes.Paginas
{
    [Binding]
    public class PaginaCadastroPessoa : Pagina
    {
        [FindsBy(How = How.Id, Using = "necessidade-sim")]
        private IWebElement _opcaoSimPossuoNecessidadesEspeciais;

        [FindsBy(How = How.Id, Using = "necessidade-nao")]
        private IWebElement _opcaoNaoPossuoNecessidadesEspeciais;

        [FindsBy(How = How.Id, Using = "masc")]
        private IWebElement _opcaoSexoMasculino;

        [FindsBy(How = How.Id, Using = "fem")]
        private IWebElement _opcaoSexoFeminino;

        [FindsBy(How = How.Id, Using = "nome")]
        private IWebElement _campoNomeCompleto;

        [FindsBy(How = How.Id, Using = "cpf")]
        private IWebElement _campoCpf;

        [FindsBy(How = How.Id, Using = "cep")]
        private IWebElement _campoCep;

        [FindsBy(How = How.Id, Using = "endereco")]
        private IWebElement _campoEndereco;

        [FindsBy(How = How.Id, Using = "bairro")]
        private IWebElement _campoBairro;

        [FindsBy(How = How.Id, Using = "cidade")]
        private IWebElement _campoCidade;

        [FindsBy(How = How.Id, Using = "estado")]
        private IWebElement _campoEstado;

        [FindsBy(How = How.Id, Using = "numero")]
        private IWebElement _campoNumero;

        [FindsBy(How = How.Id, Using = "comp")]
        private IWebElement _campoComplemento;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement _campoEmail;

        [FindsBy(How = How.Id, Using = "telefone")]
        private IWebElement _campoTelefone;

        [FindsBy(How = How.Id, Using = "celular")]
        private IWebElement _campoCelular;

        [FindsBy(How = How.Id, Using = "observacoes")]
        private IWebElement _campoObservacoes;

        [FindsBy(How = How.Id, Using = "submit_cadastro")]
        private IWebElement _botaoCadastrar;

        [FindsBy(How = How.Id, Using = "swal2-content")]
        private IWebElement _mensagemSeuCadastroFoiConcluidoComSucesso;

        private By seletorMensagemErroCampoNomeCompleto = By.Id("nome-error");
        private By seletorMensagemErroCampoCpf = By.Id("cpf-error");
        private By seletorMensagemErroCampoCep = By.Id("cep-error");
        private By seletorMensagemErroCampoEndereco = By.Id("endereco-error");
        private By seletorMensagemErroCampoCidade = By.Id("cidade-error");
        private By seletorMensagemErroCampoBairro = By.Id("bairro-error");
        private By seletorMensagemErroCampoEstado = By.Id("estado-error");
        private By seletorMensagemErroCampoNumero = By.Id("numero-error");
        private By seletorMensagemErroCampoEmail = By.Id("email-error");
        private By seletorMensagemErroCampoSexo = By.Id("sexo-error");
        private By seletorMensagemErroCampoTipoNecessidade = By.Id("selectNecessidade-error");

        private By seletorSelectTipoNecessidade = By.Id("selectNecessidade");
        private IWebElement _selectTipoNecessidadesEspeciais
        {
            get
            {
                return this._driver.WaitUntilElementIsVisible(seletorSelectTipoNecessidade);
            }
        }

        public PaginaCadastroPessoa(IWebDriver webdriver, bool voltar) : base(webdriver, voltar)
        { }

        protected override string Url => "http://treinamento.faponline.com.br/Pages/QA/index.html";

        internal static PaginaCadastroPessoa NavegarAte(IWebDriver driver)
        {
            return IrParaPagina<PaginaCadastroPessoa>(driver);
        }

        internal void SelecionarNecessidadesEspeciais(OpcaoNecessidadeEspecial opcaoNecesidadeEspecial)
        {
            if(opcaoNecesidadeEspecial == OpcaoNecessidadeEspecial.SIM)
                this._opcaoSimPossuoNecessidadesEspeciais.Click();

            if (opcaoNecesidadeEspecial == OpcaoNecessidadeEspecial.NAO)
                this._opcaoNaoPossuoNecessidadesEspeciais.Click();
        }

        internal void SelecionarSexo(OpcaoSexo opcaoSexo)
        {
            if (opcaoSexo == OpcaoSexo.MASCULINO)
                this._opcaoSexoMasculino.Click();

            if (opcaoSexo == OpcaoSexo.FEMININO)
                this._opcaoSexoFeminino.Click();
        }

        internal bool IsCampoTipoNecessidadeVisivel()
        {
            return this._selectTipoNecessidadesEspeciais.Displayed;
        }

        internal bool IsCampoTipoNecessidadeInvisivel()
        {
            return this._driver.WaitUntilElementIsInvisible(seletorSelectTipoNecessidade);
        }

        internal void InformarNomeCompleto(string nomeCompleto)
        {
            _campoNomeCompleto.SendKeys(nomeCompleto);
        }

        internal void AguardarCarregarCidade(string cidade)
        {
            this._driver.WaitUntilElementHasText(this._campoCidade, cidade, 60);
        }

        internal void InformarCpf(string cpf)
        {
            _campoCpf.SendKeys(cpf);
        }

        internal void AguardarCarregarBairro(string bairro)
        {
            this._driver.WaitUntilElementHasText(this._campoBairro, bairro, 60);
        }

        internal void InformarCep(string cep)
        {
            _campoCep.SendKeys(cep);
        }

        internal void InformarEndereco(string endereco)
        {
            _campoEndereco.SendKeys(endereco);
        }

        internal void InformarCidade(string cidade)
        {
            _campoCidade.SendKeys(cidade);
        }

        internal void InformarBairro(string bairro)
        {
            _campoBairro.SendKeys(bairro);
        }

        internal void InformarEstado(string estado)
        {
            _campoEstado.SendKeys(estado);
        }

        internal void InformarNumero(string numero)
        {
            _campoNumero.SendKeys(numero);
        }

        internal void AguardarCarregarEstado(string estado)
        {
            this._driver.WaitUntilElementHasText(this._campoEstado, estado, 60);
        }

        internal void InformarComplemento(string complemento)
        {
            _campoComplemento.SendKeys(complemento);
        }

        internal void InformarEmail(string email)
        {
            _campoEmail.SendKeys(email);
        }

        internal void InformarTelefone(string telefone)
        {
            _campoTelefone.SendKeys(telefone);
        }

        internal void InformarCelular(string celular)
        {
            _campoCelular.SendKeys(celular);
        }

        internal void InformarObservações(string observacoes)
        {
            _campoObservacoes.SendKeys(observacoes);
        }

        internal void PressionarBotaoCadastrar()
        {
            this._botaoCadastrar.Click();

        }

        internal object ObterMensagemSeuCadastroFoiConcluidoComSucesso()
        {
            return _mensagemSeuCadastroFoiConcluidoComSucesso.Text;
        }

        internal object ObterMensagemErroCampoNomeCompleto()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoNomeCompleto).Text;
        }

        internal void AguardarCarregarEndereco(string endereco)
        {
            this._driver.WaitUntilElementHasText(this._campoEndereco, endereco, 60);
        }

        internal void LimparCampoEndereco()
        {
             _campoEndereco.Clear();
        }

        internal void LimparCampoCidade()
        {
            _campoCidade.Clear();
        }

        internal void LimparCampoBairro()
        {
            _campoBairro.Clear();
        }

        internal void LimparCampoEstado()
        {
            _campoEstado.Clear();
        }
         
        internal string ObterMensagemErroCampoCpf()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoCpf).Text;
        }

        internal string ObterMensagemErroCampoCep()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoCep).Text;
        }

        internal string ObterMensagemErroCampoEmail()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoEmail).Text;
        }

        internal string ObterMensagemErroCampoEndereco()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoEndereco).Text;
        }

        internal string ObterMensagemErroCampoCidade()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoCidade).Text;
        }

        internal string ObterMensagemErroCampoBairro()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoBairro).Text;
        }

        internal string ObterMensagemErroCampoEstado()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoEstado).Text;
        }

        internal string ObterMensagemErroCampoNumero()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoNumero).Text;
        }

        internal string ObterMensagemErroCampoSexo()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoSexo).Text;
        }

        internal string ObterMensagemErroCampoTipoNecessidade()
        {
            return this._driver.FindElement(this.seletorMensagemErroCampoTipoNecessidade).Text;
        }

        internal string ObterValorCampoCpf()
        {
            return this._campoCpf.Text;
        }

        internal string ObterValorCampoCep()
        {
            return this._campoCep.Text;
        }
        internal string ObterValorCampoTelefone()
        {
            return this._campoTelefone.Text;
        }

    }
}