using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer_2
{
    class TrueFalse
    {
        private int value;

        public TrueFalse(int val)
        {
            value = val;
        }


        //naravno ne mora biti konkretno ovaj izraz
        //moze biti bilo koji drugi izraz koji vraca vrijednost boolean tipa(true, false)
        public static bool operator true(TrueFalse arg1)
        {
            //medjutim i u true i u false deklaraciji operatora moraju biti suprotne vrijednosti
            //odnosno jedan ce da definise za koje vrijednosti ce metod operator +() da vraca true
            //a u false operatoru ce se nalaziti izraz koji definise za koje vrijednosti ce ova metoda da vraca vrijednsot false
            return arg1.value >= 0;
        }

        //naravno ne mora biti konkretno ovaj izraz
        //moze biti bilo koji drugi izraz koji vraca vrijednost boolean tipa
        public static bool operator false(TrueFalse arg1)
        {
            return arg1.value < 0;
        }

    }
}
