using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3 Определить, является ли введённое пользователем число чётным.
            Console.Write("Введите любое число: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            if ((Number % 2) == 0)
            {
                Console.WriteLine($"Число {Number} является чётным.");
            }

            else
            {
                Console.WriteLine($"Число {Number} является нечётным.");
            }
        }
    }
}
