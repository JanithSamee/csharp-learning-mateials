using System.Text.RegularExpressions;

namespace ConsoleApplication;

public class ControlStructure
{
    public static  void main()
    {
        Console.Write("Put a Number: ");
        var inp=Console.ReadLine();
        if (Regex.IsMatch(inp,@"^\d+$"))
        {
            int i = Convert.ToInt32(inp);
            while ( i>0)
            {
               
                    Console.WriteLine("Number Count: "+ i);
                    i = i - 1;
            }
        }
        else
        {
            Console.WriteLine("The Input does not a type of a Number.");
        }
        

    }
}