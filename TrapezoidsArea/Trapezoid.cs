using System;

    class Trapezoid
    {
        static void Main(string[] args)
        {
            double a, b, h;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid's area is "+((a*b)/2)*h);

        }
    }

