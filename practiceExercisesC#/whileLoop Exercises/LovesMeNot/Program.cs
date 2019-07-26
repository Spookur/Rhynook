using System;

namespace LovesMeNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int petals = 34;
            while (petals <= -1)
            {
                if (petals != 0)
                {
                    Console.WriteLine("{0}", petals);
                }
                petals--;
            }
            Console.ReadLine();

        }
    }
}
