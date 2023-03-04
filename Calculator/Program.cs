using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new Calculator();

            Console.WriteLine("Bạn muốn nhập phép tính nào");
            Console.WriteLine("Input 1 cho cộng");
            Console.WriteLine("Input 2 cho trừ");
            Console.WriteLine("Input 3 cho nhân");
            Console.WriteLine("Input 4 cho chia");
            var phepTinh = Convert.ToInt32(Console.ReadLine());

            switch (phepTinh)
            {
                case 1:
                    cal.Plus();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}