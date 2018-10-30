using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            int NumberA = rnd.Next(1,100);
            int NumberB = rnd.Next(1,100);
            Console.WriteLine($"Number A: {NumberA},Number B: {NumberB}");
            int Area = NumberA * NumberB;
            Console.WriteLine($"The area of the rectangle is {Area:0.00}");
            Console.ReadKey();
        }
    }
}
