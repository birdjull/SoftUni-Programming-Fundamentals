using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumofRealNumbers
{
    class ExactSumofRealNumbers
    {
        static void Main(string[] args)
        {
            int linesToSum = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < linesToSum; i++)
            {
                sum += decimal.Parse(Console.ReadLine());

                
            }
            Console.WriteLine(sum);

        }
    }
}
