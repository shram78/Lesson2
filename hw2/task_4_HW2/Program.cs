using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел
(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.*/
namespace task_4_HW2
{
    class Program
    {
        static bool CheckAсс(string LogUser, string PassUser)
        {
            bool RA = false;
            return RA = (LogUser == "root" && PassUser == "GeekBrains");
        }
        static void Main(string[] args)
        {
            bool checkLog = false;
            int count = 0; 

            do
            {
                Console.Write("Введите логин: ");
                string LogUser = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string PassUser = Console.ReadLine();

                checkLog = CheckAсс(LogUser, PassUser);
                if (checkLog==true) break;
                count++;
                Console.WriteLine("Неправильный логин или пароль\n");
            } while (count < 3);

            if (checkLog==true)
            Console.WriteLine("Вход выполнен"); 
            else 
            Console.WriteLine("Вы превысили доступное количество попыток, в доступе отказано"); 
            Console.ReadKey();
        }
    }
}