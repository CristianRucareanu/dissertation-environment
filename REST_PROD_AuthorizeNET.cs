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


namespace CBT_NUnit
{
    [TestFixture("chrome", "REST_PROD_AuthorizeNET", "Windows 10", "local_chrome")]
    //[TestFixture("firefox", "REST_PROD_AuthorizeNET", "Windows 10", "local_firefox")]
    //[TestFixture("edge", "REST_PROD_AuthorizeNET", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "REST_PROD_AuthorizeNET", "MacOS 11.0", "cbt")]

    public class REST_PROD_AuthorizeNET_Test : CBTAPI
    {
        public REST_PROD_AuthorizeNET_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void REST_PROD_AuthorizeNET()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:
                Console.WriteLine("Open TestCase @REST_PROD_Authorize.NET");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                //driver.Navigate().GoToUrl(test_environment + "player.htm?f=S7WmgAEp");
                driver.Navigate().GoToUrl("https://app.perfectforms.com/player.htm?f=S7WmgAEp");

                //Console.WriteLine(test_environment + "player.htm?f=S7WmgAEp");

                Console.WriteLine("Verifiy Verify Credentials is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Verify Credentials not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_25"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Verify Credentials");

                driver.FindElement(By.Id("PF_25")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy resultCode = Ok");

                {
                    string value = driver.FindElement(By.Id("PF_26")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Ok"));
                }

                Console.WriteLine("Verifiy Text = Successful");

                {
                    string value = driver.FindElement(By.Id("PF_5")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Successful."));
                }

                Console.WriteLine("Click Create Profile");

                driver.FindElement(By.Id("PF_15")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy resultCode = Ok");

                {
                    string value = driver.FindElement(By.Id("PF_23")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Ok"));
                }

                Console.WriteLine("Verifiy Text = Successful");

                {
                    string value = driver.FindElement(By.Id("PF_24")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Successful."));
                }

                Console.WriteLine("Click Delete Profile");

                driver.FindElement(By.Id("PF_11")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy resultCode = Ok");

                {
                    string value = driver.FindElement(By.Id("PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Ok"));
                }

                Console.WriteLine("Verifiy Text = Successful");

                {
                    string value = driver.FindElement(By.Id("PF_14")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Successful."));
                }

                Console.WriteLine("Click Next Page");

                driver.FindElement(By.Id("PF_40")).Click();


                Console.WriteLine("Verifiy Submit is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Submit not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_88"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Generate ref ID / Transaction ID");

                driver.FindElement(By.Id("PF_76")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Click Charge Credit Card");

                driver.FindElement(By.Id("PF_77")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Text = Successful");

                {
                    string value = driver.FindElement(By.Id("PF_82")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Successful."));
                }

                Console.WriteLine("Click Submit");

                driver.FindElement(By.Id("PF_88")).Click();

                //Setting the result in CBT portal:
                Console.WriteLine("Test Finished Setting Score");
                if (enviroment == "cbt")
                {
                    setScore(driver.SessionId.ToString(), "pass");
                }
                driver.Quit();
            }
            catch (AssertionException ex)
            {

                var snapshotHash = takeSnapshot(driver.SessionId.ToString());
                setDescription(driver.SessionId.ToString(), snapshotHash, ex.ToString());
                setScore(driver.SessionId.ToString(), "fail");
                Console.WriteLine("caught the exception : " + ex);
                driver.Quit();
                throw new AssertionException(ex.ToString());
            }
            catch (Exception ex)
            {
                var snapshotHash = takeSnapshot(driver.SessionId.ToString());
                setDescription(driver.SessionId.ToString(), snapshotHash, ex.ToString());
                setScore(driver.SessionId.ToString(), "fail");
                Console.WriteLine("caught the exception : " + ex);
                driver.Quit();
                throw new Exception(ex.ToString());
            }
        }
    }
}
