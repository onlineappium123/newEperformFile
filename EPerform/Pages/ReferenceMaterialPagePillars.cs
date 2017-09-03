using EPerform.Library;
using ePerfrom.Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Pages
{
    class ReferenceMaterialPagePillars
    {
        IWebDriver _driver;


        public ReferenceMaterialPagePillars(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How=How.XPath,Using = "//span[text()='Name']")]
        public IWebElement PillarNameText { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Description']")]
        public IWebElement PillarDescriptionText { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Active']")]
        public IWebElement PillarActiveText { get; set; }


        [FindsBy(How =How.XPath,Using = "//th[@class='col-md-2 footable-visible footable-last-column']")]
        public IWebElement PillarActionsText { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()=' Add Pillar']")]
        public IWebElement AddPillarButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//h3[contains(text(),' Manage Pillar')]")]
        public IWebElement PillarManagePillarText { get; set; }

        [FindsBy(How=How.XPath,Using = "//h3[contains(text(),'Pillars')]")]
        public IWebElement PillarText { get; set; }

        [FindsBy(How=How.XPath,Using = "//span[@class='field-validation-error']")]
        public IWebElement errorMessageName { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='field-validation-error']")]
        public IWebElement invalidErrorMessage { get; set; }

        public void sortablepillarpage()
        {
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            PillarNameText.Click();
            BaseMethods.webelementverify(reference.NameText);
            PillarNameText.Click();
            BaseMethods.webelementverify(reference.NameText);
            PillarDescriptionText.Click();
            BaseMethods.webelementverify(reference.DescriptionText);
            PillarDescriptionText.Click();
            BaseMethods.webelementverify(reference.DescriptionText);
            PillarActiveText.Click();
            BaseMethods.webelementverify(reference.PillarText);
            PillarActiveText.Click();
            BaseMethods.webelementverify(reference.PillarText);
        }


        public void createPillar(String SheetName, String Keyname)
        {
            HomePage home = new HomePage(_driver);
            ArrayList list = BaseClass.GetData("ER_TESTDATA", SheetName, "KeyName", Keyname);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            home.EperformReferenceMaterialArrowIcon.Click();
            home.EperformPillarsOption.Click();
            AddPillarButton.Click();
            referenceMaterialPage.EperformNameTextBox.SendKeys(list[1].ToString());
            referenceMaterialPage.EperformDescriptionTextBox.SendKeys(list[2].ToString());
            if (list[3].ToString() == "Yes")
            {
                referenceMaterialPage.EperformActiveYesRadioBtn.Click();
            }
            else
            {
                referenceMaterialPage.EperfromActiveNoRadioBtn.Click();
            }
            reference.EperformSubmit.Click();
        }

        public void createEditpillar(String SheetName, String Keyname)
        {
            HomePage home = new HomePage(_driver);
            ArrayList list = BaseClass.GetData("ER_TESTDATA", SheetName, "KeyName", Keyname);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            home.EperformReferenceMaterialArrowIcon.Click();
            home.EperformPillarsOption.Click();
            AddPillarButton.Click();
            referenceMaterialPage.EperformNameTextBox.SendKeys(list[1].ToString());
            referenceMaterialPage.EperformDescriptionTextBox.SendKeys(list[2].ToString());
            if (list[3].ToString() == "Yes")
            {
                referenceMaterialPage.EperformActiveYesRadioBtn.Click();
            }
            else
            {
                referenceMaterialPage.EperfromActiveNoRadioBtn.Click();
            }
            reference.EperformSubmit.Click();
            try
            {
                if (formtemplate.EperformSuccessMessage.Displayed)
                {
                   BaseMethods.verifyWebElement(formtemplate.EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                  
                    IWebElement element = _driver.FindElement(By.XPath("//tbody//tr//td[contains(text(),'" + list[1].ToString() + "')]"));
                    BaseMethods.webelementverify(element);
                    IWebElement EditElement = _driver.FindElement(By.XPath("//tbody//tr//td[contains(text(),'" + list[1].ToString() + "')]/../td//a[contains(text(),'Edit')]"));
                    EditElement.Click();
                    referenceMaterialPage.EperformNameTextBox.SendKeys(list[4].ToString());
                    referenceMaterialPage.EperformDescriptionTextBox.SendKeys(list[5].ToString());
                    reference.EperformSubmit.Click();
                    BaseMethods.webelementverify(element);
                }
                else
                {
                    
               
            }
            }
            catch (Exception e)
            {
                BaseMethods.webelementverify(invalidErrorMessage);
            }
        }
    }
}
