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
    [TestFixture("chrome", "REST_PROD_AccuWheather", "Windows 10", "local_chrome")]
    //[TestFixture("firefox", "REST_PROD_AccuWheather", "Windows 10", "local_firefox")]
    ///[TestFixture("edge", "REST_PROD_AccuWheather", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "REST_PROD_AccuWheather", "MacOS 11.0", "cbt")]

    public class REST_PROD_AccuWheather_Test : CBTAPI
    {
        public REST_PROD_AccuWheather_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void REST_PROD_AccuWheather()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:
                Console.WriteLine("Open TestCase @REST_PROD_AccuWheather");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                //driver.Navigate().GoToUrl(test_environment + "player.htm?f=v7WGggYo");
                driver.Navigate().GoToUrl("https://app.perfectforms.com/player.htm?f=v7WGggYo");

                //Console.WriteLine(test_environment + "player.htm?f=v7WGggYo");

                Console.WriteLine("Verifiy Locatio is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Locatio not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_10"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_10")).Click();
                driver.FindElement(By.Id("PF_10")).SendKeys("Romania");

                Console.WriteLine("Click Search");

                driver.FindElement(By.Id("PF_11")).Click();

                Thread.Sleep(6000);

                Console.WriteLine("Verifiy Region is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Region not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("1-PF_15"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Verifiy Region is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Region not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("2-PF_15"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click CurrentConditions");

                driver.FindElement(By.Id("1-PF_18")).Click();

                Thread.Sleep(5000);

                Console.WriteLine("Verifiy Wheather is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Wheather not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("PF_19"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Verifiy Temperature: is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Temperature: not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("PF_20"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click CurrentConditions");

                driver.FindElement(By.Id("2-PF_18")).Click();

                Thread.Sleep(5000);

                Console.WriteLine("Verifiy Wheather is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Wheather not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("PF_19"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Verifiy Temperature: is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Temperature: not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("PF_20"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
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