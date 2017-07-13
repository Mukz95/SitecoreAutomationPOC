using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SitecoreAutomationPOC.Tests.EnviromentSettings;

namespace SitecoreAutomationPOC.Tests.PageObjects
{

    public class SitecorePage : BasePage
    {
        public IWebElement UserNameField
        {
            get { return Driver.FindElement(By.Id("UserName")); }
        }

        public IWebElement PasswordField
        {
            get { return Driver.FindElement(By.Id("Password")); }
        }

        public IWebElement LoginButton { get { return Driver.FindElement(By.CssSelector(".btn-primary.btn-block")); } }

        public void LoginToContentEditor(string username, string password)
        {
            UserNameField.SendKeys(username);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }



    }
}
