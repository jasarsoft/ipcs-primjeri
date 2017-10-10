using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer3
{
    delegate void Example();
    class Program
    {
        static void Instructor()
        {
            Console.WriteLine("Zdravo! Zovem se Petra Petrovic i ja sam predavac!");
        }

        //dodali smo novu metodu details
        static void Details()
        {
            Console.WriteLine("Predajem u ovoj skoli 2 godine.");
        }

        static void Main(string[] args)
        {
            //instanciranje
            Example example;
            Example instr = Instructor;
            Example det = Details;

            //pravimo listu poziva metoda
            example = instr;
            example += det;

            //poziv multikasta
            example();
            Console.ReadKey();
        }
    }
}
