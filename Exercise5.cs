using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 5 * Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
            Console.Write("Введите порядковый номер зимнего месяца: ");
            string InputMounth = Console.ReadLine();

            Console.Write("Введите среднюю температуру: ");
            string InputTemp = Console.ReadLine();

            bool isValidMounth = int.TryParse(InputMounth, out int MounthNumber);
            isValidMounth = isValidMounth || (MounthNumber < 1 || MounthNumber > 12);

            bool isValidTemp = int.TryParse(InputTemp, out int averageTemp);

            if (!isValidMounth || !isValidTemp)
            {
                Console.WriteLine("Введены некорректные данные.");
            }

            bool isWinterWeather = (MounthNumber == 12) || (MounthNumber == 1) || (MounthNumber == 2);
            if (isWinterWeather && averageTemp > 0)
            {
                Console.WriteLine("Дождливая зима.");
            }
        }
    }
}
