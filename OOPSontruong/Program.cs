using System;
using System.Collections.Generic;

namespace OOPSontruong
{
    class Program
    {
        static void Main(string[] args)
        {
            // tạo ra 1 class tên people (string name, int age, string sex)
            // tạo ra 3 class kế thừa people: student, teacher, parent
            // dùng 1 list để lưu lại cả student teacher và parent
            // in ra tên cảu student teacher và parent

            var list = new List<People>();
            Console.WriteLine("Bạn muốn nhập bao nhiêu");
            var count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("bạn muốn nhập vào Student nhập 1, Teacher nhập 2, Parent nhập 3");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Nhập vào name");
                        var name = Console.ReadLine();
                        
                        Console.WriteLine("Nhập vào age");
                        var age = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Nhập vào sex");
                        var sex = Console.ReadLine();
                        
                        var student = new Student(name, age, sex);
                        list.Add(student);
                        
                        break;
                    case 2:
                        Console.WriteLine("Nhập vào name");
                        var nameTeacher = Console.ReadLine();
                        
                        Console.WriteLine("Nhập vào age");
                        var ageTeacher = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Nhập vào sex");
                        var sexTeacher = Console.ReadLine();
                        
                        var teacher = new Teacher(nameTeacher, ageTeacher, sexTeacher);
                        list.Add(teacher);
                        break;
                    
                    case 3:
                        Console.WriteLine("Nhập vào name");
                        var nameParent = Console.ReadLine();
                        
                        Console.WriteLine("Nhập vào age");
                        var ageParent = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Nhập vào sex");
                        var sexParent = Console.ReadLine();
                        
                        var parent = new Parent(nameParent, ageParent, sexParent);
                        list.Add(parent);
                        break;
                    
                    default:
                        Console.WriteLine("bạn chọn sai");
                        break;
                }   
            }

            foreach (var obj in list)
            {
                Console.WriteLine("----------------");
                obj.PrintName();
            }

            Console.ReadKey();
        }
    }
}