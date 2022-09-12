using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicialnoPonavljanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            start: string input = Console.ReadLine();
            bool c = char.IsWhiteSpace(input, counter);
            if (c == true)
            {
                Console.WriteLine("_");
            }
            else if (c == false)
            {
                Console.WriteLine(input);
            }
            goto start;
            Console.ReadKey();
        }
    }
}
