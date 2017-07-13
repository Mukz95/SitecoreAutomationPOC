using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SitecoreAutomationPOC.Tests.EnviromentSettings;
using SitecoreAutomationPOC.Tests.PageObjects;

namespace SitecoreAutomationPOC.RegressionTests
{
    [TestFixture]
    public class SitecoreContentAuthorShould
    {
        [TestCase("{9BC6A0F1-CBDC-4D92-900C-06AF2E93C2CE}")]
        public void ReturnMatchingTemplate(string itemId)
        {
            //Given I am on the Sitecore login page
            var content = new ContentEditorPage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginUrl);
            
            //When I login to Sitecore

            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);


            //And I Search For A Template

            content.SearchSitecoreItem(itemId);
            
            }

        [TestCase("{9BC6A0F1-CBDC-4D92-900C-06AF2E93C2CE}", "MuktarsEdit")]
        public void ReturnEditedTextFieldOnContentPage(string itemId, string text)
        {
            //Given I am on the Sitecore login page
            var content = new ContentEditorPage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginUrl);

            //When I login to Sitecore

            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);


            //And I Search For A Template

            content.SearchSitecoreItem(itemId);

            //And I Edit A EditTextField
            content.ContentEditorEditTextField(text);
            content.SaveContentEditor();

        }

        [TestCase("{9BC6A0F1-CBDC-4D92-900C-06AF2E93C2CE}")]
        public void PublishASitecoreItem(string itemId)
        {
            // Given I am on the Sitecore login page
             var content = new ContentEditorPage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginUrl);

            //When I login to Sitecore

            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);

            //And I Search For A Template

            content.SearchSitecoreItem(itemId);

            //And I Publish An Item
            content.PublishItemContentEditor();

        }

        [TestCase("{9BC6A0F1-CBDC-4D92-900C-06AF2E93C2CE}")]
        public void DeleteASitecoreItem(string itemId)
        {
            // Given I am on the Sitecore login page
            var content = new ContentEditorPage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginUrl);

            //When I login to Sitecore

            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);

            //And I Search For A Template

            content.SearchSitecoreItem(itemId);

            //And I Delete An Item
            content.DeleteItemContentEditor();

        }

        [TestCase("{9BC6A0F1-CBDC-4D92-900C-06AF2E93C2CE}", "Renamed Text")]
        public void RenameAnItemInContentEditor(string itemId, string text)
        {
            //Given I am on the Sitecore login page
            var content = new ContentEditorPage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginUrl);

            //When I login to Sitecore

            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);


            //And I Search For A Template

            content.SearchSitecoreItem(itemId);

            //And I Edit A EditTextField
            content.RenameItemContentEditor(text);
            

        }  

        [TestCase("{9BC6A0F1-CBDC-4D92-900C-06AF2E93C2CE}", "/Default Website/cover")]
        public void EditImageField(string itemId, string text)
        {
            //Given I am on the Sitecore login page
            var content = new ContentEditorPage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginUrl);

            //When I login to Sitecore

            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);


            //And I Search For A Template

            content.SearchSitecoreItem(itemId);

            //And I Edit A EditTextField
            content.EditImageField(text);

            content.SaveContentEditor();
            

        }


        //Requires a new version each time
        [TestCase("{9580E500-84DB-4E7F-9C93-E7A6533F5AB9}")]
        public void AddVersionToAnItemInContentEditor(string itemId)
        {
            //Given I am on the Sitecore login page
            var content = new ContentEditorPage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginUrl);

            //When I login to Sitecore

            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);


            //And I Search For A Template

            content.SearchSitecoreItem(itemId);

            //And I Edit A EditTextField
           content.AddNewVersion();


        }

        [TestCase("{9580E500-84DB-4E7F-9C93-E7A6533F5AB9}s")]
        public void UnPublishASitecoreItem(string itemId)
        {
            // Given I am on the Sitecore login page
            var content = new ContentEditorPage();
            content.NavigateToPage(EnviromentSettings.SitecoreLoginWeb);

            //When I login to Sitecore

            content.LoginToContentEditor(EnviromentSettings.SitecoreEnviromentUsername, EnviromentSettings.SitecoreEnviromentPassword);

            //And I Search For A Template

            content.SearchSitecoreItem(itemId);

            //And I Delete An Item
            content.DeleteItemContentEditor();

        }

    }
}
