using com.tripleEigth.auto.infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace com.tripleEigth.auto.ndl
{
    public class SeleniumDriver : IDriver
    {

        private IWebDriver driver;
        private const int defaultTimeout = 1;
        public SeleniumDriver()
        {
            this.driver = new FirefoxDriver();
            this.driver.Manage().Window.Maximize();
        }
        public SeleniumDriver(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement FindElement(string selector)
        {
            return FindElement(selector, defaultTimeout);
        }

        public IWebElement FindElement(string selector, int timeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Math.Max(timeout, 0)));
            return wait.Until(drv => drv.FindElement(By.XPath(selector)));
        }

        public bool Exists(string selector, int timeout = defaultTimeout)
        {
            try
            {
                this.FindElement(selector, timeout);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Click(string selector, int timeout, Boolean optional = false)
        {
            if (optional && ! Exists(selector, timeout))
            {
                return;
            }
            IWebElement element = FindElement(selector, timeout);
            element.Click();
        }
        public void Click(string selector)
        {
            Click(selector, defaultTimeout);
        }

        public void Type(string selector, string text)
        {
            IWebElement element = FindElement(selector);
            element.Clear();
            element.SendKeys(text);
        }
        public string GetAttribute(string selector, string attribute)
        {
            IWebElement element = FindElement(selector);
            return element.GetAttribute(attribute);
        }
        public string GetText(string selector)
        {
            IWebElement element = FindElement(selector);
            return element.Text;
        }
        public SeleniumDriver Navigate(string url)
        {
            driver.Url = url;
            return this;
        }

        public void Close()
        {
            driver.Close();
        }
    }
}
