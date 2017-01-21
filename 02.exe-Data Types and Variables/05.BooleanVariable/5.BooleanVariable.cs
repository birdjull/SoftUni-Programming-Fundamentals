using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();
            bool answer = (tekst == "True");
            if (answer)
                         Console.WriteLine("Yes");
           
          else
                Console.WriteLine("No");


        }
    }
}
