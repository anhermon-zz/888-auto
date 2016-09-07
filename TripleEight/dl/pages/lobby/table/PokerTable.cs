using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;
using com.tripleEigth.auto.dl.pages;

namespace com.tripleEigth.auto.infra.dl.pages
{
    public class DnPokerTable : RanorexPageObject
    {
        public DnPokerTable(RanorexDriver driver) : base(driver)
        {
            rootLocator = getAppRefByName("PokerTableDlg");
            string tempLocator = "";
            //get last table
            int i = 0;
            while ( i++ < 30 )
            {
                try
                {
                    Host.Local.FindSingle<Form>(String.Format("{0}[{1}]", rootLocator, i));
                } catch(Exception e)
                { 
                    tempLocator = String.Format("{0}[{1}]", rootLocator, i);
                    break;
                }
            }
            Form table = Host.Local.FindSingle<Form>(tempLocator);
            String title = table.GetAttributeValue<string>("title");
            rootLocator = String.Format("{0}[@title={1}]", rootLocator, title);

        }
    }
}
