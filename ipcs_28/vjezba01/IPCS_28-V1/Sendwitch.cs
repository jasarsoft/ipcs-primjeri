using System;


namespace IPCS_28_V1
{
    //klasa sendvic nasljedjuje klasu proizvod
    class Sendwitch : Product
    {
        public Sendwitch(string name, double price)
        {
            //dodjeljuju se parametri kroz konstruktor
            this.additions = new string[10];
            this.name = name;
            this.price = price;
        }

        public override double CountPrice()
        {
 	        //izracunava se cijena prizvoda sa porezom 15%
            return this.price + this.price * 0.15;
        }
    }
}
