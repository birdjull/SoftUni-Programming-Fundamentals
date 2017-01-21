using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double lenght, width, height, volume = 0;
            //double width = 0;
            //double height = 0;
            //double volume = 0; 

            
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            volume = (lenght * width * height)/3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);


        }
    }
}
