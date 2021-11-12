using System;
using System.Collections.Generic;
using System.Text;

namespace PairNumber

{
    class Fraction : Pair
    {
        protected int _integerNumber;// целая часть
        protected int _decimalNumber;// дробная часть

        public Fraction( int initFirst, int initSecond): base (initFirst, initSecond)
        {
            _integerNumber = initFirst;
            _decimalNumber = initSecond;
        }

        public int IntegerNumber
        {
            get
            {
                return _integerNumber;
            }
            set
            {
                _integerNumber = value;
            }
        }

        public int DecimalNumber
        {
            get
            {
                return _decimalNumber;
            }
            set
            {
                _decimalNumber = value;
            }
        }
        
        public int Compare (Fraction value)
        {
            if (IntegerNumber == value.IntegerNumber && DecimalNumber == value.DecimalNumber) return 0;
            else
            if (IntegerNumber > value.IntegerNumber || (IntegerNumber == value.IntegerNumber && DecimalNumber > value.DecimalNumber)) return 1;
            else return -1;
        }
    }
    
}
