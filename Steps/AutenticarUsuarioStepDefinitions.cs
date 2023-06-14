using FluentAssertions;
using OpenQA.Selenium;
using ProjetoBDD.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProjetoBDD.Steps
{
    [Binding]
    public class AutenticarUsuarioStepDefinitions
    {
        private IWebDriver? _driver;

        [Given(@"Eu acesso a página de autenticação de usuários")]
        public void GivenEuAcessoAPaginaDeAutenticacaoDeUsuarios()
        {
            _driver = TestHelper.GetWebDriver;
            System.Threading.Thread.Sleep(10000);
        }

        [When(@"Eu preencho email e senha válidos")]
        public void WhenEuPreenchoEmailESenhaValidos()
        {
            var email = _driver?.FindElement(By.XPath("//*[@id=\"app\"]/div/main/article/div/div/div/div/form/div[1]/input"));
            email.Clear();
            email.SendKeys("sergio.coti@bol.com");

            var senha = _driver?.FindElement(By.XPath("//*[@id=\"app\"]/div/main/article/div/div/div/div/form/div[2]/input"));
            senha.Clear();
            senha.SendKeys("@Admin123");
        }

        [When(@"Solicito o acesso ao sistema")]
        public void WhenSolicitoOAcessoAoSistema()
        {
            var botao = _driver?.FindElement(By.XPath("//*[@id=\"app\"]/div/main/article/div/div/div/div/form/div[3]/div/input"));
            if (botao.Displayed && botao.Enabled)
                botao.Click();
        }

        [Then(@"Sistema redireciona para a página de consulta de estoques")]
        public void ThenSistemaRedirecionaParaAPaginaDeConsultaDeEstoques()
        {
            System.Threading.Thread.Sleep(5000);

            _driver?.Url.Should().Be("https://blazorappinfis.azurewebsites.net/admin/consultar-estoques");
            TestHelper.CreateScreenshot("Sistema redireciona para a página de consulta de estoques", _driver);
            _driver?.Close();
        }

        [When(@"Eu preencho email e senha inválidos")]
        public void WhenEuPreenchoEmailESenhaInvalidos()
        {
            var email = _driver?.FindElement(By.XPath("//*[@id=\"app\"]/div/main/article/div/div/div/div/form/div[1]/input"));
            email.Clear();
            email.SendKeys("teste@gmail.com");

            var senha = _driver?.FindElement(By.XPath("//*[@id=\"app\"]/div/main/article/div/div/div/div/form/div[2]/input"));
            senha.Clear();
            senha.SendKeys("@Teste123");
        }

        [Then(@"Sistema informa que o acesso é negado")]
        public void ThenSistemaInformaQueOAcessoENegado()
        {
            System.Threading.Thread.Sleep(5000);

            var mensagem = _driver?.FindElement(By.XPath("//*[@id=\"app\"]/div/main/article/div/div/div/div/div[2]/strong"));
            mensagem.Text.Should().Be("Acesso negado. Usuário inválido.");
            TestHelper.CreateScreenshot("Sistema informa que o acesso é negado", _driver);
            _driver?.Close();
        }
    }
}



