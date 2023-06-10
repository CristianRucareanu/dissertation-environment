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
    [TestFixture("chrome", "TC_Beh_Connect_GOOGLE_Insert", "Windows 10", "local_chrome")]
    [TestFixture("firefox", "TC_Beh_Connect_GOOGLE_Insert", "Windows 10", "local_firefox")]
    [TestFixture("edge", "TC_Beh_Connect_GOOGLE_Insert", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "TC_Beh_Int_Funct_Template", "Mac OSX 12613")]

    public class TC_Beh_Connect_GOOGLE_Insert_Test : CBTAPI
    {
        public TC_Beh_Connect_GOOGLE_Insert_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void TC_Beh_Connect_GOOGLE_Insert()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:

                Console.WriteLine("Open TestCase TC_Beh_Connect_GOOGLE_Insert");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                //driver.Navigate().GoToUrl(test_environment + "player.htm?f=GmAhAgUh");
                driver.Navigate().GoToUrl("https://testing.perfectforms.com/player.htm?f=GmAhAgUh");

                //Console.WriteLine(test_environment + "player.htm?f=GmAhAgUh");

                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_31"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_31")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_32")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_33")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_34")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_57")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_58")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_35")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy numeric inputs table = 0.02");
                {
                    string value = driver.FindElement(By.Id("1-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.02"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 3.44");
                {
                    string value = driver.FindElement(By.Id("2-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3.44"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 5,555.78");
                {
                    string value = driver.FindElement(By.Id("3-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5,555.78"));
                }
                Console.WriteLine("Verifiy numeric inputs table = - 100.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_14")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 100.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 100.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_14")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("100.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = - 56.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_14")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 56.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 0.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_15")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 23.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_15")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("23.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 99.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_15")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("99.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = - 5,553.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_16")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 5,553.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 5,553.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_16")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5,553.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 1,550.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_16")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1,550.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 2.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_17")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 45.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_17")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("45.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 189.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_17")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("189.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = - 199.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_18")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 199.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 199.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_18")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("199.00"));
                }
                Console.WriteLine("Verifiy numeric inputs table = 12,345.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_18")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12,345.00"));
                }

                Console.WriteLine("Verifiy numeric inputs dropdown = 0.02\\\\n3.44\\\\n5555.78");
                //Assert.That(driver.FindElement(By.Id("PF_36")).Text, Is.EqualTo("0.02\\\\n3.44\\\\n5555.78"));
                Console.WriteLine("Verifiy numeric inputs dropdown = -100\\\\n100\\\\n-56");
                //Assert.That(driver.FindElement(By.Id("PF_37")).Text, Is.EqualTo("-100\\\\n100\\\\n-56"));
                Console.WriteLine("Verifiy numeric inputs dropdown = 0\\\\n23\\\\n99");
                //Assert.That(driver.FindElement(By.Id("PF_38")).Text, Is.EqualTo("0\\\\n23\\\\n99"));
                Console.WriteLine("Verifiy numeric inputs dropdown = -5553\\\\n5553\\\\n1550");
                //Assert.That(driver.FindElement(By.Id("PF_39")).Text, Is.EqualTo("-5553\\\\n5553\\\\n1550"));
                Console.WriteLine("Verifiy numeric inputs dropdown = 2\\\\n45\\\\n189");
                //Assert.That(driver.FindElement(By.Id("PF_40")).Text, Is.EqualTo("2\\\\n45\\\\n189"));
                Console.WriteLine("Verifiy numeric inputs dropdown = -199\\\\n199\\\\n12345");
                //Assert.That(driver.FindElement(By.Id("PF_41")).Text, Is.EqualTo("-199\\\\n199\\\\n12345"));

                Console.WriteLine("Verifiy numeric inputs list = 0.02");
                Assert.That(driver.FindElement(By.CssSelector("#PF_42 > option:nth-child(1)")).Text, Is.EqualTo("0.02"));
                Console.WriteLine("Verifiy numeric inputs list = 3.44");
                Assert.That(driver.FindElement(By.CssSelector("#PF_42 > option:nth-child(2)")).Text, Is.EqualTo("3.44"));
                Console.WriteLine("Verifiy numeric inputs list = 5555.78");
                Assert.That(driver.FindElement(By.CssSelector("#PF_42 > option:nth-child(3)")).Text, Is.EqualTo("5555.78"));
                Console.WriteLine("Verifiy numeric inputs list = -100");
                Assert.That(driver.FindElement(By.CssSelector("#PF_43 > option:nth-child(1)")).Text, Is.EqualTo("-100"));
                Console.WriteLine("Verifiy numeric inputs list = 100");
                Assert.That(driver.FindElement(By.CssSelector("#PF_43 > option:nth-child(2)")).Text, Is.EqualTo("100"));
                Console.WriteLine("Verifiy numeric inputs list = -56");
                Assert.That(driver.FindElement(By.CssSelector("#PF_43 > option:nth-child(3)")).Text, Is.EqualTo("-56"));
                Console.WriteLine("Verifiy numeric inputs list = 0");
                Assert.That(driver.FindElement(By.CssSelector("#PF_44 > option:nth-child(1)")).Text, Is.EqualTo("0"));
                Console.WriteLine("Verifiy numeric inputs list = 23");
                Assert.That(driver.FindElement(By.CssSelector("#PF_44 > option:nth-child(2)")).Text, Is.EqualTo("23"));
                Console.WriteLine("Verifiy numeric inputs list = 99");
                Assert.That(driver.FindElement(By.CssSelector("#PF_44 > option:nth-child(3)")).Text, Is.EqualTo("99"));
                Console.WriteLine("Verifiy numeric inputs list = -5553");
                Assert.That(driver.FindElement(By.CssSelector("#PF_45 > option:nth-child(1)")).Text, Is.EqualTo("-5553"));
                Console.WriteLine("Verifiy numeric inputs list = 5553");
                Assert.That(driver.FindElement(By.CssSelector("#PF_45 > option:nth-child(2)")).Text, Is.EqualTo("5553"));
                Console.WriteLine("Verifiy numeric inputs list = 1550");
                Assert.That(driver.FindElement(By.CssSelector("#PF_45 > option:nth-child(3)")).Text, Is.EqualTo("1550"));
                Console.WriteLine("Verifiy numeric inputs list = 2");
                Assert.That(driver.FindElement(By.CssSelector("#PF_46 > option:nth-child(1)")).Text, Is.EqualTo("2"));
                Console.WriteLine("Verifiy numeric inputs list = 45");
                Assert.That(driver.FindElement(By.CssSelector("#PF_46 > option:nth-child(2)")).Text, Is.EqualTo("45"));
                Console.WriteLine("Verifiy numeric inputs list = 189");
                Assert.That(driver.FindElement(By.CssSelector("#PF_46 > option:nth-child(3)")).Text, Is.EqualTo("189"));
                Console.WriteLine("Verifiy numeric inputs list = -199");
                Assert.That(driver.FindElement(By.CssSelector("#PF_47 > option:nth-child(1)")).Text, Is.EqualTo("-199"));
                Console.WriteLine("Verifiy numeric inputs list = 199");
                Assert.That(driver.FindElement(By.CssSelector("#PF_47 > option:nth-child(2)")).Text, Is.EqualTo("199"));
                Console.WriteLine("Verifiy numeric inputs list = 12345");
                Assert.That(driver.FindElement(By.CssSelector("#PF_47 > option:nth-child(3)")).Text, Is.EqualTo("12345"));

                driver.FindElement(By.Id("PF_48")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("PF_72")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_79")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_80")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_81")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_102")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_103")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_82")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy text inputs table = 0.02");
                {
                    string value = driver.FindElement(By.Id("1-PF_60")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.02"));
                }
                Console.WriteLine("Verifiy text inputs table = 3.44");
                {
                    string value = driver.FindElement(By.Id("2-PF_60")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3.44"));
                }
                Console.WriteLine("Verifiy text inputs table = 5,555.78");
                {
                    string value = driver.FindElement(By.Id("3-PF_60")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5,555.78"));
                }
                Console.WriteLine("Verifiy text inputs table = - 100.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_61")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 100.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 100.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_61")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("100.00"));
                }
                Console.WriteLine("Verifiy text inputs table = - 56.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_61")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 56.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 0.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_62")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 23.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_62")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("23.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 99.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_62")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("99.00"));
                }
                Console.WriteLine("Verifiy text inputs table = - 5,553.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_63")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 5,553.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 5,553.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_63")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("5,553.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 1,550.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_63")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1,550.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 2.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_64")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 45.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_64")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("45.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 189.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_64")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("189.00"));
                }
                Console.WriteLine("Verifiy text inputs table = - 199.00");
                {
                    string value = driver.FindElement(By.Id("1-PF_65")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 199.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 199.00");
                {
                    string value = driver.FindElement(By.Id("2-PF_65")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("199.00"));
                }
                Console.WriteLine("Verifiy text inputs table = 12,345.00");
                {
                    string value = driver.FindElement(By.Id("3-PF_65")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12,345.00"));
                }

                Console.WriteLine("Verifiy text inputs dropdown = 0.02\\\\n3.44\\\\n5555.78");
                //Assert.That(driver.FindElement(By.Id("PF_83")).Text, Is.EqualTo("0.02\\\\n3.44\\\\n5555.78"));
                Console.WriteLine("Verifiy text inputs dropdown = -100\\\\n100\\\\n-56");
                //Assert.That(driver.FindElement(By.Id("PF_84")).Text, Is.EqualTo("-100\\\\n100\\\\n-56"));
                Console.WriteLine("Verifiy text inputs dropdown = 0\\\\n23\\\\n99");
                //Assert.That(driver.FindElement(By.Id("PF_85")).Text, Is.EqualTo("0\\\\n23\\\\n99"));
                Console.WriteLine("Verifiy text inputs dropdown = -5553\\\\n5553\\\\n1550");
                //Assert.That(driver.FindElement(By.Id("PF_86")).Text, Is.EqualTo("-5553\\\\n5553\\\\n1550"));
                Console.WriteLine("Verifiy text inputs dropdown = 2\\\\n45\\\\n189");
                //Assert.That(driver.FindElement(By.Id("PF_87")).Text, Is.EqualTo("2\\\\n45\\\\n189"));
                Console.WriteLine("Verifiy text inputs dropdown = -199\\\\n199\\\\n12345");
                //Assert.That(driver.FindElement(By.Id("PF_88")).Text, Is.EqualTo("-199\\\\n199\\\\n12345"));

                Console.WriteLine("Verifiy text inputs list = 0.02");
                Assert.That(driver.FindElement(By.CssSelector("#PF_89 > option:nth-child(1)")).Text, Is.EqualTo("0.02"));
                Console.WriteLine("Verifiy text inputs list = 3.44");
                Assert.That(driver.FindElement(By.CssSelector("#PF_89 > option:nth-child(2)")).Text, Is.EqualTo("3.44"));
                Console.WriteLine("Verifiy text inputs list = 5555.78");
                Assert.That(driver.FindElement(By.CssSelector("#PF_89 > option:nth-child(3)")).Text, Is.EqualTo("5555.78"));
                Console.WriteLine("Verifiy text inputs list = -100");
                Assert.That(driver.FindElement(By.CssSelector("#PF_90 > option:nth-child(1)")).Text, Is.EqualTo("-100"));
                Console.WriteLine("Verifiy text inputs list = 100");
                Assert.That(driver.FindElement(By.CssSelector("#PF_90 > option:nth-child(2)")).Text, Is.EqualTo("100"));
                Console.WriteLine("Verifiy text inputs list = -56");
                Assert.That(driver.FindElement(By.CssSelector("#PF_90 > option:nth-child(3)")).Text, Is.EqualTo("-56"));
                Console.WriteLine("Verifiy text inputs list = 0");
                Assert.That(driver.FindElement(By.CssSelector("#PF_91 > option:nth-child(1)")).Text, Is.EqualTo("0"));
                Console.WriteLine("Verifiy text inputs list = 23");
                Assert.That(driver.FindElement(By.CssSelector("#PF_91 > option:nth-child(2)")).Text, Is.EqualTo("23"));
                Console.WriteLine("Verifiy text inputs list = 99");
                Assert.That(driver.FindElement(By.CssSelector("#PF_91 > option:nth-child(3)")).Text, Is.EqualTo("99"));
                Console.WriteLine("Verifiy text inputs list = -5553");
                Assert.That(driver.FindElement(By.CssSelector("#PF_92 > option:nth-child(1)")).Text, Is.EqualTo("-5553"));
                Console.WriteLine("Verifiy text inputs list = 5553");
                Assert.That(driver.FindElement(By.CssSelector("#PF_92 > option:nth-child(2)")).Text, Is.EqualTo("5553"));
                Console.WriteLine("Verifiy text inputs list = 1550");
                Assert.That(driver.FindElement(By.CssSelector("#PF_92 > option:nth-child(3)")).Text, Is.EqualTo("1550"));
                Console.WriteLine("Verifiy text inputs list = 2");
                Assert.That(driver.FindElement(By.CssSelector("#PF_93 > option:nth-child(1)")).Text, Is.EqualTo("2"));
                Console.WriteLine("Verifiy text inputs list = 45");
                Assert.That(driver.FindElement(By.CssSelector("#PF_93 > option:nth-child(2)")).Text, Is.EqualTo("45"));
                Console.WriteLine("Verifiy text inputs list = 189");
                Assert.That(driver.FindElement(By.CssSelector("#PF_93 > option:nth-child(3)")).Text, Is.EqualTo("189"));
                Console.WriteLine("Verifiy text inputs list = -199");
                Assert.That(driver.FindElement(By.CssSelector("#PF_94 > option:nth-child(1)")).Text, Is.EqualTo("-199"));
                Console.WriteLine("Verifiy text inputs list = 199");
                Assert.That(driver.FindElement(By.CssSelector("#PF_94 > option:nth-child(2)")).Text, Is.EqualTo("199"));
                Console.WriteLine("Verifiy text inputs list = 12345");
                Assert.That(driver.FindElement(By.CssSelector("#PF_94 > option:nth-child(3)")).Text, Is.EqualTo("12345"));

                driver.FindElement(By.Id("PF_104")).Click();
                Thread.Sleep(2000);


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_9")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_121"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_121")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_125")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_126")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_127")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_143")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_144")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_128")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy 9 digits table = -123456789012345");
                {
                    string value = driver.FindElement(By.Id("1-PF_115")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-123456789012345"));
                }
                Console.WriteLine("Verifiy 9 digits table = -33333333333333");
                {
                    string value = driver.FindElement(By.Id("2-PF_115")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-33333333333333"));
                }
                Console.WriteLine("Verifiy 9 digits table = 91919191919191");
                {
                    string value = driver.FindElement(By.Id("3-PF_115")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("91919191919191"));
                }
                Console.WriteLine("Verifiy 9 digits table = -198765432");
                {
                    string value = driver.FindElement(By.Id("1-PF_116")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-198765432"));
                }
                Console.WriteLine("Verifiy 9 digits table = 1212121212");
                {
                    string value = driver.FindElement(By.Id("2-PF_116")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1212121212"));
                }
                Console.WriteLine("Verifiy 9 digits table = 2121212121");
                {
                    string value = driver.FindElement(By.Id("3-PF_116")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2121212121"));
                }
                Console.WriteLine("Verifiy 9 digits table = -1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("1-PF_117")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1234567890987654321"));
                }
                Console.WriteLine("Verifiy 9 digits table = 1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("2-PF_117")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1234567890987654321"));
                }
                Console.WriteLine("Verifiy 9 digits table = 4444444444444444444");
                {
                    string value = driver.FindElement(By.Id("3-PF_117")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4444444444444444444"));
                }

                Console.WriteLine("Verifiy 9 digits dropdown = -123456789012345\\\\n-33333333333333\\\\n91919191919191");
                //Assert.That(driver.FindElement(By.Id("PF_129")).Text, Is.EqualTo("-123456789012345\\\\n-33333333333333\\\\n91919191919191"));
                Console.WriteLine("Verifiy 9 digits dropdown = -198765432\\\\n1212121212\\\\n2121212121");
                //Assert.That(driver.FindElement(By.Id("PF_130")).Text, Is.EqualTo("-198765432\\\\n1212121212\\\\n2121212121"));
                Console.WriteLine("Verifiy 9 digits dropdown = -1234567890987654321\\\\n1234567890987654321\\\\n4444444444444444444");
                //Assert.That(driver.FindElement(By.Id("PF_131")).Text, Is.EqualTo("-1234567890987654321\\\\n1234567890987654321\\\\n4444444444444444444"));

                Console.WriteLine("Verifiy 9 digits list = -123456789012345");
                Assert.That(driver.FindElement(By.CssSelector("#PF_132 > option:nth-child(1)")).Text, Is.EqualTo("-123456789012345"));
                Console.WriteLine("Verifiy 9 digits list = -33333333333333");
                Assert.That(driver.FindElement(By.CssSelector("#PF_132 > option:nth-child(2)")).Text, Is.EqualTo("-33333333333333"));
                Console.WriteLine("Verifiy 9 digits list = 91919191919191");
                Assert.That(driver.FindElement(By.CssSelector("#PF_132 > option:nth-child(3)")).Text, Is.EqualTo("91919191919191"));
                Console.WriteLine("Verifiy 9 digits list = -198765432");
                Assert.That(driver.FindElement(By.CssSelector("#PF_133 > option:nth-child(1)")).Text, Is.EqualTo("-198765432"));
                Console.WriteLine("Verifiy 9 digits list = 1212121212");
                Assert.That(driver.FindElement(By.CssSelector("#PF_133 > option:nth-child(2)")).Text, Is.EqualTo("1212121212"));
                Console.WriteLine("Verifiy 9 digits list = 2121212121");
                Assert.That(driver.FindElement(By.CssSelector("#PF_133 > option:nth-child(3)")).Text, Is.EqualTo("2121212121"));
                Console.WriteLine("Verifiy 9 digits list = -1234567890987654321");
                Assert.That(driver.FindElement(By.CssSelector("#PF_134 > option:nth-child(1)")).Text, Is.EqualTo("-1234567890987654321"));
                Console.WriteLine("Verifiy 9 digits list = 1234567890987654321");
                Assert.That(driver.FindElement(By.CssSelector("#PF_134 > option:nth-child(2)")).Text, Is.EqualTo("1234567890987654321"));
                Console.WriteLine("Verifiy 9 digits list = 4444444444444444444");
                Assert.That(driver.FindElement(By.CssSelector("#PF_134 > option:nth-child(3)")).Text, Is.EqualTo("4444444444444444444"));

                Console.WriteLine("Verifiy 9 digits table = -123456789012345");
                {
                    string value = driver.FindElement(By.Id("1-PF_136")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-123456789012345"));
                }
                Console.WriteLine("Verifiy 9 digits table = -33333333333333");
                {
                    string value = driver.FindElement(By.Id("2-PF_136")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-33333333333333"));
                }
                Console.WriteLine("Verifiy 9 digits table = 91919191919191");
                {
                    string value = driver.FindElement(By.Id("3-PF_136")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("91919191919191"));
                }
                Console.WriteLine("Verifiy 9 digits table = -198765432");
                {
                    string value = driver.FindElement(By.Id("1-PF_137")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-198765432"));
                }
                Console.WriteLine("Verifiy 9 digits table = 1212121212");
                {
                    string value = driver.FindElement(By.Id("2-PF_137")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1212121212"));
                }
                Console.WriteLine("Verifiy 9 digits table = 2121212121");
                {
                    string value = driver.FindElement(By.Id("3-PF_137")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2121212121"));
                }
                Console.WriteLine("Verifiy 9 digits table = -1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("1-PF_138")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1234567890987654321"));
                }
                Console.WriteLine("Verifiy 9 digits table = 1234567890987654321");
                {
                    string value = driver.FindElement(By.Id("2-PF_138")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1234567890987654321"));
                }
                Console.WriteLine("Verifiy 9 digits table = 4444444444444444444");
                {
                    string value = driver.FindElement(By.Id("3-PF_138")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("4444444444444444444"));
                }

                driver.FindElement(By.Id("PF_145")).Click();
                Thread.Sleep(2000);


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_112")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_166"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_166")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_169")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_170")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_171")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_185")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_186")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_172")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy date 1 table = 01/03/1903");
                {
                    string value = driver.FindElement(By.Id("1-PF_160")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("01/03/1903"));
                }
                Console.WriteLine("Verifiy date 1 table = 05/09/1955");
                {
                    string value = driver.FindElement(By.Id("2-PF_160")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05/09/1955"));
                }
                Console.WriteLine("Verifiy date 1 table = 08/28/2055");
                {
                    string value = driver.FindElement(By.Id("3-PF_160")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("08/28/2055"));
                }
                Console.WriteLine("Verifiy date 1 table = 01/03/1903");
                {
                    string value = driver.FindElement(By.Id("1-PF_161")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("01/03/1903"));
                }
                Console.WriteLine("Verifiy date 1 table = 05/09/1955");
                {
                    string value = driver.FindElement(By.Id("2-PF_161")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05/09/1955"));
                }
                Console.WriteLine("Verifiy date 1 table = 28/08/2055");
                {
                    string value = driver.FindElement(By.Id("3-PF_161")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("28/08/2055"));
                }
                Console.WriteLine("Verifiy date 1 table = 01.03.1903");
                {
                    string value = driver.FindElement(By.Id("1-PF_162")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("01.03.1903"));
                }
                Console.WriteLine("Verifiy date 1 table = 05.09.1955");
                {
                    string value = driver.FindElement(By.Id("2-PF_162")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05.09.1955"));
                }
                Console.WriteLine("Verifiy date 1 table = 08.28.2055");
                {
                    string value = driver.FindElement(By.Id("3-PF_162")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("08.28.2055"));
                }
                Console.WriteLine("Verifiy date 1 table = 03.01.1903");
                {
                    string value = driver.FindElement(By.Id("1-PF_163")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("03.01.1903"));
                }
                Console.WriteLine("Verifiy date 1 table = 09.05.1955");
                {
                    string value = driver.FindElement(By.Id("2-PF_163")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("09.05.1955"));
                }
                Console.WriteLine("Verifiy date 1 table = 28.08.2055");
                {
                    string value = driver.FindElement(By.Id("3-PF_163")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("28.08.2055"));
                }
                Console.WriteLine("Verifiy date 1 table = 12/03/2001");
                {
                    string value = driver.FindElement(By.Id("1-PF_174")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12/03/2001"));
                }
                Console.WriteLine("Verifiy date 1 table = 06/22/2011");
                {
                    string value = driver.FindElement(By.Id("2-PF_174")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("06/22/2011"));
                }
                Console.WriteLine("Verifiy date 1 table = 04/13/2222");
                {
                    string value = driver.FindElement(By.Id("3-PF_174")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("04/13/2222"));
                }
                Console.WriteLine("Verifiy date 1 table = 12/03/2001");
                {
                    string value = driver.FindElement(By.Id("1-PF_175")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12/03/2001"));
                }
                Console.WriteLine("Verifiy date 1 table = 22/06/2011");
                {
                    string value = driver.FindElement(By.Id("2-PF_175")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("22/06/2011"));
                }
                Console.WriteLine("Verifiy date 1 table = 13/04/2222");
                {
                    string value = driver.FindElement(By.Id("3-PF_175")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("13/04/2222"));
                }
                Console.WriteLine("Verifiy date 1 table = 12.03.2001");
                {
                    string value = driver.FindElement(By.Id("1-PF_176")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12.03.2001"));
                }
                Console.WriteLine("Verifiy date 1 table = 06.22.2011");
                {
                    string value = driver.FindElement(By.Id("2-PF_176")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("06.22.2011"));
                }
                Console.WriteLine("Verifiy date 1 table = 04.13.2222");
                {
                    string value = driver.FindElement(By.Id("3-PF_176")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("04.13.2222"));
                }
                Console.WriteLine("Verifiy date 1 table = 03.12.2001");
                {
                    string value = driver.FindElement(By.Id("1-PF_177")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("03.12.2001"));
                }
                Console.WriteLine("Verifiy date 1 table = 22.06.2011");
                {
                    string value = driver.FindElement(By.Id("2-PF_177")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("22.06.2011"));
                }
                Console.WriteLine("Verifiy date 1 table = 13.04.2222");
                {
                    string value = driver.FindElement(By.Id("3-PF_177")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("13.04.2222"));
                }

                Console.WriteLine("Verifiy date 1 dropdown = 01/03/1903\\\\n05/09/1955\\\\n08/28/2055");
                //Assert.That(driver.FindElement(By.Id("PF_178")).Text, Is.EqualTo("01/03/1903\\\\n05/09/1955\\\\n08/28/2055"));
                Console.WriteLine("Verifiy date 1 dropdown = 12/03/2001\\\\n06/22/2011\\\\n04/13/2222");
                //Assert.That(driver.FindElement(By.Id("PF_179")).Text, Is.EqualTo("12/03/2001\\\\n06/22/2011\\\\n04/13/2222"));

                Console.WriteLine("Verifiy date 1 list = 01/03/1903");
                Assert.That(driver.FindElement(By.CssSelector("#PF_180 > option:nth-child(1)")).Text, Is.EqualTo("01/03/1903"));
                Console.WriteLine("Verifiy date 1 list = 05/09/1955");
                Assert.That(driver.FindElement(By.CssSelector("#PF_180 > option:nth-child(2)")).Text, Is.EqualTo("05/09/1955"));
                Console.WriteLine("Verifiy date 1 list = 08/28/2055");
                Assert.That(driver.FindElement(By.CssSelector("#PF_180 > option:nth-child(3)")).Text, Is.EqualTo("08/28/2055"));
                Console.WriteLine("Verifiy date 1 list = 12/03/2001");
                Assert.That(driver.FindElement(By.CssSelector("#PF_181 > option:nth-child(1)")).Text, Is.EqualTo("12/03/2001"));
                Console.WriteLine("Verifiy date 1 list = 06/22/2011");
                Assert.That(driver.FindElement(By.CssSelector("#PF_181 > option:nth-child(2)")).Text, Is.EqualTo("06/22/2011"));
                Console.WriteLine("Verifiy date 1 list = 04/13/2222");
                Assert.That(driver.FindElement(By.CssSelector("#PF_181 > option:nth-child(3)")).Text, Is.EqualTo("04/13/2222"));

                driver.FindElement(By.Id("PF_187")).Click();
                Thread.Sleep(2000);


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_157")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_217"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_217")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_222")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_223")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_224")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_231")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_232")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("PF_225")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy special characters table = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_210")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                {
                    string value = driver.FindElement(By.Id("2-PF_210")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                }
                Console.WriteLine("Verifiy special characters table = ¢£€¥ƒ");
                {
                    string value = driver.FindElement(By.Id("3-PF_210")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("¢£€¥ƒ"));
                }
                Console.WriteLine("Verifiy special characters table = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_211")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = \\`~!@#$%^&*()_+-={}|[]\\:\";\'<>?,./");
                {
                    string value = driver.FindElement(By.Id("2-PF_211")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("\\`~!@#$%^&*()_+-={}|[]\\:\";\'<>?,./"));
                }
                Console.WriteLine("Verifiy special characters table = 繁體中文字汇丰银");
                {
                    string value = driver.FindElement(By.Id("3-PF_211")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("繁體中文字汇丰银"));
                }
                Console.WriteLine("Verifiy special characters table = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_212")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = ªØ,øÅ,åÆ, æÞ, þÐ");
                {
                    string value = driver.FindElement(By.Id("2-PF_212")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                }
                Console.WriteLine("Verifiy special characters table = ¤÷°¬±µ©™®");
                {
                    string value = driver.FindElement(By.Id("3-PF_212")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("¤÷°¬±µ©™®"));
                }
                Console.WriteLine("Verifiy special characters table = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_213")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = ð« »‹ ›Š šŽ ž¢£€¥");
                {
                    string value = driver.FindElement(By.Id("2-PF_213")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                }
                Console.WriteLine("Verifiy special characters table = жगोपनीयताהגולשות");
                {
                    string value = driver.FindElement(By.Id("3-PF_213")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("жगोपनीयताהגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_227")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                {
                    string value = driver.FindElement(By.Id("2-PF_227")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                }
                Console.WriteLine("Verifiy special characters table = ¢£€¥ƒ");
                {
                    string value = driver.FindElement(By.Id("3-PF_227")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("¢£€¥ƒ"));
                }
                Console.WriteLine("Verifiy special characters table = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_228")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = \\`~!@#$%^&*()_+-={}&#124;[]\\:&#34;;\'<>?,./");
                {
                    string value = driver.FindElement(By.Id("2-PF_228")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("\\`~!@#$%^&*()_+-={}&#124;[]\\:&#34;;\'<>?,./"));
                }
                Console.WriteLine("Verifiy special characters table = 繁體中文字汇丰银");
                {
                    string value = driver.FindElement(By.Id("3-PF_228")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("繁體中文字汇丰银"));
                }
                Console.WriteLine("Verifiy special characters table = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_229")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = ªØ,øÅ,åÆ, æÞ, þÐ");
                {
                    string value = driver.FindElement(By.Id("2-PF_229")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                }
                Console.WriteLine("Verifiy special characters table = ¤÷°¬±µ©™®");
                {
                    string value = driver.FindElement(By.Id("3-PF_229")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("¤÷°¬±µ©™®"));
                }
                Console.WriteLine("Verifiy special characters table = הגולשות");
                {
                    string value = driver.FindElement(By.Id("1-PF_230")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("הגולשות"));
                }
                Console.WriteLine("Verifiy special characters table = ð« »‹ ›Š šŽ ž¢£€¥");
                {
                    string value = driver.FindElement(By.Id("2-PF_230")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                }
                Console.WriteLine("Verifiy special characters table = жगोपनीयताהגולשות");
                {
                    string value = driver.FindElement(By.Id("3-PF_230")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("жगोपनीयताהגולשות"));
                }

                Console.WriteLine("Verifiy special characters dropdown = הגולשות\\\\nAaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº\\\\n¢£€¥ƒ");
                //Assert.That(driver.FindElement(By.Id("PF_200")).Text, Is.EqualTo("הגולשות\\\\nAaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº\\\\n¢£€¥ƒ"));
                Console.WriteLine("Verifiy special characters dropdown = הגולשות\\\\n\\\\`~!@#$%^&*()_+-={}|[]\\\\:\\\";\\\'<>?,./\\\\n繁體中文字汇丰银");
                //Assert.That(driver.FindElement(By.Id("PF_201")).Text, Is.EqualTo("הגולשות\\\\n\\\\`~!@#$%^&*()_+-={}|[]\\\\:\\\";\\\'<>?,./\\\\n繁體中文字汇丰银"));
                Console.WriteLine("Verifiy special characters dropdown = הגולשות\\\\nªØ,øÅ,åÆ, æÞ, þÐ\\\\n¤÷°¬±µ©™®");
                //Assert.That(driver.FindElement(By.Id("PF_202")).Text, Is.EqualTo("הגולשות\\\\nªØ,øÅ,åÆ, æÞ, þÐ\\\\n¤÷°¬±µ©™®"));
                Console.WriteLine("Verifiy special characters dropdown = הגולשות\\\\nð« »‹ ›Š šŽ ž¢£€¥\\\\nжगोपनीयताהגולשות");
                //Assert.That(driver.FindElement(By.Id("PF_203")).Text, Is.EqualTo("הגולשות\\\\nð« »‹ ›Š šŽ ž¢£€¥\\\\nжगोपनीयताהגולשות"));

                Console.WriteLine("Verifiy special characters list = הגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_204 > option:nth-child(1)")).Text, Is.EqualTo("הגולשות"));
                Console.WriteLine("Verifiy special characters list = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                Assert.That(driver.FindElement(By.CssSelector("#PF_204 > option:nth-child(2)")).Text, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                Console.WriteLine("Verifiy special characters list = ¢£€¥ƒ");
                Assert.That(driver.FindElement(By.CssSelector("#PF_204 > option:nth-child(3)")).Text, Is.EqualTo("¢£€¥ƒ"));
                Console.WriteLine("Verifiy special characters list = הגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_205 > option:nth-child(1)")).Text, Is.EqualTo("הגולשות"));
                Console.WriteLine("Verifiy special characters list = \\\\`~!@#$%^&*()_+-={}|[]\\\\:\\\";\\\'<>?,./");
                Assert.That(driver.FindElement(By.CssSelector("#PF_205 > option:nth-child(2)")).Text, Is.EqualTo("\\\\`~!@#$%^&*()_+-={}|[]\\\\:\\\";\\\'<>?,./"));
                Console.WriteLine("Verifiy special characters list = 繁體中文字汇丰银");
                Assert.That(driver.FindElement(By.CssSelector("#PF_205 > option:nth-child(3)")).Text, Is.EqualTo("繁體中文字汇丰银"));
                Console.WriteLine("Verifiy special characters list = הגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_206 > option:nth-child(1)")).Text, Is.EqualTo("הגולשות"));
                Console.WriteLine("Verifiy special characters list = ªØ,øÅ,åÆ, æÞ, þÐ");
                Assert.That(driver.FindElement(By.CssSelector("#PF_206 > option:nth-child(2)")).Text, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                Console.WriteLine("Verifiy special characters list = ¤÷°¬±µ©™®");
                Assert.That(driver.FindElement(By.CssSelector("#PF_206 > option:nth-child(3)")).Text, Is.EqualTo("¤÷°¬±µ©™®"));
                Console.WriteLine("Verifiy special characters list = הגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_207 > option:nth-child(1)")).Text, Is.EqualTo("הגולשות"));
                Console.WriteLine("Verifiy special characters list = ð« »‹ ›Š šŽ ž¢£€¥");
                Assert.That(driver.FindElement(By.CssSelector("#PF_207 > option:nth-child(2)")).Text, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                Console.WriteLine("Verifiy special characters list = жगोपनीयताהגולשות");
                Assert.That(driver.FindElement(By.CssSelector("#PF_207 > option:nth-child(3)")).Text, Is.EqualTo("жगोपनीयताהגולשות"));

                driver.FindElement(By.Id("PF_240")).Click();
                Thread.Sleep(2000);


                Console.WriteLine("Click Submit");
                driver.FindElement(By.Id("PF_193")).Click();



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
