using System;

namespace ConsoleApplication1
{
    public class TypeCasting
    {
        public static void main()
        {
            //Implicit casting
            char value = 'A';
            int intValue = value;
            Console.WriteLine(intValue.GetType());
            
            //Explicit casting
            string frac = "456";
            int intFrac = Convert.ToInt32(frac);
            Console.WriteLine(intFrac.GetType());
        }
    }
}