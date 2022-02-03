using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var totalDistance = 0;
            var hour = 0;
            try
            {
                Console.WriteLine("Скорость первого автомобиля(км)...");
                var speedOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Скорость второго автомобиля(км)...");
                var speedTwo = int.Parse(Console.ReadLine());
                Console.WriteLine("Расстояние между ними(км)...");
                var distance = int.Parse(Console.ReadLine());
                Console.WriteLine("Время(ч)...");
                hour = int.Parse(Console.ReadLine());

                totalDistance = distance + speedOne * hour + speedTwo * hour;
            }
            catch (Exception)
            {
                throw new Exception("Некорректный ввод данных. Повторите попытку...");
            }

            Console.WriteLine($"Расстояние между ними через {hour} ч. = {totalDistance} км.");

            Console.ReadLine();
        }


    }
}
