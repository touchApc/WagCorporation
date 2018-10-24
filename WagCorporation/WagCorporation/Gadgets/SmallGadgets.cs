using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class SmallGadgets : Gadgets, IGadgets
    {
        public void SetButtonNum()
        {
            Buttons = 2;
        }

        public void SetSwitchNum()
        {
            Switch = 1;
        }
    }
}
