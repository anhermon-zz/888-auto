using com.tripleEigth.auto.ndl.components;
using com.tripleEigth.auto.ndl.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.ndl.pages.lobby
{
    public class NdlLobbyPage : SeleniumPageObject
    {
        public NdlLobbyTopBar lobbyTopBar;
        public NdlPopup popup;

        public NdlLobbyPage(SeleniumDriver driver) : base(driver){
            lobbyTopBar = new NdlLobbyTopBar(this);
            popup = new NdlPopup(this);
        }

    }
}
