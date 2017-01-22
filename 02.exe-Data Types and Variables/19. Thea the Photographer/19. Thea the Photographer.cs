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

            int pictureCount = int.Parse(Console.ReadLine());
            int fTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double filterPercentage = filterFactor / 100.0;
            int goodPictures = (int)Math.Ceiling(pictureCount * filterPercentage);

            long totalPictures = pictureCount * (long)fTime;
            long uploadedPictures = goodPictures * (long)uploadTime;


            long totals = (totalPictures + uploadedPictures);


            Console.WriteLine(TimeSpan.FromSeconds(totalPictures + uploadedPictures)
                .ToString(@"d\:hh\:mm\:ss"));


        }
    }
}
