using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.infra.dl.components
{
    public class RanorexComponent : IRanorexUIElement
    {
        public RanorexDriver driver { get; set; }
        protected IRanorexUIElement parent;

        protected RanorexComponent(IRanorexUIElement parent)
        {
            this.parent = parent;
            driver = parent.getDriver();
        }

        public RanorexDriver getDriver()
        {
            return this.driver;
        }

        private string _rootLocator;
        public string rootLocator
        {
            get
            {
                return this._rootLocator;
            }
            set
            {
                this._rootLocator = String.Format("{0}{1}", this.parent.rootLocator, value);
            }
        }

        protected string getLocator(string locator)
        {
            return String.Format("{0}{1}", this.rootLocator, locator);
        }

    }
}
