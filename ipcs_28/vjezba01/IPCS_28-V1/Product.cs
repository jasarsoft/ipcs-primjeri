using System;
using System.Text;


namespace IPCS_28_V1
{
    //klasa proizvod
    abstract class Product
    {
        //deklaracija promjenljivih
        public int type;
        public string name;
        public double price;
        public string[] additions;

        public abstract double CountPrice();

        public override string ToString()
        {
            //obzirom da se vrzi konkatinacija stringa, najefikasnija varijanta je koristenje klase StringBuilder
            StringBuilder output = new StringBuilder();

            //dodaju se podaci o proizvodu
            //this.naziv ce biti dodjeljen u konstruktoru
            //takodje i cijna ce biti dodjeljna u konstruktoru, ali se ona ne ispisuje direktno vec obradjuje kroz metod izracunaj cijenu
            //(ovaj metod ce biti kasnije napisan na nivou dijete klase, jer svaka dijete klasa ima sopstvenu stopu poreza)
            output.Append("Proizvod: ");
            output.Append(this.name + ", ");
            output.Append("cijena: " + CountPrice() + ", ");
            output.Append("dodaci: " + AllAdditions());

            return output.ToString();
        }

        //metod za prikaz svih dodataka
        public string AllAdditions()
        {
            //i u ovom slucaju postojace vjerovatno konkatinacija stringa pa se koristi string builder
            StringBuilder output = new StringBuilder();

            //prolazi se kroz listu dodataka, for petljom
            //sve dok clan liste nije null, promjeljivoj izlaz se dodaje clan liste sa dodatom oznakom ,
            for (int i = 0; i < this.additions.Length; i++)
            {
                if (this.additions[i] != null) 
                    output.Append(this.additions[i] + ", ");
            }

            //na kraju, potrebno je skinuti posljednji zarez i ukoliko nema dodataka
            //napisati poruku: bez dodataka
            if (output.ToString() != "")
            {
                if (output.ToString().Trim().EndsWith(",")) 
                    output.Remove(output.Length - 2, 2);
            }
            else
                output.Append("bez dodatka");

            return output.ToString();
        }


        public void Addition(string addition)
        {
            //prolazi se kroz listu dodataka sve do prvog nepostojeceg clana (null)
            //u nepostojeceg clana, smejsta se vrijednost i prekida se petlja
            for (int i = 0; i < this.additions.Length; i++)
            {
                if (this.additions[i] == null)
                {
                    this.additions[i] = addition;
                    break;
                }
            }
        }
    }
}
