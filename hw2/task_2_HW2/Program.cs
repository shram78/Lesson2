using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Написать метод подсчета количества цифр числа.*/
namespace task_2_HW2
{
    class Program
    {
        static void CalculNamb(int a) 
        {
            int counter = 0;
            while (a!=0)
            {
                counter++;
                a = a / 10;
            }
            Console.WriteLine("Рязряд числа: {0}", counter);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сколько цифр в числе?");
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            CalculNamb(a);
            Console.ReadLine();
        }
    }
}
