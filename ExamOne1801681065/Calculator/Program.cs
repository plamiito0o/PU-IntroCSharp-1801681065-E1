using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20.78;
            Console.WriteLine("Enter operation");
            string operator4e = Console.ReadLine();
            switch (operator4e)
            {
                case "+":
                    double sum = a + b;
                    double withPercentage = sum + (sum/100 * 10);
                    Console.WriteLine($"Result is:{withPercentage}");
                    break;
                case "-":
                    double min1=0;
                    double max1=0;
                    if (a > b)
                    {
                        a = max1;
                        b = min1;
         
                    }
                    double de = Math.Pow(a, 2) - b;
                    Console.WriteLine($"Result is:{de}");




                    break;
                case "*":
                    double umn = a * Math.Sqrt(b);
                    Console.WriteLine($"Result is:{umn}");
                    break;
                case "/":
                    if (b == 0)
                    { Console.WriteLine("b=0 -- no"); }
                    else
                    { double del = a / b;
                        Console.WriteLine($"Result is:{del}"); }
                    break;

            }
            Console.ReadKey();
        }
    }
}
