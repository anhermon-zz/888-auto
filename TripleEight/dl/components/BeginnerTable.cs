using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ranorex;
using com.tripleEigth.auto.infra.dl.pages;
using com.tripleEigth.auto.dl.pages;

namespace com.tripleEigth.auto.infra.dl.components
{
    public class DnBeginnerTable : RanorexComponent
    {
        /**
        * Selectors 
        **/
        protected string btnSelector = "//button[@text='Play now']";

        public DnPokerTable clickBtn()
        {
            Host.Local.FindSingle<Button>(getLocator(btnSelector)).Click();
            return new DnPokerTable(parent.getDriver());
        }
        public DnBeginnerTable(RanorexPageObject parent, int n) : base(parent)
        {
            this.rootLocator = String.Format("//container[@name='tabBeginners']/button[{0}]", n);

        }
    }
}
