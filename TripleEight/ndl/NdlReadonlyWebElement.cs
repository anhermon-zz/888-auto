using com.tripleEigth.auto.ndl;
using OpenQA.Selenium.Html5;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.ndl
{
    public class NdlReadonlyWebElement
    {
        private SeleniumDriver driver;
        private string locator;

        public NdlReadonlyWebElement(SeleniumDriver driver, string locator)
        {
            this.driver = driver;
            this.locator = locator;
        }

        public Point getLocation(int timeout = 5)
        {
            return this.driver.FindElement(locator, timeout).Location;
        }
        public Size getsize(int timeout = 5)
        {
            return this.driver.FindElement(locator, timeout).Size;
        }
        public bool exists(int timeout = 5)
        {
            return this.driver.Exists(locator, timeout);
        }


    }
}
