using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.infra.dl
{
    public interface IRanorexUIElement
    {
        string rootLocator { get; }

        RanorexDriver getDriver();
    }
}
