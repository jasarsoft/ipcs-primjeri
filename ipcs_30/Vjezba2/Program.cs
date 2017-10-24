using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            //pozivamo metodu Read okja sadrzi implementaciju get metode
            Exam e = Exam.Read();
            
            //postosmo set metodu implementirali u ovoj metodi klase Exam, sada samo pozivamo metodu
            Exam.Write(e);

        }
    }
}
