using com.tripleEigth.auto.ndl.components;
using com.tripleEigth.auto.ndl.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.ndl.components
{
    public class NdlPopup : NdlComponent
    {
        //message_cont bannerPopUp
        private const string closeBtn = "//div[@id='Cancel']";

        public NdlPopup(SeleniumPageObject page) : base(page, "//div[contains(@class, 'bannerPopUp')]") { }

        public void ClickCloseBtn()
        {
            this.driver.Click(this.rootLocator + closeBtn, 10, true);
        }
    }
}
