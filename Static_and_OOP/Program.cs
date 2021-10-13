using System;

namespace Static_and_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object
            Räkna Calculate = new Räkna();
            Input inP = new Input();

            //Loop
            while (true)
            {
                //UI
                Console.Write("Multiplikation, Division, Addition eller Subtraction? (M, D, A eller S); ");
                //Variabel
                string sätt = Console.ReadLine();

                //Använder Objectet
                inP.pInput();

                //Vilkor
                if (sätt == "M" || sätt == "m")
                {
                    //Använder objectet av Räkna
                    Calculate.Multiplikation();
                }

                //Vilkor om inte förra var sant
                else if (sätt == "D" || sätt == "d")
                {
                    //Använder objectet av Räkna
                    Calculate.Division();
                }

                //Vilkor om inte förra var sant
                else if (sätt == "A" || sätt == "a")
                {
                    //Använder objectet av Räkna
                    Calculate.Addition();
                }

                //Vilkor om inte förra var sant
                else if (sätt == "S" || sätt == "s")
                {
                    //Använder objectet av Räkna
                    Calculate.Subtraction();
                }

                //Vilkor som bestämmer vad som ska hända om inget annat vilkor är sant
                else
                {
                    //Avslutar programmet
                    break;
                }

                //Skriver ut svaret
                Console.WriteLine("Svar: " + Calculate.svar);

                //Tom rad
                Console.WriteLine(" ");
            }
        }
    }
}
