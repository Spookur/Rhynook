using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConstructorSample instance = new ConstructorSample();
            Console.WriteLine("Created: {0}", instance.CreateDate);

            

            Console.ReadLine();
        }
    }
}
