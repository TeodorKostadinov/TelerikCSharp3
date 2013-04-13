using System;

    class RectangleArea
    {
        static void Main(string[] args)
        {
            double recWidth, recHeight;
            Console.WriteLine("Enter rectangle's width ");
            recWidth = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rectangle's height ");
            recHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle's area is {0}",recWidth*recHeight);
        }
    }

