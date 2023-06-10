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
    [TestFixture("chrome", "TC_Beh_Connect_GOOGLE_Delete", "Windows 10", "local_chrome")]
    [TestFixture("firefox", "TC_Beh_Connect_GOOGLE_Delete", "Windows 10", "local_firefox")]
    [TestFixture("edge", "TC_Beh_Connect_GOOGLE_Delete", "Windows 10", "local_edge")]
    //[TestFixture("ie11", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie10", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("ie9", "TC_Beh_Int_Funct_Template", "Windows 7 64-Bit")]
    //[TestFixture("safari", "TC_Beh_Int_Funct_Template", "Mac OSX 12613")]

    public class TC_Beh_Connect_GOOGLE_Delete_Test : CBTAPI
    {
        public TC_Beh_Connect_GOOGLE_Delete_Test(string browser, string tc_name, string platform, string enviroment) : base(browser, tc_name, platform, enviroment) { }
        [Test]
        public void TC_Beh_Connect_GOOGLE_Delete()
        {
            // wrap the rest of the test in a try-catch for error logging via the API
            try
            {
                //Insert your recorded actions here:

                Console.WriteLine("Open TestCase TC_Beh_Connect_GOOGLE_Delete");

                driver.Manage().Window.Maximize();
                var test_environment = TestContext.Parameters.Get("test_environment", "DefaultValue");
                //driver.Navigate().GoToUrl(test_environment + "player.htm?f=NJghgAcC");
                driver.Navigate().GoToUrl("https://testing.perfectforms.com/player.htm?f=NJghgAcC");

                //Console.WriteLine(test_environment + "player.htm?f=NJghgAcC");

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
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_37")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.03");
                {
                    string value = driver.FindElement(By.Id("PF_24")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.03"));
                }
                Console.WriteLine("Verifiy Numeric = 1.23");
                {
                    string value = driver.FindElement(By.Id("PF_25")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.23"));
                }
                Console.WriteLine("Verifiy Numeric = -1.5");
                {
                    string value = driver.FindElement(By.Id("PF_26")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1.5"));
                }
                Console.WriteLine("Verifiy Numeric = 1.234");
                {
                    string value = driver.FindElement(By.Id("PF_27")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.234"));
                }
                Console.WriteLine("Verifiy Numeric = 1");
                {
                    string value = driver.FindElement(By.Id("PF_28")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy Numeric = 1200");
                {
                    string value = driver.FindElement(By.Id("PF_29")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1200"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_38")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_39")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Pop-Up Message"); // NOT DONE !! PUT IT EVERYWHERE
                driver.FindElement(By.CssSelector(".ui-button:nth-child(1)")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_42")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_49")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.03");
                {
                    string value = driver.FindElement(By.Id("PF_50")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.03"));
                }
                Console.WriteLine("Verifiy Numeric = 1.23");
                {
                    string value = driver.FindElement(By.Id("PF_51")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.23"));
                }
                Console.WriteLine("Verifiy Numeric = -1.50");
                {
                    string value = driver.FindElement(By.Id("PF_52")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1.50"));
                }
                Console.WriteLine("Verifiy Numeric = 1.23");
                {
                    string value = driver.FindElement(By.Id("PF_53")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.23"));
                }
                Console.WriteLine("Verifiy Numeric = 1.00");
                {
                    string value = driver.FindElement(By.Id("PF_54")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.00"));
                }
                Console.WriteLine("Verifiy Numeric = 1,200.00");
                {
                    string value = driver.FindElement(By.Id("PF_55")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1,200.00"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_56")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_57")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_84")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_86")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.03");
                {
                    string value = driver.FindElement(By.Id("1-PF_78")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.03"));
                }
                Console.WriteLine("Verifiy Numeric = 1.23");
                {
                    string value = driver.FindElement(By.Id("1-PF_79")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.23"));
                }
                Console.WriteLine("Verifiy Numeric = -1.5");
                {
                    string value = driver.FindElement(By.Id("1-PF_80")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1.5"));
                }
                Console.WriteLine("Verifiy Numeric = 1.234");
                {
                    string value = driver.FindElement(By.Id("1-PF_81")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.234"));
                }
                Console.WriteLine("Verifiy Numeric = 1");
                {
                    string value = driver.FindElement(By.Id("1-PF_82")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy Numeric = 1200");
                {
                    string value = driver.FindElement(By.Id("1-PF_83")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1200"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_87")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_88")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_104")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_105")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Numeric = 0.03");
                {
                    string value = driver.FindElement(By.Id("1-PF_98")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("0.03"));
                }
                Console.WriteLine("Verifiy Numeric = 1.23");
                {
                    string value = driver.FindElement(By.Id("1-PF_99")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.23"));
                }
                Console.WriteLine("Verifiy Numeric = -1.5");
                {
                    string value = driver.FindElement(By.Id("1-PF_100")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("-1.5"));
                }
                Console.WriteLine("Verifiy Numeric = 1.234");
                {
                    string value = driver.FindElement(By.Id("1-PF_101")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1.234"));
                }
                Console.WriteLine("Verifiy Numeric = 1");
                {
                    string value = driver.FindElement(By.Id("1-PF_102")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1"));
                }
                Console.WriteLine("Verifiy Numeric = 1200");
                {
                    string value = driver.FindElement(By.Id("1-PF_103")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1200"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_106")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
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
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_122")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Large Numeric = 123456");
                {
                    string value = driver.FindElement(By.Id("PF_123")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456"));
                }
                Console.WriteLine("Verifiy Large Numeric = 9876543");
                {
                    string value = driver.FindElement(By.Id("PF_124")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("9876543"));
                }
                Console.WriteLine("Verifiy Large Numeric = 88888888");
                {
                    string value = driver.FindElement(By.Id("PF_125")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("88888888"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_126")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_127")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_135")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_139")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Large Numeric = 123456");
                {
                    string value = driver.FindElement(By.Id("PF_140")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456"));
                }
                Console.WriteLine("Verifiy Large Numeric = 9876543");
                {
                    string value = driver.FindElement(By.Id("PF_141")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("9876543"));
                }
                Console.WriteLine("Verifiy Large Numeric = 88888888");
                {
                    string value = driver.FindElement(By.Id("PF_142")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("88888888"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_143")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_144")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_160")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_161")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Large Numeric = 123456123456");
                {
                    string value = driver.FindElement(By.Id("1-PF_157")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456"));
                }
                Console.WriteLine("Verifiy Large Numeric = 9876543");
                {
                    string value = driver.FindElement(By.Id("1-PF_158")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("9876543"));
                }
                Console.WriteLine("Verifiy Large Numeric = 42423423423");
                {
                    string value = driver.FindElement(By.Id("1-PF_159")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("42423423423"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_162")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_163")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_173")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_174")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Large Numeric = 12312343");
                {
                    string value = driver.FindElement(By.Id("1-PF_170")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("12312343"));
                }
                Console.WriteLine("Verifiy Large Numeric = 23");
                {
                    string value = driver.FindElement(By.Id("1-PF_171")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("23"));
                }
                Console.WriteLine("Verifiy Large Numeric = 42423423423");
                {
                    string value = driver.FindElement(By.Id("1-PF_172")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("42423423423"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_175")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
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
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_196")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 10/21/1962");
                {
                    string value = driver.FindElement(By.Id("PF_189")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("10/21/1962"));
                }
                Console.WriteLine("Verifiy Date = 04/19/1988");
                {
                    string value = driver.FindElement(By.Id("PF_190")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("04/19/1988"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_197")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_198")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_208")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_209")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 01/10/2022");
                {
                    string value = driver.FindElement(By.Id("PF_202")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("01/10/2022"));
                }
                Console.WriteLine("Verifiy Date = 24/09/1974");
                {
                    string value = driver.FindElement(By.Id("PF_203")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("24/09/1974"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_210")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_211")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_221")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_222")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 10.01.2022");
                {
                    string value = driver.FindElement(By.Id("PF_215")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("10.01.2022"));
                }
                Console.WriteLine("Verifiy Date = 04.09.1974");
                {
                    string value = driver.FindElement(By.Id("PF_216")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("04.09.1974"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_223")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_224")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_234")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_235")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 20.01.2058");
                {
                    string value = driver.FindElement(By.Id("PF_228")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("20.01.2058"));
                }
                Console.WriteLine("Verifiy Date = 03.04.1906");
                {
                    string value = driver.FindElement(By.Id("PF_229")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("03.04.1906"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_236")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_237")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_245")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_246")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 1955-05-13 0:00:00");
                {
                    string value = driver.FindElement(By.Id("PF_239")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1955-05-13 0:00:00"));
                }
                Console.WriteLine("Verifiy Date = 1998-11-30 0:00:00");
                {
                    string value = driver.FindElement(By.Id("PF_247")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("1998-11-30 0:00:00"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_248")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_249")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_256")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_257")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = 06/01/2058");
                {
                    string value = driver.FindElement(By.Id("1-PF_259")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("06/01/2058"));
                }
                Console.WriteLine("Verifiy Date = 04/03/1906");
                {
                    string value = driver.FindElement(By.Id("1-PF_260")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("04/03/1906"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_261")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_262")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_268")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_269")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Date = Jan\\\\nFeb\\\\nMar\\\\nApr\\\\nMay\\\\nJun\\\\nJul\\\\nAug\\\\nSep\\\\nOct\\\\nNov\\\\nDec");
                //Assert.That(driver.FindElement(By.CssSelector("#PF_270 .ui-datepicker-month")).Text, Is.EqualTo("Jan\\\\nFeb\\\\nMar\\\\nApr\\\\nMay\\\\nJun\\\\nJul\\\\nAug\\\\nSep\\\\nOct\\\\nNov\\\\nDec"));
                Console.WriteLine("Verifiy Date = 1900\\\\n1901\\\\n1902\\\\n1903\\\\n1904\\\\n1905\\\\n1906\\\\n1907\\\\n1908\\\\n1909\\\\n1910\\\\n1911\\\\n1912\\\\n1913\\\\n1914\\\\n1915\\\\n1916\\\\n1917\\\\n1918\\\\n1919\\\\n1920\\\\n1921\\\\n1922\\\\n1923\\\\n1924\\\\n1925\\\\n1926\\\\n1927\\\\n1928\\\\n1929\\\\n1930\\\\n1931\\\\n1932\\\\n1933\\\\n1934\\\\n1935\\\\n1936\\\\n1937\\\\n1938\\\\n1939\\\\n1940\\\\n1941\\\\n1942\\\\n1943\\\\n1944\\\\n1945\\\\n1946\\\\n1947\\\\n1948\\\\n1949\\\\n1950\\\\n1951\\\\n1952\\\\n1953\\\\n1954\\\\n1955\\\\n1956\\\\n1957\\\\n1958\\\\n1959\\\\n1960\\\\n1961\\\\n1962\\\\n1963\\\\n1964\\\\n1965\\\\n1966\\\\n1967\\\\n1968\\\\n1969\\\\n1970\\\\n1971\\\\n1972\\\\n1973\\\\n1974\\\\n1975\\\\n1976\\\\n1977\\\\n1978\\\\n1979\\\\n1980\\\\n1981\\\\n1982\\\\n1983\\\\n1984\\\\n1985\\\\n1986\\\\n1987\\\\n1988\\\\n1989\\\\n1990\\\\n1991\\\\n1992\\\\n1993\\\\n1994\\\\n1995\\\\n1996\\\\n1997\\\\n1998\\\\n1999\\\\n2000\\\\n2001\\\\n2002\\\\n2003\\\\n2004\\\\n2005\\\\n2006\\\\n2007\\\\n2008\\\\n2009\\\\n2010\\\\n2011\\\\n2012\\\\n2013\\\\n2014\\\\n2015\\\\n2016\\\\n2017\\\\n2018\\\\n2019\\\\n2020\\\\n2021\\\\n2022\\\\n2023\\\\n2024\\\\n2025\\\\n2026\\\\n2027\\\\n2028\\\\n2029\\\\n2030\\\\n2031\\\\n2032\\\\n2033\\\\n2034\\\\n2035\\\\n2036\\\\n2037\\\\n2038\\\\n2039\\\\n2040\\\\n2041\\\\n2042\\\\n2043\\\\n2044\\\\n2045\\\\n2046\\\\n2047\\\\n2048\\\\n2049\\\\n2050\\\\n2051\\\\n2052\\\\n2053\\\\n2054\\\\n2055\\\\n2056\\\\n2057\\\\n2058\\\\n2059\\\\n2060\\\\n2061\\\\n2062\\\\n2063\\\\n2064\\\\n2065\\\\n2066\\\\n2067\\\\n2068\\\\n2069\\\\n2070\\\\n2071\\\\n2072\\\\n2073\\\\n2074\\\\n2075\\\\n2076\\\\n2077\\\\n2078\\\\n2079\\\\n2080\\\\n2081\\\\n2082\\\\n2083\\\\n2084\\\\n2085\\\\n2086\\\\n2087\\\\n2088\\\\n2089\\\\n2090\\\\n2091\\\\n2092\\\\n2093\\\\n2094\\\\n2095\\\\n2096\\\\n2097\\\\n2098\\\\n2099\\\\n2100");
                //Assert.That(driver.FindElement(By.CssSelector("#PF_270 .ui-datepicker-year")).Text, Is.EqualTo("1900\\\\n1901\\\\n1902\\\\n1903\\\\n1904\\\\n1905\\\\n1906\\\\n1907\\\\n1908\\\\n1909\\\\n1910\\\\n1911\\\\n1912\\\\n1913\\\\n1914\\\\n1915\\\\n1916\\\\n1917\\\\n1918\\\\n1919\\\\n1920\\\\n1921\\\\n1922\\\\n1923\\\\n1924\\\\n1925\\\\n1926\\\\n1927\\\\n1928\\\\n1929\\\\n1930\\\\n1931\\\\n1932\\\\n1933\\\\n1934\\\\n1935\\\\n1936\\\\n1937\\\\n1938\\\\n1939\\\\n1940\\\\n1941\\\\n1942\\\\n1943\\\\n1944\\\\n1945\\\\n1946\\\\n1947\\\\n1948\\\\n1949\\\\n1950\\\\n1951\\\\n1952\\\\n1953\\\\n1954\\\\n1955\\\\n1956\\\\n1957\\\\n1958\\\\n1959\\\\n1960\\\\n1961\\\\n1962\\\\n1963\\\\n1964\\\\n1965\\\\n1966\\\\n1967\\\\n1968\\\\n1969\\\\n1970\\\\n1971\\\\n1972\\\\n1973\\\\n1974\\\\n1975\\\\n1976\\\\n1977\\\\n1978\\\\n1979\\\\n1980\\\\n1981\\\\n1982\\\\n1983\\\\n1984\\\\n1985\\\\n1986\\\\n1987\\\\n1988\\\\n1989\\\\n1990\\\\n1991\\\\n1992\\\\n1993\\\\n1994\\\\n1995\\\\n1996\\\\n1997\\\\n1998\\\\n1999\\\\n2000\\\\n2001\\\\n2002\\\\n2003\\\\n2004\\\\n2005\\\\n2006\\\\n2007\\\\n2008\\\\n2009\\\\n2010\\\\n2011\\\\n2012\\\\n2013\\\\n2014\\\\n2015\\\\n2016\\\\n2017\\\\n2018\\\\n2019\\\\n2020\\\\n2021\\\\n2022\\\\n2023\\\\n2024\\\\n2025\\\\n2026\\\\n2027\\\\n2028\\\\n2029\\\\n2030\\\\n2031\\\\n2032\\\\n2033\\\\n2034\\\\n2035\\\\n2036\\\\n2037\\\\n2038\\\\n2039\\\\n2040\\\\n2041\\\\n2042\\\\n2043\\\\n2044\\\\n2045\\\\n2046\\\\n2047\\\\n2048\\\\n2049\\\\n2050\\\\n2051\\\\n2052\\\\n2053\\\\n2054\\\\n2055\\\\n2056\\\\n2057\\\\n2058\\\\n2059\\\\n2060\\\\n2061\\\\n2062\\\\n2063\\\\n2064\\\\n2065\\\\n2066\\\\n2067\\\\n2068\\\\n2069\\\\n2070\\\\n2071\\\\n2072\\\\n2073\\\\n2074\\\\n2075\\\\n2076\\\\n2077\\\\n2078\\\\n2079\\\\n2080\\\\n2081\\\\n2082\\\\n2083\\\\n2084\\\\n2085\\\\n2086\\\\n2087\\\\n2088\\\\n2089\\\\n2090\\\\n2091\\\\n2092\\\\n2093\\\\n2094\\\\n2095\\\\n2096\\\\n2097\\\\n2098\\\\n2099\\\\n2100"));
                Console.WriteLine("Verifiy Date = Jan\\\\nFeb\\\\nMar\\\\nApr\\\\nMay\\\\nJun\\\\nJul\\\\nAug\\\\nSep\\\\nOct\\\\nNov\\\\nDec");
                //Assert.That(driver.FindElement(By.CssSelector("#PF_271 .ui-datepicker-month")).Text, Is.EqualTo("Jan\\\\nFeb\\\\nMar\\\\nApr\\\\nMay\\\\nJun\\\\nJul\\\\nAug\\\\nSep\\\\nOct\\\\nNov\\\\nDec"));
                Console.WriteLine("Verifiy Date = 1900\\\\n1901\\\\n1902\\\\n1903\\\\n1904\\\\n1905\\\\n1906\\\\n1907\\\\n1908\\\\n1909\\\\n1910\\\\n1911\\\\n1912\\\\n1913\\\\n1914\\\\n1915\\\\n1916\\\\n1917\\\\n1918\\\\n1919\\\\n1920\\\\n1921\\\\n1922\\\\n1923\\\\n1924\\\\n1925\\\\n1926\\\\n1927\\\\n1928\\\\n1929\\\\n1930\\\\n1931\\\\n1932\\\\n1933\\\\n1934\\\\n1935\\\\n1936\\\\n1937\\\\n1938\\\\n1939\\\\n1940\\\\n1941\\\\n1942\\\\n1943\\\\n1944\\\\n1945\\\\n1946\\\\n1947\\\\n1948\\\\n1949\\\\n1950\\\\n1951\\\\n1952\\\\n1953\\\\n1954\\\\n1955\\\\n1956\\\\n1957\\\\n1958\\\\n1959\\\\n1960\\\\n1961\\\\n1962\\\\n1963\\\\n1964\\\\n1965\\\\n1966\\\\n1967\\\\n1968\\\\n1969\\\\n1970\\\\n1971\\\\n1972\\\\n1973\\\\n1974\\\\n1975\\\\n1976\\\\n1977\\\\n1978\\\\n1979\\\\n1980\\\\n1981\\\\n1982\\\\n1983\\\\n1984\\\\n1985\\\\n1986\\\\n1987\\\\n1988\\\\n1989\\\\n1990\\\\n1991\\\\n1992\\\\n1993\\\\n1994\\\\n1995\\\\n1996\\\\n1997\\\\n1998\\\\n1999\\\\n2000\\\\n2001\\\\n2002\\\\n2003\\\\n2004\\\\n2005\\\\n2006\\\\n2007\\\\n2008\\\\n2009\\\\n2010\\\\n2011\\\\n2012\\\\n2013\\\\n2014\\\\n2015\\\\n2016\\\\n2017\\\\n2018\\\\n2019\\\\n2020\\\\n2021\\\\n2022\\\\n2023\\\\n2024\\\\n2025\\\\n2026\\\\n2027\\\\n2028\\\\n2029\\\\n2030\\\\n2031\\\\n2032\\\\n2033\\\\n2034\\\\n2035\\\\n2036\\\\n2037\\\\n2038\\\\n2039\\\\n2040\\\\n2041\\\\n2042\\\\n2043\\\\n2044\\\\n2045\\\\n2046\\\\n2047\\\\n2048\\\\n2049\\\\n2050\\\\n2051\\\\n2052\\\\n2053\\\\n2054\\\\n2055\\\\n2056\\\\n2057\\\\n2058\\\\n2059\\\\n2060\\\\n2061\\\\n2062\\\\n2063\\\\n2064\\\\n2065\\\\n2066\\\\n2067\\\\n2068\\\\n2069\\\\n2070\\\\n2071\\\\n2072\\\\n2073\\\\n2074\\\\n2075\\\\n2076\\\\n2077\\\\n2078\\\\n2079\\\\n2080\\\\n2081\\\\n2082\\\\n2083\\\\n2084\\\\n2085\\\\n2086\\\\n2087\\\\n2088\\\\n2089\\\\n2090\\\\n2091\\\\n2092\\\\n2093\\\\n2094\\\\n2095\\\\n2096\\\\n2097\\\\n2098\\\\n2099\\\\n2100");
                //Assert.That(driver.FindElement(By.CssSelector("#PF_271 .ui-datepicker-year")).Text, Is.EqualTo("1900\\\\n1901\\\\n1902\\\\n1903\\\\n1904\\\\n1905\\\\n1906\\\\n1907\\\\n1908\\\\n1909\\\\n1910\\\\n1911\\\\n1912\\\\n1913\\\\n1914\\\\n1915\\\\n1916\\\\n1917\\\\n1918\\\\n1919\\\\n1920\\\\n1921\\\\n1922\\\\n1923\\\\n1924\\\\n1925\\\\n1926\\\\n1927\\\\n1928\\\\n1929\\\\n1930\\\\n1931\\\\n1932\\\\n1933\\\\n1934\\\\n1935\\\\n1936\\\\n1937\\\\n1938\\\\n1939\\\\n1940\\\\n1941\\\\n1942\\\\n1943\\\\n1944\\\\n1945\\\\n1946\\\\n1947\\\\n1948\\\\n1949\\\\n1950\\\\n1951\\\\n1952\\\\n1953\\\\n1954\\\\n1955\\\\n1956\\\\n1957\\\\n1958\\\\n1959\\\\n1960\\\\n1961\\\\n1962\\\\n1963\\\\n1964\\\\n1965\\\\n1966\\\\n1967\\\\n1968\\\\n1969\\\\n1970\\\\n1971\\\\n1972\\\\n1973\\\\n1974\\\\n1975\\\\n1976\\\\n1977\\\\n1978\\\\n1979\\\\n1980\\\\n1981\\\\n1982\\\\n1983\\\\n1984\\\\n1985\\\\n1986\\\\n1987\\\\n1988\\\\n1989\\\\n1990\\\\n1991\\\\n1992\\\\n1993\\\\n1994\\\\n1995\\\\n1996\\\\n1997\\\\n1998\\\\n1999\\\\n2000\\\\n2001\\\\n2002\\\\n2003\\\\n2004\\\\n2005\\\\n2006\\\\n2007\\\\n2008\\\\n2009\\\\n2010\\\\n2011\\\\n2012\\\\n2013\\\\n2014\\\\n2015\\\\n2016\\\\n2017\\\\n2018\\\\n2019\\\\n2020\\\\n2021\\\\n2022\\\\n2023\\\\n2024\\\\n2025\\\\n2026\\\\n2027\\\\n2028\\\\n2029\\\\n2030\\\\n2031\\\\n2032\\\\n2033\\\\n2034\\\\n2035\\\\n2036\\\\n2037\\\\n2038\\\\n2039\\\\n2040\\\\n2041\\\\n2042\\\\n2043\\\\n2044\\\\n2045\\\\n2046\\\\n2047\\\\n2048\\\\n2049\\\\n2050\\\\n2051\\\\n2052\\\\n2053\\\\n2054\\\\n2055\\\\n2056\\\\n2057\\\\n2058\\\\n2059\\\\n2060\\\\n2061\\\\n2062\\\\n2063\\\\n2064\\\\n2065\\\\n2066\\\\n2067\\\\n2068\\\\n2069\\\\n2070\\\\n2071\\\\n2072\\\\n2073\\\\n2074\\\\n2075\\\\n2076\\\\n2077\\\\n2078\\\\n2079\\\\n2080\\\\n2081\\\\n2082\\\\n2083\\\\n2084\\\\n2085\\\\n2086\\\\n2087\\\\n2088\\\\n2089\\\\n2090\\\\n2091\\\\n2092\\\\n2093\\\\n2094\\\\n2095\\\\n2096\\\\n2097\\\\n2098\\\\n2099\\\\n2100"));

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_272")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
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
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_287")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Special Characters = ASD");
                {
                    string value = driver.FindElement(By.Id("PF_288")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ASD"));
                }
                Console.WriteLine("Verifiy Special Characters = 123456aa");
                {
                    string value = driver.FindElement(By.Id("PF_289")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456aa"));
                }
                Console.WriteLine("Verifiy Special Characters = 32$$%");
                {
                    string value = driver.FindElement(By.Id("PF_290")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("32$$%"));
                }
                Console.WriteLine("Verifiy Special Characters = A@E$%1");
                {
                    string value = driver.FindElement(By.Id("PF_291")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("A@E$%1"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_292")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_293")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_310")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_312")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Special Characters = ASD");
                {
                    string value = driver.FindElement(By.Id("PF_313")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ASD"));
                }
                Console.WriteLine("Verifiy Special Characters = 123456aa");
                {
                    string value = driver.FindElement(By.Id("PF_314")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456aa"));
                }
                Console.WriteLine("Verifiy Special Characters = 32$$%");
                {
                    string value = driver.FindElement(By.Id("PF_315")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("32$$%"));
                }
                Console.WriteLine("Verifiy Special Characters = A@E$%1");
                {
                    string value = driver.FindElement(By.Id("PF_316")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("A@E$%1"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_317")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_318")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_330")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_331")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Special Characters = ASD");
                {
                    string value = driver.FindElement(By.Id("1-PF_333")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ASD"));
                }
                Console.WriteLine("Verifiy Special Characters = 123456aa");
                {
                    string value = driver.FindElement(By.Id("1-PF_334")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456aa"));
                }
                Console.WriteLine("Verifiy Special Characters = 32$$%");
                {
                    string value = driver.FindElement(By.Id("1-PF_335")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("32$$%"));
                }
                Console.WriteLine("Verifiy Special Characters = A@E$%1");
                {
                    string value = driver.FindElement(By.Id("1-PF_336")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("A@E$%1"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_337")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
                driver.FindElement(By.Id("PF_338")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Click Insert");
                driver.FindElement(By.Id("PF_345")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Show Values");
                driver.FindElement(By.Id("PF_346")).Click();
                Thread.Sleep(2000);

                Console.WriteLine("Verifiy Special Characters = ASD");
                {
                    string value = driver.FindElement(By.Id("1-PF_348")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("ASD"));
                }
                Console.WriteLine("Verifiy Special Characters = 123456aa");
                {
                    string value = driver.FindElement(By.Id("1-PF_349")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("123456aa"));
                }
                Console.WriteLine("Verifiy Special Characters = 32$$%");
                {
                    string value = driver.FindElement(By.Id("1-PF_350")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("32$$%"));
                }
                Console.WriteLine("Verifiy Special Characters = A@E$%1");
                {
                    string value = driver.FindElement(By.Id("1-PF_351")).GetAttribute("value");
                    Assert.That(value, Is.EqualTo("A@E$%1"));
                }

                Console.WriteLine("Click Delete");
                driver.FindElement(By.Id("PF_352")).Click();
                Thread.Sleep(2000);
                Console.WriteLine("Click Verify Delete");
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
