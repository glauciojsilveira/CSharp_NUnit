using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Interfaces;

namespace correios

{



    class TestePuroNunit : ComecoPuroNunit
    {

        [Test]
        public void TestCepInvalido()
        {
          
            driver.FindElement(By.Id("endereco")).Clear();
            driver.FindElement(By.Id("endereco")).SendKeys("80700000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            Thread.Sleep(2000);
            Assert.That(driver.FindElement(By.Id("mensagem-resultado-alerta")).Text, Does.Contain("Dados não encontrado"));
            Assert.That(driver.FindElement(By.Id("mensagem-resultado")).Text, Does.Contain("Não há dados a serem exibidos"));
            driver.FindElement(By.Id("btn_nbusca")).Click();
           
           


         }

        [Test]

        public void TestCepValido()
        {
            driver.FindElement(By.Id("endereco")).Clear();
            driver.FindElement(By.Id("endereco")).SendKeys("01013-001");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            Thread.Sleep(2000);
            Assert.That(driver.FindElement(By.XPath("//*[@id='resultado-DNEC']/tbody/tr/td[1]")).Text, Does.Contain("Rua Quinze de Novembro - lado ímpar"));
            Assert.That(driver.FindElement(By.XPath("//*[@id='resultado-DNEC']/tbody/tr/td[3]")).Text, Does.Contain("São Paulo/SP"));
         
            
        }

        [Test]

        public void Testrastreio()
        {
            driver.Navigate().GoToUrl("https://rastreamento.correios.com.br/app/index.php"); 
            driver.FindElement(By.XPath("//*[@id='objeto']")).SendKeys("SS987654321BR");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='objeto']")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Assert.That(driver.FindElement(By.XPath("/html/body/main/div[1]/form/div[2]/div[2]/div[2]/div[3]")).Text, Does.Contain("Preencha o campo captcha"));
         
         

        }

    }
}
