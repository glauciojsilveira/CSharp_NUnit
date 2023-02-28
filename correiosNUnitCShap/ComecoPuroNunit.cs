using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Interfaces;


namespace correios

{
    public class ComecoPuroNunit

    {
        public IWebDriver driver;


        [SetUp]
        public void Inicioteste()
        {
            //1.Entre no site dos correios;
            //Aqui eu abro o navegador e maximizo a janela
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }



        [TearDown]
        public void FinalDoTeste()
        {


        }




    }




}
