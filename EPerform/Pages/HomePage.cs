using ePerform.Library.Extent_Reports;
using EPerform.Library.Excel;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Pages
{


    class HomePage
    {
        IWebDriver _driver;


        public HomePage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }


        //Eperform HomeOption
        [FindsBy(How = How.XPath, Using = "//span[text()='Home']")]
        public IWebElement EperformHomeOption { get; set; }


        //Eperform Reviews option

        [FindsBy(How = How.XPath, Using = "//span[text()='Reviews']")]
        public IWebElement EperformReviewsOption { get; set; }

        //Eperform Review Arrow drop down
        [FindsBy(How = How.XPath, Using = "//b[@class='arrow fa fa-caret-down']")]
        public IWebElement EperformReviewsArrowOption { get; set; }


        //Eperform OrganisationStructureArrowOption
        [FindsBy(How = How.XPath, Using = "(//b[@class='arrow fa fa-caret-down'])[2]")]
        public IWebElement EperformOrganisationStructureArrowOption { get; set; }

        //Eperform Competency framework text
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Competency Framework')]")]
        public IWebElement EperformCompetencyFrameworkIcon { get; set; }

        //Eperform Reference Material icon
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Reference Material')]")]
        public IWebElement EperformReferenceMaterialIcon { get; set; }

        //Eperform Reference Material arrow icon

        [FindsBy(How = How.XPath, Using = "(//b[@class='arrow fa fa-caret-down'])[4]")]
        public IWebElement EperformReferenceMaterialArrowIcon { get; set; }



        //Eperform Competency framework arrow icon

        [FindsBy(How = How.XPath, Using = "(//b[@class='arrow fa fa-caret-down'])[3]")]
        public IWebElement EperformCompetencyFrameworkArrowIcon { get; set; }
       


        //Eperform Competencies option

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Competencies')]")]
        public IWebElement eleEperformCompetenciesOption { get; set; }
        public IWebElement EperformCompetenciesOption
        {
            get
            {
                return eleEperformCompetenciesOption;
            }
            set
            {
                eleEperformCompetenciesOption = value;
            }
        }

        // Eperform Competency Levels option

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Competency Levels')]")]
        public IWebElement EperformCompetencyLevelsOption { get; set; }
       

        //Eperform Competency Behaviours option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Competency Behaviours')]")]
        public IWebElement EperformCompetencyBehavioursOption { get; set; }
      

        //Eperform Goals option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Goals')]")]
        public IWebElement EperformGoalsOption { get; set; }
     

        //Eperform Measures option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Measures')]")]
        public IWebElement EperformMeasuresOption { get; set; }
      
        //Eperform Pillars option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Pillars')]")]
        public IWebElement EperformPillarsOption { get; set; }
      
        //Eperform Development Activities option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Development Activities')]")]
        public IWebElement EperformDevelopmentActivitiesOption { get; set; }
       
        //Eperform Documents option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Documents')]")]
        public IWebElement EperformDocumentsOption { get; set; }
       

        //Eperform Welcome text 

        [FindsBy(How = How.XPath, Using = "//div//h3[contains(text(),'Welcome')]")]
        public IWebElement EperformWelcomeText { get; set; }
       

        //Eperform Reviews Icon 
        [FindsBy(How = How.XPath, Using = "//a[text()='Reviews']")]
        public IWebElement EperformReviewsIcon { get; set; }
       

        //
        //Eperform Natural Talent Home text
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Natural Talent Home')]")]
        public IWebElement EperformNaturalTalentHomeText { get; set; }
       

        //Eperform Review Templates icon

        [FindsBy(How = How.XPath, Using = "//a[text()='Review Templates']")]
        public IWebElement EperformReviewTemplatesIcon { get; set; }
       
        //Eperform Workflows icon

        [FindsBy(How = How.XPath, Using = "//a[text()='Workflows']")]
        public IWebElement EperformWorkFlowsIcon { get; set; }
        
        // Eperform Workflows roles icon
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Workflow Roles')]")]
        public IWebElement EperformWorkflowRolesIcon { get; set; }
       

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Role Types')]")]
        public IWebElement EperformRoleTypes { get; set; }
       

        //Eperform Organisation Structure
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Organisation Structure')]")]
        public IWebElement EperformOrganisationStructureIcon { get; set; }
       

        //Eperform Organisational Structure Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Organisational Structure')]")]
        public IWebElement EperformOrganisationStructureOption { get; set; }
       

        //Eperform Positions Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Positions')]")]
        public IWebElement EperformPositionsOption { get; set; }
     

        //Eperform Markers Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Markers')]")]
        public IWebElement EperformMarkersOption { get; set; }
        

        // Eperform System Configuration
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'System Configuration')]")]
        public IWebElement EperformSystemConfigurationIcon { get; set; }
       
        //Eperform EperformSystemConfigurationArrow Icon
        [FindsBy(How = How.XPath, Using = "(//b[@class='arrow fa fa-caret-down'])[5]")]
        public IWebElement EperformSystemConfigurationArrowIcon { get; set; }
       
        //Eperform Users option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Users')]")]
        public IWebElement EperformUsersOption { get; set; }
        

        //Eperform EperformPermissionProfiles Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Permission Profiles')]")]
        public IWebElement EperformPermissionProfilesOption { get; set; }
        

        //Eperform EperformMessages Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Messages')]")]
        public IWebElement EperformMessagesOption { get; set; }
       

        //Eperform EperformEmailTemplates Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Email Templates')]")]
        public IWebElement EperformEmailTemplatesOption { get; set; }
       

        //Eperform EperformEmailNotifications Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Email Notifications')]")]
        public IWebElement EperformEmailNotificationsOption { get; set; }
       

        //Eperform EperformEmailQueue Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Email Queue')]")]
        public IWebElement EperformEmailQueueOption { get; set; }
        

        //Eperform EperformGlobalQuestions Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Global Questions')]")]
        public IWebElement EperformGlobalQuestionsOption { get; set; }
       

        //Eperform EperformFormTemplates Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Form Templates')]")]
        public IWebElement EperformFormTemplatesOption { get; set; }
        

        //Eperform EperformSystemForms Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'System Forms')]")]
        public IWebElement EperformSystemFormsOption { get; set; }
       
        //Eperform EperformCaptions Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Captions')]")]
        public IWebElement EperformCaptionsOption { get; set; }
       

        //Eperform EperformBulkImportandExport Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Bulk Import and Export')]")]
        public IWebElement EperformBulkImportandExportOption { get; set; }
       
        //Eperform EperformSystemSettings Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'System Settings')]")]
        public IWebElement EperformSystemSettingsOption { get; set; }
        

        //Eperform EperformCustomerConfiguration Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Customer Configuration')]")]
        public IWebElement EperformCustomerConfiguration { get; set; }
       

        //Eperform System Administrator Icon
        [FindsBy(How = How.XPath, Using = "(//span[@id='user_info'])[1]")]
        public IWebElement EperformSystemAdministratorIcon { get; set; }
       

        // Eperform Employee Portal option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Employee Portal')]")]
        public IWebElement EperformEmployeePortalOption { get; set; }
       

        //Eperform Talent Acquisition Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Talent Acquisition')]")]
        public IWebElement EperformTalentAcquisitionOption { get; set; }
        

        //Eperform Change Password Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Change Password')]")]
        public IWebElement EperformChangePasswordOption { get; set; }
       
        //Eperform Help Icon
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Help')]")]
        public IWebElement EperformHelpIcon { get; set; }
    

        //Eperform HelpArrowIcon
        [FindsBy(How = How.XPath, Using = "(//b[@class='fa fa-caret-down'])[2]")]
        public IWebElement EperformHelpArrowIcon { get; set; }
     

        //Eperform Toggle Caption Names Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Toggle Caption Names')]")]
        public IWebElement EperformToggleCationNamesText { get; set; }
       

        //Eperform Automated Testing text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Automated Testing')]")]
        public IWebElement EperformAutomatedTestingText { get; set; }
        

        //Eperform User Community Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'User Community')]")]
        public IWebElement EperformUserCommunityText { get; set; }
       

        //Eperform Contact Administrator Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Contact Administrator')]")]
        public IWebElement EperformContactAdmistratorText { get; set; }
       

        //Eperform Give Feedback Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Give Feedback')]")]
        public IWebElement EperformGiveFeedbackText { get; set; }

        //Eperform Self Help Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Self Help')]")]
        public IWebElement EperformSelfHelpText;
      

        //EPerform Build Text
        [FindsBy(How = How.XPath, Using = "//a//b[contains(text(),'Build:')]")]
        public IWebElement EperformBuildText { get; set; }
       

        //EPerform Date Text
        [FindsBy(How = How.XPath, Using = "//a//b[contains(text(),'Date:')]")]
        public IWebElement EperformDateText { get; set; }
       

        //EPerform newPasswordErrorText
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The New Password field is required.')]")]
        public IWebElement EperformNewPasswordErrorText { get; set; }
        

        //EPerform ConfirmnewPasswordErrorText
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Confirm New Password field is required.')]")]
        public IWebElement EperformConfirmNewPasswordErrorText { get; set; }
      


        //Eperform CurrentPasswordErrorText
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Current Password field is required')]")]
        public IWebElement EperformCurrentPasswordErrorText { get; set; }
       

        //Eperform CurrentPassword TextBox
        [FindsBy(How = How.Id, Using = "Dto_CurrentPassword")]
        public IWebElement EperformCurrentPasswordTextBox { get; set; }
       

        //Eperform newPassword TextBox
        [FindsBy(How = How.Id, Using = "Dto_NewPassword")]
        public IWebElement EperformNewPasswordTextBox { get; set; }
        
        //Eperform ConfirmNewPassword textbox
        [FindsBy(How = How.Id, Using = "Dto_ConfirmNewPassword")]
        public IWebElement EperformConfirmNewPassword { get; set; }


        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Error!')]")]
        public IWebElement EperformErrorMessageText { get; set; }

        //Useable Method for the verify the reviewpage
        public void pageverify(String page)
        {
           
            IWebElement pages = _driver.FindElement(By.XPath("//div//h1[contains(text(),'" + page + "')]"));
            Assert.IsTrue(pages.Displayed, page + "is not displayed ");
            
            ExtentReport.test.Log(LogStatus.Pass, page + "text is displayed in the Reviews page");

        }

       



    }
}
