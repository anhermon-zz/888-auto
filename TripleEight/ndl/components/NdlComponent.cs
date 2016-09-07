using com.tripleEigth.auto.ndl.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.tripleEigth.auto.infra;

namespace com.tripleEigth.auto.ndl.components
{
    public class NdlComponent
    {
        protected SeleniumDriver driver;
        protected string rootLocator;

        public NdlComponent(SeleniumPageObject page)
        {
            this.driver = (SeleniumDriver) page.driver;
        }
        public NdlComponent(SeleniumPageObject page, string rootLocator) : this(page)
        {
            this.rootLocator = rootLocator;
        }
        public NdlComponent(NdlComponent component)
        {
            this.driver = (SeleniumDriver)component.driver;
            this.rootLocator = component.rootLocator;
        }
        public NdlComponent(NdlComponent component, string locatorSuffix) : this(component)
        {
            this.rootLocator += locatorSuffix;
        }
    }
}
