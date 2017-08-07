//primjer upotrebe IEnumerator-a
using System;
using System.Collections;

namespace primjer04
{
    //definisimo klasu Student, koja ce da sadrzi neke osnovne podatke
    //o studentu i format za ispisivanje tih podataka
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool PassedExam { get; set; }

        public Student(string name, int age, bool passedExam)
        {
            Name = name;
            Age = age;
            PassedExam = passedExam;
        }
    }

    public class Students : IEnumerable, IEnumerator
    {
        Student[] studArray;
        //postavljamo trenutnu poziciju niza na inicijalnu poziciju -1
        int position = -1;

        //kreiramo studente
        public Students()
        {
            studArray = new Student[3];
            studArray[0] = new Student("Mirjana Milic", 23, true);
            studArray[1] = new Student("Milos Milosevic", 21, false);
            studArray[2] = new Student("Ognjen Ognjanovic", 22, true);
        }

        //implementiramo IEnumerable
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        //implementiramo metodu IEnumeratora MoveNext
        public bool MoveNext()
        {
            position++;
            if (position < studArray.Length)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return studArray[position]; }
        }
    }


    class Program
    {
        static void Main()
        {
            Students stud = new Students();

            //prikazujemo one studente koji su polozili ispit
            foreach(Student s in stud)
            {
                if(s.PassedExam == true)
                {
                    Console.WriteLine("Name: {0}", s.Name);
                    Console.WriteLine("Amount: {0}\n", s.Age);
                }
            }

            Console.Read();
        }
    }
}
