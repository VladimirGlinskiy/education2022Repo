using System;
namespace Utils
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Введите строку для разворота");
            string s = Console.ReadLine();
            Utils.Reverse(ref s);
            Console.WriteLine("Строка после разворота");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
