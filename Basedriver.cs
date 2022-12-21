using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philips2.Drivers
{
    public class Basedriver
    {
        public IWebDriver driver;   

        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://compendiumdev.co.uk/");
        }
        public void closedriver()
        {
            driver.Quit();
        }
    }
}
