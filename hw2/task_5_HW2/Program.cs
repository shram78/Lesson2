using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет
его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
namespace task_5_HW2
{
    class Program
    {
        static void hudeem(double indMass)
        {
            if (indMass <= 20)
            Console.WriteLine("\nНадо поесть, ты худой");
            if (indMass > 20 && indMass <= 25)
            Console.WriteLine("\nТы в порядке!!!");
            if (indMass > 25)
            Console.WriteLine("\nНадо худеть и меньше жрать");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор индекса массы тела\n");
            Console.Write("Введите Ваш вес (кг): "); 
            double weightPer = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш рост (например, 1,8 м): ");
            double growthPer = double.Parse(Console.ReadLine());

            double indMass = weightPer / (growthPer * growthPer);
            Console.Write("Индекс массы Вашего тела = ");  
            Console.WriteLine("{0:0.00}", indMass);
            hudeem(indMass);
            Console.ReadLine();
        }
    }
}