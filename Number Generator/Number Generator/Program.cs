using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    internal class NumberGenerator
    {
        static void Main()
        {
            Console.Write("Enter the number of random numbers to generate: ");
            int count = int.Parse(Console.ReadLine());

            var random = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            int countBetween1And99 = numbers.Count(x => x >= 1 && x <= 99);
            int countBetween1And9 = numbers.Count(x => x >= 1 && x <= 9);

            Console.WriteLine($"Number of numbers between 1 and 99: {countBetween1And99}");
            Console.WriteLine($"Number of numbers between 1 and 9: {countBetween1And9}");
        }
    }
}
