using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;
using TripleEight;
using com.tripleEigth.auto.ndl;
using com.tripleEigth.auto.infra.dl;

namespace com.tripleEigth.auto.dl.pages
{
    /**
     *  Base Page Object
     **/
    public class RanorexPageObject : AbstractPageObject, IRanorexUIElement
    {
        public string rootLocator { get; set; }
        public RanorexDriver getDriver()
        {
            return (RanorexDriver) this.driver;
        }

        protected string minimizeLocator;
        protected RanorexPageObject(RanorexDriver driver) : base(driver)
        {
            this.rootLocator = rootLocator;
            minimizeLocator = getLocator("//button[@accessiblename='Minimize']");
        }
        protected string getAppRefByTitle(string title)
        {
            return String.Format("/form[@title='{0}']", title);
        }

        protected string getAppRefByName(string name)
        {
            return String.Format("/form[@name='{0}']", name);
        }

        protected string getLocator(string locator)
        {
            return String.Format("{0}{1}",this.rootLocator, locator);
        }

        protected void appendLocator(string locator)
        {
            locator = String.Format("{0}{1}", this.rootLocator, locator);
        }

        public void minimize()
        {
            Host.Local.FindSingle<Button>(getLocator(minimizeLocator)).Click();
        }
    }
}
