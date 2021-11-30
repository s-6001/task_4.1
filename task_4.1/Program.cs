using System;

namespace task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число N>0:");
                Console.Write("N=");
                int n = 0;  //Переменная для хранения N
                int nSquare = 0;    //Переменная для хранения N-квадрат
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());    //считываем N
                }
                catch
                {
                    Console.WriteLine("Не удалось прочитать число.");  //В случае недопустимого ввода
                }
                if (n > 0)  //проверяем условие задачи N>0
                {
                    Console.WriteLine("Квадраты чисел от 1 до {0}:",n);
                    for (int i = 1; i <= n; i++)
                    {
                        nSquare = nSquare + (2 * i - 1);    //Используем формулу вычисления квадрата числа
                        Console.WriteLine(nSquare); //выводим квадраты чисел от 1 до N
                    }
                }
                else
                {
                    Console.WriteLine("Введено недопустимое число.");
                }
            }
        }
    }
}