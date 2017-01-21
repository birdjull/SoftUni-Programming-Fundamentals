using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long personal = long.Parse(Console.ReadLine());
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {nameFirst}\nLast name: {nameSecond}\nAge: {age}\nGender: {gender}\nPersonal ID: {personal}\nUnique Employee number: {number}");
        }
    }
}
