using com.tripleEigth.auto.infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.ndl
{
    public abstract class AbstractPageObject
    {
        public IDriver driver { get; set; }

        public AbstractPageObject(IDriver driver)
        {
            this.driver = driver;
        }
    }
}
