using System;

namespace Static_and_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Räkna Calculate = new Räkna();
            Input inP = new Input();

            while (true)
            {
                Console.Write("Multiplikation, Division, Addition eller Subtraction? (M, D, A eller S); ");
                string sätt = Console.ReadLine();

                inP.pInput();

                if (sätt == "M" || sätt == "m")
                {
                    Calculate.Multiplikation();
                }

                else if (sätt == "D" || sätt == "d")
                {
                    Calculate.Division();
                }

                else if (sätt == "A" || sätt == "a")
                {
                    Calculate.Addition();
                }

                else if (sätt == "S" || sätt == "s")
                {
                    Calculate.Subtraction();
                }

                else
                {
                    break;
                }

                Console.WriteLine("Svar: " + Calculate.svar);

                Console.WriteLine(" ");
            }
        }
    }
}
