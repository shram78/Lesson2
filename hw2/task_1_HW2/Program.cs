using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Написать метод, возвращающий минимальное из трех чисел.*/
namespace task_1_HW2
{
    class Program
    {
        static void CalculMin(int a, int b, int c) // метод вычисления
        {
            if (a > b) a = b;
            if (a > c) a = c;
            Console.WriteLine("Минимальное из введенных чисел это {0}",a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Мотод минимального из трех чисел");
            Console.Write("Введите первое число: ");
            int one = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int two = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int three = int.Parse(Console.ReadLine());

            CalculMin(one, two, three);
            Console.ReadLine();
        }
    }
}
