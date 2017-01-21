using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int personsToElevate = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            int coursesNeeded = (int) Math.Ceiling((double)personsToElevate / capacity);

            Console.WriteLine(coursesNeeded);


        }
    }
}
