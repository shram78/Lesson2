using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/
namespace task_3_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать сумму всех нечетных положительных чисел\n");
            int summ = 0; // для подсчета суммы всех введенных чисел
            int ryad = 0; // для хранения значения, введенного пользователем
            do
            {
                Console.Write("Введите число, для окончания набора '0': ");
                ryad = int.Parse(Console.ReadLine());
                if (ryad > 0 && ryad %2 ==1)
                {
                    summ = summ + ryad;
                }
            } while (ryad != 0);
            Console.WriteLine("Сумма всех чисел равна: {0}", summ);
            Console.ReadLine();
        }
    }
}