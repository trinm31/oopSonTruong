using System;

namespace OOPSontruong
{
    public class Student : People
    {
        public string Test { get; set; }
        public Student(string test, string name, int age, string sex) 
            : base(name,age,sex)
        {
            Test = test;
        }
        
        public int Plus(int a, int b)
        {
            return a + b;
        }
        
        public void Print(int a, int b = 5)
        {
            Console.WriteLine($"số a={a} b={b}");
        }
    }
}