using System;

    class PointInCircle
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter point's x coordinate: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter point's y coordinate: ");
            y = double.Parse(Console.ReadLine());
            double r = 5;
            bool inside = false;
            inside = r > (Math.Sqrt(x * x + y * y));
            Console.WriteLine("The point is inside the circle is "+inside);

        }
    }

