using System;
using System.Linq;
using System.Collections;

namespace primjer03
{
    public class Student
    {
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
    }

    public class Program
    {
        static void Main()
        {
            Student[] studentCollection =
            {
                new Student("Miljana Miljkovic", 23, 8, 3),
                new Student("Marko Markovic", 20, 10, 2),
                new Student("Veljko Veljkovic", 25, 8, 3),
                new Student("Petar Petrovic", 23, 7, 4)
            };

            var studInfo = from stud in studentCollection
                           orderby stud.AvgMark descending, stud.Name
                           select stud;

            Console.WriteLine("Studenti sortiran po ocjenama: ");
            //izvsava se upit i prikazuju rezultati
            foreach (Student stud in studInfo)
            {
                Console.WriteLine("Student {0} ima prosjecnu ocjenu: {2} i ima {1} godina.", stud.Name, stud.Age, stud.AvgMark);
            }

            Console.Read();
        }
    }
}
