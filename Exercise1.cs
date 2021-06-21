using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1(Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.)
            Console.Write("Введите минимальное значение температуры за сутки: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальное значение температуры за сутки: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Cреднесуточная температура равна {(a + b) / 2}");
        }
    }
}
