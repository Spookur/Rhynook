using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGeneticsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            int cem = 100;
            Random perc = new Random();

            a = perc.Next(0, cem);
            cem -= a;

            b = perc.Next(0, cem);
            cem -= b;

            c = perc.Next(0, cem);
            cem -= c;

            d = perc.Next(0, cem);
            cem -= d;

            e = perc.Next(0, cem);
            cem -= d;

            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, a + b + c + d + e);

            Console.ReadKey(false);
        }
    }
}