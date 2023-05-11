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
using System.Linq;

namespace CBT_NUnit
{
    [TestFixture("chrome", "TC_Beh_Connect_GOOGLE_Select", "Windows 10", "local_chrome")]
    [TestFixture("firefox", "TC_Beh_Connect_GOOGLE_Select", "Windows 10", "local_firefox")]
    [TestFixture("edge", "TC_Beh_Connect_GOOGLE_Select", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "TC_Beh_Int_Funct_Template", "Mac OSX 12613")]

    public class TC_Beh_Connect_GOOGLE_Select_Test : CBTAPI
    {
        public TC_Beh_Connect_GOOGLE_Select_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void TC_Beh_Connect_GOOGLE_Select()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:

                Console.WriteLine("Open TestCase TC_Beh_Connect_GOOGLE_Select");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                driver.Navigate().GoToUrl(test_environment + "player.htm?f=FGghgAQB");
                //driver.Navigate().GoToUrl("https://testing.perfectforms.com/player.htm?f=FGghgAQB");

                Console.WriteLine(test_environment + "player.htm?f=FGghgAQB");

                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_18"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_18")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.02");
                {
                    string value = driver.FindElement(By.Id("1-PF_12")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.02"));
                }
                Console.WriteLine("Verifiy Numeric = 3.44");
                {
                    string value = driver.FindElement(By.Id("2-PF_12")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3.44"));
                }
                Console.WriteLine("Verifiy Numeric = 5,555.78");
                {
                    string value = driver.FindElement(By.Id("3-PF_12")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5,555.78"));
                }
                Console.WriteLine("Verifiy Numeric = - 100.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 100.00"));
                }
                Console.WriteLine("Verifiy Numeric = 100.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("100.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 56.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 56.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_14")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 23.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_14")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("23.00"));
                }
                Console.WriteLine("Verifiy Numeric = 99.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_14")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("99.00"));
                }

                Console.WriteLine("Verifiy Numeric = 2.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_15")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2.00"));
                }
                Console.WriteLine("Verifiy Numeric = 45.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_15")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("45.00"));
                }
                Console.WriteLine("Verifiy Numeric = 189.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_15")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("189.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 198,765,432.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_16")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 198,765,432.00"));
                }
                Console.WriteLine("Verifiy Numeric = 25,215,566.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_16")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("25,215,566.00"));
                }
                Console.WriteLine("Verifiy Numeric = 64,526,677.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_16")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("64,526,677.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 199.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_17")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 199.00"));
                }
                Console.WriteLine("Verifiy Numeric = 199.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_17")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("199.00"));
                }
                Console.WriteLine("Verifiy Numeric = 12,345.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_17")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12,345.00"));
                }

                driver.FindElement(By.Id("PF_27")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = .02");
                {
                    string value = driver.FindElement(By.Id("1-PF_21")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo(".02"));
                }
                Console.WriteLine("Verifiy Numeric = 3.44");
                {
                    string value = driver.FindElement(By.Id("2-PF_21")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3.44"));
                }
                Console.WriteLine("Verifiy Numeric = 5,555.78");
                {
                    string value = driver.FindElement(By.Id("3-PF_21")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5,555.78"));
                }
                Console.WriteLine("Verifiy Numeric = - 100.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_22")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 100.00"));
                }
                Console.WriteLine("Verifiy Numeric = 100.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_22")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("100.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 56.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_22")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 56.00"));
                }
                Console.WriteLine("Verifiy Numeric = .00");
                {
                    string value = driver.FindElement(By.Id("1-PF_23")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo(".00"));
                }
                Console.WriteLine("Verifiy Numeric = 23.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_23")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("23.00"));
                }
                Console.WriteLine("Verifiy Numeric = 99.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_23")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("99.00"));
                }

                Console.WriteLine("Verifiy Numeric = 2.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_24")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2.00"));
                }
                Console.WriteLine("Verifiy Numeric = 45.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_24")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("45.00"));
                }
                Console.WriteLine("Verifiy Numeric = 189.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_24")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("189.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 198,765,432.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_25")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 198,765,432.00"));
                }
                Console.WriteLine("Verifiy Numeric = 25,215,566.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_25")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("25,215,566.00"));
                }
                Console.WriteLine("Verifiy Numeric = 64,526,677.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_25")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("64,526,677.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 199.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_26")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 199.00"));
                }
                Console.WriteLine("Verifiy Numeric = 199.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_26")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("199.00"));
                }
                Console.WriteLine("Verifiy Numeric = 12,345.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_26")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12,345.00"));
                }

                driver.FindElement(By.Id("PF_37")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0,02");
                {
                    string value = driver.FindElement(By.Id("1-PF_31")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0,02"));
                }
                Console.WriteLine("Verifiy Numeric = 3,44");
                {
                    string value = driver.FindElement(By.Id("2-PF_31")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3,44"));
                }
                Console.WriteLine("Verifiy Numeric = 5.555,78");
                {
                    string value = driver.FindElement(By.Id("3-PF_31")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5.555,78"));
                }
                Console.WriteLine("Verifiy Numeric = - 100,00");
                {
                    string value = driver.FindElement(By.Id("1-PF_32")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 100,00"));
                }
                Console.WriteLine("Verifiy Numeric = 100,00");
                {
                    string value = driver.FindElement(By.Id("2-PF_32")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("100,00"));
                }
                Console.WriteLine("Verifiy Numeric = - 56,00");
                {
                    string value = driver.FindElement(By.Id("3-PF_32")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 56,00"));
                }
                Console.WriteLine("Verifiy Numeric = ,00");
                {
                    string value = driver.FindElement(By.Id("1-PF_33")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo(",00"));
                }
                Console.WriteLine("Verifiy Numeric = 23,00");
                {
                    string value = driver.FindElement(By.Id("2-PF_33")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("23,00"));
                }
                Console.WriteLine("Verifiy Numeric = 99,00");
                {
                    string value = driver.FindElement(By.Id("3-PF_33")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("99,00"));
                }

                Console.WriteLine("Verifiy Numeric = 2,00");
                {
                    string value = driver.FindElement(By.Id("1-PF_34")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2,00"));
                }
                Console.WriteLine("Verifiy Numeric = 45,00");
                {
                    string value = driver.FindElement(By.Id("2-PF_34")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("45,00"));
                }
                Console.WriteLine("Verifiy Numeric = 189,00");
                {
                    string value = driver.FindElement(By.Id("3-PF_34")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("189,00"));
                }
                Console.WriteLine("Verifiy Numeric = - 198.765.432,00");
                {
                    string value = driver.FindElement(By.Id("1-PF_35")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 198.765.432,00"));
                }
                Console.WriteLine("Verifiy Numeric = 25.215.566,00");
                {
                    string value = driver.FindElement(By.Id("2-PF_35")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("25.215.566,00"));
                }
                Console.WriteLine("Verifiy Numeric = 64.526.677,00");
                {
                    string value = driver.FindElement(By.Id("3-PF_35")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("64.526.677,00"));
                }
                Console.WriteLine("Verifiy Numeric = - 199,00");
                {
                    string value = driver.FindElement(By.Id("1-PF_36")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 199,00"));
                }
                Console.WriteLine("Verifiy Numeric = 199,00");
                {
                    string value = driver.FindElement(By.Id("2-PF_36")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("199,00"));
                }
                Console.WriteLine("Verifiy Numeric = 12.345,00");
                {
                    string value = driver.FindElement(By.Id("3-PF_36")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12.345,00"));
                }

                driver.FindElement(By.Id("PF_39")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_41")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_41")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_41")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 100.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_42")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 100.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_42")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 56.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_42")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 56.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_43")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_43")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_43")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }

                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_44")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_44")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_44")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 198,765,432.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_46")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 198,765,432.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_46")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_46")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = - 199.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_45")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 199.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_45")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy Numeric = 0.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_45")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }

                driver.FindElement(By.Id("PF_55")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = €0.02");
                {
                    string value = driver.FindElement(By.Id("1-PF_49")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€0.02"));
                }
                Console.WriteLine("Verifiy Numeric = €3.44");
                {
                    string value = driver.FindElement(By.Id("2-PF_49")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€3.44"));
                }
                Console.WriteLine("Verifiy Numeric = €5,555.78");
                {
                    string value = driver.FindElement(By.Id("3-PF_49")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€5,555.78"));
                }
                Console.WriteLine("Verifiy Numeric = $- 100.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_50")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$- 100.00"));
                }
                Console.WriteLine("Verifiy Numeric = $100.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_50")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$100.00"));
                }
                Console.WriteLine("Verifiy Numeric = $- 56.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_50")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$- 56.00"));
                }
                Console.WriteLine("Verifiy Numeric = €0.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_51")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€0.00"));
                }
                Console.WriteLine("Verifiy Numeric = €23.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_51")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€23.00"));
                }
                Console.WriteLine("Verifiy Numeric = €99.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_51")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€99.00"));
                }

                Console.WriteLine("Verifiy Numeric = €2.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_52")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€2.00"));
                }
                Console.WriteLine("Verifiy Numeric = €45.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_52")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€45.00"));
                }
                Console.WriteLine("Verifiy Numeric = €189.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_52")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("€189.00"));
                }
                Console.WriteLine("Verifiy Numeric = $- 198,765,432.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_53")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$- 198,765,432.00"));
                }
                Console.WriteLine("Verifiy Numeric = $25,215,566.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_53")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$25,215,566.00"));
                }
                Console.WriteLine("Verifiy Numeric = $64,526,677.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_53")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$64,526,677.00"));
                }
                Console.WriteLine("Verifiy Numeric = $- 199.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_54")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$- 199.00"));
                }
                Console.WriteLine("Verifiy Numeric = $199.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_54")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$199.00"));
                }
                Console.WriteLine("Verifiy Numeric = $12,345.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_54")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("$12,345.00"));
                }


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_9")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_68"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_68")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Text = -198765432");
                {
                    string value = driver.FindElement(By.Id("1-PF_66")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-198765432"));
                }
                Console.WriteLine("Verifiy Text = 25215566");
                {
                    string value = driver.FindElement(By.Id("2-PF_66")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("25215566"));
                }
                Console.WriteLine("Verifiy Text = 64526677");
                {
                    string value = driver.FindElement(By.Id("3-PF_66")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("64526677"));
                }
                Console.WriteLine("Verifiy Text = -1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("1-PF_67")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1234567890987654321"));
                }
                Console.WriteLine("Verifiy Text = 1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("2-PF_67")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1234567890987654321"));
                }
                Console.WriteLine("Verifiy Text = 4444444444444444444");
                {
                    string value = driver.FindElement(By.Id("3-PF_67")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4444444444444444444"));
                }

                driver.FindElement(By.Id("PF_74")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Text = -198765432");
                {
                    string value = driver.FindElement(By.Id("1-PF_72")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-198765432"));
                }
                Console.WriteLine("Verifiy Text = 25215566");
                {
                    string value = driver.FindElement(By.Id("2-PF_72")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("25215566"));
                }
                Console.WriteLine("Verifiy Text = 64526677");
                {
                    string value = driver.FindElement(By.Id("3-PF_72")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("64526677"));
                }
                Console.WriteLine("Verifiy Text = -1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("1-PF_73")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1234567890987654321"));
                }
                Console.WriteLine("Verifiy Text = 1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("2-PF_73")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1234567890987654321"));
                }
                Console.WriteLine("Verifiy Text = 4444444444444444444");
                {
                    string value = driver.FindElement(By.Id("3-PF_73")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4444444444444444444"));
                }

                driver.FindElement(By.Id("PF_79")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Text = -198765432");
                {
                    string value = driver.FindElement(By.Id("1-PF_77")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-198765432"));
                }
                Console.WriteLine("Verifiy Text = 25215566");
                {
                    string value = driver.FindElement(By.Id("2-PF_77")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("25215566"));
                }
                Console.WriteLine("Verifiy Text = 64526677");
                {
                    string value = driver.FindElement(By.Id("3-PF_77")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("64526677"));
                }
                Console.WriteLine("Verifiy Text = -1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("1-PF_78")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1234567890987654321"));
                }
                Console.WriteLine("Verifiy Text = 1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("2-PF_78")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1234567890987654321"));
                }
                Console.WriteLine("Verifiy Text = 4444444444444444444");
                {
                    string value = driver.FindElement(By.Id("3-PF_78")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4444444444444444444"));
                }

                driver.FindElement(By.Id("PF_84")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Text = -198765432");
                {
                    string value = driver.FindElement(By.Id("1-PF_82")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-198765432"));
                }
                Console.WriteLine("Verifiy Text = 25215566");
                {
                    string value = driver.FindElement(By.Id("2-PF_82")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("25215566"));
                }
                Console.WriteLine("Verifiy Text = 64526677");
                {
                    string value = driver.FindElement(By.Id("3-PF_82")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("64526677"));
                }
                Console.WriteLine("Verifiy Text = -1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("1-PF_83")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1234567890987654321"));
                }
                Console.WriteLine("Verifiy Text = 1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("2-PF_83")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1234567890987654321"));
                }
                Console.WriteLine("Verifiy Text = 4444444444444444444");
                {
                    string value = driver.FindElement(By.Id("3-PF_83")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4444444444444444444"));
                }


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_63")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_97"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_97")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 12/03/2001");
                {
                    string value = driver.FindElement(By.Id("1-PF_95")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12/03/2001"));
                }
                Console.WriteLine("Verifiy Date = 06/22/2011");
                {
                    string value = driver.FindElement(By.Id("2-PF_95")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("06/22/2011"));
                }
                Console.WriteLine("Verifiy Date = 04/13/2222");
                {
                    string value = driver.FindElement(By.Id("3-PF_95")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("04/13/2222"));
                }
                Console.WriteLine("Verifiy Date = 13  :  52  :  13");
                {
                    string value = driver.FindElement(By.Id("1-PF_96")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("13  :  52  :  13"));
                }
                Console.WriteLine("Verifiy Date = 17  :  44  :  13");
                {
                    string value = driver.FindElement(By.Id("2-PF_96")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("17  :  44  :  13"));
                }
                Console.WriteLine("Verifiy Date = 11  :  18  :  33");
                {
                    string value = driver.FindElement(By.Id("3-PF_96")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("11  :  18  :  33"));
                }

                driver.FindElement(By.Id("PF_102")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 12/03/2001");
                {
                    string value = driver.FindElement(By.Id("1-PF_100")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12/03/2001"));
                }
                Console.WriteLine("Verifiy Date = 22/06/2011");
                {
                    string value = driver.FindElement(By.Id("2-PF_100")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("22/06/2011"));
                }
                Console.WriteLine("Verifiy Date = 13/04/2222");
                {
                    string value = driver.FindElement(By.Id("3-PF_100")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("13/04/2222"));
                }
                Console.WriteLine("Verifiy Date = 01  :  52  :  13 PM");
                {
                    string value = driver.FindElement(By.Id("1-PF_101")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("01  :  52  :  13 PM"));
                }
                Console.WriteLine("Verifiy Date = 05  :  44  :  13 PM");
                {
                    string value = driver.FindElement(By.Id("2-PF_101")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05  :  44  :  13 PM"));
                }
                Console.WriteLine("Verifiy Date = 11  :  18  :  33 AM");
                {
                    string value = driver.FindElement(By.Id("3-PF_101")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("11  :  18  :  33 AM"));
                }

                driver.FindElement(By.Id("PF_108")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 12.03.2001");
                {
                    string value = driver.FindElement(By.Id("1-PF_106")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12.03.2001"));
                }
                Console.WriteLine("Verifiy Date = 06.22.2011");
                {
                    string value = driver.FindElement(By.Id("2-PF_106")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("06.22.2011"));
                }
                Console.WriteLine("Verifiy Date = 04.13.2222");
                {
                    string value = driver.FindElement(By.Id("3-PF_106")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("04.13.2222"));
                }
                Console.WriteLine("Verifiy Date = 13 : 52");
                {
                    string value = driver.FindElement(By.Id("1-PF_107")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("13 : 52"));
                }
                Console.WriteLine("Verifiy Date = 17 : 44");
                {
                    string value = driver.FindElement(By.Id("2-PF_107")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("17 : 44"));
                }
                Console.WriteLine("Verifiy Date = 11 : 18");
                {
                    string value = driver.FindElement(By.Id("3-PF_107")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("11 : 18"));
                }

                driver.FindElement(By.Id("PF_113")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 03.12.2001");
                {
                    string value = driver.FindElement(By.Id("1-PF_111")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("03.12.2001"));
                }
                Console.WriteLine("Verifiy Date = 22.06.2011");
                {
                    string value = driver.FindElement(By.Id("2-PF_111")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("22.06.2011"));
                }
                Console.WriteLine("Verifiy Date = 13.04.2222");
                {
                    string value = driver.FindElement(By.Id("3-PF_111")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("13.04.2222"));
                }
                Console.WriteLine("Verifiy Date = 01 : 52 PM");
                {
                    string value = driver.FindElement(By.Id("1-PF_112")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("01 : 52 PM"));
                }
                Console.WriteLine("Verifiy Date = 05 : 44 PM");
                {
                    string value = driver.FindElement(By.Id("2-PF_112")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05 : 44 PM"));
                }
                Console.WriteLine("Verifiy Date = 11 : 18 AM");
                {
                    string value = driver.FindElement(By.Id("3-PF_112")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("11 : 18 AM"));
                }


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_92")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_123"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_123")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Char = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_125")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy Char = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                {
                    string value = driver.FindElement(By.Id("2-PF_125")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                }
                Console.WriteLine("Verifiy Char = ¢£€¥ƒ");
                {
                    string value = driver.FindElement(By.Id("3-PF_125")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("¢£€¥ƒ"));
                }
                Console.WriteLine("Verifiy Char = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_126")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy Char = `~!@#$%^&*()_+-={}|[]\\:\";'<>?,./");
                {
                    string value = driver.FindElement(By.Id("2-PF_126")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("`~!@#$%^&*()_+-={}|[]\\:\";'<>?,./"));
                }
                Console.WriteLine("Verifiy Char = 繁體中文字汇丰银");
                {
                    string value = driver.FindElement(By.Id("3-PF_126")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("繁體中文字汇丰银"));
                }

                Console.WriteLine("Verifiy Char = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_127")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy Char = ªØ,øÅ,åÆ, æÞ, þÐ");
                {
                    string value = driver.FindElement(By.Id("2-PF_127")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                }
                Console.WriteLine("Verifiy Char = ¤÷°¬±µ©™®");
                {
                    string value = driver.FindElement(By.Id("3-PF_127")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("¤÷°¬±µ©™®"));
                }
                Console.WriteLine("Verifiy Char = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_128")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy Char = ð« »‹ ›Š šŽ ž¢£€¥");
                {
                    string value = driver.FindElement(By.Id("2-PF_128")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                }
                Console.WriteLine("Verifiy Char = жगोपनीयताהגולשות");
                {
                    string value = driver.FindElement(By.Id("3-PF_128")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("жगोपनीयताהגולשות"));
                }

                driver.FindElement(By.Id("PF_138")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Char = הגולשות\\\\nAaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº\\\\n¢£€¥ƒ");
                //Assert.That(driver.FindElement(By.Id("PF_133")).Text, Is.EqualTo("הגולשות\\\\nAaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº\\\\n¢£€¥ƒ"));
                Console.WriteLine("Verifiy Char = הגולשות\\\\n\\\\`~!@#$%^&*()_+-={}|[]\\\\:\\\";\\\'<>?,./\\\\n繁體中文字汇丰银");
                //Assert.That(driver.FindElement(By.Id("PF_132")).Text, Is.EqualTo("הגולשות\\\\n\\\\`~!@#$%^&*()_+-={}|[]\\\\:\\\";\\\'<>?,./\\\\n繁體中文字汇丰银"));
                Console.WriteLine("Verifiy Char = הגולשות\\\\nªØ,øÅ,åÆ, æÞ, þÐ\\\\n¤÷°¬±µ©™®");
                //Assert.That(driver.FindElement(By.Id("PF_139")).Text, Is.EqualTo("הגולשות\\\\nªØ,øÅ,åÆ, æÞ, þÐ\\\\n¤÷°¬±µ©™®"));
                Console.WriteLine("Verifiy Char = הגולשות\\\\nð« »‹ ›Š šŽ ž¢£€¥\\\\nжगोपनीयताהגולשות");
                //Assert.That(driver.FindElement(By.Id("PF_134")).Text, Is.EqualTo("הגולשות\\\\nð« »‹ ›Š šŽ ž¢£€¥\\\\nжगोपनीयताהגולשות"));

                driver.FindElement(By.Id("PF_140")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Char = הגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_135 > option:nth-child(1)")).Text, Is.EqualTo("הגולשות"));
                Console.WriteLine("Verifiy Char = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                Assert.That(driver.FindElement(By.CssSelector("#PF_135 > option:nth-child(2)")).Text, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                Console.WriteLine("Verifiy Char = ¢£€¥ƒ");
                Assert.That(driver.FindElement(By.CssSelector("#PF_135 > option:nth-child(3)")).Text, Is.EqualTo("¢£€¥ƒ"));
                Console.WriteLine("Verifiy Char = הגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_136 > option:nth-child(1)")).Text, Is.EqualTo("הגולשות"));
                Console.WriteLine("Verifiy Char = `~!@#$%^&*()_+-={}|[]\\:\";'<>?,./");
                Assert.That(driver.FindElement(By.CssSelector("#PF_136 > option:nth-child(2)")).Text, Is.EqualTo("`~!@#$%^&*()_+-={}|[]\\:\";'<>?,./"));
                Console.WriteLine("Verifiy Char = 繁體中文字汇丰银");
                Assert.That(driver.FindElement(By.CssSelector("#PF_136 > option:nth-child(3)")).Text, Is.EqualTo("繁體中文字汇丰银"));

                Console.WriteLine("Verifiy Char = הגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_141 > option:nth-child(1)")).Text, Is.EqualTo("הגולשות"));
                Console.WriteLine("Verifiy Char = ªØ,øÅ,åÆ, æÞ, þÐ");
                Assert.That(driver.FindElement(By.CssSelector("#PF_141 > option:nth-child(2)")).Text, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                Console.WriteLine("Verifiy Char = ¤÷°¬±µ©™®");
                Assert.That(driver.FindElement(By.CssSelector("#PF_141 > option:nth-child(3)")).Text, Is.EqualTo("¤÷°¬±µ©™®"));
                Console.WriteLine("Verifiy Char = הגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_137 > option:nth-child(1)")).Text, Is.EqualTo("הגולשות"));
                Console.WriteLine("Verifiy Char = ð« »‹ ›Š šŽ ž¢£€¥");
                Assert.That(driver.FindElement(By.CssSelector("#PF_137 > option:nth-child(2)")).Text, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                Console.WriteLine("Verifiy Char = жगोपनीयताהגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_137 > option:nth-child(3)")).Text, Is.EqualTo("жगोपनीयताהגולשות"));


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_121")).Click();



                var elements = driver.FindElements(By.Id("PF_4"));
                Assert.True(elements.Count > 0);


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
