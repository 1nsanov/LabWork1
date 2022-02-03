using System;

namespace Task2
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int a, b, n = 0;
            try
            {
                Console.WriteLine("Длина массива...");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("1-ый порядковый номер...");
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    throw new Exception("1-ый порядковый номер не может быть равен или меньше 0");
                }
                Console.WriteLine("2-ой порядковый номер...");
                b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    throw new Exception("1-ый порядковый номер не может быть больше 2-ого");
                }
                if (b > n || a > n)  
                {
                    throw new Exception("2-ой(или 1-ый) порядковый номер не может быть больше длины массива");
                }
            }
            catch (Exception)
            {
                throw new Exception("Некорректный ввод данных. Повторите попытку...");
            }
            
            var array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 15);
            }

            var totalMultiply = 1;
            for (int i = a; i <= b; i++)
            {
                totalMultiply *= array[i - 1];
            }

            OutputArray(array);

            Console.WriteLine($"Произведение массива от {a} до {b} = {totalMultiply}");

            Console.ReadLine();
        }

        private static void OutputArray(int[] array)
        {
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________________________");
        }
    }
}
