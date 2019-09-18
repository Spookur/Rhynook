using System;

namespace MoreBucketsMoreFun.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            int butterflies, beetles, bugs;
            String color, size, shape, thing;
            double number;

            butterflies = 2;
            beetles = 4;

            bugs = butterflies + beetles;
            Console.WriteLine("There are only " + butterflies + " butterflies,");
            Console.WriteLine("but " + bugs + " bugs total.");

            Console.WriteLine("Uh oh, my dog ate one.");
            butterflies--;
            Console.WriteLine("Now there are only " + butterflies + " butterflies left.");
            Console.WriteLine("But still " + bugs + " bugs left, wait a minute!!!");
            Console.WriteLine("Maybe I just counted wrong the first time...");
        }
    }
}
