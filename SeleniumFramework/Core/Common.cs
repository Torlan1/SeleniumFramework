using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Xml;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TestContext = NUnit.Framework.TestContext;

namespace SeleniumFramework.Core
{
    public class Common
    {
        public static string GetCurrentTestName()
        {
            string testName = "Test";
            try
            {
                testName = TestContext.CurrentContext.Test.FullName;
                if (string.IsNullOrEmpty(testName))
                {
                    testName = NUnit.Framework.TestContext.CurrentContext.Test.Name;
                }
            }
            catch (Exception e)
            {
                testName = "Test";
            }

            testName = Regex.Replace(testName, "[^a-zA-Z0-9%._]", string.Empty);
            return testName;
        }

        public static string GetShortTestName(int length)
        {
            var name = GetCurrentTestName();
            name = name.Replace("/", "_");
            name = name.Replace(":", "_");
            name = name.Replace("\\", "_");
            name = name.Replace("\"", string.Empty);
            name = name.Replace(" ", string.Empty);
            if (name.Length > length)
            {
                name = name.Substring(name.Length - length, length);
            }

            return name;
        }
    }
}
