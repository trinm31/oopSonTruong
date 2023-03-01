using System;

namespace OOPSontruong
{
    class Program
    {
        static void Main(string[] args)
        {
            // var student = new Student();
            // var result = student.Plus(2, 4);
            // student.Print(2, 4);
            // student.Print(2,10);
            // student.PrintInPeople();

            var people = new People("Tri", 20, "male");
            Console.WriteLine(people.Name);
            Console.WriteLine(people.Age);
            Console.WriteLine(people.Sex);

            var people1 = new People();
            people1.Name = "fdsa";
            people1.Age = 21;
        }
    }
}