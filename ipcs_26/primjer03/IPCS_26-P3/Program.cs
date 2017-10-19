using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPCS_26_P3
{
    class Program
    {
        //method paintCar mjenja polje kalse color
        static void paintCar()
        {
            Car.color = "blue";
        }

        static void Main(string[] args)
        {
            //poziva se metod paintCar
            paintCar();
            //prikazije se trenutna vrijednost polja color klase Car
            Console.WriteLine(Car.color);
        }
    }
}
