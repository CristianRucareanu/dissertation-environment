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
    [TestFixture("chrome", "TC_Beh_Int_Date_IsEmpty_MB", "Windows 10", "local_chrome")]
    //[TestFixture("firefox", "TC_Beh_Int_Date_IsEmpty_MB", "Windows 10", "local_firefox")]
    //[TestFixture("edge", "TC_Beh_Int_Date_IsEmpty_MB", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_TxtInp_NotEqual_MB", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_TxtInp_NotEqual_MB", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_TxtInp_NotEqual_MB", "Windows 7 64-Bit")]
    //[TestFixture("safari", "TC_Beh_Int_TxtInp_NotEqual_MB", "MacOS 11.0", "cbt")]

    public class TC_Beh_Int_Date_IsEmpty_MB_Test : CBTAPI
    {
        public TC_Beh_Int_Date_IsEmpty_MB_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void TC_Beh_Int_Date_IsEmpty_MB()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:

                Console.WriteLine("Open TestCase TC_Beh_Int_Date_IsEmpty_MB");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                //driver.Navigate().GoToUrl(test_environment + "player.htm?f=n7XAggEn");
                driver.Navigate().GoToUrl("https://testing.perfectforms.com/player.htm?f=n7XAggEn");

                Console.WriteLine(test_environment + "player.htm?f=n7XAggEn");

                Console.WriteLine("Verifiy Run is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Run not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_36"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_36")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date e = 1");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_7")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }

                Console.WriteLine("Verifiy MM/DD/YY = 2");

                {
                    string value = driver.FindElement(By.Id("PF_11")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }

                Console.WriteLine("Verifiy DD/MM/YY = 3");

                {
                    string value = driver.FindElement(By.Id("PF_10")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy MM.DD.YY = 4");

                {
                    string value = driver.FindElement(By.Id("PF_9")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4"));
                }

                Console.WriteLine("Verifiy DD.MM.YY = 5");

                {
                    string value = driver.FindElement(By.Id("PF_8")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5"));
                }

                Console.WriteLine("Click Date e");

                driver.FindElement(By.Id("PF_1")).Click();

                Console.WriteLine("Click MM/DD/YY");

                driver.FindElement(By.Id("PF_12")).Click();

                Console.WriteLine("Click DD/MM/YY");

                driver.FindElement(By.Id("PF_14")).Click();

                Console.WriteLine("Click MM.DD.YY");

                driver.FindElement(By.Id("PF_15")).Click();

                Console.WriteLine("Click DD.MM.YY");

                driver.FindElement(By.Id("PF_13")).Click();

                Console.WriteLine("Click Next Page");

                driver.FindElement(By.Id("PF_38")).Click();

                Console.WriteLine("Verifiy Run is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Run not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_50"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_50")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date e = 1");

                {
                    string value = driver.FindElement(By.Id("PF_19")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy MM/DD/YY = 2");

                {
                    string value = driver.FindElement(By.Id("PF_17")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }

                Console.WriteLine("Verifiy DD/MM/YY = 3");

                {
                    string value = driver.FindElement(By.Id("PF_20")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy MM.DD.YY = 4");

                {
                    string value = driver.FindElement(By.Id("PF_18")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4"));
                }

                Console.WriteLine("Verifiy DD.MM.YY = 5");

                {
                    string value = driver.FindElement(By.Id("PF_21")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5"));
                }

                Console.WriteLine("Click Date e");

                driver.FindElement(By.Id("PF_22")).Click();

                Console.WriteLine("Click MM/DD/YY");

                driver.FindElement(By.Id("PF_16")).Click();

                Console.WriteLine("Click DD/MM/YY");

                driver.FindElement(By.Id("PF_23")).Click();

                Console.WriteLine("Click MM.DD.YY");

                driver.FindElement(By.Id("PF_24")).Click();

                Console.WriteLine("Click DD.MM.YY");

                driver.FindElement(By.Id("PF_25")).Click();

                Console.WriteLine("Click Prev Page");

                driver.FindElement(By.Id("PF_49")).Click();

                Console.WriteLine("Verifiy Sumbit is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Submit not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_37"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_37")).Click();

                Console.WriteLine("Verifiy Date e = 1");

                Thread.Sleep(2000);

                {
                    string value = driver.FindElement(By.Id("PF_7")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }

                Console.WriteLine("Verifiy MM/DD/YY = 2");

                {
                    string value = driver.FindElement(By.Id("PF_11")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }

                Console.WriteLine("Verifiy DD/MM/YY = 3");

                {
                    string value = driver.FindElement(By.Id("PF_10")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy MM.DD.YY = 4");

                {
                    string value = driver.FindElement(By.Id("PF_9")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4"));
                }

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy DD.MM.YY = 5");

                {
                    string value = driver.FindElement(By.Id("PF_8")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5"));
                }

                Thread.Sleep(2000);

                Console.WriteLine("Click Date e");

                driver.FindElement(By.Id("PF_1")).Click();

                Console.WriteLine("Click MM/DD/YY");

                driver.FindElement(By.Id("PF_12")).Click();

                Console.WriteLine("Click DD/MM/YY");

                driver.FindElement(By.Id("PF_14")).Click();

                Console.WriteLine("Click MM.DD.YY");

                driver.FindElement(By.Id("PF_15")).Click();

                Console.WriteLine("Click DD.MM.YY");

                driver.FindElement(By.Id("PF_13")).Click();

                Console.WriteLine("Click Next Page");

                driver.FindElement(By.Id("PF_38")).Click();

                Console.WriteLine("Verifiy Date e is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Date e not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_19"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                {
                    string value = driver.FindElement(By.Id("PF_19")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }

                Console.WriteLine("Verifiy MM/DD/YY = 2");

                {
                    string value = driver.FindElement(By.Id("PF_17")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }

                Console.WriteLine("Verifiy DD/MM/YY = 3");

                {
                    string value = driver.FindElement(By.Id("PF_20")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy MM.DD.YY = 4");

                {
                    string value = driver.FindElement(By.Id("PF_18")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4"));
                }

                Console.WriteLine("Verifiy DD.MM.YY = 5");

                {
                    string value = driver.FindElement(By.Id("PF_21")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5"));
                }

                Console.WriteLine("Click Date e");

                driver.FindElement(By.Id("PF_22")).Click();

                Console.WriteLine("Click MM/DD/YY");

                driver.FindElement(By.Id("PF_16")).Click();

                Console.WriteLine("Click DD/MM/YY");

                driver.FindElement(By.Id("PF_23")).Click();

                Console.WriteLine("Click MM.DD.YY");

                driver.FindElement(By.Id("PF_24")).Click();

                Console.WriteLine("Click DD.MM.YY");

                driver.FindElement(By.Id("PF_25")).Click();

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
