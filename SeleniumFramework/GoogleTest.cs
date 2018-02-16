using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using SeleniumFramework.Helpers;
using SeleniumFramework.Core;

namespace SeleniumFramework
{
    public class GoogleTest : TestBase
    {

        Navigation navigation = new Navigation();
        GooglePageObjects po = new GooglePageObjects();
  
        [Test]
        public void GoodTest()
        {
            navigation.GoToBaseUrl();          
        }
    }
}
