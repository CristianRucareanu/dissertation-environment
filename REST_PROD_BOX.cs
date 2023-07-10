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
    [TestFixture("chrome", "REST_PROD_BOX", "Windows 10", "local_chrome")]
    //[TestFixture("firefox", "REST_PROD_BOX", "Windows 10", "local_firefox")]
    //[TestFixture("edge", "REST_PROD_BOX", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "REST_PROD_BOX", "MacOS 11.0", "cbt")]

    public class REST_PROD_BOX_Test : CBTAPI
    {
        public REST_PROD_BOX_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void REST_PROD_BOX()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:
                Console.WriteLine("Open TestCase @REST_PROD_BOX");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                //driver.Navigate().GoToUrl(test_environment + "player.htm?f=0b2GAgsJ");
                driver.Navigate().GoToUrl("https://app.perfectforms.com/player.htm?f=0b2GAgsJ");

                //Console.WriteLine(test_environment + "player.htm?f=0b2GAgsJ");

                Console.WriteLine("Verifiy Get Code is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Get Code not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_21"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Get Code");

                driver.FindElement(By.Id("PF_19")).Click();

                Thread.Sleep(2000);

                driver.FindElement(By.Id("login")).Click();
                driver.FindElement(By.Id("login")).SendKeys("r2d2@perfectforms.ro");

                driver.FindElement(By.Name("password")).Click();
                driver.FindElement(By.Name("password")).SendKeys("Qplates99");

                Console.WriteLine("Click Authorize");

                driver.FindElement(By.Name("login_submit")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Click Grant Access to Box");

                driver.FindElement(By.CssSelector(".submit")).Click();

                Console.WriteLine("Verifiy Get Acces Token is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Get Acces Token not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_20"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Verifiy Code: is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Code: not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("PF_2"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Get Acces Token");

                driver.FindElement(By.Id("PF_18")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Access Code: is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Access Code: not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("PF_17"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Create Account");

                driver.FindElement(By.Id("PF_20")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Verifiy ID: is not empty"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("ID: not filled"); try
                    {
                        IWebElement myInput = driver.FindElement(By.Id("1-PF_22"));
                        if (!myInput.GetAttribute("value").Equals("")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Delete Account");

                driver.FindElement(By.Id("PF_26")).Click();

                Thread.Sleep(2000);

                Console.WriteLine("Click Submit");

                driver.FindElement(By.Id("PF_4")).Click();

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
