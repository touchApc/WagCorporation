using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagCorporation
{
    public class SerialNumber
    {
        private static volatile SerialNumber _iGadget = Instance;
        //Singleton Design Pattern used here
        public static SerialNumber Instance
        {
            get
            {
                if (Instance == null)
                {
                    SerialNumber SerialNumber = new SerialNumber();
                }

                return Instance;
            }
           
            //instance variables
            private int count;
            
            private SerialNumber()
            {
            }
            
            public virtual int NextSerial
            {
                get
                {
                    return ++count;
                }
            }

        }
    }
}
