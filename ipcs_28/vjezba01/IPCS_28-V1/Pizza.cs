using System;

namespace IPCS_28_V1
{
    //klasa pica, nasljedjuje kalsu prizvod
    class Pizza : Product
    {
        public Pizza(string name, double price)
        {
            //dodjeljuju se parametri kroz konstruktor
            this.additions = new string[10];
            this.name = name;
            this.price = price;
        }


        public override double CountPrice()
        {
            //izracunava se cijena prizovda sa porezom od 10%
            return this.price + this.price * 0.1;
        }

    }
}
