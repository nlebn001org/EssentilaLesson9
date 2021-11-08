using System;

namespace EssentilaLesson9Task1
{

    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.

    class Program
    {

        public delegate int MyDelegate(int a, int b, int c);
        static void Main(string[] args)
        {
            MyDelegate d = delegate (int a, int b, int c) { return a + b + c; };
            MyDelegate r = (a, b, c) => (a + b + c) / 3;

            int sum = r(1, 2, 3);

            Console.WriteLine(sum);
        }
    }
}
