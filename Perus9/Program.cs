// Perustehtävä 9

using System;

namespace Perus9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            bool result;
            do
            {
                Console.Write("Give a number ");
                string line = Console.ReadLine();
                result = Int32.TryParse(line, out number);
                if (result)
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("You didn't give a number.");
                }
            }
            while (result && number != 0);

            Console.WriteLine("The sum is " + sum);
            Console.ReadLine();
        }
    }
}
