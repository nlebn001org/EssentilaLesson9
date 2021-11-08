using System;

namespace EssentilaLesson9Task2
{
    class Program
    {

        public delegate double MyDelegate(double a, double b);

        static void Main(string[] args)
        {
            MyDelegate add = (a, b) => { return a + b; };
            MyDelegate sub = (a, b) => { return a - b; };
            MyDelegate mul = (a, b) => { return a * b; };
            MyDelegate div = (a, b) => { if (a == 0) return 0; else return a / b; };

            int x = 10;
            int z = 5;

            Console.WriteLine($"1st parameter is {x} and 2nd is{z}");
            Console.WriteLine($"Sum is {add(x, z)}");
            Console.WriteLine($"Sub is {add(x, z)}");
            Console.WriteLine($"Mul is is {add(x, z)}");
            Console.WriteLine($"Div is {add(x, z)}");
            
        }




    }
}

