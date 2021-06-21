using System;

namespace ConsoleApp17
{
    enum Mounth
    {
        Январь = 1,
        Февраль = 2,
        Март = 3,
        Апрель = 4,
        Май = 5,
        Июнь = 6,
        Июль = 7,
        Август = 8,
        Сентябрь = 9,
        Октябрь = 10,
        Ноябрь = 11,
        Декабрь = 12
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер текущего месяца: ");
            var InputNumber = Convert.ToInt32(Console.ReadLine());

            Mounth mounth = new Mounth();
            switch (InputNumber)
            {
                case (int)Mounth.Январь:
                    Console.WriteLine("Текущий месяц - Январь");
                    break;
                case (int)Mounth.Февраль:
                    Console.WriteLine("Текущий месяц - Февраль");
                    break;
                case (int)Mounth.Март:
                    Console.WriteLine("Текущий месяц - Март");
                    break;
                case (int)Mounth.Апрель:
                    Console.WriteLine("Текущий месяц - Апрель");
                    break;
                case (int)Mounth.Май:
                    Console.WriteLine("Текущий месяц - Май");
                    break;
                case (int)Mounth.Июнь:
                    Console.WriteLine("Текущий месяц - Июнь");
                    break;
                case (int)Mounth.Июль:
                    Console.WriteLine("Текущий месяц - Июль");
                    break;
                case (int)Mounth.Август:
                    Console.WriteLine("Текущий месяц - Август");
                    break;
                case (int)Mounth.Сентябрь:
                    Console.WriteLine("Текущий месяц - Сентябрь");
                    break;
                case (int)Mounth.Октябрь:
                    Console.WriteLine("Текущий месяц - Октябрь");
                    break;
                case (int)Mounth.Ноябрь:
                    Console.WriteLine("Текущий месяц - Ноябрь");
                    break;
                case (int)Mounth.Декабрь:
                    Console.WriteLine("Текущий месяц - Декабрь");
                    break;
                default:
                    Console.WriteLine("Такого месяца не существует!");
                    break;

            }
        }
    }
}
