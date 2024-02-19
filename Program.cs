using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zəhmət olmasa, ədədi daxil edin: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2-ci ədədi daxil edin: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Simvolu daxil edin!:");
            char simvol = Convert.ToChar(Console.ReadLine());

            if (simvol == '+')
            {
                Console.WriteLine((x1 + x2) + " netice");
            }
           else if (simvol == '-')
            {
                Console.WriteLine((x1 - x2) + "netice");
            }
            if (simvol == '/')
            {
                Console.WriteLine((x1 / x2) + "netice");
            }
            if (simvol == '*')
            {
                Console.WriteLine((x1 * x2) + "netice");
            }
            if (x1 <= 0 && x2 > 0)
            {
                Console.WriteLine("Xeta bas verdi");
            }
            if (x1 + x2 > 50)
            {
                Console.WriteLine("Cəm 50-dən böyükdür.");
            }
            else
            {
                Console.WriteLine("Cəm 50-dən kiçikdir.");
            }
        }
    }
}
