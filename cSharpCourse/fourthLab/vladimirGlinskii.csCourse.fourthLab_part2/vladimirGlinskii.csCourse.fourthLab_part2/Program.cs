using System;

namespace vladimirGlinskii.csCourse.fourthLab_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Переменные до перестановки \n" +
                "x: {0}, y: {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("Переменные после перестановки \n" +
                "x: {0}, y: {1}", x, y);
            Console.ReadLine();
        }
    }
}
