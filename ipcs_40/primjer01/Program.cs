using System;
using System.Collections;

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

public class Students : CollectionBase
{
    public void Add (Student newStudent)
    {
        List.Add(newStudent);
    }

    public Student this[int index]
    {
        get { return (Student)List[index]; }
        set { List[index] = value; }
    }
}

namespace primjer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Students studentCollection = new Students();

            studentCollection.Add(new Student("Marko Markovic", 20, 10, 2));
            studentCollection.Add(new Student("Veljko Veljkovic", 25, 8, 3));
            studentCollection.Add(new Student("Petar Petrovic", 23, 7, 4));

            for (int i = 0; i < studentCollection.Count; i++)
            {
                Console.WriteLine("Ime: {0}", studentCollection[i].Name);
                Console.WriteLine("Godine: {0}", studentCollection[i].Age);
                Console.WriteLine("Prosjecna ocjena: {0}", studentCollection[i].AvgMark);
                Console.WriteLine("Godina studija: {0}", studentCollection[i].GodinaStud);
            }

            Console.Read();
        }
    }
}
