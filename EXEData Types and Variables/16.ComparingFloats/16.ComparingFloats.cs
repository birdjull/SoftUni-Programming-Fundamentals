using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {


            double eps = 0.000001;
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double difference = Math.Abs(numberA - numberB);


            bool equality = (difference <= eps);
            Console.WriteLine(equality);

        }
    }
}
