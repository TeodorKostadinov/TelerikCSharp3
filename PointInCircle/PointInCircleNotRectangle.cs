using System;


    class PointInCircleNotRectangle
    {
        static void Main(string[] args)
        {
            double x,y;
            Console.WriteLine("Input x: ");
            x=double.Parse(Console.ReadLine());
            Console.WriteLine("Input y: ");
            y=double.Parse(Console.ReadLine());
            double distanceCircleCenter=Math.Sqrt((x-1)*(x-1)+(y-1)*(y-1));
            if(distanceCircleCenter<=3&&(x<-1||x>5||y>1||y<-1))
                Console.WriteLine("It's inside the circle and outside the rectangle");
            else
                Console.WriteLine("Doesnt fit in the pattern");
        }
    }

