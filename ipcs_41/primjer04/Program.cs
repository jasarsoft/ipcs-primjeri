using System;
using System.Linq;
using System.Collections;

namespace primjer04
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Student(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }

    public class Program
    {
        static void Main()
        {
            Student[] studentCollection =
            {
                new Student("Miljka", "Miljkovic"),
                new Student("Marko", "Markovic"),
                new Student("Veljko", "Veljkovic"),
                new Student("Petar", "Petrovic")
            };

            var studInfo = from stud in studentCollection
                           select stud.Name;

            Console.WriteLine("Studenti: ");
            foreach (string stud in studInfo)
                Console.WriteLine(stud);

            Console.Read();
        }
    }
}
