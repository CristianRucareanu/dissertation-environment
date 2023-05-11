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
    [TestFixture("chrome", "TC_Beh_Connect_GOOGLE_Update", "Windows 10", "local_chrome")]
    [TestFixture("firefox", "TC_Beh_Connect_GOOGLE_Update", "Windows 10", "local_firefox")]
    [TestFixture("edge", "TC_Beh_Connect_GOOGLE_Update", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "TC_Beh_Int_Funct_Template", "Mac OSX 12613")]

    public class TC_Beh_Connect_GOOGLE_Update_Test : CBTAPI
    {
        public TC_Beh_Connect_GOOGLE_Update_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void TC_Beh_Connect_GOOGLE_Update()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:

                Console.WriteLine("Open TestCase TC_Beh_Connect_GOOGLE_Update");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                driver.Navigate().GoToUrl(test_environment + "player.htm?f=4HgBgAgE");
                //driver.Navigate().GoToUrl("https://testing.perfectforms.com/player.htm?f=4HgBgAgE");

                Console.WriteLine(test_environment + "player.htm?f=4HgBgAgE");

                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_36"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_36")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_37")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_38")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 1.33");
                //{
                //    string value = driver.FindElement(By.Id("PF_12")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.33"));
                //}
                Console.WriteLine("Verifiy Numeric = 1.56");
                //{
                //    string value = driver.FindElement(By.Id("PF_13")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.56"));
                //}
                Console.WriteLine("Verifiy Numeric = 1.5");
                //{
                //    string value = driver.FindElement(By.Id("PF_14")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.5"));
                //}
                Console.WriteLine("Verifiy Numeric = -1.234");
                //{
                //    string value = driver.FindElement(By.Id("PF_15")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("-1.234"));
                //}
                Console.WriteLine("Verifiy Numeric = 12");
                //{
                //    string value = driver.FindElement(By.Id("PF_16")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12"));
                //}
                Console.WriteLine("Verifiy Numeric = 8000");
                //{
                //    string value = driver.FindElement(By.Id("PF_17")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("8000"));
                //}

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_39")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_42")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_49")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_56")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.33");
                //{
                //    string value = driver.FindElement(By.Id("PF_43")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("0.33"));
                //}
                Console.WriteLine("Verifiy Numeric = 1.56");
                //{
                //    string value = driver.FindElement(By.Id("PF_44")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.56"));
                //}
                Console.WriteLine("Verifiy Numeric = 1.50");
                //{
                //    string value = driver.FindElement(By.Id("PF_45")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.50"));
                //}
                Console.WriteLine("Verifiy Numeric = -1.23");
                //{
                //    string value = driver.FindElement(By.Id("PF_46")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("-1.23"));
                //}
                Console.WriteLine("Verifiy Numeric = 12.00");
                //{
                //    string value = driver.FindElement(By.Id("PF_47")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12.00"));
                //}
                Console.WriteLine("Verifiy Numeric = 8,000.00");
                //{
                //    string value = driver.FindElement(By.Id("PF_48")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("8,000.00"));
                //}

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_57")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_84")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_86")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_87")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.33");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_71")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("0.33"));
                //}
                Console.WriteLine("Verifiy Numeric = 1.56");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_72")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.56"));
                //}
                Console.WriteLine("Verifiy Numeric = 1.5");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_73")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.5"));
                //}
                Console.WriteLine("Verifiy Numeric = -1.234");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_74")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("-1.234"));
                //}
                Console.WriteLine("Verifiy Numeric = 12");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_75")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12"));
                //}
                Console.WriteLine("Verifiy Numeric = 1200");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_76")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1200"));
                //}

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_88")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_104")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_105")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_106")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.33");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_91")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("0.33"));
                //}
                Console.WriteLine("Verifiy Numeric = 1.56");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_92")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.56"));
                //}
                Console.WriteLine("Verifiy Numeric = 1.5");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_93")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("1.5"));
                //}
                Console.WriteLine("Verifiy Numeric = -1.234");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_94")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("-1.234"));
                //}
                Console.WriteLine("Verifiy Numeric = 12");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_95")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("12"));
                //}
                Console.WriteLine("Verifiy Numeric = 8000");
                //{
                //    string value = driver.FindElement(By.Id("1-PF_96")).GetAttribute("value");
                //    Assert.That(value, Is.EqualTo("8000"));
                //}

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_107")).Click();
                Thread.Sleep(2000);


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_8")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_118"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_118")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_122")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_126")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Large Numeric = 2123456");
                {
                    string value = driver.FindElement(By.Id("PF_119")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2123456"));
                }
                Console.WriteLine("Verifiy Large Numeric = -9876543");
                {
                    string value = driver.FindElement(By.Id("PF_120")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-9876543"));
                }
                Console.WriteLine("Verifiy Large Numeric = -188888888");
                {
                    string value = driver.FindElement(By.Id("PF_121")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-188888888"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_127")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_135")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_139")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_143")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Large Numeric = 2123456");
                {
                    string value = driver.FindElement(By.Id("PF_136")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2123456"));
                }
                Console.WriteLine("Verifiy Large Numeric = 9876543");
                {
                    string value = driver.FindElement(By.Id("PF_137")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("9876543"));
                }
                Console.WriteLine("Verifiy Large Numeric = -188888888");
                {
                    string value = driver.FindElement(By.Id("PF_138")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-188888888"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_144")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_160")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_161")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_162")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Large Numeric = 2123456");
                {
                    string value = driver.FindElement(By.Id("1-PF_153")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("2123456"));
                }
                Console.WriteLine("Verifiy Large Numeric = 23876543");
                {
                    string value = driver.FindElement(By.Id("1-PF_154")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("23876543"));
                }
                Console.WriteLine("Verifiy Large Numeric = 111111111111111");
                {
                    string value = driver.FindElement(By.Id("1-PF_155")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("111111111111111"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_163")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_173")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_174")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_175")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Large Numeric = 100000");
                {
                    string value = driver.FindElement(By.Id("1-PF_166")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("100000"));
                }
                Console.WriteLine("Verifiy Large Numeric = 89695");
                {
                    string value = driver.FindElement(By.Id("1-PF_167")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("89695"));
                }
                Console.WriteLine("Verifiy Large Numeric = -9999999");
                {
                    string value = driver.FindElement(By.Id("1-PF_168")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-9999999"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_176")).Click();
                Thread.Sleep(2000);


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_114")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_195"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_195")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_196")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_197")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 10/25/1906");
                {
                    string value = driver.FindElement(By.Id("PF_187")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("10/25/1906"));
                }
                Console.WriteLine("Verifiy Date = 03/09/1912");
                {
                    string value = driver.FindElement(By.Id("PF_188")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("03/09/1912"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_198")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_208")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_209")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_210")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 05/10/1936");
                {
                    string value = driver.FindElement(By.Id("PF_200")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05/10/1936"));
                }
                Console.WriteLine("Verifiy Date = 09/03/1956");
                {
                    string value = driver.FindElement(By.Id("PF_201")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("09/03/1956"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_211")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_221")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_222")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_223")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 10.05.1936");
                {
                    string value = driver.FindElement(By.Id("PF_213")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("10.05.1936"));
                }
                Console.WriteLine("Verifiy Date = 03.09.1956");
                {
                    string value = driver.FindElement(By.Id("PF_214")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("03.09.1956"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_224")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_234")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_235")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_236")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 13.05.1955");
                {
                    string value = driver.FindElement(By.Id("PF_226")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("13.05.1955"));
                }
                Console.WriteLine("Verifiy Date = 30.11.1998");
                {
                    string value = driver.FindElement(By.Id("PF_227")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("30.11.1998"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_237")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_245")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_246")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_248")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 05/13/1955");
                {
                    string value = driver.FindElement(By.Id("PF_240")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05/13/1955"));
                }
                Console.WriteLine("Verifiy Date = 04/03/1906");
                {
                    string value = driver.FindElement(By.Id("PF_241")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("04/03/1906"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_249")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_256")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_257")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_261")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 05/13/2006");
                {
                    string value = driver.FindElement(By.Id("PF_252")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05/13/2006"));
                }
                Console.WriteLine("Verifiy Date = 11/30/1906");
                {
                    string value = driver.FindElement(By.Id("PF_253")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("11/30/1906"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_262")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_268")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_269")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_272")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 05/13/2006");
                {
                    string value = driver.FindElement(By.Id("PF_264")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("05/13/2006"));
                }
                Console.WriteLine("Verifiy Date = 11/30/1906");
                {
                    string value = driver.FindElement(By.Id("PF_265")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("11/30/1906"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_273")).Click();
                Thread.Sleep(2000);


                Console.WriteLine("Click Next Page");
                driver.FindElement(By.Id("PF_183")).Click();



                Console.WriteLine("Verifiy Next Page is present");
                for (int second = 0; ; second++)
                {
                    if (second >= 10) Assert.Fail("Next Page not found");
                    try
                    {
                        if (IsElementPresent(By.Id("PF_282"))) break;
                    }
                    catch (Exception)
                    { }
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_282")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_287")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_292")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Special Characters = `~!@#$%^&*()_+-={}|[]\\:\";'<>?,./");
                {
                    string value = driver.FindElement(By.Id("PF_283")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("`~!@#$%^&*()_+-={}|[]\\:\";'<>?,./"));
                }
                Console.WriteLine("Verifiy Special Characters = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                {
                    string value = driver.FindElement(By.Id("PF_284")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                }
                Console.WriteLine("Verifiy Special Characters = ªØ,øÅ,åÆ, æÞ, þÐ");
                {
                    string value = driver.FindElement(By.Id("PF_285")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                }
                Console.WriteLine("Verifiy Special Characters = ð« »‹ ›Š šŽ ž¢£€¥");
                {
                    string value = driver.FindElement(By.Id("PF_286")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_293")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_310")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_312")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_317")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Special Characters = `~!@#$%^&*()_+-={}|[]\\:\";'<>?,./");
                {
                    string value = driver.FindElement(By.Id("PF_307")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("`~!@#$%^&*()_+-={}|[]\\:\";'<>?,./"));
                }
                Console.WriteLine("Verifiy Special Characters = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                {
                    string value = driver.FindElement(By.Id("PF_308")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                }
                Console.WriteLine("Verifiy Special Characters = ªØ,øÅ,åÆ, æÞ, þÐ");
                {
                    string value = driver.FindElement(By.Id("PF_309")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                }
                Console.WriteLine("Verifiy Special Characters = ð« »‹ ›Š šŽ ž¢£€¥");
                {
                    string value = driver.FindElement(By.Id("PF_311")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_303")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_330")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_331")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_337")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Special Characters = `~!@#$%^&*()_+-={}|[]&#92;:&#34;;&#39;&#60;&#62;?,./");
                {
                    string value = driver.FindElement(By.Id("1-PF_326")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("`~!@#$%^&*()_+-={}|[]&#92;:&#34;;&#39;&#60;&#62;?,./"));
                }
                Console.WriteLine("Verifiy Special Characters = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                {
                    string value = driver.FindElement(By.Id("1-PF_327")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                }
                Console.WriteLine("Verifiy Special Characters = ªØ,øÅ,åÆ, æÞ, þÐ");
                {
                    string value = driver.FindElement(By.Id("1-PF_328")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                }
                Console.WriteLine("Verifiy Special Characters = ð« »‹ ›Š šŽ ž¢£€¥");
                {
                    string value = driver.FindElement(By.Id("1-PF_329")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_324")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_345")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Update");
                driver.FindElement(By.Id("PF_346")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show updated Value");
                driver.FindElement(By.Id("PF_352")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Special Characters = `~!@#$%^&*()_+-={}&#124;[]&#92;:&#34;;&#39;&#60;&#62;?,./");
                {
                    string value = driver.FindElement(By.Id("1-PF_341")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("`~!@#$%^&*()_+-={}&#124;[]&#92;:&#34;;&#39;&#60;&#62;?,./"));
                }
                Console.WriteLine("Verifiy Special Characters = AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº");
                {
                    string value = driver.FindElement(By.Id("1-PF_342")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("AaÎîÂâSsTtÀÈÒÌÒÙàèìòù¿ÇçŒœ¡ßº"));
                }
                Console.WriteLine("Verifiy Special Characters = ªØ,øÅ,åÆ, æÞ, þÐ");
                {
                    string value = driver.FindElement(By.Id("1-PF_343")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ªØ,øÅ,åÆ, æÞ, þÐ"));
                }
                Console.WriteLine("Verifiy Special Characters = ð« »‹ ›Š šŽ ž¢£€¥");
                {
                    string value = driver.FindElement(By.Id("1-PF_344")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ð« »‹ ›Š šŽ ž¢£€¥"));
                }

                Console.WriteLine("Click Restore Values");
                driver.FindElement(By.Id("PF_353")).Click();
                Thread.Sleep(2000);


                Console.WriteLine("Click Submit");
                driver.FindElement(By.Id("PF_354")).Click();



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
