using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.tripleEigth.auto.ndl.pages;
using com.tripleEigth.auto.ndl;
using com.tripleEigth.auto.ndl.pages.lobby;

namespace UnitTestProject1
{
    [TestClass]
    public class Sanity
    {

        [TestMethod]
        public void SeleniumSimpleTest()
        {
            SeleniumDriver driver = new SeleniumDriver();

            NdlLoginPage loginPage = new NdlLoginPage(driver);
            loginPage.Navigate();
            NdlLobbyPage lobby = loginPage.doLogin("testuser125", "test123");
            lobby.popup.ClickCloseBtn();
            lobby.lobbyTopBar.ClickMyProfileTab();
            lobby.lobbyTopBar.ClickSettingsTab();
            lobby.lobbyTopBar.ClickExtraGamesTab();
            lobby.lobbyTopBar.ClickPromotionsTab();
            lobby.Close();
        }
    }
}
