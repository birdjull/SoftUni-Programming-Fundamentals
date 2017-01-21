using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {


            string integer = Console.ReadLine();

            long isLong;

            if (long.TryParse(integer, out isLong))
            {
                sbyte isSbyte;
                byte isByte;
                short isShort;
                ushort isUshort;
                int isInt;
                uint isUint;
                Console.WriteLine($"{integer} can fit in:");

                if (sbyte.TryParse(integer, out isSbyte))
                    Console.WriteLine($"* sbyte");
                if (byte.TryParse(integer, out isByte))
                    Console.WriteLine($"* byte");
                if (short.TryParse(integer, out isShort))
                    Console.WriteLine($"* short");
                if (ushort.TryParse(integer, out isUshort))
                    Console.WriteLine($"* ushort");
                if (int.TryParse(integer, out isInt))
                    Console.WriteLine($"* int");
                if (uint.TryParse(integer, out isUint))
                    Console.WriteLine($"* uint");

                Console.WriteLine($"* long");

            }
            else
            {
                Console.WriteLine($"{integer} can't fit in any type");
            }



        }

    }
}

