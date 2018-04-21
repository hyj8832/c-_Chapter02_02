using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class CSmartPhone
    {
        private string theMarket;
        public string theID;
        public CSmartPhone()
        {
            theMarket = "Google";
            theID = "Noname";
        }
        public virtual string GetMarket()
        {
            return theMarket;
        }
        public int GetButtonCount() //
        {
            return 1;
        }

    }
}
