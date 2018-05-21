using Microsoft.VisualStudio.TestTools.UnitTesting;
using Milaneli.FapOnline.Testes.Framework.Step;
using Milaneli.FapOnline.Testes.Paginas;
using TechTalk.SpecFlow;

namespace Milaneli.FapOnline.Testes.Passos
{
    [Binding]
    public class CadastroPessoaSteps : Passo
    {
        PaginaCadastroPessoa paginaCadastroPessoa;

        [Given(@"que acesso o cadastro de pessoas")]
        public void DadoQueAcessoOCadastroDePessoas()
        {
            this.PaginaAtual = paginaCadastroPessoa = PaginaCadastroPessoa.NavegarAte(this.driver);
        }
        
        [When(@"informo sim para necessidades especiais")]
        public void QuandoInformoSimParaNecessidadesEspeciais()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.SelecionarNecessidadesEspeciais(Dominio.OpcaoNecessidadeEspecial.SIM);
        }
        
        [Then(@"deve ser exibido o campo tipo da necessidade")]
        public void EntaoDeveSerExibidoOCampoDeTipoDaNecessidade()
        {
            DeveSerExibidoOCampoDeTipoDaNecessidade();
        }

        [Given(@"informo sim para necessidades especiais")]
        public void DadoInformoSimParaNecessidadesEspeciais()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.SelecionarNecessidadesEspeciais(Dominio.OpcaoNecessidadeEspecial.SIM);
        }

        [Given(@"deve ser exibido o campo tipo da necessidade")]
        public void DadoDeveSerExibidoOCampoDeTipoDaNecessidade()
        {
            DeveSerExibidoOCampoDeTipoDaNecessidade();
        }

        private void DeveSerExibidoOCampoDeTipoDaNecessidade()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            bool campoVisivel = paginaCadastroPessoa.IsCampoTipoNecessidadeVisivel();
            Assert.IsTrue(campoVisivel);
        }

        [When(@"informo não para necessidades especiais")]
        public void QuandoInformoNaoParaNecessidadesEspeciais()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.SelecionarNecessidadesEspeciais(Dominio.OpcaoNecessidadeEspecial.NAO);
        }

        [Then(@"não deve ser exibido o campo tipo da necessidade")]
        public void EntaoNaoDeveSerExibidoOCampoDeTipoDaNecessidade()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            bool campoInvisivel = paginaCadastroPessoa.IsCampoTipoNecessidadeInvisivel();
            Assert.IsTrue(campoInvisivel);
        }

        [When(@"informo nome completo ""(.*)""")]
        public void QuandoInformoNomeCompleto(string nomeCompleto)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarNomeCompleto(nomeCompleto);
        }

        [When(@"informo CPF ""(.*)""")]
        public void QuandoInformoCpf(string cpf)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarCpf(cpf);
        }

        [When(@"tiro o foco do campo")]
        public void QuandoTiroOFocoDoCampo()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarNomeCompleto("");
        }

        [When(@"informo CEP ""(.*)""")]
        public void QuandoInformoCep(string cep)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarCep(cep);
        }

        [When(@"informo endereço ""(.*)""")]
        public void QuandoInformoEndereço(string endereco)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarEndereco(endereco);
        }

        [When(@"informo cidade ""(.*)""")]
        public void QuandoInformoCidade(string cidade)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarCidade(cidade);
        }

        [When(@"informo bairro ""(.*)""")]
        public void QuandoInformoBairro(string bairro)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarBairro(bairro);
        }

        [When(@"informo estado ""(.*)""")]
        public void QuandoInformoEstado(string estado)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarEstado(estado);
        }

        [When(@"aguardo carregar o endereco ""(.*)""")]
        public void QuandoAguardoCarregarOEndereco(string endereco)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.AguardarCarregarEndereco(endereco);
        }

        [When(@"aguardo carregar a cidade ""(.*)""")]
        public void QuandoAguardoCarregarACidade(string cidade)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.AguardarCarregarCidade(cidade);
        }

        [When(@"aguardo carregar o bairro ""(.*)""")]
        public void QuandoAguardoCarregarOBairro(string bairro)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.AguardarCarregarBairro(bairro);
        }

        [When(@"aguardo carregar o estado ""(.*)""")]
        public void QuandoAguardoCarregarOEstado(string estado)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.AguardarCarregarEstado(estado);
        }

        [When(@"informo número ""(.*)""")]
        public void QuandoInformoNumero(string numero)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarNumero(numero);
        }

        [When(@"informo complemento ""(.*)""")]
        public void QuandoInformoComplemento(string complemento)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarComplemento(complemento);
        }

        [When(@"informo e-mail ""(.*)""")]
        public void QuandoInformoEmail(string email)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarEmail(email);
        }

        [When(@"informo sexo masculino")]
        public void QuandoInformoSexoMasculino()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.SelecionarSexo(Dominio.OpcaoSexo.MASCULINO);
        }

        [When(@"informo telefone ""(.*)""")]
        public void QuandoInformoTelefone(string telefone)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarTelefone(telefone);
        }

        [When(@"informo celular ""(.*)""")]
        public void QuandoInformoCelular(string celular)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarCelular(celular);
        }

        [When(@"informo observações ""(.*)""")]
        public void QuandoInformoObservações(string observações)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.InformarObservações(observações);
        }

        [When(@"pressiono o botão cadastrar")]
        public void QuandoPressionoBotaoCadastrar()
        {
            paginaCadastroPessoa.PressionarBotaoCadastrar();
        }

        [Then(@"é exibida a mensagem ""(.*)""")]
        public void EntaoEExibidaAMensagemSeuCadastroFoiConcluidoComSucesso(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemSeuCadastroFoiConcluidoComSucesso());
        }

        [When(@"não informo nome completo")]
        public void QuandoNaoInformoNomeCompleto()
        {
            
        }

        [When(@"não informo CPF")]
        public void QuandoNaoInformoCpf()
        {

        }

        [When(@"não informo CEP")]
        public void QuandoNaoInformoCep()
        {

        }

        [When(@"não informo número")]
        public void QuandoNaoInformoNumero()
        {

        }

        [When(@"não informo sexo")]
        public void QuandoNaoInformoSexo()
        {

        }

        [When(@"não informo tipo da necessidade")]
        public void QuandoNaoInformoTipoNecessidade()
        {

        }

        [When(@"limpo o campo endereço")]
        public void QuandoLimpoOCampoEndereco()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.LimparCampoEndereco();
        }

        [When(@"limpo o campo cidade")]
        public void QuandoLimpoOCampoCidade()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.LimparCampoCidade();
        }

        [When(@"limpo o campo bairro")]
        public void QuandoLimpoOCampoBairro()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.LimparCampoBairro();
        }

        [When(@"limpo o campo estado")]
        public void QuandoLimpoOCampoEstado()
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            paginaCadastroPessoa.LimparCampoEstado();
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo nome completo")]
        public void EntaoEExibidaAMensagemCampoObrigatorioAbaixoDoCampoNomeCompleto(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoNomeCompleto());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo CPF")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoCpf(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoCpf());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo CEP")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoCep(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoCep());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo endereço")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoEndereco(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoEndereco());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo cidade")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoCidade(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoCidade());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo bairro")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoBairro(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoBairro());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo estado")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoEstado(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoEstado());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo número")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoNumero(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoNumero());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo sexo")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoSexo(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoSexo());
        }

        [Then(@"é exibida a mensagem ""(.*)"" abaixo do campo tipo da necessidade")]
        public void EntaoEExibidaAMensagemAbaixoDoCampoTipoNecessidade(string mensagem)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(mensagem, paginaCadastroPessoa.ObterMensagemErroCampoTipoNecessidade());
        }

        [Then(@"o campo CPF deve conter ""(.*)""")]
        public void EntaoOCampoCpfDeveConter(string cpf)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(cpf, paginaCadastroPessoa.ObterValorCampoCpf());
        }

        [Then(@"o campo CEP deve conter ""(.*)""")]
        public void EntaoOCampoCepDeveConter(string cep)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(cep, paginaCadastroPessoa.ObterValorCampoCep());
        }

        [Then(@"o campo telefone deve conter ""(.*)""")]
        public void EntaoOCampoTelefoneDeveConter(string telefone)
        {
            paginaCadastroPessoa = (PaginaCadastroPessoa)PaginaAtual;
            Assert.AreEqual(telefone, paginaCadastroPessoa.ObterValorCampoTelefone());
        }


    }
}
