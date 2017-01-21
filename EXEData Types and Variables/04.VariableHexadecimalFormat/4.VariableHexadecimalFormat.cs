using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.VariableHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            var value = Convert.ToInt32(number, 16);
            Console.WriteLine(value);
        }
    }
}
