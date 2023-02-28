using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Interfaces;
using SpecFlow;

namespace correios.Pages
{
    public class PaginaPrincipal
    {

        public IWebDriver driver { get; }

        public PaginaPrincipal(IWebDriver driver) 
        {

            driver = driver;
        
        }

        public IWebElement CampoCep => driver.FindElement(By.Id("endereco"));
        public IWebElement BotaoBuscarCep => driver.FindElement(By.Id("btn_pesquisar"));
        public IWebElement MensagemAlerta => driver.FindElement(By.Id("mensagem-resultado-alerta"));
        public IWebElement MensagemResultado => driver.FindElement(By.Id("mensagem-resultado"));
        public IWebElement BotaoBusca => driver.FindElement(By.Id("btn_nbusca"));
        public IWebElement Botaopesquisar => driver.FindElement(By.Id("btn_pesquisar"));
        public IWebElement ResultadoEndereco => driver.FindElement(By.XPath("//*[@id='resultado-DNEC']/tbody/tr/td[1]"));
        public IWebElement ResultadoUF => driver.FindElement(By.XPath("//*[@id='resultado-DNEC']/tbody/tr/td[3]"));
        public IWebElement VoltarInicio => driver.FindElement(By.XPath("//*[@id=\'menu\']/a[2]"));
        public IWebElement Ratreio => driver.FindElement(By.XPath("//*[@id='content']/div[3]/div/div[2]/div[1]/form/div[2]/button/i"));
        public IWebElement RatreioPreencher => driver.FindElement(By.XPath("//*[@id='objetos']"));
        public IWebElement RatreioBuscarLupa => driver.FindElement(By.XPath("//*[@id='b-pesquisar']"));
        public IWebElement RatreioMensagem => driver.FindElement(By.XPath("tml/body/main/div[1]/form/div[2]/div[2]/div[2]/div[1]/label"));






     }
}
