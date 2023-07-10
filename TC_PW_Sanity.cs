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
    [TestFixture("chrome", "TC_PW_Sanity_Ticket", "Windows 10", "local_chrome")]
    //[TestFixture("firefox", "TC_PW_Sanity_Ticket", "Windows 10", "local_firefox")]
    //[TestFixture("edge", "TC_PW_Sanity_Ticket", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "TC_PW_Sanity_Ticket", "MacOS 11.0", "cbt")]

    public class TC_PW_Sanity_Test : CBTAPI
    {
        public TC_PW_Sanity_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void TC_PW_Sanity()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:
                Console.WriteLine("Open TestCase TC_PW_Sanity");

                driver.Manage().Window.Maximize();
                //var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                driver.Navigate().GoToUrl("https://www.perfectapps.com/");

                string signup_email;
                signup_email = SequentialNumber.GetNextNumber();

                Console.WriteLine("Verifiy Build web apps & automate worflows is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Build web apps & automate worflows not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                Console.WriteLine("Verifiy if heading is equal Build web apps & automate worflows"); for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Heading is not equal Build web apps & automate worflows"); try
                    {
                        IWebElement myInput = driver.FindElement(By.XPath("//div[@class='elementor-element elementor-element-a3f7e3d elementor-widget-mobile__width-initial mobtitle elementor-widget elementor-widget-heading']//div[@class='elementor-widget-container']//h1[@class='elementor-heading-title elementor-size-xxl'][contains(text(),'Build web apps & automate workflows')]"));
                        if (!myInput.GetAttribute("textContent").Equals("Build web apps & automate worflows")) { break; }
                    }
                    catch (Exception) { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Verifiy Heading = Transform Ideas Into Solutions");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[8]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Transform Ideas Into Solutions"));
                }

                Console.WriteLine("Verifiy Heading = Ready to Get Started?");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[17]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Ready to Get Started?"));
                }

                Console.WriteLine("Click Try it Free");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/span[1]/span[1]")).Click();

                Assert.AreEqual(true, IsElementPresent(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[1]")));
                Console.WriteLine("Enter First Name");
                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[1]")).Clear();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[1]")).SendKeys("Bogdan");

                Assert.AreEqual(true, IsElementPresent(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[2]")));
                Console.WriteLine("Enter Last Name");
                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[2]")).Clear();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[2]")).SendKeys("Calin");

                Assert.AreEqual(true, IsElementPresent(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[3]")));
                Console.WriteLine("Enter Email");
                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[3]")).Clear();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[3]")).SendKeys(signup_email);

                Assert.AreEqual(true, IsElementPresent(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[4]")));
                Console.WriteLine("Enter Password");
                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[4]")).Clear();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/div[1]/input[4]")).SendKeys("Hr1st0s@inv1@t");

                Console.WriteLine("Click Try it Free");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[3]/div[1]/form[1]/div[1]/input[1]")).Click();

                Thread.Sleep(10000);

                Console.WriteLine("Click Login");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]/span[1]/span[1]")).Click();

                Thread.Sleep(10000);

                Assert.AreEqual(true, IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/input[1]")));
                Console.WriteLine("Enter Email");
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/input[1]")).Clear();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/input[1]")).SendKeys(signup_email);

                Assert.AreEqual(true, IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/input[1]")));
                Console.WriteLine("Enter Password");
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/input[1]")).Clear();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/input[1]")).SendKeys("Hr1st0s@inv1@t");

                Console.WriteLine("Click Login");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/form[1]/div[6]/div[1]/div[1]/button[1]/span[1]")).Click();

                Thread.Sleep(2500);

                driver.Navigate().GoToUrl("https://www.perfectapps.com/");

                Thread.Sleep(2500);

                //driver.FindElement(By.CssSelector(".pp-modal-popup-link-d8d0171 > span")).Click();
                //driver.SwitchTo().Frame(4);
                //driver.FindElement(By.CssSelector(".QECEkKf3_N2EWMUmONto")).Click();
                //driver.FindElement(By.CssSelector("tr:nth-child(2) > td:nth-child(1) > .Iji9Uvqm6IyoZcOtebAT > span")).Click();
                //driver.FindElement(By.CssSelector(".VXLYg9DOnab9MiwAMg_6:nth-child(1) > .g5ly_JZq5ecQ4uPUKZEi")).Click();
                //driver.FindElement(By.CssSelector(".QEEHVyHRa6B4YIw_pMR_")).Click();
                //driver.FindElement(By.Id("fTy50aBWL_5zIdh3Qre2w")).Click();
                //driver.FindElement(By.Id("fTy50aBWL_5zIdh3Qre2w")).SendKeys("Bogdan");
                //driver.FindElement(By.Id("s1v8wVBqGGCOGIbxUQyGL")).Click();
                //driver.FindElement(By.Id("s1v8wVBqGGCOGIbxUQyGL")).SendKeys("Calin");
                //driver.FindElement(By.Id("email_input")).Click();
                //driver.FindElement(By.Id("email_input")).SendKeys(signup_email);
                //driver.FindElement(By.CssSelector(".\\_6n0CRU_Q9ef6f3sgBGZ")).Click();
                //driver.SwitchTo().DefaultContent();
                //driver.SwitchTo().Frame(5);
                //driver.SwitchTo().DefaultContent();
                //driver.FindElement(By.CssSelector(".mfp-close")).Click();

                Console.WriteLine("Click No-Code Platform");

                Thread.Sleep(5000);

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[1]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[1]/a[1]")).Click();

                Console.WriteLine("Verifiy Deliver Fast and Flexible Solutions - Without Coding is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Deliver Fast and Flexible Solutions  - Without Coding not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Deliver Fast and Flexible Solutions - Without Coding"); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Deliver Fast and Flexible Solutions - Without Coding"); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template-default page page-id-14 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-14 elementor-page-19612 e--ua-firefox gdpr-infobar-visible']/div[@id='page']/div[@class='elementor elementor-14']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-63a1568 topheader elementor-hidden-mobile elementor-section-full_width elementor-hidden-tablet elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-1e7393c']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-b887827 elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Deliver Fast and Flexible Solutions - Without Coding")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = No-Code Platform Features");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[5]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("No-Code Platform Features"));
                }

                Console.WriteLine("Verifiy Heading = Ready to Get Started?");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[11]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Ready to Get Started?"));
                }

                Console.WriteLine("Click Integrations");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[1]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[1]/ul[1]/li[2]/a[1]")).Click();

                Console.WriteLine("Verifiy Integrate PerfectApps' Solutions With Your Favorite Apps - Without Coding. is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Integrate PerfectApps' Solutions With Your Favorite Apps - Without Coding. not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Integrate PerfectApps' Solutions With Your Favorite Apps - Without Coding."); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Integrate PerfectApps' Solutions With Your Favorite Apps - Without Coding."); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template-default page page-id-18964 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-18964 elementor-page-19612 e--ua-firefox gdpr-infobar-visible']/div[@id='page']/div[@class='elementor elementor-18964']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-1d574475 topheader elementor-section-full_width elementor-hidden-mobile elementor-hidden-tablet elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-647edcb3']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-7dfc5cc elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Integrate PerfectApps' Solutions With Your Favorite Apps - Without Coding.")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                //Console.WriteLine("Verifiy Heading = Explore Our Powerful Third - Party Integrations");

                //{
                //    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[4]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                //    Assert.That(value, Is.EqualTo("Explore Our Powerful Third - Party Integrations"));
                //}

                Console.WriteLine("Click Security");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[1]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[1]/ul[1]/li[3]/a[1]")).Click();

                Console.WriteLine("Verifiy Keep Your Critical Apps Secure, Available & Compliant - With PerfectApps is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Keep Your Critical Apps Secure, Available & Compliant - With PerfectApps not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Verifiy Keep Your Critical Apps Secure, Available & Compliant - With PerfectApps"); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Verifiy Keep Your Critical Apps Secure, Available & Compliant - With PerfectApps"); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template page-template-elementor_header_footer page page-id-267 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-267 elementor-page-19612 e--ua-firefox gdpr-infobar-visible']/div[@id='page']/div[@class='elementor elementor-267']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-49a9b971 topheader elementor-section-full_width elementor-hidden-mobile elementor-hidden-tablet elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-6b42b23e']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-2202a0f9 elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Verifiy Keep Your Critical Apps Secure, Available & Compliant - With PerfectApps")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = No-Code Platform Security Features");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[6]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h3[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("No-Code Platform Security Features"));
                }

                Console.WriteLine("Click Pricing");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[1]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[1]/ul[1]/li[4]/a[1]")).Click();

                Console.WriteLine("Platform Plans & Pricing is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Platform Plans & Pricing not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Platform Plans & Pricing"); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Platform Plans & Pricing"); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//h1[contains(text(),'Platform Plans & Pricing')]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Platform Plans & Pricing")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = Ready to Get Started?");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[6]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Ready to Get Started?"));
                }

                Console.WriteLine("Click Applications");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/a[1]")).Click();

                Console.WriteLine("Create Web Apps, Workflow Apps, Web Forms & Reports - Without Coding. is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Create Web Apps, Workflow Apps, Web Forms & Reports - Without Coding. not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Create Web Apps, Workflow Apps, Web Forms & Reports - Without Coding."); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Create Web Apps, Workflow Apps, Web Forms & Reports - Without Coding."); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//h1[contains(text(),'Create Web Apps, Workflow Apps, Web Forms & Report')]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Create Web Apps, Workflow Apps, Web Forms & Reports - Without Coding.")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = No-Code Apps & Reports to Power Your Team");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[5]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("No-Code Apps & Reports to Power Your Team"));
                }

                Console.WriteLine("Click Web Apps");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/ul[1]/li[2]/a[1]")).Click();

                Console.WriteLine("The Faster, Easier Way to Build Web Apps - No Code Required. is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("The Faster, Easier Way to Build Web Apps - No Code Required. not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal The Faster, Easier Way to Build Web Apps - No Code Required."); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal The Faster, Easier Way to Build Web Apps - No Code Required."); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template-default page page-id-131 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-131 elementor-page-19612 e--ua-firefox gdpr-infobar-visible']/div[@id='page']/div[@class='elementor elementor-131']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-4e0c7764 topheader elementor-section-full_width elementor-hidden-mobile elementor-hidden-tablet elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-9a2b654']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-2c78a4d6 elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("The Faster, Easier Way to Build Web Apps - No Code Required.")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = Take Advantage of Our Dynamic No-Code\r\nWeb App Builder Features");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[7]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Take Advantage of Our Dynamic No-Code\r\nWeb App Builder Features"));
                }

                Console.WriteLine("Click Workflow Apps");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/ul[1]/li[3]/a[1]")).Click();

                Console.WriteLine("Build Dynamic, Custom Workflow Apps - Without Coding is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Build Dynamic, Custom Workflow Apps - Without Coding not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Build Dynamic, Custom Workflow Apps - Without Coding"); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Build Dynamic, Custom Workflow Apps - Without Coding"); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template-default page page-id-133 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-133 elementor-page-19612 e--ua-firefox gdpr-infobar-visible']/div[@id='page']/div[@class='elementor elementor-133']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-3be3e212 topheader elementor-section-full_width elementor-hidden-mobile elementor-hidden-tablet elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-458454bb']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-4531df66 elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Build Dynamic, Custom Workflow Apps - Without Coding")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = Ready to See PerfectApps in Action?");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[7]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Ready to See PerfectApps in Action?"));
                }

                Console.WriteLine("Click Web Forms");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/ul[1]/li[4]/a[1]")).Click();

                Console.WriteLine("Create Custom Web Forms - No Coding Required. is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Create Custom Web Forms - No Coding Required. not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Create Custom Web Forms - No Coding Required."); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Create Custom Web Forms - No Coding Required."); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template-default page page-id-135 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-135 elementor-page-19612 e--ua-firefox']/div[@id='page']/div[@class='elementor elementor-135']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-7e75984f topheader elementor-hidden-mobile elementor-section-full_width elementor-hidden-tablet elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-5d192a41']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-3a0fbe25 elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Create Custom Web Forms - No Coding Required.")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = Integrations");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[8]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Integrations"));
                }

                Console.WriteLine("Click Case Studies");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/ul[1]/li[5]/a[1]")).Click();

                Console.WriteLine("Case Studies is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Case Studies not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Case Studies"); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Case Studies"); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//div[@class='elementor-element elementor-element-41e54ee elementor-widget elementor-widget-heading']//div[@class='elementor-widget-container']//h1[@class='elementor-heading-title elementor-size-xxl'][contains(text(),'Case Studies')]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Case Studies")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Click How it Works");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[3]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[3]/a[1]")).Click();

                Console.WriteLine("Simplify Web App Development - With Zero Coding. is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Simplify Web App Development - With Zero Coding. not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Simplify Web App Development - With Zero Coding."); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Simplify Web App Development - With Zero Coding."); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template-default page page-id-18 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-18 elementor-page-19612 e--ua-firefox']/div[@id='page']/div[@class='elementor elementor-18']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-cfd6729 topheader elementor-hidden-mobile elementor-section-full_width elementor-hidden-tablet elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-82ef063']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-3d6d00e elementor-hidden-mobile elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Simplify Web App Development - With Zero Coding.")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = Integrations");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[5]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Integrations"));
                }

                Console.WriteLine("Click Resources");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[4]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[4]/a[1]")).Click();

                Console.WriteLine("Need Help With PerfectApps? We're Here For You. is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Need Help With PerfectApps? We're Here For You. not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Need Help With PerfectApps? We're Here For You."); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Need Help With PerfectApps? We're Here For You."); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template-default page page-id-20 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-20 elementor-page-19612 e--ua-firefox gdpr-infobar-visible']/div[@id='page']/div[@class='elementor elementor-20']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-7f303cb topheader elementor-hidden-mobile elementor-section-full_width elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-10acb0a9']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-36e982aa elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Need Help With PerfectApps? We're Here For You.")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = Help Center");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[6]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Help Center"));
                }

                Console.WriteLine("Click Accept");

                driver.FindElement(By.XPath("/html/body/aside/div/div/div[2]/button")).Click();

                //driver.SwitchTo().Frame(0);

                //driver.FindElement(By.Id("PF_126")).Click();
                //driver.FindElement(By.Id("PF_126")).SendKeys("Automation Test");

                //Thread.Sleep(1000);

                //driver.FindElement(By.Id("PF_24")).Click();
                //driver.FindElement(By.Id("PF_24")).SendKeys(signup_email);

                //Thread.Sleep(1000);

                //driver.FindElement(By.Id("PF_57")).Click();
                //driver.FindElement(By.Id("PF_57")).SendKeys("Automation");

                //Thread.Sleep(1000);

                //driver.FindElement(By.Id("PF_127")).Click();
                //{
                //    var dropdown = driver.FindElement(By.Id("PF_127"));
                //    dropdown.FindElement(By.XPath("//option[. = 'Other']")).Click();
                //}
                //driver.FindElement(By.CssSelector("#PF_127 > option:nth-child(10)")).Click();

                //Thread.Sleep(1000);

                //driver.FindElement(By.Id("PF_139")).Click();
                //driver.FindElement(By.Id("PF_139")).SendKeys("Automated Testing");

                //Thread.Sleep(1000);

                //driver.FindElement(By.Id("PF_208")).Click();
                //driver.FindElement(By.Id("PF_208")).SendKeys("...");

                //Thread.Sleep(1000);

                //Console.WriteLine("Click Attachments");

                //driver.FindElement(By.Id("PF_148")).Click();

                //Thread.Sleep(2000);

                //Console.WriteLine("Click Add New File");

                //driver.FindElement(By.Id("PF_250")).Click();

                //Thread.Sleep(2000);

                //Console.WriteLine("Click Attach");
                //Thread.Sleep(3000);
                //IWebElement uploadElement = driver.FindElement(By.Id("1-PF_246file"));
                //uploadElement.SendKeys("C:\\Windows\\WindowsUpdate.log");
                //Thread.Sleep(2000);

                //Console.WriteLine("Click Back");

                //driver.FindElement(By.Id("PF_252")).Click();

                //Thread.Sleep(2000);

                //Console.WriteLine("Click Submit");

                //driver.FindElement(By.Id("PF_142")).Click();

                //Console.WriteLine("Click Ok");

                //driver.FindElement(By.Id("/html/body/div[5]/div[3]/div/button")).Click();

                //driver.SwitchTo().Frame(0);

                //driver.Navigate().GoToUrl("https://www.perfectapps.com/");

                Thread.Sleep(5000);

                Console.WriteLine("Click Blog");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[4]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[4]/ul[1]/li[2]/a[1]")).Click();

                Console.WriteLine("Blog is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Blog not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Blog"); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Blog"); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//div[@class='elementor-element elementor-element-4cc627ab elementor-widget elementor-widget-heading']//div[@class='elementor-widget-container']//h1[@class='elementor-heading-title elementor-size-xxl'][contains(text(),'Blog')]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Blog")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = Have a Question About Our Services?");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[6]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Have a Question About Our Services?"));
                }

                Console.WriteLine("Click Proffesional Services");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[4]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[4]/ul[1]/li[3]/a[1]")).Click();

                Console.WriteLine("Need Training, Coaching or App Development? We're Here to Help. is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Need Training, Coaching or App Development? We're Here to Help. not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal Need Training, Coaching or App Development? We're Here to Help."); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal Need Training, Coaching or App Development? We're Here to Help."); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template page-template-elementor_header_footer page page-id-262 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-262 elementor-page-19612 e--ua-firefox gdpr-infobar-visible']/div[@id='page']/div[@class='elementor elementor-262']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-7b342db7 topheader elementor-section-full_width elementor-hidden-mobile elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-56f96362']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-371c045c elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("Need Training, Coaching or App Development? We're Here to Help.")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Click Company");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[5]/a[1]")).Click();
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[5]/a[1]")).Click();

                Console.WriteLine("The Perfect Solution For App Development - No Coding Required. is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("The Perfect Solution For App Development - No Coding Required. not found");
                    try
                    {
                        if (IsElementPresent(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/h1[1]"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(5000);
                }

                //Console.WriteLine("Verifiy if heading is equal The Perfect Solution For App Development - No Coding Required."); for (int second = 0; ; second++)
                //{
                //    if (second >= 10) Assert.Fail("Heading is not equal The Perfect Solution For App Development - No Coding Required."); try
                //    {
                //        IWebElement myInput = driver.FindElement(By.XPath("//body[@class='page-template-default page page-id-194 wp-custom-logo ehf-header ehf-footer ehf-template-hello-elementor ehf-stylesheet-hello-elementor elementor-default elementor-template-full-width elementor-kit-15003 elementor-page elementor-page-194 elementor-page-19612 e--ua-firefox gdpr-infobar-visible']/div[@id='page']/div[@class='elementor elementor-194']/div[@class='elementor-inner']/div[@class='elementor-section-wrap']/section[@class='elementor-section elementor-top-section elementor-element elementor-element-789a2db3 topheader elementor-section-full_width elementor-hidden-mobile elementor-hidden-tablet elementor-section-height-default elementor-section-height-default']/div[@class='elementor-container elementor-column-gap-default']/div[@class='elementor-row']/div[@class='elementor-column elementor-col-100 elementor-top-column elementor-element elementor-element-732f68a4']/div[@class='elementor-column-wrap elementor-element-populated']/div[@class='elementor-widget-wrap']/div[@class='elementor-element elementor-element-712c18fb elementor-widget elementor-widget-heading']/div[@class='elementor-widget-container']/h1[1]"));
                //        if (!myInput.GetAttribute("textContent").Equals("The Perfect Solution For App Development - No Coding Required.")) { break; }
                //    }
                //    catch (Exception) { }
                //    Thread.Sleep(1000);
                //}

                Console.WriteLine("Verifiy Heading = Democratizing Application Development");

                {
                    string value = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/section[5]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h2[1]")).GetAttribute("textContent");
                    Assert.That(value, Is.EqualTo("Democratizing Application Development"));
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
