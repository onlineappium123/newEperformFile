
using ePerform.Library.Extent_Reports;

using EPerform.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Library
{
    public class BaseMethods
    {
        /// <summary>
        /// Navigate Back Page Method(Clicks on Browser Back Button)
        /// </summary>
        /// <param name="_driver">Current IWebDriver</param>
        public static void Navigate_Back(IWebDriver _driver)
        {
            _driver.Navigate().Back();
        }

        /// <summary>
        /// Navigate Forward Page Method(Clicks on Browser Forward Button)
        /// </summary>
        /// <param name="_driver">Current IWebDriver</param>
        public static void Navigate_Forward(IWebDriver _driver)
        {
            _driver.Navigate().Forward();
        }

        /// <summary>
        /// This function can used to make the Thread Sleep for specified time. The value passed will be used as Mili Seconds
        /// </summary>
        /// <param name="Value">Number of Mili Seconds</param>
        public static void SleepTimeOut(int Value)
        {
            System.Threading.Thread.Sleep(Value);
        }

        /// <summary>
        /// This function will check whether the Alert is present or not. 
        /// If the Alert is present, pass the value to perform action on Alert. Ex: Accept, Dismiss..
        /// </summary>
        /// <param name="_driver">IWebDriver</param>
        /// <param name="Value">Alert Action (Accept or Dismiss)</param>
        /// <returns></returns>
        public static void IsAlertPresent(IWebDriver _driver, string Value)
        {
            try
            {
                IAlert alert = _driver.SwitchTo().Alert();
                if (Value == "Accept")
                {
                    alert.Accept();
                    Console.WriteLine("Alert is Accepted");
                }
                else if (Value == "Dismiss")
                {
                    alert.Dismiss();
                    Console.WriteLine("Alert is Dismissed");
                }
                else
                {
                    Console.WriteLine("Alert Action is Indefined");
                }
            }
            catch (NoAlertPresentException NoAlert)
            {
                Console.WriteLine("No Alert is Present");
                Console.WriteLine(NoAlert.StackTrace);
            }
        }

        /// <summary>
        /// Check whether the Alert is present, returns the alert text
        /// </summary>
        /// <param name="_driver">IWebDriver</param>
        /// <returns></returns>
        public static string GetAlertText(IWebDriver _driver)
        {
            try
            {
                IAlert alert = _driver.SwitchTo().Alert();
                string _text = alert.Text;
                alert.Accept();
                return _text;
            }
            catch (NoAlertPresentException NoAlert)
            {
                Console.WriteLine("No Alert is Present");
                Console.WriteLine(NoAlert.StackTrace);
            }
            return "No Alert is Present";
        }

        /// <summary>
        /// Selects the element in Drop Down List based on Text
        /// </summary>
        /// <param name="Ddl">Drop Down List WebElemnt</param>
        /// <param name="SelectText">Text to Select in Drop Down List</param>
        public static void DdlSelectByText(IWebElement Ddl, string SelectText)
        {
            SelectElement select = new SelectElement(Ddl);
            select.SelectByText(SelectText);
            ePerform.Library.Extent_Reports.ExtentReport.test.Log(LogStatus.Info, SelectText + " Option Selected");
        }

        /// <summary>
        /// Selects the element in Drop Down List based on Value
        /// </summary>
        /// <param name="Ddl">Drop Down List WebElemnt</param>
        /// <param name="SelectValue">Value to Select in Drop Down List</param>
        public static void DdlSelectByValue(IWebElement Ddl, string SelectValue)
        {
            SelectElement select = new SelectElement(Ddl);          
            select.SelectByValue(SelectValue);
        }

        /// <summary>
        /// Selects the element in Drop Down List based on Index
        /// </summary>
        /// <param name="Ddl">Drop Down List WebElemnt</param>
        /// <param name="SelectIndex">Index to Select in Drop Down List</param>
        public static void DdlSelectByIndex(IWebElement Ddl, int SelectIndex)
        {
            SelectElement select = new SelectElement(Ddl);
            select.SelectByIndex(SelectIndex);
        }

        /// <summary>
        /// Method to press the Control Button
        /// </summary>
        /// <param name="_driver">IWebDriver</param>
        public static void CtrlKeyDown(IWebDriver _driver)
        {
            Actions action = new Actions(_driver);
            action.SendKeys(Keys.Control + "]").Build().Perform();
        }

        /// <summary>
        /// Tiny MCE Editor
        /// </summary>
        /// <param name="_driver">IWebDriver</param>
        /// <param name="element">Frame WebElement</param>
        /// <param name="Value">Value to be entered</param>
        public static void TinyMCEEditor(IWebDriver _driver, IWebElement element, string Value)
        {
            _driver.SwitchTo().Frame(element);
            ExtentReport.test.Log(LogStatus.Info, "Switched to Editor");
            IWebElement body = _driver.FindElement(By.CssSelector("body"));
            body.SendKeys(Value);
            ExtentReport.test.Log(LogStatus.Info, "Entred Text " + Value + "in Editor");
            _driver.SwitchTo().ParentFrame();
            ExtentReport.test.Log(LogStatus.Info, "Switching to Parent Frame");
        }

        public static void webelementverify(IWebElement WebElement)
        {
            Assert.IsTrue(WebElement.Displayed, " is not displayed");
            ExtentReport.test.Log(LogStatus.Pass, WebElement.Text + " is displayed");
        }

        public static void verifyWebElement(IWebElement WebElement,String actual,String expected)
        {
            Assert.IsTrue(WebElement.Displayed, actual);
            ExtentReport.test.Log(LogStatus.Pass, expected);
        }

       


        /// <summary>
        /// Compare Two String Soft Assert
        /// </summary>
        /// <param name="ExpectedMsg">Expected Message</param>
        /// <param name="ActualMsg">Actual Message</param>
        public static void SoftAssertEqual(string ExpectedMsg, string ActualMsg)
        {
            try
            {
                Assert.AreEqual(ExpectedMsg, ActualMsg, "Assert Pass");
            }
            catch (AssertionException ex)
            {
                ExtentReport.test.Log(LogStatus.Fatal, "Assert Failed: Expected Message: " + ExpectedMsg + "but Message was: " + ActualMsg);
                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + ex.Message);
            }
        }
    }
}