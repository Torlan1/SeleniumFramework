using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFramework.Helpers
{
    public class GooglePageObjects
    {
        [FindsBy(How = How.Name, Using = "btnk")]
        public IWebElement SearchBtn { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input[title='Search']")]
        public IWebElement SearchField { get; set; }

        public void Search()
        {
            SearchField.SendKeys("Hello");
            SearchBtn.Click();
        }
    }
}
