using System;
using TechTalk.SpecFlow;

namespace correios.StepDefinitions
{
    [Binding]
    public class CorreiosStepDefinitions
    {
        [Given(@"Eu abro o site dos Correios")]
        public void GivenEuAbroOSiteDosCorreios()
        {
            throw new PendingStepException();
        }

        [Given(@"No campo buscar CEP ou endereço preencho um valor invalido\.")]
        public void GivenNoCampoBuscarCEPOuEnderecoPreenchoUmValorInvalido_(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"Eu pressiono o botão buscar, lupa ou dou enter\.")]
        public void WhenEuPressionoOBotaoBuscarLupaOuDouEnter_()
        {
            throw new PendingStepException();
        }

        [Then(@"o resultado deve ser a mensagem ""([^""]*)""\.")]
        public void ThenOResultadoDeveSerAMensagem_(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"Eu volto ao inicio da pagina")]
        public void GivenEuVoltoAoInicioDaPagina()
        {
            throw new PendingStepException();
        }

        [Given(@"Eu no campo buscar CEP ou endereço preencho um valor valido")]
        public void GivenEuNoCampoBuscarCEPOuEnderecoPreenchoUmValorValido(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"Eu pressiono o botão lupa ou pressiono enter")]
        public void WhenEuPressionoOBotaoLupaOuPressionoEnter()
        {
            throw new PendingStepException();
        }

        [Then(@"o resultado deve conter ""([^""]*)"" e ""([^""]*)""")]
        public void ThenOResultadoDeveConterE(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Given(@"Eu volto a pagina inicial")]
        public void GivenEuVoltoAPaginaInicial()
        {
            throw new PendingStepException();
        }

        [Given(@"No campo ratreio clico no lupa ou pressione enter")]
        public void GivenNoCampoRatreioClicoNoLupaOuPressioneEnter()
        {
            throw new PendingStepException();
        }

        [Given(@"Na pagina de rastreio preencho o valor")]
        public void GivenNaPaginaDeRastreioPreenchoOValor(Table table)
        {
            throw new PendingStepException();
        }
    }
}
