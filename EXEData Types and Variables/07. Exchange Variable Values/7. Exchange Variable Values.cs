using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {first}\nb = {second}");


            first = first + second;
            second = first - second;
            first = first - second;

            Console.WriteLine($"After:\na = {first}\nb = {second}"); 

        }
    }
}
