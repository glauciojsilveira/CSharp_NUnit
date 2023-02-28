using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Interfaces;
using SpecFlow;

namespace correios.StepDefinitions
{
    [Binding]
    public class HomeSteps
    {
        [Given(@"Eu abro o site dos correios\.")]
        public void GivenEuAbroOSiteDosCorreios_()
        {
            throw new PendingStepException();
        }

        
    }
}
