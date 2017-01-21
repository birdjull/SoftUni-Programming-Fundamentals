using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            var pictureCount = int.Parse(Console.ReadLine());
            var fTime = int.Parse(Console.ReadLine());
            var filterPercentage = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var fiterSeconds = pictureCount * fTime;
            var goodPictures = (int)Math.Ceiling(pictureCount * ((double)filterPercentage / 100));
            var uploadSeconds = goodPictures * uploadTime;

            var totalSeconds = (fiterSeconds + uploadSeconds);            
            var totalTime = new TimeSpan(0,0,totalSeconds);

            Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));



        }
    }
}
