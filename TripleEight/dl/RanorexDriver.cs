using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ranorex;

namespace com.tripleEigth.auto.infra.dl
{
    public class RanorexDriver : IDriver
    {
        public void Click(string selector)
        {
            if (selector.Contains("tabpage"))
            {
                Host.Local.FindSingle<TabPage>(selector).Click();
            } else if(selector.Contains("button"))
            {
                Host.Local.FindSingle<Button>(selector).Click();
            } 
        }
    }
}
