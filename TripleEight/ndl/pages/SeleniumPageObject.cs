using com.tripleEigth.auto.ndl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.ndl.pages
{
    public class SeleniumPageObject : AbstractPageObject
    {
        private String url;
        public SeleniumPageObject(SeleniumDriver driver) : base(driver) { }
        public SeleniumPageObject(SeleniumDriver driver, string url) : base(driver) {
            this.url = url;
        }
        public SeleniumDriver getDriver()
        {
            return (SeleniumDriver)this.driver;
        }

        public SeleniumPageObject Navigate( )
        {
            getDriver().Navigate(url);
            return this;
        }
        public void Close()
        {
            getDriver().Close();
        }
    }
}
