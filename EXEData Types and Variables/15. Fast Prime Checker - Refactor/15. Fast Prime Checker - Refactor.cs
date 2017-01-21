using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGiven = int.Parse(Console.ReadLine());
            for (int division = 2; division <= numberGiven; division++)
            {
                bool result = true;
                for (int devided = 2; devided <= Math.Sqrt(division); devided++)
                {
                    if (division % devided == 0)
                    {
                        result = false;
                        break;
                    }
                }
                Console.WriteLine($"{division} -> {result}");
            }

        }
    }
}
