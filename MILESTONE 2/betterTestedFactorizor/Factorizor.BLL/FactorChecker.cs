using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    public class FactorChecker
    {
        public int[] GetFactors(int number)
        {
            int[] result = new int[number / 2];
            
            int placeHolder = 0;


            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0) // input divided by all the possible numbers up until the given input. remainder of 0, 
                {
                    result[placeHolder] = i;
                    
                    placeHolder++;
                }


            }
            return result; 
        }

    }
}
