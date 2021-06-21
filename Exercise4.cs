using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4 Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
            string check = "       Кассовый чек";
            string ShopName = "ООО Магнит";
            int INN = 1234567890;
            string adress = "115280, г. Москва, ул. Ленина 19";
            string Date = DateTime.Now.ToString();
            string cashier = "Кассир: Иванов И.И";
            int number = 1441;
            string toy = "Мягкая игрушка\n2 x 500               = 1000.00";
            string NDC = "НДС 10%               = 90.91";



            Console.WriteLine(check);
            Console.WriteLine("ПРИХОД");
            Console.WriteLine(ShopName);
            Console.WriteLine(INN);
            Console.WriteLine(adress);
            Console.WriteLine($"Чек № {number}");
            Console.WriteLine(Date);
            Console.WriteLine(cashier);
            Console.WriteLine("________________________________");
            Console.WriteLine(toy);
            Console.WriteLine("________________________________");
            Console.Write("Итог                  = 1000.00\n");
            Console.Write("НАЛИЧНЫМИ             = 1000.00\n");
            Console.Write("НАЛОГОБЛОЖЕНИЕ        ОСН\n");
            Console.Write(NDC);
        }
    }
}
