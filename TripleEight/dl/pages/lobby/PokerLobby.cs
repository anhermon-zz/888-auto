using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;
using com.tripleEigth.auto.dl.pages;

namespace com.tripleEigth.auto.infra.dl.pages
{
    public class DnPokerLobby : RanorexPageObject
    {

        public DnPokerLobby(RanorexDriver driver) : base(driver)
        {
            rootLocator = getAppRefByName("MainWindowWin");
        }
    }
}
