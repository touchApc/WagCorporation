using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagCorporation
{
    public class Painted
    {
        public enum Paint { painted, plated, plain }
        float _ExPricePlated;

        public Paint paint
        {
            get
            {
                return paint;
            }
            set
            {
                paint = value;
            }


        }

        public float GetTotalPrice()
        {
            if ( paint == Paint.plated )
            {
                return _ExPricePlated;
            }
            else
            {
                return 0.0f;
            }
            
        }

        public bool getIsPlated()
        {
            if ( paint == Paint.plated )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
