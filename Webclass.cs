using OpenQA.Selenium;
using Philips2.Drivers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philips2.POM
{
    public class Webclass : Basedriver
    {
       
            public Webclass(IWebDriver driver)
            {
                PageFactory.InitElements(driver, this);
            }

            [FindsBy(How = How.XPath, Using = "//*[@id=\"cssmenu\"]/ul/li[1]/a")]
            public IWebElement abt;

            [FindsBy(How = How.XPath, Using = "//*[@id=\"cssmenu\"]/ul/li[2]/a")]
            public IWebElement contact;

            [FindsBy(How = How.XPath, Using = "//*[@id=\"cssmenu\"]/ul/li[3]/a")]
            public IWebElement joinemail;

            [FindsBy(How = How.XPath, Using = "//*[@id=\"cssmenu\"]/ul/li[4]/a")]
            public IWebElement softwareblog;

            [FindsBy(How = How.XPath, Using = "//*[@id=\"cssmenu\"]/ul/li[5]/a")]
            public IWebElement marketblog;

        
        //[FindsBy(How = How.Id, Using = "mce-EMAIL")]
        //public IWebElement emailtxt;


    }


}
