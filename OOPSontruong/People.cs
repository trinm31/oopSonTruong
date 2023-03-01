using System;

namespace OOPSontruong
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        // contructor
        public People(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public People()
        {
        }

        public void PrintInPeople()
        {
            Console.WriteLine("Hello world");
        }
    }
}