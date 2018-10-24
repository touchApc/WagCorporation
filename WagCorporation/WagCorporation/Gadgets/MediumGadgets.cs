using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets
{
    public class MediumGadgets : Gadgets, IGadgets
    {
        public void SetButtonNum()
        {
            while (Buttons < 2)
            {
                Console.WriteLine("Ask the customer How many buttons do you want greater than 2?");
                String sButtons = Console.ReadLine();
                Buttons = int.Parse(sButtons);
            }
        }
        
        public void SetSwitchNum()
        {
            throw new NotImplementedException();
        }
    }
}
