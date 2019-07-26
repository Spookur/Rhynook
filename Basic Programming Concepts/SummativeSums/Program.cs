using System;

namespace ReturnToSender
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int sum1 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }
            Console.WriteLine("#1 Array is: " + sum1);

            int[] array2 = { 45, 34, 67, 98, 90 };
            int sum2 = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }
            Console.WriteLine("#2 Array is: " + sum2);

            int[] array3 = { 349, 694, 341, 806, 149 };
            int sum3 = 0;

            for (int i = 0; i < array3.Length; i++)
            {
                sum3 += array3[i];
            }
            Console.WriteLine("#3 Array is: " + sum3);
            Console.Read();
        }
    }
}
