using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int counter = 0;
            while (counter <= 5)
                {
                Console.WriteLine("Enter a new name: ");
                string nameSingle = Console.ReadLine();
                names[counter] = nameSingle;
                counter++;
            }
            DisplayNames(names);

            int[] numbers = new int[4];
            while (counter <= 4)
            {
                Console.WriteLine("Enter a new number: ");
                int numberSingle = Convert.ToInt32(Console.ReadLine());
                numbers[counter] = numberSingle;
                counter++;
            }
            foreach(int numSingle in numbers)
            {
                Console.Write(numSingle + " ");
            }

            int sumOfAllNumbers = Addition(numbers);
            Console.WriteLine($"The sum of all numbers is: {sumOfAllNumbers}");
        }

        private static int Addition(params int[] numbers)
        {
            int sum = 0, counter = 0;
            while (counter <= numbers.Length)
            {
                sum += counter;
                counter++;
            }
            return sum;
        }

        private static void DisplayNames(params string[] names)
        {
            foreach(string nameSingle in names)
            {
                Console.Write(nameSingle + " ");
            }
        }
    }
}
