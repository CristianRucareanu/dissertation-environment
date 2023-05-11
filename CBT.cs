using System;
using System.IO;
using System.Net;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections.Specialized;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using Microsoft.Edge.SeleniumTools;
using EdgeOptions = Microsoft.Edge.SeleniumTools.EdgeOptions;
using EdgeDriver = Microsoft.Edge.SeleniumTools.EdgeDriver;

// There are a couple components we’ll need. We’ll separate starting/closing our WebDriver and running our tests. For starting up, we can use this code to generate our WebDriver
namespace CBT_NUnit
{
    [TestFixture]
    public class CBTAPI
    {
        protected RemoteWebDriver driver;
        protected string browser;
        protected string platform;
        protected string session_id;
        protected string tc_name;
        protected string enviroment;
        public string BaseURL = "https://crossbrowsertesting.com/api/v3/selenium";
        public string username = "bcalin@perfectforms.com";
        public string authkey = "u9e112e2f5b4b0c6";
        private bool acceptNextAlert = true;

        public CBTAPI(string browser, string tc_name, string platform, string enviroment)
        {
            this.browser = browser;
            this.tc_name = tc_name;
            this.platform = platform;
            this.enviroment = enviroment;
        }

        [SetUp]
        public void Initialize()
        {
            // Start by setting the capabilities
            var caps = new RemoteSessionSettings();
            caps.AddMetadataSetting("record_video", "true");
            var buildname = TestContext.Parameters.Get("buildname", "DefaultValue");
            caps.AddMetadataSetting("build", buildname);
            switch (tc_name)
            {
                case "TC_Help_Links":
                    caps.AddMetadataSetting("name", "TC_Help_Links");
                    break;
                case "SignUp":
                    caps.AddMetadataSetting("name", "SignUp");
                    break;
                case "BPMSoftwareCapterraNew":
                    caps.AddMetadataSetting("name", "BPMSoftwareCapterraNew");
                    break;
                case "OnlineFormBuilderSoftwareCapterra":
                    caps.AddMetadataSetting("name", "OnlineFormBuilderSoftwareCapterra");
                    break;
                case "PF_APPROVAL_SOFTWARE":
                    caps.AddMetadataSetting("name", "PF_APPROVAL_SOFTWARE");
                    break;
                case "ONLINE_FORM_BUILDER":
                    caps.AddMetadataSetting("name", "ONLINE_FORM_BUILDER");
                    break;
                case "Workflow_Forms_Legacy":
                    caps.AddMetadataSetting("name", "Workflow_Forms_Legacy");
                    break;
                case "Workflow_Forms":
                    caps.AddMetadataSetting("name", "Workflow_Forms");
                    break;
                case "BuildingSoftwareB1":
                    caps.AddMetadataSetting("name", "BuildingSoftwareB1");
                    break;
                case "CRM_LeadManagement_Old":
                    caps.AddMetadataSetting("name", "CRM_LeadManagement_Old");
                    break;
                case "PF_FORM_GENERATOR":
                    caps.AddMetadataSetting("name", "PF_FORM_GENERATOR");
                    break;
                case "WorkflowFormsCapterraNew":
                    caps.AddMetadataSetting("name", "WorkflowFormsCapterraNew");
                    break;
                case "SaveAsNewVersion":
                    caps.AddMetadataSetting("name", "SaveAsNewVersion");
                    break;
                case "Template_test":
                    caps.AddMetadataSetting("name", "Template_test");
                    break;

                case "TC_Beh_Connect_GOOGLE_Insert":
                    caps.AddMetadataSetting("name", "TC_Beh_Connect_GOOGLE_Insert");
                    break;
                case "TC_Beh_Connect_GOOGLE_Select":
                    caps.AddMetadataSetting("name", "TC_Beh_Connect_GOOGLE_Select");
                    break;
                case "TC_Beh_Connect_GOOGLE_Update":
                    caps.AddMetadataSetting("name", "TC_Beh_Connect_GOOGLE_Update");
                    break;
                case "TC_Beh_Connect_GOOGLE_Delete":
                    caps.AddMetadataSetting("name", "TC_Beh_Connect_GOOGLE_Delete");
                    break;



                default:
                    caps.AddMetadataSetting("name", "TC_Sanity_Signup_LeadManagement");
                    break;

            }
            switch (platform)
            {
                case "Windows 10":
                    caps.AddMetadataSetting("platform", "Windows 10");
                    break;
                case "Windows 8.1":
                    caps.AddMetadataSetting("platform", "Windows 8.1");
                    break;
                case "Windows 7 64-Bit":
                    caps.AddMetadataSetting("platform", "Windows 7 64-Bit");
                    break;
                case "Mac OSX 10.12":
                    caps.AddMetadataSetting("platform", "Mac OSX 10.12");
                    break;
                case "Mac OSX 10.11":
                    caps.AddMetadataSetting("platform", "Mac OSX 10.11");
                    break;
                case "Mac OSX 10.10":
                    caps.AddMetadataSetting("platform", "Mac OSX 10.10");
                    break;
                case "Mac OSX 10.9":
                    caps.AddMetadataSetting("platform", "Mac OSX 10.9");
                    break;
                case "Mac OSX 10.13":
                    caps.AddMetadataSetting("platform", "Mac OSX 10.13");
                    break;
            }
            switch (browser)
            {
                case "chrome":
                    caps.AddMetadataSetting("browserName", "Chrome");
                    //Comment for mobiles
                    //caps.AddMetadataSetting("version", "56x64");
                    break;
                case "firefox":
                    caps.AddMetadataSetting("browserName", "Firefox");
                    //Comment for mobiles
                    //caps.AddMetadataSetting("version", "45");
                    break;
                case "edge":
                    caps.AddMetadataSetting("browserName", "MicrosoftEdge");
                    //Comment for mobiles
                    //caps.AddMetadataSetting("version", "14");
                    break;
                case "safari":
                    caps.AddMetadataSetting("browserName", "Safari");
                    //caps.AddMetadataSetting("version", "11");
                    break;
                case "ie11":
                    caps.AddMetadataSetting("browserName", "Internet Explorer");
                    caps.AddMetadataSetting("version", "11");
                    break;
                case "ie10":
                    caps.AddMetadataSetting("browserName", "Internet Explorer");
                    caps.AddMetadataSetting("version", "10");
                    break;
                case "ie9":
                    caps.AddMetadataSetting("browserName", "Internet Explorer");
                    caps.AddMetadataSetting("version", "9");
                    break;
                default:
                    //Comment for mobiles
                    //caps.AddMetadataSetting("browserName", "Internet Explorer");
                    //caps.AddMetadataSetting("version", "11");
                    break;
            }
            caps.AddMetadataSetting("username", username);
            caps.AddMetadataSetting("password", authkey);
            switch (enviroment)
            {
                case "cbt":
                    driver = new RemoteWebDriver(new Uri("http://hub.crossbrowsertesting.com:80/wd/hub/"), caps);
                    break;
                case "local_chrome":
                    driver = new ChromeDriver("C:\\chromedriver_win33");
                    break;
                case "local_firefox":
                    driver = new FirefoxDriver("C:\\geckodriver");
                    break;
                case "local_edge":
                    var options = new EdgeOptions();
                    options.UseChromium = true;
                    driver = new EdgeDriver(@"C:\edgedriver_win64", options);
                    break;
                default:
                    driver = new ChromeDriver("C:\\chromedriver_win33");
                    break;
            }
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
        }

        public void setScore(string sessionId, string score)
        {
            string url = BaseURL + "/" + sessionId;
            // encode the data to be written
            ASCIIEncoding encoding = new ASCIIEncoding();
            string data = "action=set_score&score=" + score;
            byte[] putdata = encoding.GetBytes(data);
            // Create the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "PUT";
            request.Credentials = new NetworkCredential(username, authkey);
            request.ContentLength = putdata.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "HttpWebRequest";
            // Write data to stream
            Stream newStream = request.GetRequestStream();
            newStream.Write(putdata, 0, putdata.Length);
            WebResponse response = request.GetResponse();
            newStream.Close();
        }
        public string takeSnapshot(string sessionId)
        {
            // returns the screenshot hash to be used in the setDescription method.
            // create the POST request object pointed at the snapshot endpoint
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BaseURL + "/" + sessionId + "/snapshots");
            Console.WriteLine(BaseURL + "/" + sessionId);
            request.Method = "POST";
            request.Credentials = new NetworkCredential(username, authkey);
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "HttpWebRequest";
            // Execute the request
            var response = (HttpWebResponse)request.GetResponse();
            // store the response
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            // parse out the snapshot Hash value 
            var myregex = new Regex("(?<=\"hash\": \")((\\w|\\d)*)");
            var snapshotHash = myregex.Match(responseString).Value;
            Console.WriteLine(snapshotHash);
            return snapshotHash;
        }

        public void setDescription(string sessionId, string snapshotHash, string description)
        {
            // encode the data to be written
            ASCIIEncoding encoding = new ASCIIEncoding();
            var putData = encoding.GetBytes("description=" + description);
            // create the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BaseURL + "/" + sessionId + "/snapshots/" + snapshotHash);
            request.Method = "PUT";
            request.Credentials = new NetworkCredential(username, authkey);
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "HttpWebRequest";
            // write data to stream
            Stream newStream = request.GetRequestStream();
            newStream.Write(putData, 0, putData.Length);
            newStream.Close();
            WebResponse response = request.GetResponse();
        }
        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        public string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
        //Here each run we need to change the email based on the name of the test set we have to run
        public static class SequentialNumber
        {
            private static int _currentNumber = 0;
            public static string GetNextNumber()
            {
                _currentNumber++;
                return _currentNumber.ToString() + "6.1.3.0_Hotfix6a2@blackesign.com";
            }
        }
    }
}

