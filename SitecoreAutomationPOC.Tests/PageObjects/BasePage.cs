using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SitecoreAutomationPOC.Tests.PageObjects
{
   public class BasePage
   {
        public IWebDriver Driver { get; private set; }
    
        public void NavigateToPage(string url)
        {
            
            Driver = new ChromeDriver();
            Driver.Manage().Window.Size = new Size(1920,1080);
            Driver.Navigate().GoToUrl(url);
        }

        public string PageTitle()
        {
            return Driver.Title;
        }


    }
}
