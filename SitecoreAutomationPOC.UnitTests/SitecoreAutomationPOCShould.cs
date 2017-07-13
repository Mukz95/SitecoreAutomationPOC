using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SitecoreAutomationPOC.Tests;
using SitecoreAutomationPOC.Tests.EnviromentSettings;
using SitecoreAutomationPOC.Tests.PageObjects;

namespace SitecoreAutomationPOC.UnitTests
{
    [TestFixture]
    public class SitecoreAutomationPocShould 
    {
        [Test]
        public void LogUserIntoContentEditor()
        {
            //Given I am on the Sitecore login page
            var content = new SitecorePage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginUrl);

            
            //When I login to Sitecore
            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);

            //Then I am logged in to Sitecore

           Assert.AreEqual("Content Editor", content.PageTitle());
        }
    }
}
