using System;

namespace Calculator
{
    public class Calculator
    {
        public void Plus()
        {
            Console.WriteLine("Muộn cộng bao nhiêu số");
            Console.WriteLine("Input 1 để cộng 2 số");
            Console.WriteLine("Input 2 để cộng 3 số");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Nhập vào số a");
                var a = GetInputValue();
                Console.WriteLine("Nhập vào số b");
                var b = GetInputValue();
                Plus(a, b);
            }
            else
            {
                Console.WriteLine("Nhập vào số a");
                var a = GetInputValue();
                Console.WriteLine("Nhập vào số b");
                var b = GetInputValue();
                Console.WriteLine("Nhập vào số c");
                var c = GetInputValue();
                Plus(a, b, c);
            }
        }

        private void Plus(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        
        private void Plus(int a , int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        
        private void Plus(double a , double b)
        {
            Console.WriteLine(a + b);
        }
        
        private void Minus(int a , int b)
        {
            Console.WriteLine(a - b);
        }
        
        private void Minus(int a , int b, int c)
        {
            Console.WriteLine(a - b - c);
        }
        
        private void Minus(double a , double b)
        {
            Console.WriteLine(a - b);
        }
        
        private void Multiple(int a , int b)
        {
            Console.WriteLine(a * b);
        }
        
        private void Multiple(int a , int b, int c)
        {
            Console.WriteLine(a * b * c);
        }
        
        private void Multiple(double a , double b)
        {
            Console.WriteLine(a * b);
        }
        
        private void Devide(int a , int b)
        {
            Console.WriteLine((double)a / b);
        }
        
        private void Devide(int a , int b, int c)
        {
            Console.WriteLine((double)a / b / c);
        }
        
        private void Devide(double a , double b)
        {
            Console.WriteLine(a / b);
        }
        
        private static dynamic GetInputValue()
        {
            var a = Console.ReadLine();
            dynamic aClean;
            if (int.TryParse(a, out _))
            {
                aClean = Convert.ToInt32(a);
            }
            else
            {
                aClean = Convert.ToDouble(a);
            }

            return aClean;
        }
    }
}