using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Static_and_OOP.Räkna;

namespace Static_and_OOP
{
    class Input
    {
        public static void pInput()
        {
            Console.Write("Mata in första talet: ");
            tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mata in andra talet: ");
            tal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
        }
    }
}
