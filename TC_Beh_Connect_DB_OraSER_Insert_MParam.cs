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
    //[TestFixture("safari", "TC_Beh_Connect_DB_OraSER_Insert_MParam",  "MacOS 11.0", "cbt")]
    [TestFixture("chrome", "TC_Beh_Connect_DB_OraSER_Insert_MParam", "Windows 10", "local_chrome")]
    [TestFixture("firefox", "TC_Beh_Connect_DB_OraSER_Insert_MParam", "Windows 10", "local_firefox")]
    [TestFixture("edge", "TC_Beh_Connect_DB_OraSER_Insert_MParam", "Windows 10", "local_edge")]
    //[TestFixture("safari", "TC_Beh_Int_Funct_Template", "Galaxy S10", "cbt")]
    //[TestFixture("safari", "TC_Beh_Int_Funct_Template", "Galaxy Tab S5E", "cbt")]
    //[TestFixture("safari", "TC_Beh_Int_Funct_Template", "Pixel 5", "cbt")]
    //[TestFixture("safari", "TC_Beh_Connect_DB_OraSER_Insert_MParam", "MacOS 11.0", "cbt")]

    public class TC_Beh_Connect_DB_OraSER_Insert_MParam_Test : CBTAPI
    {
        public TC_Beh_Connect_DB_OraSER_Insert_MParam_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void TC_Beh_Connect_DB_OraSER_Insert_MParam()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:

                Console.WriteLine("Open TestCase TC_Beh_Connect_DB_OraSER_Insert_MParam");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                //driver.Navigate().GoToUrl(test_environment + "player.htm?f=kR9AAgoG");
                driver.Navigate().GoToUrl("https://testing.perfectforms.com/player.htm?f=kR9AAgoG");

                //Console.WriteLine(test_environment + "player.htm?f=kR9AAgoG");

                Console.WriteLine("Verifiy Set 1st is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Set 1st not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_18"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }
                Thread.Sleep(3000);

                driver.FindElement(By.Id("PF_18")).Click();

                Thread.Sleep(3000);

                driver.FindElement(By.Id("PF_19")).Click();

                Thread.Sleep(3000);

                driver.FindElement(By.Id("PF_20")).Click();

                Thread.Sleep(3000);

                driver.FindElement(By.Id("PF_21")).Click();

                Thread.Sleep(3000);

                driver.FindElement(By.Id("PF_32")).Click();

                Thread.Sleep(3000);

                driver.FindElement(By.Id("PF_33")).Click();

                Thread.Sleep(3000);


                driver.FindElement(By.Id("PF_22")).Click();

                Thread.Sleep(4000);

                Console.WriteLine("Verifiy Number 52 = 987.65");
                {
                    string value = driver.FindElement(By.Id("1-PF_12")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("987.65"));
                }
                Console.WriteLine("Verifiy Number 52 = - 999.99");
                {
                    string value = driver.FindElement(By.Id("2-PF_12")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 999.99"));
                }
                Console.WriteLine("Verifiy Number 52 = 0.01");
                {
                    string value = driver.FindElement(By.Id("3-PF_12")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.01"));
                }
                Console.WriteLine("Verifiy Number 92 = 9,999,999.01");
                {
                    string value = driver.FindElement(By.Id("1-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("9,999,999.01"));
                }
                Console.WriteLine("Verifiy Number 92 = - 111,111.11");
                {
                    string value = driver.FindElement(By.Id("2-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 111,111.11"));
                }
                Console.WriteLine("Verifiy Number 92 = 12.09");
                {
                    string value = driver.FindElement(By.Id("3-PF_13")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12.09"));
                }

                Console.WriteLine("Verifiy DD N52 = 1");
                {
                    string value = driver.FindElement(By.Id("PF_23")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N52 = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_25 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N52 = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_25 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD N52 = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_25 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy DD N92 = 1");
                {
                    string value = driver.FindElement(By.Id("PF_24")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N92 = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_26 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N92 = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_26 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD N92 = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_26 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                driver.FindElement(By.Id("PF_27")).Click();

                Thread.Sleep(4000);


                driver.FindElement(By.Id("PF_39")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_42")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_43")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_44")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_53")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_54")).Click();

                Thread.Sleep(4000);


                driver.FindElement(By.Id("PF_45")).Click();

                Thread.Sleep(4000);

                Console.WriteLine("Verifiy Number 52 = 333.33");
                {
                    string value = driver.FindElement(By.Id("1-PF_35")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("333.33"));
                }
                Console.WriteLine("Verifiy Number 52 = - 999.99");
                {
                    string value = driver.FindElement(By.Id("2-PF_35")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 999.99"));
                }
                Console.WriteLine("Verifiy Number 52 = 9.99");
                {
                    string value = driver.FindElement(By.Id("3-PF_35")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("9.99"));
                }
                Console.WriteLine("Verifiy Number 92 = 1,234,567.89");
                {
                    string value = driver.FindElement(By.Id("1-PF_36")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1,234,567.89"));
                }
                Console.WriteLine("Verifiy Number 92 = - 111,111.11");
                {
                    string value = driver.FindElement(By.Id("2-PF_36")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("- 111,111.11"));
                }
                Console.WriteLine("Verifiy Number 92 = 0.09");
                {
                    string value = driver.FindElement(By.Id("3-PF_36")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.09"));
                }

                Console.WriteLine("Verifiy DD N52 = 1");
                {
                    string value = driver.FindElement(By.Id("PF_46")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N52 = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_48 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N52 = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_48 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD N52 = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_48 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy DD N92 = 1");
                {
                    string value = driver.FindElement(By.Id("PF_47")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N92 = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_49 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N92 = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_49 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD N92 = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_49 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                driver.FindElement(By.Id("PF_55")).Click();

                Thread.Sleep(4000);

                Console.WriteLine("Click Next Page");

                driver.FindElement(By.Id("PF_8")).Click();



                Console.WriteLine("Verifiy Set 1st is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Set 1st not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_68"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_68")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_71")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_72")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_73")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_85")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_86")).Click();

                Thread.Sleep(4000);


                driver.FindElement(By.Id("PF_74")).Click();

                Thread.Sleep(4000);

                Console.WriteLine("Verifiy Number 112 = 212121212");
                {
                    string value = driver.FindElement(By.Id("1-PF_64")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("212121212"));
                }
                Console.WriteLine("Verifiy Number 112 = -198765432");
                {
                    string value = driver.FindElement(By.Id("2-PF_64")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-198765432"));
                }
                Console.WriteLine("Verifiy Number 112 = 999999999.99");
                {
                    string value = driver.FindElement(By.Id("3-PF_64")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("999999999.99"));
                }
                Console.WriteLine("Verifiy Number 202 = 444444444444444444.44");
                {
                    string value = driver.FindElement(By.Id("1-PF_65")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("444444444444444444.44"));
                }
                Console.WriteLine("Verifiy Number 202 = -123456789098765432.10");
                {
                    string value = driver.FindElement(By.Id("2-PF_65")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-123456789098765432.10"));
                }
                Console.WriteLine("Verifiy Number 202 = 123456789098765432.10");
                {
                    string value = driver.FindElement(By.Id("3-PF_65")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456789098765432.10"));
                }

                Console.WriteLine("Verifiy DD N112 = 1");
                {
                    string value = driver.FindElement(By.Id("PF_78")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N112 = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_80 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N112 = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_80 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD N112 = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_80 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy DD N202 = 1");
                {
                    string value = driver.FindElement(By.Id("PF_79")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N202 = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_81 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD N202 = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_81 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD N202 = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_81 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy Number 112 = 212121212");
                {
                    string value = driver.FindElement(By.Id("1-PF_76")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("212121212"));
                }
                Console.WriteLine("Verifiy Number 112 = -198765432");
                {
                    string value = driver.FindElement(By.Id("2-PF_76")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-198765432"));
                }
                Console.WriteLine("Verifiy Number 112 = 999999999.99");
                {
                    string value = driver.FindElement(By.Id("3-PF_76")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("999999999.99"));
                }
                Console.WriteLine("Verifiy Number 202 = 444444444444444444.44");
                {
                    string value = driver.FindElement(By.Id("1-PF_77")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("444444444444444444.44"));
                }
                Console.WriteLine("Verifiy Number 202 = -123456789098765432.10");
                {
                    string value = driver.FindElement(By.Id("2-PF_77")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-123456789098765432.10"));
                }
                Console.WriteLine("Verifiy Number 202 = 123456789098765432.10");
                {
                    string value = driver.FindElement(By.Id("3-PF_77")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456789098765432.10"));
                }

                driver.FindElement(By.Id("PF_87")).Click();

                Thread.Sleep(4000);

                Console.WriteLine("Click Next Page");

                driver.FindElement(By.Id("PF_93")).Click();



                Console.WriteLine("Verifiy Set 1st is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Set 1st not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_107"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_107")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_110")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_111")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_112")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_126")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_127")).Click();

                Thread.Sleep(4000);


                driver.FindElement(By.Id("PF_113")).Click();

                Thread.Sleep(4000);

                //Console.WriteLine("Verifiy Date MM/DD/YYYY = 09/01/1990");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_102")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("09/01/1990"));
                //}
                //Console.WriteLine("Verifiy Date MM/DD/YYYY = 12/01/1941");
                //{
                //    string value = driver.FindElement(By.Id("2-PF_102")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12/01/1941"));
                //}
                //Console.WriteLine("Verifiy Date MM/DD/YYYY = 04/21/2001");
                //{
                //    string value = driver.FindElement(By.Id("3-PF_102")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("04/21/2001"));
                //}
                //Console.WriteLine("Verifiy Date DD/MM/YYYY = 09/01/1990");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_103")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("09/01/1990"));
                //}
                //Console.WriteLine("Verifiy Date DD/MM/YYYY = 12/01/1941");
                //{
                //    string value = driver.FindElement(By.Id("2-PF_103")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12/01/1941"));
                //}
                //Console.WriteLine("Verifiy Date DD/MM/YYYY = 21/04/2001");
                //{
                //    string value = driver.FindElement(By.Id("3-PF_103")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("21/04/2001"));
                //}
                //Console.WriteLine("Verifiy Date MM.DD.YYYY = 09.01.1990");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_104")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("09.01.1990"));
                //}
                //Console.WriteLine("Verifiy Date MM.DD.YYYY = 12.01.1941");
                //{
                //    string value = driver.FindElement(By.Id("2-PF_104")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12.01.1941"));
                //}
                //Console.WriteLine("Verifiy Date MM.DD.YYYY = 04.21.2001");
                //{
                //    string value = driver.FindElement(By.Id("3-PF_104")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("04.21.2001"));
                //}
                //Console.WriteLine("Verifiy Date DD.MM.YYYY = 01.09.1990");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_105")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("01.09.1990"));
                //}
                //Console.WriteLine("Verifiy Date DD.MM.YYYY = 01.12.1941");
                //{
                //    string value = driver.FindElement(By.Id("2-PF_105")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("01.12.1941"));
                //}
                //Console.WriteLine("Verifiy Date DD.MM.YYYY = 21.04.2001");
                //{
                //    string value = driver.FindElement(By.Id("3-PF_105")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("21.04.2001"));
                //}

                //Console.WriteLine("Verifiy Date MM/DD/YYYY = 07/22/2031");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_115")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("07/22/2031"));
                //}
                //Console.WriteLine("Verifiy Date MM/DD/YYYY = 12/31/2001");
                //{
                //    string value = driver.FindElement(By.Id("2-PF_115")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12/31/2001"));
                //}
                //Console.WriteLine("Verifiy Date MM/DD/YYYY = 06/01/2011");
                //{
                //    string value = driver.FindElement(By.Id("3-PF_115")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("06/01/2011"));
                //}
                //Console.WriteLine("Verifiy DD/MM/YYYY = 22/07/2031");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_116")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("22/07/2031"));
                //}
                //Console.WriteLine("Verifiy DD/MM/YYYY = 31/12/2001");
                //{
                //    string value = driver.FindElement(By.Id("2-PF_116")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("31/12/2001"));
                //}
                //Console.WriteLine("Verifiy DD/MM/YYYY = 06/01/2011");
                //{
                //    string value = driver.FindElement(By.Id("3-PF_116")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("06/01/2011"));
                //}
                //Console.WriteLine("Verifiy Date MM.DD.YYYY = 07.22.2031");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_117")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("07.22.2031"));
                //}
                //Console.WriteLine("Verifiy Date MM.DD.YYYY = 12.31.2001");
                //{
                //    string value = driver.FindElement(By.Id("2-PF_117")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12.31.2001"));
                //}
                //Console.WriteLine("Verifiy Date MM.DD.YYYY = 06.01.2011");
                //{
                //    string value = driver.FindElement(By.Id("3-PF_117")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("06.01.2011"));
                //}
                //Console.WriteLine("Verifiy Date DD.MM.YYYY = 22.07.2031");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_118")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("22.07.2031"));
                //}
                //Console.WriteLine("Verifiy Date DD.MM.YYYY = 31.12.2001");
                //{
                //    string value = driver.FindElement(By.Id("2-PF_118")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("31.12.2001"));
                //}
                //Console.WriteLine("Verifiy Date DD.MM.YYYY = 01.06.2011");
                //{
                //    string value = driver.FindElement(By.Id("3-PF_118")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("01.06.2011"));
                //}

                //Console.WriteLine("Verifiy DD Date = 1");
                //{
                //    string value = driver.FindElement(By.Id("PF_119")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1"));
                //}
                Console.WriteLine("Verifiy DD Date = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_121 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD Date = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_121 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD Date = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_121 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy DD TimeStamp = 1");
                {
                    string value = driver.FindElement(By.Id("PF_120")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD TimeStamp = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_122 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD TimeStamp = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_122 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD TimeStamp = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_122 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                driver.FindElement(By.Id("PF_128")).Click();

                Thread.Sleep(4000);

                Console.WriteLine("Click Next Page");

                driver.FindElement(By.Id("PF_133")).Click();



                Console.WriteLine("Verifiy Set 1st is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Set 1st not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_151"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                driver.FindElement(By.Id("PF_151")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_154")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_155")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_156")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_161")).Click();

                Thread.Sleep(4000);

                driver.FindElement(By.Id("PF_162")).Click();

                Thread.Sleep(4000);


                driver.FindElement(By.Id("PF_157")).Click();

                Thread.Sleep(4000);

                Console.WriteLine("Verifiy Char = ĂăÎîÂâŞşŢţÀÈ");
                {
                    string value = driver.FindElement(By.Id("1-PF_148")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ĂăÎîÂâŞşŢţÀÈ"));
                }
                Console.WriteLine("Verifiy Char = abcdefghijklmnoprstquwvxz");
                {
                    string value = driver.FindElement(By.Id("2-PF_148")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("abcdefghijklmnoprstquwvxz"));
                }
                Console.WriteLine("Verifiy Char = `~!@#$%^&*()_+-={}|[]\\:\";");
                {
                    string value = driver.FindElement(By.Id("3-PF_148")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("`~!@#$%^&*()_+-={}|[]\\:\";"));
                }
                Console.WriteLine("Verifiy VarChar = لاندونيسية");
                {
                    string value = driver.FindElement(By.Id("1-PF_149")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("لاندونيسية"));
                }
                Console.WriteLine("Verifiy VarChar = ~!@#$%^&*()_+}{:\"|?><");
                {
                    string value = driver.FindElement(By.Id("2-PF_149")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("~!@#$%^&*()_+}{:\"|?><"));
                }
                Console.WriteLine("Verifiy VarChar = गोपनीयताהגולשות");
                {
                    string value = driver.FindElement(By.Id("3-PF_149")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("गोपनीयताהגולשות"));
                }

                Console.WriteLine("Verifiy Char = ĂăÎîÂâŞşŢţÀÈ");
                {
                    string value = driver.FindElement(By.Id("1-PF_159")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ĂăÎîÂâŞşŢţÀÈ"));
                }
                Console.WriteLine("Verifiy Char = abcdefghijklmnoprstquwvxz");
                {
                    string value = driver.FindElement(By.Id("2-PF_159")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("abcdefghijklmnoprstquwvxz"));
                }
                Console.WriteLine("Verifiy Char = `~!@#$%^&*()_+-={}&#124;[]\\:&#34;;");
                {
                    string value = driver.FindElement(By.Id("3-PF_159")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("`~!@#$%^&*()_+-={}&#124;[]\\:&#34;;"));
                }
                Console.WriteLine("Verifiy VarChar = لاندونيسية");
                {
                    string value = driver.FindElement(By.Id("1-PF_160")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("لاندونيسية"));
                }
                Console.WriteLine("Verifiy VarChar = ~!@#$%^&*()_+}{:&#34;&#124;?><");
                {
                    string value = driver.FindElement(By.Id("2-PF_160")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("~!@#$%^&*()_+}{:&#34;&#124;?><"));
                }
                Console.WriteLine("Verifiy VarChar = गोपनीयताהגולשות");
                {
                    string value = driver.FindElement(By.Id("3-PF_160")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("गोपनीयताהגולשות"));
                }

                Console.WriteLine("Verifiy DD Char = 1");
                {
                    string value = driver.FindElement(By.Id("PF_142")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD Char = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_144 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD Char = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_144 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD Char = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_144 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                Console.WriteLine("Verifiy DD VarChar = 1");
                {
                    string value = driver.FindElement(By.Id("PF_143")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD VarChar = 1");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_145 > option:nth-child(1)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy DD VarChar = 2");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_145 > option:nth-child(2)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2"));
                }
                Console.WriteLine("Verifiy DD VarChar = 3");
                {
                    string value = driver.FindElement(By.CssSelector("#PF_145 > option:nth-child(3)")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("3"));
                }

                driver.FindElement(By.Id("PF_168")).Click();

                Thread.Sleep(4000);

                Console.WriteLine("Click Submit");

                driver.FindElement(By.Id("PF_136")).Click();



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
