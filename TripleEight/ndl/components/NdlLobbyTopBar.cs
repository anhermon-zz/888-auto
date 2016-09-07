using com.tripleEigth.auto.ndl.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.ndl.components
{
    public class NdlLobbyTopBar : NdlComponent
    {
        private const string myProfileTabLocator = "//div[text()='My Profile']";
        private const string extraGamesTabLocator = "//div[@class='extraGames']";
        private const string promotionsTabLocator = "//div[text()='Promotions']";  
        private const string settingsTabLocator = "//div[text()='Settings']";
        private const string helpTabLocator = "//div[text()='Help']";

        public NdlLobbyTopBar(SeleniumPageObject page) : base(page, "//header[@data-automationid='lobbyTopBar']") {}

        public void ClickMyProfileTab()
        {
            this.driver.Click(rootLocator + myProfileTabLocator, 5);
        }

        public void ClickExtraGamesTab()
        {
            this.driver.Click(rootLocator + extraGamesTabLocator, 5);
        }

        public void ClickPromotionsTab()
        {
            this.driver.Click(rootLocator + promotionsTabLocator, 5);
        }

        public void ClickSettingsTab()
        {
            this.driver.Click(rootLocator + settingsTabLocator, 5);
        }

        public void ClickHelpTab()
        {
            this.driver.Click(rootLocator + helpTabLocator, 5);
        }
    }
}
