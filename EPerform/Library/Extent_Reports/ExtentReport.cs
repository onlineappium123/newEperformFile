﻿using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using RelevantCodes.ExtentReports.Config;
using System;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePerform.Library.Extent_Reports
{
    public class ExtentReport
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        public static string ReportPath = null;

        public static void CExtentReport()
        {
            string ReportValue = ConfigurationManager.AppSettings["ExtentReports"];
            if (ReportValue == "True")
            {
                string _path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                string _actualPath = _path.Substring(0, _path.LastIndexOf("bin"));
                string _projectPath = new Uri(_actualPath).LocalPath;
                string _reportPath = _projectPath + "Output\\ExtentReports\\";
                string _CurrentDate = Convert.ToString(DateTime.Now);
                string _FileName = _CurrentDate.Replace("/", "_").Replace(":", "_").Replace(" ", "_");
                _reportPath += "ExtentReport_" + _FileName + ".html";
                ReportPath = _reportPath;

                try
                {
                    if (!File.Exists(ReportPath))
                    {
                        File.Create(ReportPath).Close();
                    }

                }
                catch (FileNotFoundException fnfe)
                {
                    Console.WriteLine(fnfe.Message);
                }
                catch (FileLoadException fle)
                {
                    Console.WriteLine(fle.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["ExtentReports"].Value = "False";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }

            extent = new ExtentReports(ReportPath, false);
            extent
                .AddSystemInfo("Host Name", "Acendre")
                .AddSystemInfo("Environment", "QA2")
                .AddSystemInfo("User Name", "QA Team");

        }

        public static string Capture(IWebDriver driver)
        {
            string CurrentDate = Convert.ToString(DateTime.Now);
            string screenShotName = CurrentDate.Replace("/", "_").Replace(":", "_").Replace(" ", "_");
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "Output\\ErrorScreenshots\\" + screenShotName + ".png";
            string localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ImageFormat.Jpeg);
            return localpath;
        }

    }
}
