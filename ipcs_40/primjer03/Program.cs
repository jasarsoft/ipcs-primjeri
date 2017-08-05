using System;
using System.Collections;
using System.Collections.Generic;



namespace primjer03
{
    //definisali smo klasu student koju ce koristiti nasa kolekcija klase rjecnik
    public class Student
    {
        private string v;

        public string Name { get; set; }
        public int Age { get; set; }
        public double AvgMark { get; set; }
        public int GodinaStud { get; set; }

        public Student(string name, int age, double avgMark, int godinaStud)
        {
            Name = name;
            Age = age;
            AvgMark = avgMark;
            GodinaStud = godinaStud;
        }

        public Student(string v)
        {
            this.v = v;
        }
    }

    //specifikovali smo klasu koja implementira DictonaryBase kolekciju klasa u kojoj postoji meotda Add
    public class Students : DictionaryBase
    {
        //ova metoda zahtjeva kljuc string i objekat Student koji namjeravamo da dodamo
        //na osnovu kljuca koji je tip student vraca se kljuc
        public void Add(string key, Student stud)
        {
            //koristimo svojstva dictionary da dodamo podatak u rjecnik koristeci poslat argument
            Dictionary.Add(key, stud);
        }

        //definisemo indekser
        public Student this[string key]
        {
            get { return (Student)Dictionary[key]; }
            set { Dictionary[key] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            students.Add("Student1", new Student("Petar Petrovic"));
            students.Add("Student2", new Student("Nemanja Nemanjic"));
            students.Add("Student3", new Student("Mirko Mirkovic"));

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students["Student" + (i + 1)].Name);
            }

            Console.Read();
        }
    }
}
