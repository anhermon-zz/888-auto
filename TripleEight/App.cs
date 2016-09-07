using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;
using com.tripleEigth.auto.infra.dl.pages;
using com.tripleEigth.auto.infra.dl;

namespace TripleEight
{
    class App
    {
        [STAThread]
        static void Main(String[] args)
        {
            DnPokerLobbyBeginners pokerLobbyBeginners = new DnPokerLobbyBeginners(new RanorexDriver());
            DnPokerLobbyAllGames pokerLobbyAllGames = pokerLobbyBeginners.tabs.clickAllGamesTab();
            DnPokerLobbyMyFavorites pokerLobbyMyFavorites = pokerLobbyAllGames.tabs.clickMyFavoritesTab();
            pokerLobbyBeginners = pokerLobbyMyFavorites.tabs.clickBeginnersTab();
            //PokerTable table = pokerLobbyBeginners.getNthTable(1).clickBtn();
            //table.minimize();

        }
        
    }
}
