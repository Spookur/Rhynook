using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTImes2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int num;
                Console.Write("Enter the Number :");
                num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine("{0}*{1}={2}", num, i, num * i);
                }

                Console.ReadLine();
            }
        }
    }
}