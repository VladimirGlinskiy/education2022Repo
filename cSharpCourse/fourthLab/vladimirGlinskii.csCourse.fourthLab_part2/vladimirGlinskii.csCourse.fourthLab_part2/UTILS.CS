namespace vladimirGlinskii.csCourse.fourthLab_part2
{
    using System;

    public class Utils
    {
        public static void Swap(ref int a, ref int b) {

            int temp;
            temp = a; 
            a = b;
            b = temp;

        }
    }
}
