using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
	  //Задание 6 * Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, к примеру, чтобы описать работу какого либо офиса. Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.
            string Monday = "Понедельник: с 8:00 до 18:00";
            string Tuesday = "Вторник: с 8:00 до 18:00";
            string Wednesday = "Среда:   с 8:00 до 18:00";
            string Thursday = "Четверг: с 8:00 до 18:00";
            string Friday = "Пятница: с 8:00 до 18:00";
            string Saturday = "Суббота: с 8:00 до 18:00";
            string Sunday = "Воскресенье: с 8:00 до 18:00";

            Console.Write("Введите номер офиса (1 или 2): ");
            int office = Convert.ToInt32(Console.ReadLine());

            if (office == 1)
            {
                Console.WriteLine($"Режим работы офиса №1:\n {Tuesday}\n {Wednesday}\n {Thursday}\n {Friday}");
            }

            else if (office == 2)
            {
                Console.WriteLine($"Режим работы офиса №2:\n {Monday}\n {Tuesday}\n {Wednesday}\n {Thursday}\n {Friday}\n {Saturday}\n {Sunday}");
            }

            else
            {

            }
	}
    }
}