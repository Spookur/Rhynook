using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of positive numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
      