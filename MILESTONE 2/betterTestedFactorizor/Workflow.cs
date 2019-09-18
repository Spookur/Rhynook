using Factorizor.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betterTestedFactorizor
{
    public class Workflow
    {
        public void Run()
        {
            // Call method on ConsoleInput to get number from user. 
            int no = 0;
            // Create new instance of all three checkers. 
            FactorChecker factorChecker = new FactorChecker();
            int[] factors = factorChecker.GetFactors(no);
            // Get all factors for number
            // Check if perfect
            // Check if prime
            // Call method on ConsoleOutput to display the three results. 
        }
    }
}

