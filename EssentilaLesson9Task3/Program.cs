using System;
using System.Threading;

namespace EssentilaLesson9Task3
{

    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов, 
    //    сообщенных с делегатами в массиве.Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.

    class Program
    {

        public delegate int MyDelLast(MyDel[] a);
        public delegate int MyDel(int a, int b);

        static void Main(string[] args)
        {
            MyDel del = (a, b) => (a + b) / 2;
            int a = new Random().Next(5,20);
            MyDel[] delArr = new MyDel[a];

            for (int i = 0; i < delArr.Length; i++)
            {
                delArr[i] = del;
            }
            

            MyDelLast delLast;

            for (int i = 0; i < delArr.Length; i++)
            {
                int b = new Random().Next(5, 50);
                delLast = (delArr) => (delArr[i].Invoke(b, b+5)) / 2;
                Console.WriteLine(delLast.Invoke(delArr));
                Thread.Sleep(20);
            }
        }

    }
}
