using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SitecoreAutomationPOC.Tests.PageObjects
{
    public class ContentEditorPage : SitecorePage
    {

        private IWebElement DeleteButton
        {
            get
            {
                return Driver.FindElement(By.XPath("//a[@title='Delete the item.']"));
            }
        }

        private IWebElement ImageField
        {
            get { return Driver.FindElement(By.CssSelector(".scContentControlImage")); }
        }
        private IWebElement ContentEditor
        {
            get { return Driver.FindElement(By.CssSelector("html")); }
        }

        private IWebElement SitecoreSearchBar
        {
            get { return Driver.FindElement(By.Id("TreeSearch")); }

        }

        private IWebElement SitecoreSearchButton
        {
            get { return Driver.FindElement(By.CssSelector(".scSearchButton")); }
        }

        private IWebElement SitecoreTextField
        {
            get { return Driver.FindElement(By.CssSelector(".scContentControl")); }
        }

        private IWebElement PublishButton
        {
            get { return Driver.FindElement(By.XPath("//*[@class='scRibbonToolbarLargeComboButtonTop']")); }
        }

        private IWebElement ModalButton
        {
            get
            {
                var test =
                    Driver.SwitchTo()
                        .Frame("jqueryModalDialogsFrame")
                        .SwitchTo()
                        .Frame("scContentIframeId0")
                        .FindElement(By.Id("OK"));

                return test;

            }
        }

        private IWebElement ModalText
        {
            get
            {
                return
                    Driver.SwitchTo()
                        .Frame("jqueryModalDialogsFrame")
                        .SwitchTo()
                        .Frame("scContentIframeId0")
                        .FindElement(By.CssSelector("#Value"));
            }
        }

        private IWebElement VersionSelector
        {
            get
            {
                Driver.FindElement(By.CssSelector(".scEditorHeaderVersionsLanguage")).Click();

                return Driver.SwitchTo()
                    .Frame("Header_Language_Gallery")
                    .FindElements(By.CssSelector(".scMenuPanelItem"))[1];
            }
        }

        public void SearchSitecoreItem(string templateId)
        {
            SitecoreSearchBar.SendKeys(templateId);
            SitecoreSearchButton.Click();
        }

        public void ContentEditorEditTextField(string text)
        {
            SitecoreTextField.Clear();
            SitecoreTextField.SendKeys(text);
        }

        public void SaveContentEditor()
        {
            SitecoreTextField.SendKeys(Keys.Control + 's');
        }

        public void PublishItemContentEditor()
        {
            ContentEditor.SendKeys(Keys.Alt + 'p');
           
            PublishButton.Click();
         
            ModalButton.Click();
            ModalButton.Click();
        }

        public void RenameItemContentEditor(string itemName)
        {
            ContentEditor.SendKeys(Keys.F2);
            ModalText.SendKeys(itemName);
            Driver.SwitchTo().DefaultContent();
            ModalButton.Click();
            
        }

        public void DeleteItemContentEditor()
        {
            DeleteButton.Click();   
        }

        public void EditImageField(string imagepath)
        {
            ImageField.Clear();
            ImageField.SendKeys(imagepath);

                
                }

        public void AddNewVersion()
        {
            VersionSelector.Click();
            Driver.FindElement(By.CssSelector(".scMessageBarOption"))
                .Click();
        }

       
    }
}
