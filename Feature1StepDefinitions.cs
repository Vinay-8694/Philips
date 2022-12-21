using Gherkin.Ast;
using OpenQA.Selenium;
using Philips2.Drivers;
using Philips2.POM;
using System;
using TechTalk.SpecFlow;

namespace Philips2.StepDefinitions
{

    [Binding]
    public class Feature1StepDefinitions : Basedriver
    {
        Webclass w;

        [Given(@"Navigate to url")]
        public void GivenNavigateToUrl()
        {
            setup();
        }

        [When(@"click on about link")]
        public void WhenClickOnAboutLink()
        {
            w = new Webclass(driver);
            w.abt.Click();
        }
        
        [Then(@"about link page should open")]
        public void ThenAboutLinkPageShouldOpen()
        {
            Task.Delay(1000).Wait();
            //driver.Navigate().Back();
            closedriver();
        }

        [When(@"click on contact link")]
        public void WhenClickOnContactLink()
        {
            w = new Webclass(driver);
            w.contact.Click();
        }

        [Then(@"contact link should open")]
        public void ThenContactLinkShouldOpen()
        {
            Task.Delay(1000).Wait();
            //driver.Navigate().Back();
            closedriver();
        }


        [When(@"click on joinemaillink")]
        public void WhenClickOnJoinemaillink()
        {
            w = new Webclass(driver);
            w.joinemail.Click();
            //w.joinemail.SendKeys("vina");


        }

        [Then(@"joinemaillink should open")]
        public void ThenJoinemaillinkShouldOpen()
        {
            Task.Delay(1000).Wait();
            //driver.Navigate().Back();
            closedriver();
        }


        [When(@"click on softwareblog")]
        public void WhenClickOnSoftwareblog()
        {
            w = new Webclass(driver);
            w.softwareblog.Click();


        }

        [Then(@"softwareblog will open")]
        public void ThenSoftwareblogWillOpen()
        {
            Task.Delay(1000).Wait();
            //driver.Navigate().Back();
            closedriver();
        }

        [When(@"click on marketblog")]
        public void WhenClickOnMarketblog()
        {
            w = new Webclass(driver);
            w.marketblog.Click();
        }

        [Then(@"marketblog should open")]
        public void ThenMarketblogShouldOpen()
        {
            Task.Delay(1000).Wait();
            driver.Navigate().Back();
        }        
    }
}

    

