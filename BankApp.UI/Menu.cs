using BankApp.UI.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.UI
{
    public static class Menu
    {
        public static void Start()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("SG Banking Application");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Lookup an Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("\nQ to quit");
                Console.Write("\nEnter selection: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AccountLookupWorkflow lookupWorkflow = new AccountLookupWorkflow();
                        lookupWorkflow.Execute();
                        break;
                    case "2":
                        DepositWorkFlow depositWorkflow = new DepositWorkFlow();
                        depositWorkflow.Execute();
                        break;
                    case "3":
                        break;
                    case "Q":
                        return;
                }
            }
        }
    }
}
