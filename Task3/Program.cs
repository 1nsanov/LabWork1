using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int count, price = 0;
            try
            {
                Console.WriteLine("Тираж журнала...");
                count = int.Parse(Console.ReadLine());
                Console.WriteLine("Цена за 1 штуку($)...");
                price = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Некорректный ввод данных. Повторите попытку...");
            }

            Magazine magazine = new Magazine(count, price);

            Console.WriteLine(magazine);

            Console.ReadLine();
        }
    }
}
