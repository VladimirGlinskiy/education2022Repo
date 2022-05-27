namespace Utils
{
    using System;
    using System.Text;

    public class Test
    {

        public static void Main()
        {

            int x, y;

            Console.WriteLine("¬ведите число X");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("¬ведите число Y");
            y = int.Parse(Console.ReadLine());

            int greater = Utils.Greater(x,y);
            Console.WriteLine("„исло {0} - наибольшее", 
                greater);
            Console.ReadLine();
        }
    }
}
