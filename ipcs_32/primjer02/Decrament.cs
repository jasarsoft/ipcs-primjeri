using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer_2
{
    public class Decrament
    {
        public int X;


        //konstruktor bez parametara
        public Decrament() { }

        //kontrukotr sa parametrima za rezultat
        public Decrament(int i)
        {
            X = i;
        }

        //deklarisemo prekoracenje unarong operatora --
        //koji ima povratnu vrijednost Decarament
        //i koji ima jedan operand tipa Decrament
        public static Decrament operator --(Decrament op)
        {
            //umanjujemo vrijednost operanda za jedan
            //dobijenu vrijednost dodjeljujemo novom objektu tipa Decarament koji vracam
            return new Decrament(op.X - 1);
        }
    }
}
