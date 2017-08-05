using System;
using System.Collections.Generic;

namespace primjer02
{
    public class Student
    {
        public string Name;

        public Student(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            students.Add("Student1", new Student("Petar Petrovic"));
            students.Add("Student2", new Student("Nemanja Nemanjic"));
            students.Add("Student3", new Student("Mirko Mirkovic"));

            foreach (Student student in students.Values)
            {
                Console.WriteLine(student.Name);
            }

            Console.Read();
        }
    }
}
