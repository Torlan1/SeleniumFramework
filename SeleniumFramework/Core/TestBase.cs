using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;
using System.Threading.Tasks;
using TestContext = NUnit.Framework.TestContext;
using TestStatus = NUnit.Framework.Interfaces.TestStatus;

namespace SeleniumFramework.Core
{
    public class TestBase
    {
        ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        
        public enum Browser
        {
            Firefox,
            Chrome,
            IE
        }

        public ThreadLocal<IWebDriver> LaunchBrowser(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    driver.Value =  new ChromeDriver();
                    break;
                case Browser.Firefox:
                    driver.Value = new FirefoxDriver();
                    break;
                case Browser.IE:
                    driver.Value = new InternetExplorerDriver();
                    break;
                default:
                    driver.Value = new ChromeDriver();
                    break;
            }
            return driver;
        }

        public void OpenPage(string url)
        {
            driver.Value.Navigate().GoToUrl(url);
        }


        public void GetStackTrace()
        {
            var stackTrace = new StackTrace();
            var stackFrames = stackTrace.GetFrames();
            var status = TestContext.CurrentContext.Result.Outcome;
            var testName = TestContext.CurrentContext.Test.MethodName;
            var stack = TestContext.CurrentContext.Result.StackTrace;
        }
    }
}
