using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingListAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // collect a list of numbers
            string input;
            int output;

            List<int> numbers = new List<int>();

            do
            {
                Console.Write("Enter a number (press Q to quit): ");
                input = Console.ReadLine();
                if (int.TryParse(input, out output))
                {
                    numbers.Add(output);
                }
            } while (input != "Q");

            Console.WriteLine("The numbers entered were: {0}", string.Join(", ", numbers));
            Console.WriteLine("");

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("The sum of the numbers entered is: {0}", sum);
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }

    public class Stack
    {
        private int[] _items;
        private int _nextIndex;

        public Stack(int maxItemCount)
        {
            // initialize the array to hold as many items
            // as specified
            _items = new int[maxItemCount];
        }

        public void Push(int item)
        {
            // push the item on
            _items[_nextIndex] = item;

            // get ready for next item
            _nextIndex++;
        }

        public int Pop()
        {
            // can't return if we are empty
            if (_nextIndex == 0)
                throw new Exception("No items in the stack!");

            // decrement the index
            _nextIndex--;

            // pull out the item at that specific index
            int value = _items[_nextIndex];

            // clear the value in the array
            _items[_nextIndex] = 0;

            // return the item
            return value;


        }


    }
}








