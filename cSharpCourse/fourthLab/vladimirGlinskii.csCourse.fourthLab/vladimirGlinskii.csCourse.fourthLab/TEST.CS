namespace Utils
{
    using System;
    using System.Text;

    public class Test
    {

        public static void Main()
        {

            int x, y;

            Console.WriteLine("������� ����� X");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("������� ����� Y");
            y = int.Parse(Console.ReadLine());

            int greater = Utils.Greater(x,y);
            Console.WriteLine("����� {0} - ����������", 
                greater);
            Console.ReadLine();
        }
    }
}
