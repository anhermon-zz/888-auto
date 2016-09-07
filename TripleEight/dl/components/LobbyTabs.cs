using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;
using com.tripleEigth.auto.infra.dl.pages;

namespace com.tripleEigth.auto.infra.dl.components
{
    public class LobbyTabs : RanorexComponent
    {
        protected string beginnersTabLocator = "//tabpage[@title='Beginners']";
        protected string quickSeatTabLocator = "//tabpage[@title = 'Quick seat']";
        protected string allGamesTabLocator = "//tabpage[@title = 'All games']";
        protected string myFavouritesTabLocator = "//tabpage[@title = 'My favourites']";
        protected string snapTabLocator = "//tabpage[@index = '4']";
        protected string blastTabLocator = "//tabpage[@index = '5']";
        public LobbyTabs(IRanorexUIElement parent) : base(parent) { }


        public DnPokerLobbyBeginners clickBeginnersTab()
        {
            driver.Click(getLocator(beginnersTabLocator));
            return new DnPokerLobbyBeginners(driver);
        }
        public DnPokerLobbyQuickSeat clickQuickSeatTab()
        {
            driver.Click(getLocator(quickSeatTabLocator));
            return new DnPokerLobbyQuickSeat(driver);
        }
        public DnPokerLobbyAllGames clickAllGamesTab()
        {
            driver.Click(getLocator(allGamesTabLocator));
            return new DnPokerLobbyAllGames(driver);
        }
        public DnPokerLobbyMyFavorites clickMyFavoritesTab()
        {
            driver.Click(getLocator(myFavouritesTabLocator));
            return new DnPokerLobbyMyFavorites(driver);
        }
        public DnPokerLobbySnap clickSnapTab()
        {
            driver.Click(getLocator(snapTabLocator));
            return new DnPokerLobbySnap(driver);
        }
        public DnPokerLobbyBlast clickBlastTab()
        {
            driver.Click(getLocator(blastTabLocator));
            return new DnPokerLobbyBlast(driver);
        }
    }
}
