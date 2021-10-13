using System;

namespace Static_and_OOP
{
    class Räkna
    {
        //Fält
        public static double tal1 = 0;
        public static double tal2 = 0;
        public double svar = 0;

        //Metod / Function
        public void Multiplikation() 
        {
            svar = tal1 * tal2;
        }

        //Metod / Function
        public void Division()
        {
            svar = tal1 / tal2;
        }

        //Metod / Function
        public void Addition() 
        {
            svar = tal1 + tal2;
        }

        //Metod / Function
        public void Subtraction()
        {
            svar = tal1 - tal2;
        }
    }
}
