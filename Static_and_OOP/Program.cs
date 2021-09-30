using System;
using static Static_and_OOP.Input;

namespace Static_and_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Multiplikation, Division, Addition eller Subtraction? (M, D, A eller S); ");
                string sätt = Console.ReadLine();
                Räkna Calculate = new Räkna();

                if (sätt == "M" || sätt == "m")
                {
                    pInput();
                    Calculate.Multiplikation();
                }

                else if (sätt == "D" || sätt == "d")
                {
                    pInput();
                    Calculate.Division();
                }

                else if (sätt == "A" || sätt == "a")
                {
                    pInput();
                    Calculate.Addition();
                }

                else if (sätt == "S" || sätt == "s")
                {
                    pInput();
                    Calculate.Subtraction();
                }

                else
                {
                    break;
                }

                Console.WriteLine(" ");
            }
        }
    }
}
