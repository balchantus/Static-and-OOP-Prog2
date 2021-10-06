using System;
using static Static_and_OOP.Räkna;

namespace Static_and_OOP
{
    class Input
    {
        public void pInput()
        {
            Console.Write("Mata in första talet: ");
            tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mata in andra talet: ");
            tal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
        }
    }
}
