using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladimirGlinskii.csCourse.firstLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            String myName;
            Console.WriteLine("Введите имя пользователя");
            myName = Console.ReadLine();
            Console.WriteLine( "Hello {0}", 
            myName);
            Console.ReadLine();

        }
    }
}
