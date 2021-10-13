using System;
using static Static_and_OOP.Räkna;

namespace Static_and_OOP
{
    class Input
    {
        //Metod / Function
        public void pInput()
        {
            //UI för att personen ska kunna använda programmet enkelt och
            //konverterar deras tal till datatypen double
            Console.Write("Mata in första talet: ");
            tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mata in andra talet: ");
            tal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
        }
    }
}
