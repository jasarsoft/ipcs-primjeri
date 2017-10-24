using System;


namespace IPCS_27_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.firstName = "Peter";
            s.indexNumber = "25/10";

            Console.WriteLine(s.firstName);
            Console.WriteLine(s.indexNumber);

            s.Show();


            Professor p = new Professor();
            p.firstName = "Sally";
            p.className = "Programming";
            p.Show();
        }
    }
}
