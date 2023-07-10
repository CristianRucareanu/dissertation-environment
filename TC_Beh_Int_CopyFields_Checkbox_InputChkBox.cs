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
    [TestFixture("chrome", "TC_Beh_Int_CopyFields_Checkbox_InputChkBox", "Windows 10", "local_chrome")]
    [TestFixture("firefox", "TC_Beh_Int_CopyFields_Checkbox_InputChkBox", "Windows 10", "local_firefox")]
    [TestFixture("edge", "TC_Beh_Int_CopyFields_Checkbox_InputChkBox", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "TC_Beh_Int_Funct_Template", "MacOS 11.0", "cbt")]

    public class TC_Beh_Int_CopyFields_Checkbox_InputChkBox_Test : CBTAPI
    {
        public TC_Beh_Int_CopyFields_Checkbox_InputChkBox_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void TC_Beh_Int_CopyFields_Checkbox_InputChkBox()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:
                Console.WriteLine("Open TestCase TC_Beh_Int_CopyFields_Checkbox_InputChkBox");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                //driver.Navigate().GoToUrl(test_environment + "player.htm?f=oe2AgAwH");
                driver.Navigate().GoToUrl("https://testing.perfectforms.com/player.htm?f=oe2AgAwH");

                Console.WriteLine(test_environment + "player.htm?f=oe2AgAwH");

                Console.WriteLine("Verifiy Run is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Run not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_19"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Run");

                driver.FindElement(By.Id("PF_19")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Check = Check");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_20")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Check"));
                }

                Console.WriteLine("Verifiy Check = Check");

                {
                    string value = driver.FindElement(By.Id("PF_22")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Check"));
                }

                Console.WriteLine("Verifiy Checkbox True = Checbox True");

                {
                    string value = driver.FindElement(By.Id("PF_21")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Checbox True"));
                }

                Console.WriteLine("Verifiy Checkbox False = Checbox False");

                {
                    string value = driver.FindElement(By.Id("PF_23")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Checbox False"));
                }

                Console.WriteLine("Click Next Page");

                driver.FindElement(By.Id("PF_17")).Click();


                Console.WriteLine("Verifiy Submit is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Submit not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_27"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Verifiy Checkbox True = Checbox True");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_24")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Checbox True"));
                }

                Console.WriteLine("Verifiy Checkbox False = Checbox False");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_25")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Checbox False"));
                }

                Console.WriteLine("Click Submit");

                driver.FindElement(By.Id("PF_27")).Click();


                Console.WriteLine("Verifiy Run is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Run not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_19"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Verifiy Check = Check");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_20")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Check"));
                }

                Console.WriteLine("Verifiy Check = Check");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_22")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Check"));
                }

                Console.WriteLine("Verifiy Checkbox True = Checbox True");

                {
                    string value = driver.FindElement(By.Id("PF_21")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Checbox True"));
                }

                Console.WriteLine("Verifiy Checkbox False = Checbox False");

                {
                    string value = driver.FindElement(By.Id("PF_23")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Checbox False"));
                }

                Console.WriteLine("Click Next Page");

                driver.FindElement(By.Id("PF_17")).Click();


                Console.WriteLine("Verifiy Submit is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Submit not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_27"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Verifiy Checkbox True = Checbox True");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_24")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Checbox True"));
                }

                Console.WriteLine("Verifiy Checkbox False = Checbox False");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_25")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("Checbox False"));
                }

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
