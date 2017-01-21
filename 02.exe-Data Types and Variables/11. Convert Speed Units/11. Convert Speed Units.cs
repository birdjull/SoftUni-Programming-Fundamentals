using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float allHours = hours  + (minutes / 60.0f) + seconds / 60.0f / 60.0f;
            float kilometersPerHours = (distanceMeters / 1000.0f)/allHours;
            float metersPerSecond = kilometersPerHours / 3.6f;
            float milesPerHours = (distanceMeters /1609.0f)/allHours;

            

            Console.WriteLine( metersPerSecond);
            Console.WriteLine( kilometersPerHours);
            Console.WriteLine( milesPerHours);



        }
    }
}
