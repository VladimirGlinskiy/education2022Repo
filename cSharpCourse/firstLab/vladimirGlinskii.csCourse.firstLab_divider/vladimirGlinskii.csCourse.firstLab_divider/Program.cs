using System;
using System.Text;

namespace vladimirGlinskii.csCourse.firstLab_divider
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            String exit;

            do {

                try
                {

                    Console.WriteLine("Введите первое целое число");
                    String temp = Console.ReadLine();
                    int i = Int32.Parse(temp);


                    Console.WriteLine("Введите второе целое число");
                    temp = Console.ReadLine();
                    int j = Int32.Parse(temp);


                    int k = i / j;
                    Console.WriteLine("Округленный результат деления первого числа на второе равен: {0} ", k);

                }
                catch (Exception e) {
                    Console.WriteLine("An exception was thrown: {0}", e);
                }

                Console.WriteLine("Чтобы закрыть программу введите y");
                exit = Console.ReadLine();
                
            } 
            
            while (exit != "y");
        } 
    }
}
