using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            bool special = false;
            for (int letter = 1; letter <= number; letter++)
            {
                count = letter;
                while (letter > 0)
                {
                    sum += letter % 10;
                    letter = letter / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{count} -> {special}");
                sum = 0;
                letter = count;

            }
        }
    }
}
