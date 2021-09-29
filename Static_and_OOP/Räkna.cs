using System;

namespace Static_and_OOP
{
    class Räkna
    {
        public static double tal1 = 0;
        public static double tal2 = 0;
        public static double svar = 0;

        public void Answer()
        {
            Console.WriteLine("Svar: " + svar);
        }

        public void Multiplikation() 
        {
            svar = tal1 * tal2;

            Answer();
        }

        public void Division()
        {
            svar = tal1 / tal2;

            Answer();
        }

        public void Addition() 
        {
            svar = tal1 + tal2;

            Answer();
        }

        public void Subtraction()
        {
            svar = tal1 - tal2;

            Answer();
        }
    }
}
